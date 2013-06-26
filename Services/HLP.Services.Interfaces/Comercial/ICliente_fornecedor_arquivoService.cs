using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Comercial;

namespace HLP.Services.Interfaces.Entries.Comercial
{
    public interface ICliente_fornecedor_arquivoService
    {
        void Save(Cliente_fornecedor_arquivoModel objCliente_fornecedor_arquivo);
        void Update(Cliente_fornecedor_arquivoModel objCliente_fornecedor_arquivo);
        void Delete(Cliente_fornecedor_arquivoModel objCliente_fornecedor_arquivo);
        void Delete(int idClienteFornecedor);
        void Copy(Cliente_fornecedor_arquivoModel objCliente_fornecedor_arquivo);
        Cliente_fornecedor_arquivoModel GetCliente_fornecedor_arquivo(int idClienteFornecedorArquivo);
        List<Cliente_fornecedor_arquivoModel> GetAllCliente_fornecedor_arquivo(int idClienteFornecedor);
    }
}
