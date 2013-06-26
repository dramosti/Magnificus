using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Comercial;

namespace HLP.Services.Interfaces.Entries.Comercial
{
    public interface ICliente_fornecedor_representanteService
    {
        void Save(Cliente_fornecedor_representanteModel objCliente_fornecedor_representante);
        void Update(Cliente_fornecedor_representanteModel objCliente_fornecedor_representante);
        void Delete(Cliente_fornecedor_representanteModel objCliente_fornecedor_representante);
        void Delete(int idClienteFornecedor);
        void Copy(Cliente_fornecedor_representanteModel objCliente_fornecedor_representante);
        Cliente_fornecedor_representanteModel GetCliente_fornecedor_representante(int idClienteFornecedorRepresentante);
        List<Cliente_fornecedor_representanteModel> GetAllCliente_fornecedor_representante(int idClienteFornecedor);
    }
}
