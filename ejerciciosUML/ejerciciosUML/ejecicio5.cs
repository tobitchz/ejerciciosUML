using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosUML { 

class ejecicio5
    {
        public static void Main5(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            biblioteca.AgregarLibro();
            biblioteca.BuscarLibro();
            biblioteca.PrestarLibros();
            biblioteca.DevolverLibro();
        }

        public class Biblioteca
        {
            public string? nombre;
            public string? ubicacion;
            public string? horarioApertura;

            List<Libro> libros = new List<Libro>();

            public void AgregarLibro()
            {
                Console.WriteLine("Ingrese el nombre del libro: ");
                string? nombreLibro = Console.ReadLine();
                nombreLibro = nombreLibro.ToLower();
                Console.WriteLine("Ingrese el autor del libro: ");
                string? nombreAutor = Console.ReadLine();
                nombreAutor = nombreAutor.ToLower();
                Console.WriteLine("Ingrese el anio de publicacion del libro: ");
                int anioLibro = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el genero del libro: ");
                string? nombreGenero = Console.ReadLine();


                Libro nuevo = new Libro(nombreLibro, nombreAutor, anioLibro, nombreGenero);

                libros.Add(nuevo);

                Console.WriteLine("Libro agregado exitosamente.");
            }

            public void PrestarLibros()
            {
                Console.WriteLine("¿Qué libro queres prestar?: ");
                Console.ReadLine();
                Console.WriteLine("Ok, libro prestado!");
            }

            public void DevolverLibro()
            {
                Console.WriteLine("¿Qué libro queres devolver?: ");
                Console.ReadLine();
                Console.WriteLine("Libro devuelto!");
            }

            

            public void BuscarLibro()
            {
                Console.WriteLine("Diga el nombre del autor o del libro:");
                string busqueda = Console.ReadLine();

                busqueda = busqueda.ToLower();

                foreach (Libro libro in libros)
                {
                    if (libro.titulo.Equals(busqueda) || libro.autor.Equals(busqueda))
                    {
                        Console.WriteLine("EL LIBRO SE HA ENCONTRADO");
                    }
                }

              
            }
        }

            public class Libro
        {
            public string titulo;
            public string autor;
            public int anio;
            public string genero;

      
            public Libro(string libroTitulo, string libroAutor, int libroAnio, string libroGenero)
            {
                this.titulo = libroTitulo;
                this.autor = libroAutor;
                this.anio = libroAnio;
                this.genero = libroGenero;
            }
        }
    }
}

/*
 Crea una clase "Biblioteca" con atributos como nombre, ubicación, horario de
apertura, etc. Define métodos para agregar libros al inventario, prestar libros,
devolver libros y buscar libros por título o autor.
*/
