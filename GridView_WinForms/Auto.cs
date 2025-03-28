using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridView_WinForms
{
    internal class Auto:Vehiculo
    {
        public Auto(int matricula, string modelo, string marca,int anio, string color)
            :base(matricula,marca,modelo)
        {
            Anio = anio;
            Color = color;
        }

        public int Anio { get; set; }
        public string Color { get; set; }
    }
}
