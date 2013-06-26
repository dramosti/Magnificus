using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Comercial;

namespace HLP.Repository.Interfaces.Entries.Comercial
{
    public interface ICliente_fornecedor_fiscalRepository
    {
        void Save(Cliente_fornecedor_fiscalModel objCliente_fornecedor_fiscal);
        void Delete(int idClienteFornecedor);
        void Copy(Cliente_fornecedor_fiscalModel objCliente_fornecedor_fiscal);
        Cliente_fornecedor_fiscalModel GetCliente_fornecedor_fiscal(int idClienteFornecedor);
    }
}
