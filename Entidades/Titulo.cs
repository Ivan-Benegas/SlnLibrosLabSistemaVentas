using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Titulo
    {
        public string NombreAutor { get; set; }
        public string TituloLibro { get; set; }
        public string Categoria { get; set; }
        public int Precio { get; set; }
        public string Notas { get; set; }

        public Titulo(string nombreAutor, string tituloLibro, string categoria, int precio, string notas)
        {
            NombreAutor = nombreAutor;
            TituloLibro = tituloLibro;
            Categoria = categoria;
            Precio = precio;
            Notas = notas;
        }

        public Titulo() { }

    }
}
