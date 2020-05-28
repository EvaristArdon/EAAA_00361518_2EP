using System;
using System.Collections.Generic;
using System.Data;
using Parcial02.Modelo;

namespace Parcial02
{
    public static class UserDAO
    {
        public static List<User> getLista()
        {
            string sql = "select * from APPUSER";

            DataTable dt = ConnectionDB.ExecuteQuery(sql);

            List<User> lista = new List<User>();
            foreach (DataRow fila in dt.Rows)
            {
                User u = new User();
                u.fullname = fila[1].ToString();
                u.user = fila[2].ToString();
                u.password = fila[3].ToString();
                u.admin = Convert.ToBoolean(fila[4].ToString());
                
                lista.Add(u);
            }
            return lista;
        }

        public static void actualizarContra(string usuario, string nuevaContra)
        {
            string sql = String.Format(
                "update APPUSER set password='{0}' where username='{1}';",
                nuevaContra, usuario);
            
            ConnectionDB.ExecuteNonQuery(sql);
        }

    }
}