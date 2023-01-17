using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Publicador
    {
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public string Domicilio { get; set; }
        public string Contacto { get; set; }
        public string Pais { get; set; }

        public Publicador(string nombre, string ciudad, string domicilio, string contacto, string pais)
        {
            Nombre = nombre;
            Ciudad = ciudad;
            Domicilio = domicilio;
            Contacto = contacto;
            Pais = pais;
        }

        public Publicador() { }

    }
}
