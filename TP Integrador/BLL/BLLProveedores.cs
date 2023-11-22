﻿using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLProveedores
    {
        DalConexion dal = new DalConexion();

        public void AltaProveedor(Proveedor prov)
        {
          SqlParameter[] parametros = new SqlParameter[]
          {
                new SqlParameter("@Nombre", prov.Nombre),
                new SqlParameter("@NumTel", prov.NumTelefono)
          };

            dal.EjecutarProcAlmacenado("AltaProveedor", parametros);
        }

        public void BajaProveedor(int idProveedor)
        {
            
        }

        public DataTable traerTabla()
        {
            DataTable dt = dal.TraerTabla("Proveedores");
            return dt;
        }
    }
}
