﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Fiscal
{
    public class Tipo_documentoModel
    {
        [ParameterOrder(Order = 1)]
        public int idEmpresa { get; set; }
        [ParameterOrder(Order = 2)]
        public int? idTipoDocumento { get; set; }
        [ParameterOrder(Order = 3)]
        public string xTpdoc { get; set; }
        [ParameterOrder(Order = 4)]
        public byte stDocumento { get; set; }
        [ParameterOrder(Order = 5)]
        public byte stRelacaoPedidoxorcamento { get; set; }
        [ParameterOrder(Order = 6)]
        public byte stRelacaoPedidoxnf { get; set; }
        [ParameterOrder(Order = 7)]
        public byte stRelacaoPedidoxproducao { get; set; }
        [ParameterOrder(Order = 8)]
        public byte stGrupoFaturamento { get; set; }
        [ParameterOrder(Order = 9)]
        public string xSerieNf { get; set; }
        [ParameterOrder(Order = 10)]
        public string xEspecieVolumeNf { get; set; }
        [ParameterOrder(Order = 11)]
        public string xMarcaVolumeNf { get; set; }
        [ParameterOrder(Order = 12)]
        public byte stSomaIpi1Dup { get; set; }
        [ParameterOrder(Order = 13)]
        public byte stSomaSt1Dup { get; set; }
        [ParameterOrder(Order = 14)]
        public string xObs { get; set; }
        [ParameterOrder(Order = 15)]
        public byte stNfComplementar { get; set; }
        [ParameterOrder(Order = 16)]
        public byte stNfImportacao { get; set; }
        [ParameterOrder(Order = 17)]
        public byte stNfExportacao { get; set; }
        [ParameterOrder(Order = 18)]
        public byte stNfIndustrializacao { get; set; }
        [ParameterOrder(Order = 19)]
        public byte stNfSuframa { get; set; }
        [ParameterOrder(Order = 20)]
        public byte stNfAtivo { get; set; }
        [ParameterOrder(Order = 21)]
        public byte stCompoeVlTotalProdutos { get; set; }
        [ParameterOrder(Order = 22)]
        public byte stSomaDevolucaoVlTotalNf { get; set; }
        [ParameterOrder(Order = 23)]
        public byte stImprimeIcmsProprioComNormal { get; set; }
        [ParameterOrder(Order = 24)]
        public byte stRelacaoRecebimentoPedidocpa { get; set; }
        [ParameterOrder(Order = 25)]
        public byte stRelacaoPedidocpaCotacao { get; set; }
        [ParameterOrder(Order = 26)]
        public bool Ativo { get; set; }
        [ParameterOrder(Order = 27)]
        public int idModeloDocFiscal { get; set; }
        [ParameterOrder(Order = 28)]
        public byte? stNFdevolucao { get; set; }
    }
}
