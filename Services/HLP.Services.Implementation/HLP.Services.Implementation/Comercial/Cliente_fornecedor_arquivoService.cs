using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Comercial;
using HLP.Models.Entries.Comercial;
using HLP.Repository.Interfaces.Entries.Comercial;
using Ninject;

namespace HLP.Services.Implementation.Entries.Comercial
{
    public class Cliente_fornecedor_arquivoService : ICliente_fornecedor_arquivoService
    {
        [Inject]
        public ICliente_fornecedor_arquivoRepository _Cliente_fornecedor_arquivoRepository { get; set; }

        public void Save(Cliente_fornecedor_arquivoModel objCliente_fornecedor_arquivo)
        {
            _Cliente_fornecedor_arquivoRepository.Save(objCliente_fornecedor_arquivo);
        }

        public void Update(Cliente_fornecedor_arquivoModel objCliente_fornecedor_arquivo)
        {
            _Cliente_fornecedor_arquivoRepository.Update(objCliente_fornecedor_arquivo);
        }

        public void Delete(Cliente_fornecedor_arquivoModel objCliente_fornecedor_arquivo)
        {
            _Cliente_fornecedor_arquivoRepository.Delete(objCliente_fornecedor_arquivo);
        }

        public void Delete(int idClienteFornecedor)
        {
            _Cliente_fornecedor_arquivoRepository.Delete(idClienteFornecedor);
        }

        public void Copy(Cliente_fornecedor_arquivoModel objCliente_fornecedor_arquivo)
        {
            _Cliente_fornecedor_arquivoRepository.Copy(objCliente_fornecedor_arquivo);
        }

        public Cliente_fornecedor_arquivoModel GetCliente_fornecedor_arquivo(int idClienteFornecedorArquivo)
        {
            return _Cliente_fornecedor_arquivoRepository.GetCliente_fornecedor_arquivo(idClienteFornecedorArquivo);
        }

        public List<Cliente_fornecedor_arquivoModel> GetAllCliente_fornecedor_arquivo(int idClienteFornecedor)
        {
            return _Cliente_fornecedor_arquivoRepository.GetAllCliente_fornecedor_arquivo(idClienteFornecedor);
        }
    }
}
