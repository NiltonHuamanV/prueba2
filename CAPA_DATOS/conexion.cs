using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CAPA_DATOS
{
    public class conexion
    {
        public static string strconex = "Data Source=70.38.114.121;Initial Catalog=bdprototipo;User ID=uprototipo2;Password=b8q5#4tB";
        public SqlConnection con = new SqlConnection(strconex);

        public void Open()
        {
            con.Open();

        }

        public void Close()
        {
            con.Close();
        }
        public DataTable ListaProveedor()
        {

            string query = "select * from tb_proveedor  ";
            SqlCommand comandos = new SqlCommand(query, con);
            SqlDataAdapter datos = new SqlDataAdapter(comandos);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }
        public DataTable FiltroProveedor(string par1)
        {

            string query = "select * from tb_proveedor where cod_prv like '%" + par1 + "%' ";
            SqlCommand comandos = new SqlCommand(query, con);
            SqlDataAdapter datos = new SqlDataAdapter(comandos);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }
        public void db_insertproveedor(string codpro, string nompro, string dirpro, string telpro)
        {

            SqlCommand cmd = new SqlCommand("INSERT INTO TB_PROVEEDOR(COD_PRV, RAZ_SOC_PRV, DIR_PRV, TEL_PRV, COD_DIS, REP_VEN) values(@a,@b,@c,@d,'D10',' ')", con);
            cmd.Parameters.AddWithValue("@a", codpro);
            cmd.Parameters.AddWithValue("@b", nompro);
            cmd.Parameters.AddWithValue("@c", dirpro);
            cmd.Parameters.AddWithValue("@d", telpro);

            int i = cmd.ExecuteNonQuery();
        }

        public void db_updateproveedor(string codpro, string nompro, string dirpro, string telpro)
        {

            SqlCommand cmd = new SqlCommand("UPDATE TB_PROVEEDOR SET RAZ_SOC_PRV=@b, DIR_PRV=@c, TEL_PRV=@d  WHERE COD_PRV=@a ", con);
            cmd.Parameters.AddWithValue("@a", codpro);
            cmd.Parameters.AddWithValue("@b", nompro);
            cmd.Parameters.AddWithValue("@c", dirpro);
            cmd.Parameters.AddWithValue("@d", telpro);
            int i = cmd.ExecuteNonQuery();
        }
        public void db_deleteproveedor(string codpro)
        {

            SqlCommand cmd = new SqlCommand("DELETE FROM TB_PROVEEDOR WHERE COD_PRV=@a ", con);

            cmd.Parameters.AddWithValue("@a", codpro);

            int i = cmd.ExecuteNonQuery();
        }
    }
}
