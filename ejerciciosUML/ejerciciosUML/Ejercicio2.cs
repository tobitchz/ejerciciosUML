using System;

namespace Ejercico2{
    class Ejercicio2
    {
        public static void Main(String[] args) 
        {
            
            Avion avion = new Avion();
            Barco barco = new Barco();  
            Auto auto = new Auto();

            avion.modelo = "Boeing 777";
            auto.marca = "Bugatti";
            Console.WriteLine($"El coche es un {auto.marca}, el modelo del avion es {avion.modelo}");

            barco.Ancla();

            //pongo cosas variadas asi no hago uno por uno
        }
    }

    public class Vehiculo {

        public string? modelo;
        public string? marca;
        public string? anio;
        public string? numeroSerie;

        public void Arrancar()
        {
            Console.WriteLine("El vehiculo se encendio");
        }
        public void Apagar ()
        {
            Console.WriteLine("El vehiculo se apago");
        }
        public void Acelerar()
        {
            Console.WriteLine("El vehiculo esta acelerando");
        }
        public void Frenar()
        {
            Console.WriteLine("El vehiculo freno");
        }

    }


    public class Avion : Vehiculo 
    {

        public void Despegar()
        {
            Console.WriteLine("El avion esta despegando");
        }
        public void Aterrizar()
        {
            Console.WriteLine("El avion esta aterrizando");
        }
        
    }

    public class Barco : Vehiculo 
    {
        public void Ancla()
        {
            Console.WriteLine("Se desplego el ancla");
        }
    }

    public class Auto : Vehiculo 
    {
        public void EncenderElParabrisas() {
            Console.WriteLine("Se encendio el parabrisas");
                }
    }
}


