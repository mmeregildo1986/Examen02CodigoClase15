using Examen02CodigoClase15.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen02CodigoClase15.Clases
{
    public abstract class EmpleadoBase : IEmpleado
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Puesto { get; set; }
        public abstract double SueldoBase { get;}

        public abstract double CalcularSueldo();

        public void MostrarDetalle()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("ID del empleado es:");
            Console.WriteLine(IdEmpleado);
            Console.WriteLine("El nombre del empleado es:");
            Console.WriteLine(Nombre);
            Console.WriteLine("El puesto del empleado es:");
            Console.WriteLine(Puesto);
            Console.WriteLine("El sueldo base del empleado es:");
            Console.WriteLine(SueldoBase);

        }

        double IEmpleado.CalcularSueldo()
        {
            throw new NotImplementedException();
        }
    }
}
