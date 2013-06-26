using System.Collections.Generic;
using HLP.Comum.Models;
using HLP.Comum.Repository.Interfaces;
using HLP.Comum.Services.Interface;
using Ninject;
using System.Data;

namespace HLP.Comum.Services.Implementation
{
    public class PesquisaPadraoService : IPesquisaPadraoService
    {
        [Inject]
        public IPesquisaPadraoRepository pesquisaPadraoRepository { get; set; }

        public List<PesquisaPadraoModel> GetTableInformation(string sViewName)
        {
            return pesquisaPadraoRepository.GetTableInformation(sViewName);
        }

        public string GetSingleData(string sSelect)
        {
            return pesquisaPadraoRepository.GetSingleData(sSelect);
        }
        public DataTable GetData(string sSelect, bool addDefault = false, string sWhere = "", bool bOrdena = true)
        {
            return pesquisaPadraoRepository.GetData(sSelect, addDefault, sWhere, bOrdena);
        }


        public string GetIdentityColumnName(string sTable)
        {
            return pesquisaPadraoRepository.GetIdentityColumnName(sTable);
        }


        public List<int> GetIdentityColumnValue(string sSelect)
        {
            return pesquisaPadraoRepository.GetIdentityColumnValue(sSelect);
        }


        public string GetFilter(string Value, string Operator, string sField, string sType)
        {
            return pesquisaPadraoRepository.GetFilter(Value, Operator, sField, sType);
        }


        public string ValidValue(string Value, string sType)
        {
            return pesquisaPadraoRepository.ValidValue(Value, sType);
        }


        public string GetFkTableName(string sTable, string sField)
        {
            return pesquisaPadraoRepository.GetFkTableName(sTable, sField);
        }


        public void CreateViewByTable(string sTable)
        {
            pesquisaPadraoRepository.CreateViewByTable(sTable);
        }


        public int GetFirstIDbyTable(string sTable, string sNameID = "")
        {
            return pesquisaPadraoRepository.GetFirstIDbyTable(sTable, sNameID);
        }
    }
}
