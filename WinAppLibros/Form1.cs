using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppLibros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Autor autor = new Autor();

            autor.Nombre = "Juan";
            autor.Apellido = "González";
            autor.FechaNacimiento = new DateTime(1980, 01, 10);
            autor.Domicilio = "Avenida Genial 123";
            autor.Ciudad = "Rosario";
            autor.Pais = "Argentina";

            labelAutor.Text =
                "El nombre del autor es " + autor.Nombre + "\n" +
                "El apellido es " + autor.Apellido + "\n" +
                "La fecha de nacimiento es " + autor.FechaNacimiento + "\n" +
                "El domicilio es " + autor.Domicilio + "\n" +
                "La ciudad es " + autor.Ciudad + "\n" +
                "El país es " + autor.Pais;

        }

    }
}
