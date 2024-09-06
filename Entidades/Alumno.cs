using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrimeraApp.Entidades
{
    internal class Alumno
    {
        

        internal string Nombre { get; set; }
        internal string Apellido { get; set; }
        internal int Edad { get; set; } = 12;


        public Alumno(string nombre, string apellido)
        {
            Nombre = nombre;    
            Apellido = apellido;
            Edad = 12; //regla de negocio (condicion)
        }

        public Alumno(string nombre, string apellido, int edad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;   
            this.Edad = edad;
        }
    }
}
