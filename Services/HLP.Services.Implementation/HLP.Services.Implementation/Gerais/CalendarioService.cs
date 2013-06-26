using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Gerais;
using Ninject;
using HLP.Repository.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using HLP.Comum.Infrastructure;

namespace HLP.Services.Implementation.Entries.Gerais
{
    public class CalendarioService : ICalendarioService
    {
        [Inject]
        public ICalendarioRepository _CalendarioRepository { get; set; }

        [Inject]
        public ICalendario_DetalheRepository _Calendario_DetalheRepository { get; set; }

        public void Save(CalendarioModel objCalendario)
        {
            try
            {
                _CalendarioRepository.BeginTransaction();
                _CalendarioRepository.Save(objCalendario);

                #region Calendario_Detalhe
                foreach (Calendario_DetalheModel item in objCalendario.lCalendario_Detalhe.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Incluido))
                {
                    //Aqui deve-se setar as Fks' que devem ser carregadas de classes estaticas (se houver)
                    //Exemplo:
                    //item.idUsuario = (int)AcessoUser.idUser;

                    item.idCalendario = (int)objCalendario.idCalendario;
                    _Calendario_DetalheRepository.Save(item);
                }
                foreach (Calendario_DetalheModel item in objCalendario.lCalendario_Detalhe.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Alterado))
                {
                    _Calendario_DetalheRepository.Update(item);
                }
                foreach (Calendario_DetalheModel item in objCalendario.lCalendario_Detalhe.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Excluido))
                {
                    _Calendario_DetalheRepository.Delete(item);
                }
                #endregion

                _CalendarioRepository.CommitTransaction();

            }
            catch (Exception)
            {
                _CalendarioRepository.RollackTransaction();
                throw;
            }
        }

        public void Delete(CalendarioModel objCalendario)
        {
            try
            {

                _CalendarioRepository.BeginTransaction();

                //Deleta Filho
                _Calendario_DetalheRepository.Delete((int)objCalendario.idCalendario);

                _CalendarioRepository.Delete(objCalendario);
                _CalendarioRepository.CommitTransaction();

            }
            catch (Exception)
            {
                _CalendarioRepository.RollackTransaction();
                throw;
            }
        }

        public void Copy(CalendarioModel objCalendario)
        {
            try
            {

                _CalendarioRepository.BeginTransaction();
                _CalendarioRepository.Copy(objCalendario);

                foreach (Calendario_DetalheModel item in objCalendario.lCalendario_Detalhe)
                {
                    item.idCalendario = (int)objCalendario.idCalendario; //codigo do novo pai
                    _Calendario_DetalheRepository.Copy(item);
                }

                _CalendarioRepository.CommitTransaction();
            }
            catch (Exception)
            {
                _CalendarioRepository.RollackTransaction();
                throw;
            }
        }

        public CalendarioModel GetCalendario(int idCalendario, bool bChildren = false)
        {
            CalendarioModel objCalendario = _CalendarioRepository.GetCalendario(idCalendario);

            if (bChildren)
            {
                objCalendario.lCalendario_Detalhe = _Calendario_DetalheRepository.GetAllCalendario_Detalhe(idCalendario);
            }

            return objCalendario;
        }


        public List<CalendarioModel> GetCalendarios(int idEmpresa)
        {
            return _CalendarioRepository.GetCalendarios(idEmpresa);
        }
    }
}
