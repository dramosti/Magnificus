using HLP.Services.Interfaces.Entries.Comercial;
using Ninject;
using HLP.Repository.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using HLP.Services.Interfaces.Entries.Gerais;
using System;
using HLP.Comum.Infrastructure;
using System.Linq;

namespace HLP.Services.Implementation.Entries.Gerais
{
    public class RotaService : IRotaService
    {
        [Inject]
        public IRotaRepository _RotaRepository { get; set; }

        [Inject]
        public IRota_pracaRepository _Rota_PracaRepository { get; set; }

        public void Save(RotaModel objRota)
        {
            try
            {
                _RotaRepository.BeginTransaction();
                _RotaRepository.Save(objRota);

                #region Rota_Praca
                foreach (Rota_pracaModel item in objRota.lRota_Praca.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Incluido))
                {
                    //Aqui deve-se setar as Fks' que devem ser carregadas de classes estaticas (se houver)
                    //Exemplo:
                    //item.idUsuario = (int)AcessoUser.idUser;

                    item.idRota = (int)objRota.idRota;
                    _Rota_PracaRepository.Save(item);
                }
                foreach (Rota_pracaModel item in objRota.lRota_Praca.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Alterado))
                {
                    _Rota_PracaRepository.Update(item);
                }
                foreach (Rota_pracaModel item in objRota.lRota_Praca.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Excluido))
                {
                    _Rota_PracaRepository.Delete(item);
                }
                #endregion

                _RotaRepository.CommitTransaction();

            }
            catch (Exception)
            {
                _RotaRepository.RollackTransaction();
                throw;
            }
        }

        public void Delete(RotaModel objRota)
        {
            try
            {

                _RotaRepository.BeginTransaction();

                //Deleta Filho
                _Rota_PracaRepository.Delete((int)objRota.idRota);

                _RotaRepository.Delete(objRota);
                _RotaRepository.CommitTransaction();

            }
            catch (Exception)
            {
                _RotaRepository.RollackTransaction();
                throw;
            }
        }

        public void Copy(RotaModel objRota)
        {
            try
            {

                _RotaRepository.BeginTransaction();
                _RotaRepository.Copy(objRota);

                foreach (Rota_pracaModel item in objRota.lRota_Praca)
                {
                    item.idRota = (int)objRota.idRota; //codigo do novo pai
                    _Rota_PracaRepository.Copy(item);
                }

                _RotaRepository.CommitTransaction();
            }
            catch (Exception)
            {
                _RotaRepository.RollackTransaction();
                throw;
            }
        }

        public RotaModel GetRota(int idRota, bool bChildren = false)
        {
            RotaModel objRota = _RotaRepository.GetRota(idRota);

            if (bChildren)
            {
                objRota.lRota_Praca = _Rota_PracaRepository.GetAllRota_Praca(idRota);
            }

            return objRota;
        }
    }
}
