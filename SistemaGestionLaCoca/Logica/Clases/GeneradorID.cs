using LogicaClases.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Logica.Clases
{
    public class GeneradorID
    {
        private static int lastID = 0;

        public static int GenerateID()
        {
            lastID++;
            return lastID;
        }

        // ajustar los ID
        public static void AdjustIDs(List<Cancha> listaCancha)
        {
            for (int i = 0; i < listaCancha.Count; i++)
            {
                //Actualizamos el ID del elemento para que coincida con su posición en la lista +1
                listaCancha[i].id = i + 1;
            }
            //Actualizamos la variable lastID para que sea igual a la cantidad actual de elementos en la lista.
            // De esta manera, el próximo ID generado será consecutivo desde el último ID utilizado en la lista.
            lastID = listaCancha.Count;
        }
    }
}
