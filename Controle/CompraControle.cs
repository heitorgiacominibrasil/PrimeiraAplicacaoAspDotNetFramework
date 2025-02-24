﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    public class CompraControle
    {
        public void SalvarCompra(Modelo.Compra modelocompra)
        {
            try
            {
                DAL.CompraDAO compradao = new DAL.CompraDAO();
                if (modelocompra.Codigo == 0) {
                    compradao.SalvarTudo(modelocompra);
                }
                else {
                    compradao.AtualizarCompra(modelocompra);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Modelo.Compra> SelectTodasCompras(int id = 0)
        {
            try
            {
                DAL.CompraDAO daocompra = new DAL.CompraDAO();
                return daocompra.TodasCompras(id);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void DesabilitarCompra(Modelo.Compra modelocompra)
        {
            try
            {
                DAL.CompraDAO daocompra = new DAL.CompraDAO();
                daocompra.DesativarCompra(modelocompra);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
