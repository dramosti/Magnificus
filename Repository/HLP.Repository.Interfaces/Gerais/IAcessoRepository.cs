﻿using HLP.Models.Entries.Gerais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Repository.Interfaces.Entries.Gerais
{
    public interface IAcessoRepository
    {
        void Save(Funcionario_AcessoModel objAcesso);
        void Update(Funcionario_AcessoModel objAcesso);
        void Delete(int idAcesso);
        void Delete(Funcionario_AcessoModel objAcesso);
        int Copy(int idAcesso);
        Funcionario_AcessoModel GetAcesso(int idAcesso);
        List<Funcionario_AcessoModel> GetAllAcesso();
        List<Funcionario_AcessoModel> GetAllAcesso_Funcionario(int idFuncionario);
    }
}
