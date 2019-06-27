using System;

namespace Adopcion
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Alberto Alanis", 23, "Villa Garcia °109");

            Console.WriteLine("Bienvenidos a la tienda de Adopciones");
            Console.WriteLine("");
            Console.WriteLine("El nombre del cliente es: " + persona1.Nombre);
            Console.WriteLine("Su edad es: " + persona1.Edad);
            Console.WriteLine("El domicilio del cliente es: " + persona1.Domicilio);
            Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("Desea Adoptar un Perro");
            Mascota mascota1 = new Mascota("Lulu", 10,"Chihuahua");
            Console.WriteLine("El Nombre de la mascota que desea es: " + mascota1.Nombre);
            Console.WriteLine("La Edad de la mascota que quiere es: " + mascota1.Edad);
            Console.WriteLine("La Raza del perro es: " + mascota1.Raza);
            Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("Segundo Cliente");
            Persona persona2 = new Persona("Jose Luis", 26, "Villa Hermosa °928");
            Console.WriteLine("");
            Console.WriteLine("El nombre del cliente es: " + persona2.Nombre);
            Console.WriteLine("Su edad es: " + persona2.Edad);
            Console.WriteLine("El domicilio del cliente es: " + persona2.Domicilio);
            Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("Desea Adoptar un Gato");
            Mascota mascota2 = new Mascota("Lucky", 3, "Montes");
            Console.WriteLine("El Nombre de la mascota que desea es: " + mascota2.Nombre);
            Console.WriteLine("La Edad de la mascota que quiere es: " + mascota2.Edad);
            Console.WriteLine("La Raza del perro es: " + mascota2.Raza);
            Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("Tercer Cliente");
            Persona persona3 = new Persona("Carlos Beltran", 19, "Magisterial °1072");
            Console.WriteLine("");
            Console.WriteLine("El nombre del cliente es: " + persona3.Nombre);
            Console.WriteLine("Su edad es: " + persona3.Edad);
            Console.WriteLine("El domicilio del cliente es: " + persona3.Domicilio);
            Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("Desea Adoptar una Iguana");
            Mascota mascota3 = new Mascota("Iguano","Verde",2);
            Console.WriteLine("El Nombre de la mascota que desea es: " + mascota3.Nombre);
            Console.WriteLine("Su edad es: " + persona3.Edad);
            Console.WriteLine("Su color natural es: " + mascota3.Color);
            
            Console.ReadKey();
        }
    }
}
