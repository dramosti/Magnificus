using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Comercial;
using HLP.Models.Entries.Comercial;
using Ninject;
using HLP.Repository.Interfaces.Entries.Comercial;
using HLP.Comum.Infrastructure;

namespace HLP.Services.Implementation.Entries.Comercial
{
    public class Cliente_fornecedorService : ICliente_fornecedorService
    {
        [Inject]
        public ICliente_fornecedorRepository _Cliente_fornecedorRepository { get; set; }

        [Inject]
        public ICliente_fornecedor_representanteRepository _Cliente_fornecedor_representanteRepository { get; set; }

        [Inject]
        public ICliente_fornecedor_produtoRepository _Cliente_fornecedor_produtoRepository { get; set; }

        [Inject]
        public ICliente_Fornecedor_ObservacaoRepository _Cliente_Fornecedor_ObservacaoRepository { get; set; }

        [Inject]
        public ICliente_fornecedor_EnderecoRepository _Cliente_Fornecedor_EnderecoRepository { get; set; }

        [Inject]
        public ICliente_fornecedor_fiscalRepository _Cliente_fornecedor_fiscalRepository { get; set; }

        [Inject]
        public ICliente_fornecedor_contatoRepository _Cliente_fornecedor_contatoRepository { get; set; }

        [Inject]
        public ICliente_fornecedor_arquivoRepository _Cliente_fornecedor_arquivoRepository { get; set; }


        public void Save(Cliente_fornecedorModel objCliente_fornecedor)
        {
            try
            {
                _Cliente_fornecedorRepository.BeginTransaction();
                _Cliente_fornecedorRepository.Save(objCliente_fornecedor);

                #region Cliente_fornecedor_representante
                foreach (Cliente_fornecedor_representanteModel item in objCliente_fornecedor.lCliente_fornecedor_representante.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Incluido))
                {
                    //Aqui deve-se setar as Fks' que devem ser carregadas de classes estaticas (se houver)
                    //Exemplo:
                    //item.idUsuario = (int)AcessoUser.idUser;

                    item.idClienteFornecedor = (int)objCliente_fornecedor.idClienteFornecedor;
                    _Cliente_fornecedor_representanteRepository.Save(item);
                }
                foreach (Cliente_fornecedor_representanteModel item in objCliente_fornecedor.lCliente_fornecedor_representante.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Alterado))
                {
                    _Cliente_fornecedor_representanteRepository.Update(item);
                }
                foreach (Cliente_fornecedor_representanteModel item in objCliente_fornecedor.lCliente_fornecedor_representante.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Excluido))
                {
                    _Cliente_fornecedor_representanteRepository.Delete(item);
                }
                #endregion

                #region Cliente_fornecedor_produto
                foreach (Cliente_fornecedor_produtoModel item in objCliente_fornecedor.lCliente_fornecedor_produto.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Incluido))
                {
                    //Aqui deve-se setar as Fks' que devem ser carregadas de classes estaticas (se houver)
                    //Exemplo:
                    //item.idUsuario = (int)AcessoUser.idUser;

                    item.idClienteFornecedor = (int)objCliente_fornecedor.idClienteFornecedor;
                    _Cliente_fornecedor_produtoRepository.Save(item);
                }
                foreach (Cliente_fornecedor_produtoModel item in objCliente_fornecedor.lCliente_fornecedor_produto.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Alterado))
                {
                    _Cliente_fornecedor_produtoRepository.Update(item);
                }
                foreach (Cliente_fornecedor_produtoModel item in objCliente_fornecedor.lCliente_fornecedor_produto.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Excluido))
                {
                    _Cliente_fornecedor_produtoRepository.Delete(item);
                }
                #endregion

                #region Cliente_Fornecedor_Observacao
                foreach (Cliente_Fornecedor_ObservacaoModel item in objCliente_fornecedor.lCliente_Fornecedor_Observacao.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Incluido))
                {
                    //Aqui deve-se setar as Fks' que devem ser carregadas de classes estaticas (se houver)
                    //Exemplo:
                    //item.idUsuario = (int)AcessoUser.idUser;

                    item.idClienteFornecedor = (int)objCliente_fornecedor.idClienteFornecedor;
                    _Cliente_Fornecedor_ObservacaoRepository.Save(item);
                }
                foreach (Cliente_Fornecedor_ObservacaoModel item in objCliente_fornecedor.lCliente_Fornecedor_Observacao.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Alterado))
                {
                    _Cliente_Fornecedor_ObservacaoRepository.Update(item);
                }
                foreach (Cliente_Fornecedor_ObservacaoModel item in objCliente_fornecedor.lCliente_Fornecedor_Observacao.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Excluido))
                {
                    _Cliente_Fornecedor_ObservacaoRepository.Delete(item);
                }
                #endregion

                #region Cliente_Fornecedor_Endereco
                foreach (Cliente_fornecedor_EnderecoModel item in objCliente_fornecedor.lCliente_Fornecedor_Endereco.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Incluido))
                {
                    //Aqui deve-se setar as Fks' que devem ser carregadas de classes estaticas (se houver)
                    //Exemplo:
                    //item.idUsuario = (int)AcessoUser.idUser;

                    item.idClienteFornecedor = (int)objCliente_fornecedor.idClienteFornecedor;
                    _Cliente_Fornecedor_EnderecoRepository.Save(item);
                }
                foreach (Cliente_fornecedor_EnderecoModel item in objCliente_fornecedor.lCliente_Fornecedor_Endereco.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Alterado))
                {
                    _Cliente_Fornecedor_EnderecoRepository.Update(item);
                }
                foreach (Cliente_fornecedor_EnderecoModel item in objCliente_fornecedor.lCliente_Fornecedor_Endereco.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Excluido))
                {
                    _Cliente_Fornecedor_EnderecoRepository.Delete(item);
                }
                #endregion

                #region Cliente_fornecedor_fiscal

                objCliente_fornecedor.cliforFiscalModel.idClienteFornecedor = (int)objCliente_fornecedor.idClienteFornecedor;
                _Cliente_fornecedor_fiscalRepository.Save(objCliente_fornecedor.cliforFiscalModel);

                #endregion

                #region Cliente_fornecedor_contato
                foreach (Cliente_fornecedor_contatoModel item in objCliente_fornecedor.lCliente_fornecedor_contato.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Incluido))
                {
                    //Aqui deve-se setar as Fks' que devem ser carregadas de classes estaticas (se houver)
                    //Exemplo:
                    //item.idUsuario = (int)AcessoUser.idUser;

                    item.idClienteFornecedor = (int)objCliente_fornecedor.idClienteFornecedor;
                    _Cliente_fornecedor_contatoRepository.Save(item);
                }
                foreach (Cliente_fornecedor_contatoModel item in objCliente_fornecedor.lCliente_fornecedor_contato.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Alterado))
                {
                    _Cliente_fornecedor_contatoRepository.Update(item);
                }
                foreach (Cliente_fornecedor_contatoModel item in objCliente_fornecedor.lCliente_fornecedor_contato.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Excluido))
                {
                    _Cliente_fornecedor_contatoRepository.Delete(item);
                }
                #endregion

                #region Cliente_fornecedor_arquivo
                foreach (Cliente_fornecedor_arquivoModel item in objCliente_fornecedor.lCliente_fornecedor_arquivo.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Incluido))
                {
                    //Aqui deve-se setar as Fks' que devem ser carregadas de classes estaticas (se houver)
                    //Exemplo:
                    //item.idUsuario = (int)AcessoUser.idUser;

                    item.idClienteFornecedor = (int)objCliente_fornecedor.idClienteFornecedor;
                    _Cliente_fornecedor_arquivoRepository.Save(item);
                }
                foreach (Cliente_fornecedor_arquivoModel item in objCliente_fornecedor.lCliente_fornecedor_arquivo.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Alterado))
                {
                    _Cliente_fornecedor_arquivoRepository.Update(item);
                }
                foreach (Cliente_fornecedor_arquivoModel item in objCliente_fornecedor.lCliente_fornecedor_arquivo.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Excluido))
                {
                    _Cliente_fornecedor_arquivoRepository.Delete(item);
                }
                #endregion

                _Cliente_fornecedorRepository.CommitTransaction();

            }
            catch (Exception)
            {
                _Cliente_fornecedorRepository.RollackTransaction();
                throw;
            }
        }

        public void Delete(Cliente_fornecedorModel objCliente_fornecedor)
        {
            try
            {

                _Cliente_fornecedorRepository.BeginTransaction();

                //Deleta Filho
                _Cliente_fornecedor_representanteRepository.Delete((int)objCliente_fornecedor.idClienteFornecedor);

                //Deleta Filho
                _Cliente_fornecedor_produtoRepository.Delete((int)objCliente_fornecedor.idClienteFornecedor);

                //Deleta Filho
                _Cliente_Fornecedor_ObservacaoRepository.Delete((int)objCliente_fornecedor.idClienteFornecedor);

                //Deleta Filho
                _Cliente_Fornecedor_EnderecoRepository.Delete((int)objCliente_fornecedor.idClienteFornecedor);

                //Deleta Filho
                _Cliente_fornecedor_fiscalRepository.Delete((int)objCliente_fornecedor.idClienteFornecedor);

                //Deleta Filho
                _Cliente_fornecedor_contatoRepository.Delete((int)objCliente_fornecedor.idClienteFornecedor);

                //Deleta Filho
                _Cliente_fornecedor_arquivoRepository.Delete((int)objCliente_fornecedor.idClienteFornecedor);

                _Cliente_fornecedorRepository.Delete(objCliente_fornecedor);
                _Cliente_fornecedorRepository.CommitTransaction();

            }
            catch (Exception)
            {
                _Cliente_fornecedorRepository.RollackTransaction();
                throw;
            }
        }

        public void Copy(Cliente_fornecedorModel objCliente_fornecedor)
        {
            try
            {

                _Cliente_fornecedorRepository.BeginTransaction();
                _Cliente_fornecedorRepository.Copy(objCliente_fornecedor);

                foreach (Cliente_fornecedor_representanteModel item in objCliente_fornecedor.lCliente_fornecedor_representante)
                {
                    item.idClienteFornecedor = (int)objCliente_fornecedor.idClienteFornecedor; //codigo do novo pai
                    _Cliente_fornecedor_representanteRepository.Copy(item);
                }

                foreach (Cliente_fornecedor_produtoModel item in objCliente_fornecedor.lCliente_fornecedor_produto)
                {
                    item.idClienteFornecedor = (int)objCliente_fornecedor.idClienteFornecedor; //codigo do novo pai
                    _Cliente_fornecedor_produtoRepository.Copy(item);
                }

                foreach (Cliente_Fornecedor_ObservacaoModel item in objCliente_fornecedor.lCliente_Fornecedor_Observacao)
                {
                    item.idClienteFornecedor = (int)objCliente_fornecedor.idClienteFornecedor; //codigo do novo pai
                    _Cliente_Fornecedor_ObservacaoRepository.Copy(item);
                }

                foreach (Cliente_fornecedor_EnderecoModel item in objCliente_fornecedor.lCliente_Fornecedor_Endereco)
                {
                    item.idClienteFornecedor = (int)objCliente_fornecedor.idClienteFornecedor; //codigo do novo pai
                    _Cliente_Fornecedor_EnderecoRepository.Copy(item);
                }


                objCliente_fornecedor.cliforFiscalModel.idClienteFornecedor = (int)objCliente_fornecedor.idClienteFornecedor; //codigo do novo pai
                _Cliente_fornecedor_fiscalRepository.Copy(objCliente_fornecedor.cliforFiscalModel);


                foreach (Cliente_fornecedor_contatoModel item in objCliente_fornecedor.lCliente_fornecedor_contato)
                {
                    item.idClienteFornecedor = (int)objCliente_fornecedor.idClienteFornecedor; //codigo do novo pai
                    _Cliente_fornecedor_contatoRepository.Copy(item);
                }

                foreach (Cliente_fornecedor_arquivoModel item in objCliente_fornecedor.lCliente_fornecedor_arquivo)
                {
                    item.idClienteFornecedor = (int)objCliente_fornecedor.idClienteFornecedor; //codigo do novo pai
                    _Cliente_fornecedor_arquivoRepository.Copy(item);
                }

                _Cliente_fornecedorRepository.CommitTransaction();
            }
            catch (Exception)
            {
                _Cliente_fornecedorRepository.RollackTransaction();
                throw;
            }
        }

        public Cliente_fornecedorModel GetCliente_fornecedor(int idClienteFornecedor, bool bChildren = false)
        {
            Cliente_fornecedorModel objCliente_fornecedor = _Cliente_fornecedorRepository.GetCliente_fornecedor(idClienteFornecedor);

            if (bChildren && objCliente_fornecedor != null)
            {
                objCliente_fornecedor.lCliente_fornecedor_representante = _Cliente_fornecedor_representanteRepository.GetAllCliente_fornecedor_representante(idClienteFornecedor);
                objCliente_fornecedor.lCliente_fornecedor_produto = _Cliente_fornecedor_produtoRepository.GetAllCliente_fornecedor_produto(idClienteFornecedor);
                objCliente_fornecedor.lCliente_Fornecedor_Observacao = _Cliente_Fornecedor_ObservacaoRepository.GetAllCliente_Fornecedor_Observacao(idClienteFornecedor);
                objCliente_fornecedor.lCliente_Fornecedor_Endereco = _Cliente_Fornecedor_EnderecoRepository.GetAllCliente_Fornecedor_Endereco(idClienteFornecedor);
                objCliente_fornecedor.cliforFiscalModel = _Cliente_fornecedor_fiscalRepository.GetCliente_fornecedor_fiscal(idClienteFornecedor);
                objCliente_fornecedor.lCliente_fornecedor_contato = _Cliente_fornecedor_contatoRepository.GetAllCliente_fornecedor_contato(idClienteFornecedor);
                objCliente_fornecedor.lCliente_fornecedor_arquivo = _Cliente_fornecedor_arquivoRepository.GetAllCliente_fornecedor_arquivo(idClienteFornecedor);
            }

            return objCliente_fornecedor;
        }

        public Cliente_fornecedor_EnderecoModel GetCliente_enderecoPrincipal(int idClienteFornecedor)
        {
            return _Cliente_fornecedorRepository.GetCliente_fornecedor_EnderecoPrincipal(idCliente_fornecedor: idClienteFornecedor);
        }

        public List<Cliente_fornecedor_representanteModel> GetCliente_fornecedor_Representante(int idCliente_fornecedor)
        {
            return _Cliente_fornecedorRepository.GetCliente_fornecedor_Representante(idCliente_fornecedor: idCliente_fornecedor);
        }
    }
}
