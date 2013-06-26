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
    public class Cliente_fornecedor_EnderecoService : ICliente_fornecedor_EnderecoService
    {
        [Inject]
        public ICliente_fornecedor_EnderecoRepository _Cliente_Fornecedor_EnderecoRepository { get; set; }

        public void Save(Cliente_fornecedor_EnderecoModel objCliente_Fornecedor_Endereco)
        {
            _Cliente_Fornecedor_EnderecoRepository.Save(objCliente_Fornecedor_Endereco);
        }

        public void Update(Cliente_fornecedor_EnderecoModel objCliente_Fornecedor_Endereco)
        {
            _Cliente_Fornecedor_EnderecoRepository.Update(objCliente_Fornecedor_Endereco);
        }

        public void Delete(Cliente_fornecedor_EnderecoModel objCliente_Fornecedor_Endereco)
        {
            _Cliente_Fornecedor_EnderecoRepository.Delete(objCliente_Fornecedor_Endereco);
        }

        public void Delete(int idClienteFornecedor)
        {
            _Cliente_Fornecedor_EnderecoRepository.Delete(idClienteFornecedor);
        }

        public void Copy(Cliente_fornecedor_EnderecoModel objCliente_Fornecedor_Endereco)
        {
            _Cliente_Fornecedor_EnderecoRepository.Copy(objCliente_Fornecedor_Endereco);
        }

        public Cliente_fornecedor_EnderecoModel GetCliente_Fornecedor_Endereco(int idEndereco)
        {
            return _Cliente_Fornecedor_EnderecoRepository.GetCliente_Fornecedor_Endereco(idEndereco);
        }

        public List<Cliente_fornecedor_EnderecoModel> GetAllCliente_Fornecedor_Endereco(int idClienteFornecedor)
        {
            return _Cliente_Fornecedor_EnderecoRepository.GetAllCliente_Fornecedor_Endereco(idClienteFornecedor);
        }
    }
}
