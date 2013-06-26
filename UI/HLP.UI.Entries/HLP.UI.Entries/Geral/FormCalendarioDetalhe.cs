using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HLP.Models.Entries.Gerais;
using HLP.Dependencies;
using Ninject;
using HLP.Comum.UI.Exception;
using ComponentFactory.Krypton.Toolkit;

namespace HLP.UI.Entries.Geral
{
    public partial class FormCalendarioDetalhe : Form
    {
        public bool Aplica = false;
        public List<Calendario_DetalheModel> lcalendarioDetalheModel;

        public FormCalendarioDetalhe()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);

        }



        private void FormCalendarioDetalhe_Load(object sender, EventArgs e)
        {
            cboConsiderarDomingo.SelectedIndex = 0;
            cboConsiderarSabado.SelectedIndex = 0;

            dtpSegSexInicial.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 7, 0, 0);
            dtpSegSexFinal.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 0, 0);
            dtpSegSexInicial.dtp.ShowUpDown = true;
            dtpSegSexFinal.dtp.ShowUpDown = true;

            dtpSabadoInicial.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 7, 0, 0);
            dtpSabadoFinal.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 0, 0);
            dtpSabadoInicial.dtp.ShowUpDown = true;
            dtpSabadoFinal.dtp.ShowUpDown = true;

            dtpDomingoInicial.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 7, 0, 0);
            dtpDomingoFinal.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 0, 0);
            dtpDomingoInicial.dtp.ShowUpDown = true;
            dtpDomingoFinal.dtp.ShowUpDown = true;


            //AdicionaIntervaloGrid();
        }

        private void AdicionaIntervaloGrid()
        {
            try
            {
                dgvIntervalo.Rows.Add();
                dgvIntervalo.Rows[0].Cells["Inicio"].Value = Convert.ToDateTime("12:00");
                dgvIntervalo.Rows[0].Cells["Fim"].Value = Convert.ToDateTime("13:00");
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }

        private bool ValidaIntervalosDia()
        {
            try
            {
                bool ret = true;
                if (dgvIntervalo.RowCount > 1)
                {
                    DateTime Inicio;
                    DateTime Fim;
                    for (int i = 0; i < dgvIntervalo.RowCount - 1; i++)
                    {
                        if (dgvIntervalo.Rows[i].Cells["Inicio"].Value != null)
                        {
                            Inicio = Convert.ToDateTime(dgvIntervalo.Rows[i].Cells["Inicio"].Value);
                        }
                        else
                        {
                            ret = false;
                            break;
                        }
                        if (dgvIntervalo.Rows[i].Cells["Fim"].Value != null)
                        {
                            Fim = Convert.ToDateTime(dgvIntervalo.Rows[i].Cells["Fim"].Value);
                        }
                        else
                        {
                            ret = false;
                            break;
                        }
                        if (Inicio >= Fim)
                        {
                            ret = false;
                            break;
                        }

                    }
                    if (!ret)
                    {
                        KryptonMessageBox.Show("Intervalo(s) do dia Inválido(s)", "A V I S O", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    return ret;
                }
                else
                {
                    return ret;
                }
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
                return false;
            }
        }
        private bool ValidaDiasSemProgramacao()
        {
            try
            {
                bool ret = true;
                if (txtDiasSemProgramacao.Text != "")
                {
                    string[] intervalos = txtDiasSemProgramacao.Text.Split(',');
                    foreach (string dias in intervalos)
                    {
                        string[] dia = dias.Split('/');
                        if (dia.Count() == 2)
                        {
                            if (!ValidaDia(dia))
                            {
                                ret = false;
                                break;
                            }
                        }
                        else
                        {
                            ret = false;
                            break;
                        }
                    }
                }
                if (!ret)
                {
                    KryptonMessageBox.Show("Dia(s) de Intervalo Inválido(s)", "A V I S O", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return ret;
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
                return false;
            }
        }
        private bool ValidaDia(string[] dia)
        {
            try
            {
                int dias = Convert.ToInt32(dia[0]);
                int mes = Convert.ToInt32(dia[1]);

                if (dias == 0 || dias > 31 || mes == 0 || mes > 12)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool VerificaHorarios()
        {
            try
            {
                bool ret = true;
                if (dtpDataFinal.Value.Date < dtpDataInicial.Value.Date)
                {
                    ret = false;
                }
                if (dtpSegSexInicial.Value.TimeOfDay > dtpSegSexFinal.Value.TimeOfDay)
                {
                    ret = false;
                }
                if (dtpSabadoInicial.Value.TimeOfDay > dtpSabadoFinal.Value.TimeOfDay && cboConsiderarSabado.SelectedIndex == 1)
                {
                    ret = false;
                }
                if (dtpDomingoInicial.Value.TimeOfDay > dtpDomingoFinal.Value.TimeOfDay && cboConsiderarDomingo.SelectedIndex == 1)
                {
                    ret = false;
                }
                if (!ret)
                {
                    KryptonMessageBox.Show("Data ou Horário(s) Inválido(s)", "A V I S O", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return ret;
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
                return false;
            }
        }
        private Dictionary<DateTime, DateTime> GeraIntervalos()
        {
            try
            {
                Dictionary<DateTime, DateTime> Intervalos = new Dictionary<DateTime, DateTime>();

                for (int i = 0; i < dgvIntervalo.RowCount - 1; i++)
                {
                    DateTime Inicio = Convert.ToDateTime(dgvIntervalo.Rows[i].Cells["Inicio"].Value);
                    DateTime Fim = Convert.ToDateTime(dgvIntervalo.Rows[i].Cells["Fim"].Value);

                    Intervalos.Add(Inicio, Fim);
                }
                return Intervalos;
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
                return null;
            }
        }



        private void GeraGradeHoraria()
        {
            try
            {
                lcalendarioDetalheModel = new List<Calendario_DetalheModel>();
                bool Sabado = false;
                bool Domingo = false;

                if (cboConsiderarDomingo.SelectedIndex == 1)
                {
                    Domingo = true;
                }
                if (cboConsiderarSabado.SelectedIndex == 1)
                {
                    Sabado = true;
                }

                List<string> DiasSemProgramacao = txtDiasSemProgramacao.Text.Split(',').ToList();
                Dictionary<DateTime, DateTime> Intervalos = GeraIntervalos();

                DateTime DataInicial = dtpDataInicial.Value;
                DateTime DataFinal = dtpDataFinal.Value;

                DateTime HoraInicialSegSex = dtpSegSexInicial.Value;
                DateTime HoraFinalSegSex = dtpSegSexFinal.Value;

                DateTime HoraInicialSabado = dtpSabadoInicial.Value;
                DateTime HoraFinalSabado = dtpSabadoFinal.Value;

                DateTime HoraInicialDomingo = dtpDomingoInicial.Value;
                DateTime HoraFinalDomingo = dtpDomingoFinal.Value;




                DateTimeEnumerator dateTimeRange = new DateTimeEnumerator(DataInicial, DataFinal);
                foreach (DateTime day in dateTimeRange)
                {
                    if (VerificaDiaExcluidoProgramacao(day, DiasSemProgramacao))
                    {
                        if (day.DayOfWeek == DayOfWeek.Saturday && Sabado)
                        {
                            HoraInicialSabado = new DateTime(day.Year, day.Month, day.Day, HoraInicialSabado.Hour, HoraInicialSabado.Minute, HoraInicialSabado.Second);
                            MontaHorario(Intervalos, day, HoraInicialSabado, HoraFinalSabado);
                        }
                        else if (day.DayOfWeek == DayOfWeek.Sunday && Domingo)
                        {
                            MontaHorario(Intervalos, day, HoraInicialDomingo, HoraFinalDomingo);
                        }
                        else if (day.DayOfWeek != DayOfWeek.Saturday && day.DayOfWeek != DayOfWeek.Sunday)
                        {
                            HoraInicialSegSex = new DateTime(day.Year, day.Month, day.Day, HoraInicialSegSex.Hour, HoraInicialSegSex.Minute, HoraInicialSegSex.Second);
                            HoraFinalSegSex = new DateTime(day.Year, day.Month, day.Day, HoraFinalSegSex.Hour, HoraFinalSegSex.Minute, HoraFinalSegSex.Second);
                            MontaHorario(Intervalos, day, HoraInicialSegSex, HoraFinalSegSex);
                        }

                    }
                }
                Aplica = true;
                this.Close();

            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }
        private void MontaHorario(Dictionary<DateTime, DateTime> Intervalos, DateTime day, DateTime HoraInicial, DateTime HoraFinal)
        {
            try
            {
                Calendario_DetalheModel detalhe = new Calendario_DetalheModel();

                detalhe.SetStatusRegistro(Comum.Infrastructure.BaseModelFilhos.statusRegistroFilho.Incluido);

                detalhe.dCalendario = day.Date;
                detalhe.dHoraInicio = HoraInicial;

                if (Intervalos.Count() > 0)
                {
                    foreach (KeyValuePair<DateTime, DateTime> inter in Intervalos.OrderBy(C => C.Key))
                    {
                        

                        if (inter.Key.TimeOfDay < HoraFinal.TimeOfDay)
                        {
                            detalhe.dHoraTermino = new DateTime(detalhe.dCalendario.Year, detalhe.dCalendario.Month, detalhe.dCalendario.Day, inter.Key.Hour, inter.Key.Minute, inter.Key.Second);
                            lcalendarioDetalheModel.Add(detalhe);

                            if (inter.Value.TimeOfDay < HoraFinal.TimeOfDay)
                            {
                                detalhe = new Calendario_DetalheModel();
                                detalhe.SetStatusRegistro(Comum.Infrastructure.BaseModelFilhos.statusRegistroFilho.Incluido);
                                detalhe.dCalendario = day.Date;
                                // detalhe.dHoraInicio = inter.Value;
                                detalhe.dHoraInicio = new DateTime(detalhe.dCalendario.Year, detalhe.dCalendario.Month, detalhe.dCalendario.Day, inter.Value.Hour, inter.Value.Minute, inter.Value.Second);
                            }
                        }
                        else
                        {
                            // detalhe.dHoraTermino = HoraFinal;
                            detalhe.dHoraTermino = new DateTime(detalhe.dCalendario.Year, detalhe.dCalendario.Month, detalhe.dCalendario.Day, HoraFinal.Hour, HoraFinal.Minute, HoraFinal.Second);
                            lcalendarioDetalheModel.Add(detalhe);
                        }
                    }
                    if (detalhe.dHoraTermino.TimeOfDay.Equals(new TimeSpan(0, 0, 0)))
                    {
                        // detalhe.dHoraTermino = HoraFinal;
                        detalhe.dHoraTermino = new DateTime(detalhe.dCalendario.Year, detalhe.dCalendario.Month, detalhe.dCalendario.Day, HoraFinal.Hour, HoraFinal.Minute, HoraFinal.Second);
                        lcalendarioDetalheModel.Add(detalhe);
                    }

                }
                else
                {
                    //detalhe.dHoraTermino = HoraFinal;
                    detalhe.dHoraTermino = new DateTime(detalhe.dCalendario.Year, detalhe.dCalendario.Month, detalhe.dCalendario.Day, HoraFinal.Hour, HoraFinal.Minute, HoraFinal.Second);
                    lcalendarioDetalheModel.Add(detalhe);
                }
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }


        private bool VerificaDiaExcluidoProgramacao(DateTime day, List<string> DiasSemProgramacao)
        {
            try
            {
                bool ret = true;
                foreach (string diasExcluidos in DiasSemProgramacao)
                {
                    if (diasExcluidos != "")
                    {
                        int dia = Convert.ToInt32(diasExcluidos.Split('/')[0]);
                        int mes = Convert.ToInt32(diasExcluidos.Split('/')[1]);

                        if (day.Date.Day == dia && day.Date.Month == mes)
                        {
                            ret = false;
                            break;
                        }
                    }
                }
                return ret;
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
                return false;
            }
        }

        public class DateTimeEnumerator : System.Collections.IEnumerable
        {
            private DateTime begin;
            private DateTime end;
            public DateTimeEnumerator(DateTime begin, DateTime end)
            {
                this.begin = begin;
                this.end = end;
            }
            public System.Collections.IEnumerator GetEnumerator()
            {
                for (DateTime date = begin; date <= end; date = date.AddDays(1))
                {
                    yield return date;
                }
            }
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    foreach (DataGridViewRow dr in dgvIntervalo.Rows)
            //    {
            //        if((dgvIntervalo[Inicio.Name, dr.Index].Value.ToString().Contains("00:00:00")) &&
            //            (dgvIntervalo[Fim.Name, dr.Index].Value.ToString().Contains("00:00:00")))
            //        {
            //            dgvIntervalo.Rows.Remove(dr);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //}
            
            try
            {
                dgvIntervalo.Refresh();
                if (ValidaIntervalosDia())
                {
                    if (ValidaDiasSemProgramacao())
                    {
                        if (VerificaHorarios())
                        {
                            GeraGradeHoraria();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }

        private void dgvIntervalo_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            dgvIntervalo[Inicio.Name, e.Row.Index].Value = Convert.ToDateTime("00:00:00");
            dgvIntervalo[Fim.Name, e.Row.Index].Value = Convert.ToDateTime("00:00:00");
        }


    }
}
