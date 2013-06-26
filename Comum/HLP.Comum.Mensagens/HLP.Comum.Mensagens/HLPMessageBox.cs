using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;

namespace HLP.Comum.Messages
{
    public class HLPMessageBox
    {
        public static void MsgErrorValidacao()
        {
            KryptonMessageBox.Show(null, Mensagens.CampoVazio_Incorreto, Mensagens.MSG_Alerta, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static bool MsgSalvar()
        {
            if (KryptonMessageBox.Show(Mensagens.Salvar, Mensagens.MSG_Confirmacao, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool MsgCancelar()
        {
            if (KryptonMessageBox.Show(Mensagens.CCancelar, Mensagens.MSG_Confirmacao, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool MsgExcluir()
        {
            if (KryptonMessageBox.Show(Mensagens.Excluir, Mensagens.MSG_Confirmacao, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 0 - Cancelar
        /// 1 - Tela
        /// 2 - Todos
        /// </summary>
        /// <returns></returns>
        public static int MsgExcluirTodos()
        {
            FormMensagemExcluir frm = new FormMensagemExcluir();
            frm.ShowDialog();
            return frm.iRet;
        }

        public static void MsgExclusaoFinalizada(int[] iRegistrosNaoExcluidos)
        {
            string sMessageRegNaoExcluidos = "";
            if (iRegistrosNaoExcluidos.Count() == 1)
            {
                sMessageRegNaoExcluidos = "O registro (" + String.Join(",", iRegistrosNaoExcluidos) +") não pode ser excluido pois possuí vínculo(s) com outro(s) cadastro(s)";
            }
            else if (iRegistrosNaoExcluidos.Count() > 1)
            {
                sMessageRegNaoExcluidos = "Os registros (" + String.Join(",", iRegistrosNaoExcluidos) + ") não podem ser excluídos pois possuem vínculo(s) com outro(s) cadastro(s)";
            }

            KryptonMessageBox.Show(null, "Processo de exclusão finalizado!\n\n"+ sMessageRegNaoExcluidos, Mensagens.MSG_Aviso, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        public static bool MsgImprimir()
        {
            if (MessageBox.Show(Mensagens.Imprimir, Mensagens.MSG_Confirmacao, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void ShowAviso(string sAviso)
        {
            KryptonMessageBox.Show(null, sAviso, Mensagens.MSG_Alerta, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
