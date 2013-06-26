using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Comercial;

namespace HLP.Services.Interfaces.Entries.Comercial
{
    public interface ICliente_Fornecedor_ObservacaoService
    {
        void Save(Cliente_Fornecedor_ObservacaoModel objCliente_Fornecedor_Observacao);
        void Update(Cliente_Fornecedor_ObservacaoModel objCliente_Fornecedor_Observacao);
        void Delete(Cliente_Fornecedor_ObservacaoModel objCliente_Fornecedor_Observacao);
        void Delete(int idClienteFornecedor);
        void Copy(Cliente_Fornecedor_ObservacaoModel objCliente_Fornecedor_Observacao);
        Cliente_Fornecedor_ObservacaoModel GetCliente_Fornecedor_Observacao(int idClienteFornecedorObservacao);
        List<Cliente_Fornecedor_ObservacaoModel> GetAllCliente_Fornecedor_Observacao(int idClienteFornecedor);
    }
}
