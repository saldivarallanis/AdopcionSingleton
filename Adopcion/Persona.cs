using System;
using System.Collections.Generic;
using System.Text;

namespace Adopcion
{
    class Persona
    {
        public int Edad;
        public String Nombre;
        public String Domicilio;

        public Persona()
        {

        }

        public Persona(int Edad)
        {
            this.Edad = Edad;
        }

        public Persona(int Edad, String Nombre)
        {
            this.Edad = Edad;
            this.Nombre = Nombre;
        }

        public Persona(String Nombre, int Edad,String Domicilio)
        { 
            this.Edad = Edad;
            this.Nombre = Nombre;
            this.Domicilio = Domicilio;
        }
    }
}