using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Comercial;

namespace HLP.Services.Interfaces.Entries.Comercial
{
    public interface ICliente_fornecedorService
    {
        void Save(Cliente_fornecedorModel objCliente_fornecedor);
        void Delete(Cliente_fornecedorModel objCliente_fornecedor);
        void Copy(Cliente_fornecedorModel objCliente_fornecedor);
        Cliente_fornecedorModel GetCliente_fornecedor(int idClienteFornecedor, bool bChildren = false);
    }
}
