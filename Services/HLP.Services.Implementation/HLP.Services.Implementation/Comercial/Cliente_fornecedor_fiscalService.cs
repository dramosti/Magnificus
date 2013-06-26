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
    public class Cliente_fornecedor_fiscalService : ICliente_fornecedor_fiscalService
    {
        [Inject]
        public ICliente_fornecedor_fiscalRepository _Cliente_fornecedor_fiscalRepository { get; set; }

        public void Save(Cliente_fornecedor_fiscalModel objCliente_fornecedor_fiscal)
        {
            _Cliente_fornecedor_fiscalRepository.Save(objCliente_fornecedor_fiscal);
        }

        public void Delete(int idClienteFornecedor)
        {
            _Cliente_fornecedor_fiscalRepository.Delete(idClienteFornecedor);
        }

        public void Copy(Cliente_fornecedor_fiscalModel objCliente_fornecedor_fiscal)
        {
            _Cliente_fornecedor_fiscalRepository.Copy(objCliente_fornecedor_fiscal);
        }

        public Cliente_fornecedor_fiscalModel GetCliente_fornecedor_fiscal(int idClienteFornecedor)
        {
            return _Cliente_fornecedor_fiscalRepository.GetCliente_fornecedor_fiscal(idClienteFornecedor);
        }
    }
}
