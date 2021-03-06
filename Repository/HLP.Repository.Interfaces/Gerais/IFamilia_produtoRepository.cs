﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Repository.Interfaces.Entries.Gerais
{
    public interface IFamilia_ProdutoRepository
    {
        Familia_produtoModel GetFamilia_produto(int idFamiliaProduto);
        void Save(Familia_produtoModel familia_produto);
        void Delete(int idFamiliaProduto);
        int Copy(Familia_produtoModel familia_produto);


        void BeginTransaction();
        void CommitTransaction();
        void RollackTransaction();
    }
}
