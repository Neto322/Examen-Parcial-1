using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcial1
{
    class Platillos
    {
        string Nombre { get; set; }
        string Descripcion { get; set; }
        int Precio;
        int _Precio
        {
            get
            {
               return _Precio;

            }
            set
            {
                if (_Precio < 50)
                {
                    Console.WriteLine("El precio no debe ser menor a 50 pesos");
                }
                else
                {
                    _Precio = value;
                }
            }
    }
        int Identificador { get; set; }
        List<Ingredientes> ingredientes = new List<Ingredientes>();
        public Platillos()
        {
            Nombre = "Nombre del platillo";
            Descripcion = "Descripcion del platillo";
            Precio = 00;
            Identificador = 00;
        }
        public Platillos(string nombre, string descripcion, int precio, int identificador)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            Identificador = identificador;
            ingredientes = new List<Ingredientes>();
        }
        
    }
}
