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
        public int Descuento = 10;

        public string CrearNombreCompleto(string nombre, string apellido)
        {

            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException("El nombre esta en blanco");
            }

            Descuento = 30;
            ClienteNombre = $"{nombre} {apellido}";
            //return $"{nombre} {apellido}";
            return ClienteNombre;
        }

    }
}
