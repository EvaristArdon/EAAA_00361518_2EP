using System.Collections.Generic;

namespace Parcial02.Modelo
{
    public class User
    {
       
        public string fullname { get; set;}
        public string user { get; set; }
        public string password { get; set; }
        public bool admin { get; set; }

        public User()
        {
            fullname = "";
            user = "";
            password = "";
            admin = false;
        }

    }
}