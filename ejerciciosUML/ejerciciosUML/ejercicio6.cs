using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosUML
{
    class Ejercicio6
    {
        public static void Main(String[] args)
        {
            CajeroAutomatico cajero = new CajeroAutomatico();

            cajero.saldoDisponible = 0;

            int boton;
            do
            {
                Menu();
                boton = int.Parse(Console.ReadLine());
                switch (boton)
                {
                    case 1:
                        cajero.ConsultarSaldo();
                        break;
                    case 2:
                        cajero.DepositarDinero();
                        break;
                    case 3:
                        cajero.RetirarDinero();
                        break;
                    case 0:
                        Console.WriteLine("Gracias!");
                        break;
                    default:
                        Console.WriteLine("Opcion invalida.");
                        break;
                }
            } while (boton != 0);
        }


        class CajeroAutomatico
        {
            public string ubicacion;
            public string numeroSerie;
            public float saldoDisponible;


            public void ConsultarSaldo()
            {
                Console.WriteLine($"Saldo disponible: ${saldoDisponible}");
            }
            public void DepositarDinero()
            {
                Console.Write("Ingrese cuanto dinero quiere depositar: $");
                saldoDisponible =+ float.Parse(Console.ReadLine());

            }
            public void RetirarDinero() 
            {
                Console.Write("Ingrese cuanto dinero quiere retirar: $");
                float saldoRetirar = float.Parse(Console.ReadLine());
                if (saldoRetirar > saldoDisponible)
                {
                    Console.WriteLine("Dinero insuficiente.");
                } else
                {
                    saldoDisponible =- saldoRetirar;
                    Console.WriteLine($"Dienero retirado con exito! Saldo actual: ${saldoDisponible}");
                }
            }
        }
        static void Menu()
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("       BIENVENIDO AL CAJERO          ");
            Console.WriteLine("=====================================");
            Console.WriteLine("1. Consultar saldo");
            Console.WriteLine("2. Depositar dinero");
            Console.WriteLine("3. Retirar dinero");
            Console.WriteLine("0. Salir");
            Console.WriteLine("=====================================");
            Console.Write("Seleccioná una opción: ");
        }



    }
}


/*
 6. Diseño de clase para un cajero automático:
• Crea una clase "CajeroAutomático" con atributos como ubicación, número de serie,
saldo disponible, etc. Implementa métodos para retirar dinero, depositar dinero y
consultar saldo.

 */