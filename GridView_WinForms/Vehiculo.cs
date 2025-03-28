using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridView_WinForms
{
    internal class Vehiculo
    {
        public Vehiculo(int matricula, string modelo, string marca)
        {
            Matricula = matricula;
            Modelo = modelo;
            Marca = marca;
        }
        public Vehiculo() { }

        public int Matricula { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
    }
}
