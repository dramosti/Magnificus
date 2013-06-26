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
    public class Cliente_Fornecedor_ObservacaoService : ICliente_Fornecedor_ObservacaoService
    {
        [Inject]
        public ICliente_Fornecedor_ObservacaoRepository _Cliente_Fornecedor_ObservacaoRepository { get; set; }

        public void Save(Cliente_Fornecedor_ObservacaoModel objCliente_Fornecedor_Observacao)
        {
            _Cliente_Fornecedor_ObservacaoRepository.Save(objCliente_Fornecedor_Observacao);
        }

        public void Update(Cliente_Fornecedor_ObservacaoModel objCliente_Fornecedor_Observacao)
        {
            _Cliente_Fornecedor_ObservacaoRepository.Update(objCliente_Fornecedor_Observacao);
        }

        public void Delete(Cliente_Fornecedor_ObservacaoModel objCliente_Fornecedor_Observacao)
        {
            _Cliente_Fornecedor_ObservacaoRepository.Delete(objCliente_Fornecedor_Observacao);
        }

        public void Delete(int idClienteFornecedor)
        {
            _Cliente_Fornecedor_ObservacaoRepository.Delete(idClienteFornecedor);
        }

        public void Copy(Cliente_Fornecedor_ObservacaoModel objCliente_Fornecedor_Observacao)
        {
            _Cliente_Fornecedor_ObservacaoRepository.Copy(objCliente_Fornecedor_Observacao);
        }

        public Cliente_Fornecedor_ObservacaoModel GetCliente_Fornecedor_Observacao(int idClienteFornecedorObservacao)
        {
            return _Cliente_Fornecedor_ObservacaoRepository.GetCliente_Fornecedor_Observacao(idClienteFornecedorObservacao);
        }

        public List<Cliente_Fornecedor_ObservacaoModel> GetAllCliente_Fornecedor_Observacao(int idClienteFornecedor)
        {
            return _Cliente_Fornecedor_ObservacaoRepository.GetAllCliente_Fornecedor_Observacao(idClienteFornecedor);
        }
    }
}
