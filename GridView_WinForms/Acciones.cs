using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridView_WinForms
{
    internal class Acciones
    {
        List<Auto> listaauto = new List<Auto>()
        {
        new Auto(112255,"v1","Tesla",2025,"Rojo"),
        new Auto(112508,"Versa","Nissan",2022,"Balnco"),
        new Auto(112003,"March","Nissan",2024,"Negro"),
        new Auto(112928,"Fiesta","Ford",2005,"Gris"),
        new Auto(112447,"Explores","Ford",2023,"Negro")
        };
      
    
        public List<Auto> MostrarAutos()
        {
            return listaauto;
        }
        public List<Auto> EliminarAutos()
        {
            return  listaauto.Clear();
        }


    }
}
