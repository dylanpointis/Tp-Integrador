using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using BE;
using System.Security.Claims;

namespace BLL
{
    public class BLLUsuarios
    {
        DalConexion dal = new DalConexion();

        public DataTable traerTabla()
        {
            DataTable dt = dal.TraerTabla("Usuarios");
            return dt;
        }

        public void RegistrarUsuario(string username, string password, string rol)
        {

            string hash = HashPassword(password);

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@nombreDeUsuario", username),
                new SqlParameter("@clave", hash),
                new SqlParameter("@rol", rol)
            };


            //$"INSERT INTO Usuarios (NombreDeUsuario, Clave, Salt) VALUES (@NombreDeUsuario, @Clave, @Salt)";
            dal.EjecutarProcAlmacenado("RegistrarUsuario", parametros);
        }

        public void BajaUsuario(int id)
        {
            dal.EjecutarComando($"delete from Usuarios where id_usuario = {id}");
        }



        //Encriptar password con metodo MD5
        private string HashPassword(string clave)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(clave);
                byte[] hash = md5.ComputeHash(inputBytes);

                string hashTexto = BitConverter.ToString(hash).Replace("-", "").ToLower();

                return hashTexto;
            }
        }


        public (bool, Usuario)VerificarUsuario(string nombreUsuario, string clave)
        {
            DataTable tabla = dal.TraerTabla("Usuarios");

            foreach(DataRow row in tabla.Rows)
            {
                if (row[1].ToString() == nombreUsuario && row[2].ToString() == HashPassword(clave))
                {
                    Usuario user = new Usuario(nombreUsuario, "-");
                    user.Rol = row[3].ToString();
                    user.IDUser = Convert.ToInt32(row[0]);
                    return (true, user);
                }
            }
            return (false, null);
        }


        public int TraerId(string nombreUsuario)
        {
            int id = 0;

            DataTable tabla = dal.TraerTabla("Usuarios");
            foreach (DataRow row in tabla.Rows)
            {
                if (row[1].ToString() == nombreUsuario)
                {
                    id = Convert.ToInt32(row[0]);
                }
            }
            return id;
        }
    }
}
