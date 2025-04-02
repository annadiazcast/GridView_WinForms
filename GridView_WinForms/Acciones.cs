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

        Auto a=new Auto();
        public List<Auto> MostrarAutos()
        {
            return listaauto;
        }

        public bool EliminarAuto(int matricula)
        {
            try
            {
                var objectEliminar = listaauto.Find(x => x.Matricula == matricula);
                if (objectEliminar != null)
                {
                    listaauto.Remove(objectEliminar);
                    return true;
                }
                    return false;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool InsertarAuto(int matricula,string marca,string modelo,int anio,string color)
        {
            try
            {
                listaauto.Add(new Auto(a.Matricula=matricula,a.Marca=marca,a.Modelo=modelo,a.Anio=anio,a.Color=color));
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
