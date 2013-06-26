using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Comercial;

namespace HLP.Repository.Interfaces.Entries.Comercial
{
    public interface ICliente_fornecedor_contatoRepository
    {
        void Save(Cliente_fornecedor_contatoModel objCliente_fornecedor_contato);
        void Update(Cliente_fornecedor_contatoModel objCliente_fornecedor_contato);
        void Delete(Cliente_fornecedor_contatoModel objCliente_fornecedor_contato);
        void Delete(int idClienteFornecedor);
        void Copy(Cliente_fornecedor_contatoModel objCliente_fornecedor_contato);
        Cliente_fornecedor_contatoModel GetCliente_fornecedor_contato(int idClienteFornecedorContato);
        List<Cliente_fornecedor_contatoModel> GetAllCliente_fornecedor_contato(int idClienteFornecedor);
    }
}
