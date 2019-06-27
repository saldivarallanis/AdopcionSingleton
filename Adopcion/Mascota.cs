using System;
using System.Collections.Generic;
using System.Text;

namespace Adopcion
{
    class Mascota
    {
        public string Nombre;
        public string Raza;
        public int Edad;
        public string Color;

        public Mascota()
        {

        }

        public Mascota(String Nombre, String Raza)
        {
            this.Nombre = Nombre;
            this.Raza = Raza;
        }

        public Mascota(String Nombre, int Edad)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
        }

        public Mascota(String Nombre, int Edad, String Raza)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
            this.Raza = Raza;
        }

        public Mascota(String Nombre, String Color, int Edad)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
            this.Color = Color;
        }
    }
}
