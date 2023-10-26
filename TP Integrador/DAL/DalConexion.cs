using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DalConexion
    {
        //Data Source=090L6PC21 = AGUS Y JOAQUIN
        //Data Source=090L6PC22-10217
        SqlConnection con = new SqlConnection("Data Source=090L6PC22-10217;Initial Catalog=TPIntegrador;Integrated Security=True");
       
        private void Conectar()
        {          
            con.Open();
        }

        //CONECTADO
        
        


        //DESCONECTADO
        DataSet dataSet;
        SqlDataAdapter adapter;
        SqlTransaction tran;

        public void CargarDataSet(string nombreTabla)
        {
            try
            {
                Conectar();
                dataSet = new DataSet();

                tran = con.BeginTransaction();

                SqlCommand command = new SqlCommand($"SELECT * FROM {nombreTabla}", con);
                command.Transaction = tran;

                adapter = new SqlDataAdapter(command);
                adapter.FillSchema(dataSet, SchemaType.Source, nombreTabla);
                adapter.Fill(dataSet, nombreTabla);

                tran.Commit();
                con.Close();
            }
            catch (Exception ex) { tran.Rollback(); }
        }

        public DataTable TraerTabla(string tabla)
        {
            if(dataSet == null)
            {
                CargarDataSet(tabla);
            }
            DataTable Tabla = dataSet.Tables[tabla];
            return Tabla;

        }

    }
}
