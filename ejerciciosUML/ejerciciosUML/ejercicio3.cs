using System;


namespace ejercicio3
{
    class ejercicio3
    {

        public static void Main3(String[] args)
        {
            Gato gato = new Gato();
            Perro perro = new Perro();
            Vaca vaca = new Vaca();



            gato.edad = 6;
            gato.especie = "gato";

            Console.WriteLine($"El {gato.especie} tiene {gato.edad} anios y hace: ");
            gato.Maullar();

            perro.edad = 8;
            perro.especie ="perro";

            Console.WriteLine($"El {perro.especie} tiene {perro.edad} anios y hace: ");
            perro.Ladrar();

            vaca.edad = 1;
            vaca.especie = "vaca";

            Console.WriteLine($"El {vaca.especie} tiene {vaca.edad} anio y hace: ");
            vaca.LoQueSeaQueHaganLasVacas();
       



        }

        public class Animal { 

            public string? especie;
            public int? edad;
            public string? genero;


            public void Alimentarse()
            {
                Console.WriteLine("niam niam");
            }

            public void Reproducirse() 
            { 
                Console.WriteLine("*se reproducen*");
            }
        }

        public class Gato : Animal 
        { 
            
            public void Maullar() {
                Console.WriteLine("MIAUUU");
            }

        }
        public class Perro : Animal
        {
            public void Ladrar()
            {
                Console.WriteLine("GUAUUU");
            }
        }
        public class Vaca : Animal
        {
            public void LoQueSeaQueHaganLasVacas() 
            {
                Console.WriteLine("MUUUUUUUUUUUUUUUUUUUUU");
            }

        }



    }
}


/*Define una clase "Animal" con atributos como especie, edad, género, etc. Incluye
métodos para alimentar, reproducir y hacer sonidos característicos, que a su vez sea
clase padre de 2 clases más con sus métodos y atributos cada una.
*/