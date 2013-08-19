using HLP.Comum.Infrastructure;
using HLP.Models.Sales.Comercial;
using HLP.Repository.Interfaces.Sales.Comercial;
using HLP.Services.Interfaces.Sales.Comercial;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Services.Implementation.Sales.Comercial
{
    public class Orcamento_ideService : IOrcamento_ideService
    {
        [Inject]
        public IOrcamento_ideRepository _Orcamento_ideRepository { get; set; }

        [Inject]
        public IOrcamento_ItemRepository _Orcamento_itemRepository { get; set; }

        [Inject]
        public IOrcamento_Item_ImpostosRepository _Orcamento_Item_ImpostosRepository { get; set; }

        [Inject]
        public IOrcamento_retTranspRepository _Orcamento_retTranspRepository { get; set; }

        [Inject]
        public IOrcamento_Total_ImpostosRepository _Orcamento_Total_ImpostosRepository { get; set; }

        public void Save(Orcamento_ideModel objOrcamento_ide)
        {
            try
            {
                _Orcamento_ideRepository.BeginTransaction();
                _Orcamento_ideRepository.Save(objOrcamento_ide);
                _Orcamento_retTranspRepository.Save(objOrcamento_ide.orcamento_retTransp);
                _Orcamento_Total_ImpostosRepository.Save(objOrcamento_ide.orcamento_Total_Impostos);

                #region Itens orçamento
                foreach (Orcamento_ItemModel item in objOrcamento_ide.lOrcamento_Itens.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Incluido))
                {
                    item.idOrcamento = (int)objOrcamento_ide.idOrcamento;
                    _Orcamento_itemRepository.Save(item);
                    _Orcamento_Item_ImpostosRepository.Save(item.orcamento_Item_Impostos);
                }
                foreach (Orcamento_ItemModel item in objOrcamento_ide.lOrcamento_Itens.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Alterado))
                {
                    _Orcamento_itemRepository.Update(item);
                    _Orcamento_Item_ImpostosRepository.Save(item.orcamento_Item_Impostos);
                }
                foreach (Orcamento_ItemModel item in objOrcamento_ide.lOrcamento_Itens.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Excluido))
                {
                    _Orcamento_itemRepository.Delete((int)item.idOrcamentoItem);
                    _Orcamento_Item_ImpostosRepository.Delete((int)item.orcamento_Item_Impostos.idOrcamentoTotalizadorImpostos);
                }
                #endregion

                #region Itens orçamento vendidos
                foreach (Orcamento_ItemModel item in objOrcamento_ide.lOrcamento_ItensVendidos.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Incluido))
                {
                    item.idOrcamento = (int)objOrcamento_ide.idOrcamento;
                    _Orcamento_itemRepository.Save(item);
                    _Orcamento_Item_ImpostosRepository.Save(item.orcamento_Item_Impostos);
                }
                foreach (Orcamento_ItemModel item in objOrcamento_ide.lOrcamento_ItensVendidos.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Alterado))
                {
                    _Orcamento_itemRepository.Update(item);
                    _Orcamento_Item_ImpostosRepository.Save(item.orcamento_Item_Impostos);
                }
                foreach (Orcamento_ItemModel item in objOrcamento_ide.lOrcamento_ItensVendidos.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Excluido))
                {
                    _Orcamento_itemRepository.Delete((int)item.idOrcamentoItem);
                    _Orcamento_Item_ImpostosRepository.Delete((int)item.orcamento_Item_Impostos.idOrcamentoTotalizadorImpostos);
                }
                #endregion

                #region Itens orçamento cancelados ou perdidos
                foreach (Orcamento_ItemModel item in objOrcamento_ide.lOrcamento_ItensCancelPerd.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Incluido))
                {
                    item.idOrcamento = (int)objOrcamento_ide.idOrcamento;
                    _Orcamento_itemRepository.Save(item);
                    _Orcamento_Item_ImpostosRepository.Save(item.orcamento_Item_Impostos);
                }
                foreach (Orcamento_ItemModel item in objOrcamento_ide.lOrcamento_ItensCancelPerd.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Alterado))
                {
                    _Orcamento_itemRepository.Update(item);
                    _Orcamento_Item_ImpostosRepository.Save(item.orcamento_Item_Impostos);
                }
                foreach (Orcamento_ItemModel item in objOrcamento_ide.lOrcamento_ItensCancelPerd.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Excluido))
                {
                    _Orcamento_itemRepository.Delete((int)item.idOrcamentoItem);
                    _Orcamento_Item_ImpostosRepository.Delete((int)item.orcamento_Item_Impostos.idOrcamentoTotalizadorImpostos);
                }
                #endregion

                _Orcamento_ideRepository.CommitTransaction();
            }
            catch (Exception)
            {
                _Orcamento_ideRepository.RollackTransaction();
                throw;
            }


        }

        public void Delete(Orcamento_ideModel objOrcamento_ide)
        {
            try
            {
                _Orcamento_ideRepository.BeginTransaction();
                _Orcamento_Item_ImpostosRepository.Delete(
                    (int)objOrcamento_ide.lOrcamento_Itens[0].orcamento_Item_Impostos.idOrcamentoTotalizadorImpostos);
                _Orcamento_Item_ImpostosRepository.Delete(
                    (int)objOrcamento_ide.lOrcamento_ItensVendidos[0].orcamento_Item_Impostos.idOrcamentoTotalizadorImpostos);
                _Orcamento_Item_ImpostosRepository.Delete(
                    (int)objOrcamento_ide.lOrcamento_ItensCancelPerd[0].orcamento_Item_Impostos.idOrcamentoTotalizadorImpostos);
                _Orcamento_itemRepository.Delete((int)objOrcamento_ide.lOrcamento_Itens[0].idOrcamentoItem);
                _Orcamento_itemRepository.Delete((int)objOrcamento_ide.lOrcamento_ItensVendidos[0].idOrcamentoItem);
                _Orcamento_itemRepository.Delete((int)objOrcamento_ide.lOrcamento_ItensCancelPerd[0].idOrcamentoItem);
                _Orcamento_Total_ImpostosRepository.Delete((int)objOrcamento_ide.orcamento_Total_Impostos.idOrcamentoTotalImpostos);
                _Orcamento_retTranspRepository.Delete((int)objOrcamento_ide.orcamento_retTransp.idRetTransp);
                _Orcamento_ideRepository.Delete((int)objOrcamento_ide.idOrcamento);
                _Orcamento_ideRepository.CommitTransaction();
            }
            catch (Exception)
            {
                _Orcamento_ideRepository.RollackTransaction();
                throw;
            }
        }

        public void Copy(Orcamento_ideModel objOrcamento_ide)
        {
            try
            {
                _Orcamento_ideRepository.BeginTransaction();
                _Orcamento_ideRepository.Copy((int)objOrcamento_ide.idOrcamento);
                foreach (Orcamento_ItemModel item in objOrcamento_ide.lOrcamento_Itens)
                {
                    _Orcamento_itemRepository.Copy((int)item.idOrcamentoItem);
                    _Orcamento_Item_ImpostosRepository.Copy((int)item.orcamento_Item_Impostos.idOrcamentoTotalizadorImpostos);
                }
                _Orcamento_retTranspRepository.Copy((int)objOrcamento_ide.orcamento_retTransp.idRetTransp);
                _Orcamento_Total_ImpostosRepository.Copy((int)objOrcamento_ide.orcamento_Total_Impostos.idOrcamentoTotalImpostos);

                _Orcamento_ideRepository.CommitTransaction();
            }
            catch (Exception)
            {
                _Orcamento_ideRepository.RollackTransaction();
                throw;
            }
        }

        public Orcamento_ideModel GetOrcamento_ide(int idOrcamento)
        {
            return _Orcamento_ideRepository.GetOrcamento_ide(idOrcamento);
        }

        public List<Orcamento_ideModel> GetAllOrcamento_ide()
        {
            return _Orcamento_ideRepository.GetAllOrcamento_ide();
        }
    }
}
