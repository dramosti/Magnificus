using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HLP.Comum.Components
{
    public partial class HLP_ListBox2 : UserControlBase
    {
        private Point screenOffset;
        private int indexOfItemUnderMouseToDrop;

        public HLP_ListBox2()
        {
            InitializeComponent();
            controleBase = this.splitPrincipal;
            lblBase = this.lblDescricao;
        }
        [Category("HLP")]
        public ListBox ListBox1 { get { return this.listBox1; } }
        [Category("HLP")]
        public ListBox ListBox2 { get { return this.listBox2; } }

        [Category("HLP")]
        public string HeaderGroup1
        {
            get { return groupBox1.Text; }
            set { groupBox1.Text = value; }
        }
        [Category("HLP")]
        public string HeaderGroup2
        {
            get { return groupBox2.Text; }
            set { groupBox2.Text = value; }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            int indexOfItem = listBox1.IndexFromPoint(e.X, e.Y);
            if (indexOfItem >= 0 && indexOfItem < listBox1.Items.Count)  // check that an string is selected
            {
                listBox1.DoDragDrop(listBox1.Items[indexOfItem], DragDropEffects.Copy);
            }
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;  // The cursor changes to show Copy
        }

        private void listBox1_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            screenOffset = SystemInformation.WorkingArea.Location;
            ListBox lb = sender as ListBox;
            if (lb != null)
            {
                Form f = lb.FindForm();
                if (((Control.MousePosition.X - screenOffset.X) < f.DesktopBounds.Left) ||
                    ((Control.MousePosition.X - screenOffset.X) > f.DesktopBounds.Right) ||
                    ((Control.MousePosition.Y - screenOffset.Y) < f.DesktopBounds.Top) ||
                    ((Control.MousePosition.Y - screenOffset.Y) > f.DesktopBounds.Bottom))
                {
                    e.Action = DragAction.Cancel;
                }
            }
        }

        private void listBox2_MouseDown(object sender, MouseEventArgs e)
        {
            int indexOfItem = listBox2.IndexFromPoint(e.X, e.Y);
            DateTime date = DateTime.Now;
            if (indexOfItem >= 0 && indexOfItem < listBox2.Items.Count)  // check we clicked down on a string
            {
                listBox2.DoDragDrop(listBox2.Items[indexOfItem], DragDropEffects.Move);
            }
        }

        private void listBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat) && (e.AllowedEffect == DragDropEffects.Copy))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.Move;
        }

        private void listBox2_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            screenOffset = SystemInformation.WorkingArea.Location;
            ListBox lb = sender as ListBox;
            if (lb != null)
            {
                Form f = lb.FindForm();
                if (((Control.MousePosition.X - screenOffset.X) < f.DesktopBounds.Left) ||
                    ((Control.MousePosition.X - screenOffset.X) > f.DesktopBounds.Right) ||
                    ((Control.MousePosition.Y - screenOffset.Y) < f.DesktopBounds.Top) ||
                    ((Control.MousePosition.Y - screenOffset.Y) > f.DesktopBounds.Bottom))
                {
                    e.Action = DragAction.Cancel;
                }
            }
        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                if (indexOfItemUnderMouseToDrop >= 0 && indexOfItemUnderMouseToDrop < listBox2.Items.Count)
                {
                    if (!listBox2.Items.Contains(e.Data.GetData(DataFormats.Text)))
                        listBox2.Items.Insert(indexOfItemUnderMouseToDrop, e.Data.GetData(DataFormats.Text));
                }
                else
                {
                    if (!listBox2.Items.Contains(e.Data.GetData(DataFormats.Text)))
                        listBox2.Items.Add(e.Data.GetData(DataFormats.Text));
                }
            }
        }

        private void listBox2_DragOver(object sender, DragEventArgs e)
        {
            indexOfItemUnderMouseToDrop =
              listBox2.IndexFromPoint(listBox2.PointToClient(new Point(e.X, e.Y)));

            if (indexOfItemUnderMouseToDrop != ListBox.NoMatches)
            {
                listBox2.SelectedIndex = indexOfItemUnderMouseToDrop;

            }
            else
            {
                listBox2.SelectedIndex = indexOfItemUnderMouseToDrop;
            }

            if (e.Effect == DragDropEffects.Move)  // When moving an item within listBox2
                listBox2.Items.Remove((string)e.Data.GetData(DataFormats.Text));
        }

    }
}
