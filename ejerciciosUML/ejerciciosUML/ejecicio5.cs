using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosUML { 

    class ejecicio5
    {
        public static void Main(string[] args) 
        {

            Biblioteca biblioteca = new Biblioteca();

            biblioteca.AgregarLibro();

        }

        public class Biblioteca
        {
            public string? nombre;
            public string? ubicacion;
            public string? horarioApertura;


            public void AgregarLibro()
            {
                Console.WriteLine("Ingrese los datos del libro; ");    
                string? nombreLibro = Console.ReadLine(); 
                string? nombreAutor = Console.ReadLine();
                int anioLibro = int.Parse(Console.ReadLine());
                string? nombreGenero = Console.ReadLine();

                Libro[] libros = new Libro[30];

                libros[0] = new Libro(nombreLibro, nombreAutor, anioLibro, nombreGenero);

                foreach (Libro libro in libros)
                {
                    if (libro != null)
                    {
                        Console.WriteLine($"Titulo: {libro.titulo}, Autor: {libro.autor}, Anio: {libro.anio}, Genero: {libro.genero}");
                    }
                }
            }

            public void PrestarLibros() 
            {
                Console.WriteLine("Que libro queres prestar?: ");
                Console.ReadLine();
                Console.WriteLine("Ok, libro prestado!");
            }


            public void DevolverLibro() 
            { 
                Console.WriteLine("Que libro quiere devolver?: "); 
                Console.ReadLine();
                Console.WriteLine("Libro devuelto!");
            }

            public void BuscarLibro()
            {
                Console.WriteLine("Diga el nombre del autor o del libro: ")
                    {


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
