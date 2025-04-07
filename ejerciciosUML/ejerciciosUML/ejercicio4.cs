using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosUML
{
    class ejercicio4
    {

        public static void Main(String[] args) 
        { 
            Libro libro = new Libro();

            libro.titulo = "1984";
            libro.autor = "George Orwell";
            libro.anio = 1949;
            libro.genero = "Ficcion distopica";

            Console.WriteLine($"hoy vamos a leer un libro de {libro.genero}. El libro es: {libro.titulo}, escrito por {libro.autor} y publicado en {libro.anio}");
            libro.Abrir();

            libro.Leer();

            libro.Cerrar();
        
        }

        public class Libro
        {
            public string titulo;
            public string autor;
            public int anio;
            public string genero;


            public void Abrir()
            {
                Console.WriteLine("se abre el libro");
            }

            public void Cerrar() 
            {
                Console.WriteLine("se cierra el libro");
            }

            public void Leer() 
            {
                Console.WriteLine("*lee el libro*");
            }
        }



    }
}


/*• Define una clase llamada "Libro" con atributos como título, autor, año de
publicación, género, etc. Incluye métodos para abrir, cerrar y leer.*/