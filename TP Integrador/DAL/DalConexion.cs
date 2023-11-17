using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace DAL
{
    public class DalConexion
    {
        SqlConnection con = new SqlConnection("Data Source=090L3PC08-79692;Initial Catalog=TPIntegrador;Integrated Security=True");
       
        private void Conectar()
        {      
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }     
        }


        SqlTransaction tran;
        //CONECTADO

        public void EjecutarComando(string query)
        {
            try
            {
                Conectar();
                tran = con.BeginTransaction();
                SqlCommand command = new SqlCommand(query, con);
                command.Transaction = tran;
                command.ExecuteNonQuery();
                tran.Commit();
                con.Close();
            }
            catch (Exception ex) { tran.Rollback(); }
        }

        public void EjecutarProcAlmacenado(string nombreProc, SqlParameter[] parametros)
        {
            using (SqlCommand command = new SqlCommand(nombreProc, con))
            {
                command.CommandType = CommandType.StoredProcedure;
                foreach (SqlParameter parametro in parametros)
                {
                    command.Parameters.Add(parametro);
                }
                Conectar();
                command.ExecuteNonQuery();
                con.Close();
            }
        }

        public int EjecutarComandoYTraerID(string query)
        {
            Conectar();
            SqlCommand command = new SqlCommand(query, con);

            int idValor = Convert.ToInt32(command.ExecuteScalar());
            con.Close();
            return idValor;
        }

        //DESCONECTADO
        DataSet dataSet;
        SqlDataAdapter adapter;
        

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

        public DataTable traerTablaQuery(string query)
        {
            Conectar();

            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            DataTable tabla = new DataTable();
            tabla.Load(reader);

            con.Close();
            return tabla;
        }
    }
}
