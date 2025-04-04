using System;

namespace Ejercicio1
{
    class Program
    {
        public static void Main1(String[] args)
        {

            Autobus autobus = new Autobus();

            autobus.capacidadPasajeros = 23;
            autobus.cantPuertas = 3;
            autobus.cantAsientos = 120;
            autobus.numeroColectivo = "114";



        }
    }

    public class Vehiculo
    {
        public int capacidadPasajeros;
        public int cantPuertas;
        public int cantAsientos;

    }
    public class Autobus : Vehiculo
    {
        public string numeroColectivo;


        public void SubidaDePasajeros()
        {
            Console.WriteLine("*El vehiculo se detiene y los pasajeros suben*");
        }
        public void BajadaDePasajeros()
        {
            Console.WriteLine("*El vehiculo se detiene y los pasajeros bajan*");
        }

    }
}
