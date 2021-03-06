﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Comercial;

namespace HLP.Repository.Interfaces.Entries.Comercial
{
    public interface ICliente_fornecedor_EnderecoRepository
    {
        void Save(Cliente_fornecedor_EnderecoModel objCliente_Fornecedor_Endereco);
        void Update(Cliente_fornecedor_EnderecoModel objCliente_Fornecedor_Endereco);
        void Delete(Cliente_fornecedor_EnderecoModel objCliente_Fornecedor_Endereco);
        void Delete(int idClienteFornecedor);
        void Copy(Cliente_fornecedor_EnderecoModel objCliente_Fornecedor_Endereco);
        Cliente_fornecedor_EnderecoModel GetCliente_Fornecedor_Endereco(int idEndereco);
        List<Cliente_fornecedor_EnderecoModel> GetAllCliente_Fornecedor_Endereco(int idClienteFornecedor);
    }
}
