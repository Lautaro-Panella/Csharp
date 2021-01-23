using Ejercicio2.Modelo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Principal
    {
        static void Main(string[] args)
        {
            LeerJSONFromURL();    
        }
        public static void LeerJSONFromURL()
        {
            var url = "https://randomuser.me/api/?results=10";
            WebClient wc = new WebClient();
            string usuariosJson = wc.DownloadString(url);

            var root = JsonConvert.DeserializeObject<Root>(usuariosJson);
            var usuarios = root.results;
            int i = 1;
            foreach (Usuario usuario in usuarios)
            {
                Console.WriteLine(i);
                Console.WriteLine("First name: " + usuario.name.first);
                Console.WriteLine("Last name: " + usuario.name.last);
                Console.WriteLine("Username: " + usuario.login.username);
                Console.WriteLine("Passwords: " + usuario.login.password);
                Console.WriteLine("--------------------------------------");
                i++;
            }
        }
    }
}
