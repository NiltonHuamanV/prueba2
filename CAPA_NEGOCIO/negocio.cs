using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CAPA_DATOS;

//Esta es la capa de negocio
namespace CAPA_NEGOCIO
{
    public class negocio
    {
        conexion cn = new conexion();
        public DataTable ConsultaProveedor()
        {
            return cn.ListaProveedor();
        }
        public DataTable FiltroConsulta(string par1)
        {
            return cn.FiltroProveedor(par1);
        }
        public void InsertarProveedor(string codpro, string nompro, string dirpro, string telpro)
        {
            conexion cn2 = new conexion();
            cn2.Open();
            cn2.db_insertproveedor(codpro, nompro, dirpro, telpro);
        }
        public void ActualizarProveedor(string codpro, string nompro, string dirpro, string telpro)
        {
            conexion cn2 = new conexion();
            cn2.Open();
            cn2.db_updateproveedor(codpro, nompro, dirpro, telpro);
        }
        public void EliminarProveedor(string codpro)
        {
            conexion cn2 = new conexion();
            cn2.Open();
            cn2.db_deleteproveedor(codpro);
        }

    }
}
