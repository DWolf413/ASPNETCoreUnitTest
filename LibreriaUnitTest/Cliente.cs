using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUnitTest
{
    public class Cliente
    {
        public string ClienteNombre {  get; set; }

        public string CrearNombreCompleto(string nombre, string apellido)
        {
            ClienteNombre = $"{nombre} {apellido}";
            //return $"{nombre} {apellido}";
            return ClienteNombre;
        }

    }
}
