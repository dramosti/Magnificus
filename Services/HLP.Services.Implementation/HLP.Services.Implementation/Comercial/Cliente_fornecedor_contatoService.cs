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
    public class Cliente_fornecedor_contatoService : ICliente_fornecedor_contatoService
    {
        [Inject]
        public ICliente_fornecedor_contatoRepository _Cliente_fornecedor_contatoRepository { get; set; }

        public void Save(Cliente_fornecedor_contatoModel objCliente_fornecedor_contato)
        {
            _Cliente_fornecedor_contatoRepository.Save(objCliente_fornecedor_contato);
        }

        public void Update(Cliente_fornecedor_contatoModel objCliente_fornecedor_contato)
        {
            _Cliente_fornecedor_contatoRepository.Update(objCliente_fornecedor_contato);
        }

        public void Delete(Cliente_fornecedor_contatoModel objCliente_fornecedor_contato)
        {
            _Cliente_fornecedor_contatoRepository.Delete(objCliente_fornecedor_contato);
        }

        public void Delete(int idClienteFornecedor)
        {
            _Cliente_fornecedor_contatoRepository.Delete(idClienteFornecedor);
        }

        public void Copy(Cliente_fornecedor_contatoModel objCliente_fornecedor_contato)
        {
            _Cliente_fornecedor_contatoRepository.Copy(objCliente_fornecedor_contato);
        }

        public Cliente_fornecedor_contatoModel GetCliente_fornecedor_contato(int idClienteFornecedorContato)
        {
            return _Cliente_fornecedor_contatoRepository.GetCliente_fornecedor_contato(idClienteFornecedorContato);
        }

        public List<Cliente_fornecedor_contatoModel> GetAllCliente_fornecedor_contato(int idClienteFornecedor)
        {
            return _Cliente_fornecedor_contatoRepository.GetAllCliente_fornecedor_contato(idClienteFornecedor);
        }
    }
}
