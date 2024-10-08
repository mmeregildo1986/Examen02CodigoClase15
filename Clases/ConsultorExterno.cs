using Examen02CodigoClase15.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen02CodigoClase15.Clases
{
    public class ConsultorExterno : EmpleadoBase
    {
        public override double SueldoBase => 5000;


        public override double CalcularSueldo()
        {
            return SueldoBase;
        }
    }
}
