using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace ejerciciosUML
{
    class ejercicio7
    {
        public static void Main()
         { 
            Departamento depto = new Departamento();

            Console.WriteLine("nombre del empleado: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("salario: ");
            float salario = float.Parse(Console.ReadLine());

            depto.AgregarEmpleado(nombre, salario);

            Console.WriteLine("rol: ");
            string nombreRol = Console.ReadLine();

            Console.WriteLine("descripcion del rol: ");
            string descripcion = Console.ReadLine();

            Rol rol = new Rol(nombreRol, descripcion);
            depto.AsignarRol(nombre, rol);

            depto.MostrarNomina();
            depto.CalcularSalario(nombre);
      }

        class Rol
        {
            public string nombre, descripcion;
            public Rol(string nombre, string desc)
            {
                this.nombre = nombre;
                this.descripcion = desc;
            }
        
        
     }

        class Empleado
        {
            public string nombre;
            public float salario;
            public Rol rol = new Rol("sin rol", "sin descripcion");
        }

        class Departamento
        {
            private List<Empleado> nomina = new List<Empleado>();

            public void AgregarEmpleado(string nombre, float salario)
            {
                Empleado nuevoEmpleado = new Empleado();
                nuevoEmpleado.nombre = nombre;
                nuevoEmpleado.salario = salario; 
                nomina.Add(nuevoEmpleado);

            }  

            public void AsignarRol(string nombreEmpleado, Rol rol)
            {
                foreach (Empleado emp in nomina)
                {
                    if (emp.nombre == nombreEmpleado)
                    {
                        emp.rol = rol;
                    }
                }
            }

            public void MostrarNomina() {   
                foreach (Empleado emp in nomina)
                {
                    Console.WriteLine($"{emp.nombre} - ${emp.salario} - Rol: {emp.rol.nombre} ({emp.rol.descripcion})");
                }
            }

            public void CalcularSalario(string nombreEmpleado)
            {
                foreach (Empleado emp in nomina)
                { 
                    if (emp.nombre == nombreEmpleado)
                    {
                        double salarioNeto = emp.salario * 0.73;
                        Console.WriteLine($"salario neto: {salarioNeto}");
                    }
                
                    }
         }
   }
    }
}


/*
 7. Diseño de clase para un sistema de gestión de empleados:
• Define clases para representar empleados, departamentos, roles, etc. Incluye métodos
para agregar empleados, asignar roles, calcular salarios, etc.
*/


//este ejercicio en particular me hizo llorar, no porque sea dificil sino por lo cansado que estaba