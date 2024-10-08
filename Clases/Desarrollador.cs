using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen02CodigoClase15.Clases
{
    public class Desarrollador : EmpleadoBase
    {
        public override double SueldoBase => 3000;

        public override double CalcularSueldo()
        {
            return SueldoBase;
        }

    }
}
