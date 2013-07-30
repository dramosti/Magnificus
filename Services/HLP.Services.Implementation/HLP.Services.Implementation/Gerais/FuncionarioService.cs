using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using HLP.Repository.Interfaces.Entries.Gerais;
using Ninject;
using HLP.Comum.Infrastructure;
using HLP.Comum.Infrastructure.Static;

namespace HLP.Services.Implementation.Entries.Gerais
{
    public class FuncionarioService : IFuncionarioService
    {

        [Inject]
        public IFuncionarioRepository _FuncionarioRepository { get; set; }

        [Inject]
        public IFuncionario_Margem_Lucro_ComissaoRepository _Funcionario_Margem_Lucro_ComissaoRepository { get; set; }

        [Inject]
        public IFuncionario_EnderecoRepository _Funcionario_EnderecoRepository { get; set; }

        [Inject]
        public IFuncionario_Comissao_ProdutoRepository _Funcionario_Comissao_ProdutoRepository { get; set; }

        [Inject]
        public IFuncionario_ArquivoRepository _Funcionario_ArquivoRepository { get; set; }

        [Inject]
        public IFuncionario_CertificacaoRepository _Funcionario_CertificacaoRepository { get; set; }

        [Inject]
        public IAcessoRepository _Acesso_Funcionario { get; set; }

        public void Save(FuncionarioModel objFuncionario)
        {
            try
            {
                _FuncionarioRepository.BeginTransaction();
                _FuncionarioRepository.Save(objFuncionario);

                #region Funcionario_Margem_Lucro_Comissao
                foreach (Funcionario_Margem_Lucro_ComissaoModel item in objFuncionario.lFuncionario_Margem_Lucro_Comissao.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Incluido))
                {
                    //Aqui deve-se setar as Fks' que devem ser carregadas de classes estaticas (se houver)
                    //Exemplo:
                    //item.idUsuario = (int)AcessoUser.idUser;

                    item.idFuncionario = (int)objFuncionario.idFuncionario;
                    _Funcionario_Margem_Lucro_ComissaoRepository.Save(item);
                }
                foreach (Funcionario_Margem_Lucro_ComissaoModel item in objFuncionario.lFuncionario_Margem_Lucro_Comissao.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Alterado))
                {
                    _Funcionario_Margem_Lucro_ComissaoRepository.Update(item);
                }
                foreach (Funcionario_Margem_Lucro_ComissaoModel item in objFuncionario.lFuncionario_Margem_Lucro_Comissao.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Excluido))
                {
                    _Funcionario_Margem_Lucro_ComissaoRepository.Delete(item);
                }
                #endregion

                #region Funcionario_Endereco
                foreach (Funcionario_EnderecoModel item in objFuncionario.lFuncionario_Endereco.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Incluido))
                {
                    //Aqui deve-se setar as Fks' que devem ser carregadas de classes estaticas (se houver)
                    //Exemplo:
                    //item.idUsuario = (int)AcessoUser.idUser;

                    item.idFuncionario = (int)objFuncionario.idFuncionario;
                    _Funcionario_EnderecoRepository.Save(item);
                }
                foreach (Funcionario_EnderecoModel item in objFuncionario.lFuncionario_Endereco.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Alterado))
                {
                    _Funcionario_EnderecoRepository.Update(item);
                }
                foreach (Funcionario_EnderecoModel item in objFuncionario.lFuncionario_Endereco.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Excluido))
                {
                    _Funcionario_EnderecoRepository.Delete(item);
                }
                #endregion

                #region Funcionario_Comissao_Produto
                foreach (Funcionario_Comissao_ProdutoModel item in objFuncionario.lFuncionario_Comissao_Produto.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Incluido))
                {
                    //Aqui deve-se setar as Fks' que devem ser carregadas de classes estaticas (se houver)
                    //Exemplo:
                    //item.idUsuario = (int)AcessoUser.idUser;

                    item.idFuncionario = (int)objFuncionario.idFuncionario;
                    _Funcionario_Comissao_ProdutoRepository.Save(item);
                }
                foreach (Funcionario_Comissao_ProdutoModel item in objFuncionario.lFuncionario_Comissao_Produto.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Alterado))
                {
                    _Funcionario_Comissao_ProdutoRepository.Update(item);
                }
                foreach (Funcionario_Comissao_ProdutoModel item in objFuncionario.lFuncionario_Comissao_Produto.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Excluido))
                {
                    _Funcionario_Comissao_ProdutoRepository.Delete(item);
                }
                #endregion

                #region Funcionario_Arquivo
                foreach (Funcionario_ArquivoModel item in objFuncionario.lFuncionario_Arquivo.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Incluido))
                {
                    //Aqui deve-se setar as Fks' que devem ser carregadas de classes estaticas (se houver)
                    //Exemplo:
                    //item.idUsuario = (int)AcessoUser.idUser;

                    item.idFuncionario = (int)objFuncionario.idFuncionario;
                    _Funcionario_ArquivoRepository.Save(item);
                }
                foreach (Funcionario_ArquivoModel item in objFuncionario.lFuncionario_Arquivo.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Alterado))
                {
                    _Funcionario_ArquivoRepository.Update(item);
                }
                foreach (Funcionario_ArquivoModel item in objFuncionario.lFuncionario_Arquivo.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Excluido))
                {
                    _Funcionario_ArquivoRepository.Delete(item);
                }
                #endregion

                #region Funcionario_Certificacao
                foreach (Funcionario_CertificacaoModel item in objFuncionario.lFuncionario_Certificacao.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Incluido))
                {
                    //Aqui deve-se setar as Fks' que devem ser carregadas de classes estaticas (se houver)
                    //Exemplo:
                    //item.idUsuario = (int)AcessoUser.idUser;

                    item.idFuncionario = (int)objFuncionario.idFuncionario;
                    _Funcionario_CertificacaoRepository.Save(item);
                }
                foreach (Funcionario_CertificacaoModel item in objFuncionario.lFuncionario_Certificacao.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Alterado))
                {
                    _Funcionario_CertificacaoRepository.Update(item);
                }
                foreach (Funcionario_CertificacaoModel item in objFuncionario.lFuncionario_Certificacao.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Excluido))
                {
                    _Funcionario_CertificacaoRepository.Delete(item);
                }
                #endregion

                #region Acesso

                foreach (Funcionario_AcessoModel item in objFuncionario.lFuncionario_Acesso.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Incluido))
                {
                    //Aqui deve-se setar as Fks' que devem ser carregadas de classes estaticas (se houver)
                    //Exemplo:
                    //item.idUsuario = (int)AcessoUser.idUser;

                    item.idFuncionario = (int)objFuncionario.idFuncionario;
                    _Acesso_Funcionario.Save(item);
                }
                foreach (Funcionario_AcessoModel item in objFuncionario.lFuncionario_Acesso.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Alterado))
                {
                    _Acesso_Funcionario.Update(item);
                }
                foreach (Funcionario_AcessoModel item in objFuncionario.lFuncionario_Acesso.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Excluido))
                {
                    _Acesso_Funcionario.Delete(item);
                }

                #endregion

                _FuncionarioRepository.CommitTransaction();

            }
            catch (Exception)
            {
                _FuncionarioRepository.RollackTransaction();
                throw;
            }
        }

        public void Delete(FuncionarioModel objFuncionario)
        {
            try
            {

                _FuncionarioRepository.BeginTransaction();

                //Deleta Filho
                _Funcionario_Margem_Lucro_ComissaoRepository.Delete((int)objFuncionario.idFuncionario);

                //Deleta Filho
                _Funcionario_EnderecoRepository.Delete((int)objFuncionario.idFuncionario);

                //Deleta Filho
                _Funcionario_Comissao_ProdutoRepository.Delete((int)objFuncionario.idFuncionario);

                //Deleta Filho
                _Funcionario_ArquivoRepository.Delete((int)objFuncionario.idFuncionario);

                //Deleta Filho
                _Funcionario_CertificacaoRepository.Delete((int)objFuncionario.idFuncionario);

                _FuncionarioRepository.Delete(objFuncionario);
                _FuncionarioRepository.CommitTransaction();

            }
            catch (Exception)
            {
                _FuncionarioRepository.RollackTransaction();
                throw;
            }
        }

        public void Copy(FuncionarioModel objFuncionario)
        {
            try
            {

                _FuncionarioRepository.BeginTransaction();
                _FuncionarioRepository.Copy(objFuncionario);

                foreach (Funcionario_Margem_Lucro_ComissaoModel item in objFuncionario.lFuncionario_Margem_Lucro_Comissao)
                {
                    item.idFuncionario = (int)objFuncionario.idFuncionario; //codigo do novo pai
                    _Funcionario_Margem_Lucro_ComissaoRepository.Copy(item);
                }

                foreach (Funcionario_EnderecoModel item in objFuncionario.lFuncionario_Endereco)
                {
                    item.idFuncionario = (int)objFuncionario.idFuncionario; //codigo do novo pai
                    _Funcionario_EnderecoRepository.Copy(item);
                }

                foreach (Funcionario_Comissao_ProdutoModel item in objFuncionario.lFuncionario_Comissao_Produto)
                {
                    item.idFuncionario = (int)objFuncionario.idFuncionario; //codigo do novo pai
                    _Funcionario_Comissao_ProdutoRepository.Copy(item);
                }

                foreach (Funcionario_ArquivoModel item in objFuncionario.lFuncionario_Arquivo)
                {
                    item.idFuncionario = (int)objFuncionario.idFuncionario; //codigo do novo pai
                    _Funcionario_ArquivoRepository.Copy(item);
                }

                foreach (Funcionario_CertificacaoModel item in objFuncionario.lFuncionario_Certificacao)
                {
                    item.idFuncionario = (int)objFuncionario.idFuncionario; //codigo do novo pai
                    _Funcionario_CertificacaoRepository.Copy(item);
                }

                _FuncionarioRepository.CommitTransaction();
            }
            catch (Exception)
            {
                _FuncionarioRepository.RollackTransaction();
                throw;
            }
        }

        public FuncionarioModel GetFuncionario(int idFuncionario, bool bChildren = false)
        {
            FuncionarioModel objFuncionario = _FuncionarioRepository.GetFuncionario(idFuncionario);

            if (bChildren)
            {
                objFuncionario.lFuncionario_Margem_Lucro_Comissao = _Funcionario_Margem_Lucro_ComissaoRepository.GetAllFuncionario_Margem_Lucro_Comissao(idFuncionario);
                objFuncionario.lFuncionario_Endereco = _Funcionario_EnderecoRepository.GetAllFuncionario_Endereco(idFuncionario);
                objFuncionario.lFuncionario_Comissao_Produto = _Funcionario_Comissao_ProdutoRepository.GetAllFuncionario_Comissao_Produto(idFuncionario);
                objFuncionario.lFuncionario_Arquivo = _Funcionario_ArquivoRepository.GetAllFuncionario_Arquivo(idFuncionario);
                objFuncionario.lFuncionario_Certificacao = _Funcionario_CertificacaoRepository.GetAllFuncionario_Certificacao(idFuncionario);
            }

            return objFuncionario;
        }

        public List<FuncionarioModel> GetAllFuncionario(bool bChildren = false)
        {
            List<FuncionarioModel> lFuncionarios = _FuncionarioRepository.GetAllFuncionario();

            if (bChildren)
            {
                foreach (FuncionarioModel func in lFuncionarios)
                {
                    func.lFuncionario_Arquivo = _Funcionario_ArquivoRepository.GetAllFuncionario_Arquivo((int)func.idFuncionario);

                    func.lFuncionario_Certificacao = _Funcionario_CertificacaoRepository.GetAllFuncionario_Certificacao((int)func.idFuncionario);

                    func.lFuncionario_Comissao_Produto = _Funcionario_Comissao_ProdutoRepository.GetAllFuncionario_Comissao_Produto((int)func.idFuncionario);

                    func.lFuncionario_Endereco = _Funcionario_EnderecoRepository.GetAllFuncionario_Endereco((int)func.idFuncionario);

                    func.lFuncionario_Margem_Lucro_Comissao = _Funcionario_Margem_Lucro_ComissaoRepository.GetAllFuncionario_Margem_Lucro_Comissao((int)func.idFuncionario);
                }
            }

            return lFuncionarios;
        }

        public string CalculaTotalHorasTrabSemanal(List<DateTime> lHorasTrab)
        {
            TimeSpan total = new TimeSpan();

            foreach (TimeSpan hora in lHorasTrab.Select(c => c.TimeOfDay))
            {
                total = total.Add(hora);
            }

            int horas = (total.Days * 24) + total.Hours;

            string sRetorno = "{0}:{1}:{2}";

            return string.Format(sRetorno,
                                horas.ToString().PadLeft(2, '0'),
                                total.Minutes.ToString().PadLeft(2, '0'),
                                total.Seconds.ToString().PadLeft(2, '0'));
        }


        public string GetQueryFuncionarios()
        {
            return _FuncionarioRepository.GetQueryFuncionarios();
        }

        public bool ValidaNomeUsuario(string xId)
        {
            if (_FuncionarioRepository.ValidaNomeUsuario(xId) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidaAcesso(int idEmpresa, int idUsuario)
        {
            if (_FuncionarioRepository.ValidaAcesso(idEmpresa, idUsuario) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public FuncionarioModel ValidaUsuario(string xID, string xSenha)
        {
            xSenha = Criptografia.Encripta(xSenha);
            return _FuncionarioRepository.ValidaUsuario(xID, xSenha);
        }

        public int GetIdUserHLP()
        {
            return _FuncionarioRepository.GetIdUserHLP();
        }

        public int GetIdUserDEFAULT()
        {
            return _FuncionarioRepository.GetIdUserDEFAULT();
        }

        public string GetQueryUserByEmpresaToComboBox()
        {
            return _FuncionarioRepository.GetQueryUserByEmpresaToComboBox();
        }
    }
}
