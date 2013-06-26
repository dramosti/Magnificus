using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.IO;
using System.Xml;
using ICSharpCode.SharpZipLib.Zip;

namespace HLP.Comum.Components
{
    public partial class FormObservacao : KryptonForm
    {
        private string _text = "";
        public string _Text
        {
            get { return _text; }
            set
            {
                _text = value;
                rtbText.Text = value;
            }
        }
        public FormObservacao(string Text)
        {
            InitializeComponent();
            this._Text = Text;
        }


        private void arquivoWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.Title = "Abrir Arquivo";
                openFileDialog.Filter = "Arquivo Word (*.docx)|*.docx";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    DocxToText dtt = new DocxToText(openFileDialog.FileName);
                    rtbText.Text += dtt.ExtractText();
                    if (rtbText.Text.Length > 5000)
                    {
                        rtbText.Text = rtbText.Text.Substring(0, 5000);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void arquivoTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.Title = "Abrir Arquivo";
                openFileDialog.Filter = "Arquivo Texto (*.txt)|*.txt";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamReader reader = new StreamReader(openFileDialog.OpenFile());
                    rtbText.Text += reader.ReadToEnd();
                    if (rtbText.Text.Length > 5000)
                    {
                        rtbText.Text = rtbText.Text.Substring(0, 5000);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public class DocxToText
        {
            private const string ContentTypeNamespace =
                @"http://schemas.openxmlformats.org/package/2006/content-types";

            private const string WordprocessingMlNamespace =
                @"http://schemas.openxmlformats.org/wordprocessingml/2006/main";

            private const string DocumentXmlXPath =
                "/t:Types/t:Override[@ContentType=\"application/vnd.openxmlformats-officedocument.wordprocessingml.document.main+xml\"]";

            private const string BodyXPath = "/w:document/w:body";

            private string docxFile = "";
            private string docxFileLocation = "";


            public DocxToText(string fileName)
            {
                docxFile = fileName;
            }

            #region ExtractText()
            /// <summary>
            /// Extracts text from the Docx file.
            /// </summary>
            /// <returns>Extracted text.</returns>
            public string ExtractText()
            {
                if (string.IsNullOrEmpty(docxFile))
                    throw new Exception("Input file not specified.");

                // Usually it is "/word/document.xml"

                docxFileLocation = FindDocumentXmlLocation();

                if (string.IsNullOrEmpty(docxFileLocation))
                    throw new Exception("It is not a valid Docx file.");

                return ReadDocumentXml();
            }
            #endregion

            #region FindDocumentXmlLocation()
            /// <summary>
            /// Gets location of the "document.xml" zip entry.
            /// </summary>
            /// <returns>Location of the "document.xml".</returns>
            private string FindDocumentXmlLocation()
            {
                ZipFile zip = new ZipFile(docxFile);
                foreach (ZipEntry entry in zip)
                {
                    // Find "[Content_Types].xml" zip entry

                    if (string.Compare(entry.Name, "[Content_Types].xml", true) == 0)
                    {
                        Stream contentTypes = zip.GetInputStream(entry);

                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.PreserveWhitespace = true;
                        xmlDoc.Load(contentTypes);
                        contentTypes.Close();

                        //Create an XmlNamespaceManager for resolving namespaces

                        XmlNamespaceManager nsmgr = new XmlNamespaceManager(xmlDoc.NameTable);
                        nsmgr.AddNamespace("t", ContentTypeNamespace);

                        // Find location of "document.xml"

                        XmlNode node = xmlDoc.DocumentElement.SelectSingleNode(DocumentXmlXPath, nsmgr);

                        if (node != null)
                        {
                            string location = ((XmlElement)node).GetAttribute("PartName");
                            return location.TrimStart(new char[] { '/' });
                        }
                        break;
                    }
                }
                zip.Close();
                return null;
            }
            #endregion

            #region ReadDocumentXml()
            /// <summary>
            /// Reads "document.xml" zip entry.
            /// </summary>
            /// <returns>Text containing in the document.</returns>
            private string ReadDocumentXml()
            {
                StringBuilder sb = new StringBuilder();

                ZipFile zip = new ZipFile(docxFile);
                foreach (ZipEntry entry in zip)
                {
                    if (string.Compare(entry.Name, docxFileLocation, true) == 0)
                    {
                        Stream documentXml = zip.GetInputStream(entry);

                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.PreserveWhitespace = true;
                        xmlDoc.Load(documentXml);
                        documentXml.Close();

                        XmlNamespaceManager nsmgr = new XmlNamespaceManager(xmlDoc.NameTable);
                        nsmgr.AddNamespace("w", WordprocessingMlNamespace);

                        XmlNode node = xmlDoc.DocumentElement.SelectSingleNode(BodyXPath, nsmgr);

                        if (node == null)
                            return string.Empty;

                        sb.Append(ReadNode(node));

                        break;
                    }
                }
                zip.Close();
                return sb.ToString();
            }
            #endregion

            #region ReadNode()
            /// <summary>
            /// Reads content of the node and its nested childs.
            /// </summary>
            /// <param name="node">XmlNode.</param>
            /// <returns>Text containing in the node.</returns>
            private string ReadNode(XmlNode node)
            {
                if (node == null || node.NodeType != XmlNodeType.Element)
                    return string.Empty;

                StringBuilder sb = new StringBuilder();
                foreach (XmlNode child in node.ChildNodes)
                {
                    if (child.NodeType != XmlNodeType.Element) continue;

                    switch (child.LocalName)
                    {
                        case "t":                           // Text
                            sb.Append(child.InnerText.TrimEnd());

                            string space = ((XmlElement)child).GetAttribute("xml:space");
                            if (!string.IsNullOrEmpty(space) && space == "preserve")
                                sb.Append(' ');

                            break;

                        case "cr":                          // Carriage return
                        case "br":                          // Page break
                            sb.Append(Environment.NewLine);
                            break;

                        case "tab":                         // Tab
                            sb.Append("\t");
                            break;

                        case "p":                           // Paragraph
                            sb.Append(ReadNode(child));
                            sb.Append(Environment.NewLine);
                            sb.Append(Environment.NewLine);
                            break;

                        default:
                            sb.Append(ReadNode(child));
                            break;
                    }
                }
                return sb.ToString();
            }
            #endregion
        }


        private void FormObservacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }
        private void FormObservacao_FormClosing(object sender, FormClosingEventArgs e)
        {
            this._Text = rtbText.Text;
        }
    }
}