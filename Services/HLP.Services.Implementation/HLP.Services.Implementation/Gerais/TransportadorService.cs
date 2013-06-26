using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries;
using Ninject;
using HLP.Repository.Interfaces.Entries.Gerais;
using HLP.Services.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using HLP.Comum.Infrastructure;

namespace HLP.Services.Implementation.Entries.Gerais
{
    public class TransportadorService : ITransportadorService
    {
        [Inject]
        public ITransportadorReposiroty _TransportadorRepository { get; set; }

        [Inject]
        public ITransportador_VeiculosRepository _Transportador_VeiculosRepository { get; set; }

        [Inject]
        public ITransportador_MotoristaRepository _Transportador_MotoristaRepository { get; set; }

        [Inject]
        public ITransportador_ContatoRepository _Transportador_ContatoRepository { get; set; }

        [Inject]
        public ITransportador_EnderecoRepository _Transportador_EnderecoRepository { get; set; }

        public void Save(TransportadorModel objTransportador)
        {
            try
            {
                _TransportadorRepository.BeginTransaction();
                _TransportadorRepository.Save(objTransportador);

                #region Transportador_Veiculos
                foreach (Transportador_VeiculosModel item in objTransportador.lTransportador_Veiculos.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Incluido))
                {
                    //Aqui deve-se setar as Fks' que devem ser carregadas de classes estaticas (se houver)
                    //Exemplo:
                    //item.idUsuario = (int)AcessoUser.idUser;

                    item.idTransportador = (int)objTransportador.idTransportador;
                    _Transportador_VeiculosRepository.Save(item);
                }
                foreach (Transportador_VeiculosModel item in objTransportador.lTransportador_Veiculos.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Alterado))
                {
                    _Transportador_VeiculosRepository.Update(item);
                }
                foreach (Transportador_VeiculosModel item in objTransportador.lTransportador_Veiculos.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Excluido))
                {
                    _Transportador_VeiculosRepository.Delete(item);
                }
                #endregion

                #region Transportador_Motorista
                foreach (Transportador_MotoristaModel item in objTransportador.lTransportador_Motorista.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Incluido))
                {
                    //Aqui deve-se setar as Fks' que devem ser carregadas de classes estaticas (se houver)
                    //Exemplo:
                    //item.idUsuario = (int)AcessoUser.idUser;

                    item.idTransportador = (int)objTransportador.idTransportador;
                    _Transportador_MotoristaRepository.Save(item);
                }
                foreach (Transportador_MotoristaModel item in objTransportador.lTransportador_Motorista.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Alterado))
                {
                    _Transportador_MotoristaRepository.Update(item);
                }
                foreach (Transportador_MotoristaModel item in objTransportador.lTransportador_Motorista.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Excluido))
                {
                    _Transportador_MotoristaRepository.Delete(item);
                }
                #endregion

                #region Transportador_Contato
                foreach (Transportador_ContatoModel item in objTransportador.lTransportador_Contato.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Incluido))
                {
                    //Aqui deve-se setar as Fks' que devem ser carregadas de classes estaticas (se houver)
                    //Exemplo:
                    //item.idUsuario = (int)AcessoUser.idUser;

                    item.idTransportador = (int)objTransportador.idTransportador;
                    _Transportador_ContatoRepository.Save(item);
                }
                foreach (Transportador_ContatoModel item in objTransportador.lTransportador_Contato.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Alterado))
                {
                    _Transportador_ContatoRepository.Update(item);
                }
                foreach (Transportador_ContatoModel item in objTransportador.lTransportador_Contato.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Excluido))
                {
                    _Transportador_ContatoRepository.Delete(item);
                }
                #endregion

                #region Transportador_Endereco
                foreach (Transportador_EnderecoModel item in objTransportador.lTransportador_Endereco.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Incluido))
                {
                    //Aqui deve-se setar as Fks' que devem ser carregadas de classes estaticas (se houver)
                    //Exemplo:
                    //item.idUsuario = (int)AcessoUser.idUser;

                    item.idTransportador = (int)objTransportador.idTransportador;
                    _Transportador_EnderecoRepository.Save(item);
                }
                foreach (Transportador_EnderecoModel item in objTransportador.lTransportador_Endereco.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Alterado))
                {
                    _Transportador_EnderecoRepository.Update(item);
                }
                foreach (Transportador_EnderecoModel item in objTransportador.lTransportador_Endereco.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Excluido))
                {
                    _Transportador_EnderecoRepository.Delete(item);
                }
                #endregion

                _TransportadorRepository.CommitTransaction();

            }
            catch (Exception)
            {
                _TransportadorRepository.RollackTransaction();
                throw;
            }
        }

        public void Delete(TransportadorModel objTransportador)
        {
            try
            {

                _TransportadorRepository.BeginTransaction();

                //Deleta Filho
                _Transportador_VeiculosRepository.Delete((int)objTransportador.idTransportador);

                //Deleta Filho
                _Transportador_MotoristaRepository.Delete((int)objTransportador.idTransportador);

                //Deleta Filho
                _Transportador_ContatoRepository.Delete((int)objTransportador.idTransportador);

                //Deleta Filho
                _Transportador_EnderecoRepository.Delete((int)objTransportador.idTransportador);

                _TransportadorRepository.Delete(objTransportador);
                _TransportadorRepository.CommitTransaction();

            }
            catch (Exception)
            {
                _TransportadorRepository.RollackTransaction();
                throw;
            }
        }

        public void Copy(TransportadorModel objTransportador)
        {
            try
            {

                _TransportadorRepository.BeginTransaction();
                _TransportadorRepository.Copy(objTransportador);

                foreach (Transportador_VeiculosModel item in objTransportador.lTransportador_Veiculos)
                {
                    item.idTransportador = (int)objTransportador.idTransportador; //codigo do novo pai
                    _Transportador_VeiculosRepository.Copy(item);
                }

                foreach (Transportador_MotoristaModel item in objTransportador.lTransportador_Motorista)
                {
                    item.idTransportador = (int)objTransportador.idTransportador; //codigo do novo pai
                    _Transportador_MotoristaRepository.Copy(item);
                }

                foreach (Transportador_ContatoModel item in objTransportador.lTransportador_Contato)
                {
                    item.idTransportador = (int)objTransportador.idTransportador; //codigo do novo pai
                    _Transportador_ContatoRepository.Copy(item);
                }

                foreach (Transportador_EnderecoModel item in objTransportador.lTransportador_Endereco)
                {
                    item.idTransportador = (int)objTransportador.idTransportador; //codigo do novo pai
                    _Transportador_EnderecoRepository.Copy(item);
                }

                _TransportadorRepository.CommitTransaction();
            }
            catch (Exception)
            {
                _TransportadorRepository.RollackTransaction();
                throw;
            }
        }

        public TransportadorModel GetTransportador(int idTransportador, bool bChildren = false)
        {
            TransportadorModel objTransportador = _TransportadorRepository.GetTransportador(idTransportador);

            if (bChildren)
            {
                objTransportador.lTransportador_Veiculos = _Transportador_VeiculosRepository.GetAllTransportador_Veiculos(idTransportador);
                objTransportador.lTransportador_Motorista = _Transportador_MotoristaRepository.GetAllTransportador_Motorista(idTransportador);
                objTransportador.lTransportador_Contato = _Transportador_ContatoRepository.GetAllTransportador_Contato(idTransportador);
                objTransportador.lTransportador_Endereco = _Transportador_EnderecoRepository.GetAllTransportador_Endereco(idTransportador);
            }

            return objTransportador;
        }
    }
}
