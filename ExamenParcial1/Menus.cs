using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcial1
{
    class Menus
    {
        string Nombre { get; set; }
        int Identificador { get; set; }
        int Horadeinicio { get; set; }
        int Horadefin { get; set; }
        List<Platillos> platillos = new List<Platillos>();
        public Menus()
        {
            Nombre = "Nuevo Menu";
            Identificador = 00;
            Horadeinicio = 00;
            Horadefin = 00;
        }
        public Menus(string nombre, int identificador, int horadeinicio, int horadefin)
        {
            Nombre = nombre;
            Identificador = identificador;
            Horadeinicio = horadeinicio;
            Horadefin = horadefin;
            platillos = new List<Platillos>();
        }
    }
}
