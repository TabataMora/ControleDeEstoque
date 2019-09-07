﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DAL;
using System.Data;

namespace BLL
{
    public class BLLUnidadeDeMedida
    {
        private DALConexao conexao;

        public BLLUnidadeDeMedida(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloUnidadeDeMedida modelo)
        {
            if (modelo.UmedNome.Trim().Length == 0)
            {
                throw new Exception("O nome da unidade de medida é obrigatório!");
            }

            DALUnidadeDeMedida DALobj = new DALUnidadeDeMedida(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloUnidadeDeMedida modelo)
        {
            if (modelo.UmedCod <= 0)
            {
                throw new Exception("O código da unidade de medida é obrigatório!");
            }

            if (modelo.UmedNome.Trim().Length == 0)
            {
                throw new Exception("O nome da unidade de medida é obrigatório!");
            }

            DALUnidadeDeMedida DALobj = new DALUnidadeDeMedida(conexao);
            DALobj.Alterar(modelo);

        }

        public void Excluir(int codigo)
        {
            DALUnidadeDeMedida Dalobj = new DALUnidadeDeMedida(conexao);
            Dalobj.Excluir(codigo);
        }

        public DataTable Localizar(string valor)
        {
            DALUnidadeDeMedida Dalobj = new DALUnidadeDeMedida(conexao);
            return Dalobj.Localizar(valor);
        }

        public ModeloUnidadeDeMedida CarregaModeloUnidadeDeMedida(int codigo)
        {
            DALUnidadeDeMedida Dalobj = new DALUnidadeDeMedida(conexao);
            return Dalobj.CarregaModeloUnidadeDeMedida(codigo);
        }
    }
}

