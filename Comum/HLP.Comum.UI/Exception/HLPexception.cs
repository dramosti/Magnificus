using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComponentFactory.Krypton.Toolkit;
using HLP.Comum.Messages;
using System.Windows.Forms;
using HLP.Comum.Components;

namespace HLP.Comum.UI.Exception
{
    public class HLPexception : System.Exception
    {
        public HLPexception(System.Exception ex, FormPadraoCadastro objFrm = null)
            : base(ex.Message)
        {
            string xStackTrace = "";
            if (ex.StackTrace != null)
            {
                xStackTrace = ex.StackTrace.ToString().Trim();
            }

            string xMessage = ex.Message;
            string xInner = (ex.InnerException == null ? string.Empty : ex.InnerException.ToString());
            #region Tratamento

            if (ex.GetType() == typeof(System.Data.SqlClient.SqlException))
            {
                System.Data.SqlClient.SqlException sqlEx = ex as System.Data.SqlClient.SqlException;
                int numero = sqlEx.Number;
                if (numero == 547)
                {
                    if (ex.Message.Contains("DELETE"))
                    {
                        xMessage = "Você não pode excluir este registro porque ele está sendo usado em outra tabela";
                    }
                }
                else if (numero == 3609)
                {
                    string sMessage = "";
                    if (sqlEx.Errors.Count > 1)
                    {
                        for (int i = 0; i < sqlEx.Errors.Count; i++)
                        {
                            if (sqlEx.Errors[i].Number == 50000)
                            {
                                sMessage = sqlEx.Errors[i].Message;
                            }
                        }
                    }
                    if (sMessage == "")
                    {
                        sMessage = sqlEx.Message;
                    }
                }
                else if (numero == 2627)
                {
                    //string nomeConstraint = ex.Message.ToString().Split('\'')[1];
                    List<Control> lControls = 
                        objFrm.iConfigFormularioService.lControl.Where(
                        l => (l.GetType() != typeof(DataGridView)) &&
                            l.GetType() != typeof(HLP_DataGridView)).ToList();
                    Control objControl = lControls.Where(c =>
                        ((HLP.Comum.Components.UserControlBase)c)._Field == 
                        ex.Message.ToString().Split('\'')[1].Split('_')
                        [ex.Message.ToString().Split('\'')[1].Split('_').Count() - 1]).FirstOrDefault();

                    if (objControl != null)
                    {
                        ProcuraTabPage(objControl.Parent);
                        objControl.Focus();
                        if (objControl.GetType() == typeof(HLP_TextBox))
                        {
                            ((HLP_TextBox)objControl).errorProvider1.SetError(objControl, "Valor já existe na base de dados");
                        }
                        if (objControl.GetType() == typeof(HLP_NumericUpDown))
                        {
                            ((HLP_NumericUpDown)objControl).errorProvider1.SetError(objControl, "Valor já existe na base de dados");
                        }

                        xMessage = "Não é possível inserir o valor '" + ex.Message.ToString().Split('(')[1].Split(')')[0] + "' " +
                            "pois ele já existe na base de dados";
                    }
                    //                    Violation of UNIQUE KEY constraint 'constr_Moeda_xSiglaMoeda'. Cannot insert duplicate key in object 'dbo.Moeda'. The duplicate key value is (R$).
                    //The statement has been terminated.
                }
            }
            #endregion


            FormException frmEx = new FormException(xMessage, xInner, xStackTrace);
            frmEx.ShowDialog();
        }

        private void ProcuraTabPage(Control controle)
        {
            if (controle.Parent != null)
            {
                if (controle.Parent.GetType() == typeof(TabPage))
                {
                    (controle.Parent.Parent as TabControl).SelectedTab = (controle.Parent as TabPage);
                }
                ProcuraTabPage(controle.Parent);
            }
        }
    }
}
