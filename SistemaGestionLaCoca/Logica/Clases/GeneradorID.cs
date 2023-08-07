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
    public abstract class GeneradorID
    {
        private static int lastID = 0;

        public static int GenerateID()
        {
            lastID++;
            return lastID;
        }
            
        //FUNCIONES PARA AJUSTAR LOS IDs AL ELIMINAR UN OBJETO DE LA LISTA, EN ESTE CASO, CANCHAS
        // LA FUNCION DE ABAJO, AL ELIMINAR UN ELEMENTO, LE CAMBIA LOS IDs PARA QUE QUEDE UNA LISTA CONSECUTIVA

        /*
        // ajustar los ID
        public static void AdjustIDs(List<Cancha> listaCancha)
        {
            for (int i = 0; i < listaCancha.Count; i++)
            {
                //Actualizamos el ID del elemento para que coincida con su posición en la lista +1
                listaCancha[i].id = i + 1;
            }
            lastID = listaCancha.Count;
        }
        */

        // ESTA FUNCION, AL ELIMINAR UN ELEMENTO, NO CAMBIA LOS VALORES DE LOS IDs, SINO QUE, GUARDA EL ID MAS ALTO Y SIGUE AGEGANDO A PARTIR DE ESE.
        public static void AdjustIDs(List<Cancha> listaCancha)
        {
            int IDmasAlto = listaCancha.Max(item => item.id);

            // Actualizamos la variable lastID para que sea igual al ID más alto encontrado en la lista.
            // De esta manera, el próximo ID generado será consecutivo desde el último ID utilizado en la lista.
            lastID = IDmasAlto;
        }
        
        
    }
}   
