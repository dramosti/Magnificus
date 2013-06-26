using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Reflection;
using HLP.Comum.Infrastructure;
using System.ComponentModel;
using System.Drawing;

namespace HLP.Comum.Components
{
    public class HLP_DataGridView : KryptonDataGridView
    {
        public CurrencyManager cm { get; set; }
        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;

        public HLP_DataGridView()
        {
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragDrop);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragOver);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseMove);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (msg.WParam.ToInt32() == (int)Keys.Enter)
            {
                SendKeys.Send("{Tab}");
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected override void OnCellValueChanged(DataGridViewCellEventArgs e)
        {
            base.OnCellValueChanged(e);

            if (this.IsCurrentCellInEditMode)
            {
                try
                {

                    if (this.CurrentRow != null && this.DataSource != null)
                    {
                        if ((this.DataSource as BindingSource) != null)
                        {
                            string Namespace = (this.DataSource as BindingSource).Current.ToString();

                            Assembly assembly = (this.DataSource as BindingSource).Current.GetType().Assembly;
                            Type classe = assembly.GetType(Namespace);

                            MethodInfo metodo = classe.GetMethod("GetStatusRegistro");

                            if (metodo != null)
                            {

                                object ob = (this.DataSource as BindingSource).Current;
                                object retorno = metodo.Invoke(ob, new object[] { });

                                string status = retorno.ToString();

                                //Só continua SE o status for sem mudança
                                if (status == BaseModelFilhos.statusRegistroFilho.SemMudanca.ToString())
                                {

                                    metodo = classe.GetMethod("SetStatusRegistro");

                                    MethodInfo pk = classe.GetMethod("GetID");
                                    object objCodigo = pk.Invoke(ob, new object[] { });
                                    int iCodigo = Convert.ToInt32(objCodigo);


                                    if (status == BaseModelFilhos.statusRegistroFilho.SemMudanca.ToString() && iCodigo != 0)
                                    {
                                        metodo.Invoke(ob, new object[] { (BaseModelFilhos.statusRegistroFilho.Alterado) });
                                    }

                                    if (status == BaseModelFilhos.statusRegistroFilho.SemMudanca.ToString() && iCodigo == 0)
                                    {
                                        metodo.Invoke(ob, new object[] { (BaseModelFilhos.statusRegistroFilho.Incluido) });
                                    }

                                }
                            }//if metodo != null
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public void HLP_Refresh()
        {
            try
            {
                if (this.DataSource != null)
                {
                    if (cm == null)
                    {
                        cm = (CurrencyManager)BindingContext[this.DataSource];
                    }

                    foreach (DataGridViewRow row in this.Rows)
                    {
                        object obj = null;

                        try
                        { obj = (this.DataSource as BindingSource).List[row.Index]; }
                        catch (Exception) { }
                        if (obj != null)
                        {
                            string nameSpace = obj.ToString();

                            Assembly assembly = obj.GetType().Assembly;
                            Type classe = assembly.GetType(nameSpace);

                            MethodInfo metodo = classe.GetMethod("GetStatusRegistro");

                            if (metodo != null)
                            {
                                object retorno = metodo.Invoke(obj, new object[] { });
                                string status = retorno.ToString();
                                if (status != BaseModelFilhos.statusRegistroFilho.Incluido.ToString())
                                {
                                    cm.SuspendBinding();
                                    row.Visible = false;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cm != null)
                {
                    cm.ResumeBinding();
                }
            }
        }

        public void HLP_Clear()
        {
            try
            {
                if (this.DataSource != null)
                {
                    if (cm == null)
                    {
                        try
                        {
                            cm = (CurrencyManager)BindingContext[this.DataSource];
                        }
                        catch (Exception)
                        {
                        }
                    }

                    if (cm != null)
                    {
                        List<DataGridViewRow> lRows = new List<DataGridViewRow>();

                        foreach (DataGridViewRow r in this.Rows)
                        {
                            lRows.Add(r);
                        }



                        int iCount = lRows.Count;

                        for (int i = 0; i < iCount; i++)
                        {

                            DataGridViewRow row = lRows[i];                            

                            object obj = null;

                            try
                            { obj = row.DataBoundItem; }
                            catch (Exception) { }
                            if (obj != null)
                            {
                                string nameSpace = obj.ToString();

                                Assembly assembly = obj.GetType().Assembly;
                                Type classe = assembly.GetType(nameSpace);

                                MethodInfo metodo = classe.GetMethod("GetStatusRegistro");

                                if (metodo != null)
                                {
                                    object retorno = metodo.Invoke(obj, new object[] { });
                                    string status = retorno.ToString();
                                    if (status != BaseModelFilhos.statusRegistroFilho.Incluido.ToString())
                                    {
                                        metodo = classe.GetMethod("SetStatusRegistro");
                                        metodo.Invoke(obj, new object[] { (BaseModelFilhos.statusRegistroFilho.Excluido) });
                                        //suspende temporáriamente o binding para que seja possivel alterar o visible da row
                                        cm.SuspendBinding();
                                        row.Visible = false;
                                    }
                                    else
                                    {
                                        DataGridViewRowCancelEventArgs eRow = new DataGridViewRowCancelEventArgs(row);
                                        OnUserDeletingRow(eRow);
                                        this.Rows.Remove(row);

                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cm != null)
                {
                    cm.ResumeBinding();
                }
            }
        }

        protected override void OnUserDeletingRow(DataGridViewRowCancelEventArgs e)
        {

            try
            {

                if (e.Row != null)
                {
                    if (this.DataSource != null)
                    {

                        if (cm == null)
                        {
                            cm = (CurrencyManager)BindingContext[this.DataSource];
                        }

                        object obj = (this.DataSource as BindingSource).List[e.Row.Index];

                        string nameSpace = obj.ToString();

                        Assembly assembly = obj.GetType().Assembly;
                        Type classe = assembly.GetType(nameSpace);

                        MethodInfo metodo = classe.GetMethod("GetStatusRegistro");

                        if (metodo != null)
                        {
                            e.Cancel = true;

                            object retorno = metodo.Invoke(obj, new object[] { });

                            string status = retorno.ToString();

                            if (status != BaseModelFilhos.statusRegistroFilho.Incluido.ToString())
                            {

                                metodo = classe.GetMethod("SetStatusRegistro");
                                metodo.Invoke(obj, new object[] { (BaseModelFilhos.statusRegistroFilho.Excluido) });

                                //suspende temporáriamente o binding para que seja possivel alterar o visible da row
                                cm.SuspendBinding();
                                e.Row.Visible = false;

                            }
                            else
                            {
                                e.Cancel = false;
                            }
                        }// if metodo != null
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (cm != null)
                {
                    cm.ResumeBinding();
                }
            }

        }

        [Category("HLP")]
        [Description("Habilita ao inclusão para o Usuário")]
        public bool Inclui { get; set; }

        [Category("HLP")]
        [Description("Habilita ao exclusão para o Usuário")]
        public bool Exclui { get; set; }

        [Category("HLP")]
        [Description("Habilita ao alteração para o Usuário")]
        public bool Altera { get; set; }

        [Category("HLP")]
        [Description("Habilita DragDrop nas linhas da DataGridView")]
        public bool DragDropLinha { get; set; }

        #region métodos Drag and Drop Linhas
        private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.DragDropLinha)
            {
                if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
                {
                    // If the mouse moves outside the rectangle, start the drag.
                    if (dragBoxFromMouseDown != Rectangle.Empty &&
                        !dragBoxFromMouseDown.Contains(e.X, e.Y))
                    {

                        // Proceed with the drag and drop, passing in the list item.                    
                        DragDropEffects dropEffect = this.DoDragDrop(
                        this.Rows[rowIndexFromMouseDown],
                        DragDropEffects.Move);
                    }
                }
            }
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.DragDropLinha)
            {
                // Get the index of the item the mouse is below.
                rowIndexFromMouseDown = this.HitTest(e.X, e.Y).RowIndex;
                if (rowIndexFromMouseDown != -1)
                {
                    // Remember the point where the mouse down occurred. 
                    // The DragSize indicates the size that the mouse can move 
                    // before a drag event should be started.                
                    Size dragSize = SystemInformation.DragSize;

                    // Create a rectangle using the DragSize, with the mouse position being
                    // at the center of the rectangle.
                    dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2),
                                                                   e.Y - (dragSize.Height / 2)),
                                        dragSize);
                }
                else
                    // Reset the rectangle if the mouse is not over an item in the ListBox.
                    dragBoxFromMouseDown = Rectangle.Empty;
            }
        }

        private void dataGridView1_DragOver(object sender, DragEventArgs e)
        {
            if (this.DragDropLinha)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void dataGridView1_DragDrop(object sender, DragEventArgs e)
        {
            if (this.DragDropLinha)
            {
                // The mouse locations are relative to the screen, so they must be 
                // converted to client coordinates.
                Point clientPoint = this.PointToClient(new Point(e.X, e.Y));

                // Get the row index of the item the mouse is below. 
                rowIndexOfItemUnderMouseToDrop =
                    this.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

                // If the drag operation was a move then remove and insert the row.
                if (e.Effect == DragDropEffects.Move)
                {
                    //DataGridViewRow rowToMove = e.Data.GetData(
                    //    typeof(DataGridViewRow)) as DataGridViewRow;
                    object o = (this.DataSource as BindingSource)[rowIndexFromMouseDown];
                    //this.Rows.RemoveAt(rowIndexFromMouseDown);
                    (this.DataSource as BindingSource).Remove((this.DataSource as BindingSource)[rowIndexFromMouseDown]);
                    if ((rowIndexOfItemUnderMouseToDrop == -1) ||
                        !(rowIndexOfItemUnderMouseToDrop < (this.DataSource as BindingSource).Count))
                    {
                        rowIndexOfItemUnderMouseToDrop = (this.DataSource as BindingSource).Count;
                    }
                    (this.DataSource as BindingSource).Insert(
                        rowIndexOfItemUnderMouseToDrop, o);
                    BindingSource bsAux = new BindingSource();
                    bsAux = (BindingSource)this.DataSource;
                    this.DataSource = bsAux;

                    //this.Rows.Insert(rowIndexOfItemUnderMouseToDrop, rowToMove);

                }
            }
        }
        #endregion
    }
}
