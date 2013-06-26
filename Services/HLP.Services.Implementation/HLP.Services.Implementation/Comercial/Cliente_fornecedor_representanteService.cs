using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Comercial;
using HLP.Repository.Interfaces.Entries.Comercial;
using Ninject;
using HLP.Models.Entries.Comercial;

namespace HLP.Services.Implementation.Entries.Comercial
{
    public class Cliente_fornecedor_representanteService : ICliente_fornecedor_representanteService
    {
        [Inject]
        public ICliente_fornecedor_representanteRepository _Cliente_fornecedor_representanteRepository { get; set; }

        public void Save(Cliente_fornecedor_representanteModel objCliente_fornecedor_representante)
        {
            _Cliente_fornecedor_representanteRepository.Save(objCliente_fornecedor_representante);
        }

        public void Update(Cliente_fornecedor_representanteModel objCliente_fornecedor_representante)
        {
            _Cliente_fornecedor_representanteRepository.Update(objCliente_fornecedor_representante);
        }

        public void Delete(Cliente_fornecedor_representanteModel objCliente_fornecedor_representante)
        {
            _Cliente_fornecedor_representanteRepository.Delete(objCliente_fornecedor_representante);
        }

        public void Delete(int idClienteFornecedor)
        {
            _Cliente_fornecedor_representanteRepository.Delete(idClienteFornecedor);
        }

        public void Copy(Cliente_fornecedor_representanteModel objCliente_fornecedor_representante)
        {
            _Cliente_fornecedor_representanteRepository.Copy(objCliente_fornecedor_representante);
        }

        public Cliente_fornecedor_representanteModel GetCliente_fornecedor_representante(int idClienteFornecedorRepresentante)
        {
            return _Cliente_fornecedor_representanteRepository.GetCliente_fornecedor_representante(idClienteFornecedorRepresentante);
        }

        public List<Cliente_fornecedor_representanteModel> GetAllCliente_fornecedor_representante(int idClienteFornecedor)
        {
            return _Cliente_fornecedor_representanteRepository.GetAllCliente_fornecedor_representante(idClienteFornecedor);
        }
    }
}
