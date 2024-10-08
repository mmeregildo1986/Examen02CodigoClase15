using Examen02CodigoClase15.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen02CodigoClase15.Clases
{
    public class Gerente : EmpleadoBase, ISueldoBonificable, IDescuentoImpuesto 
    {
        public override double SueldoBase => 8000;
        public double descuento;
        public double CalcularBonificacion()
        {
            return 1000;
        }
        
        public double DescontarSueldo()
        {
            descuento = (double)Constantes.DescuentoGerente10Porciento;
            return SueldoBase*descuento;
        }

        public override double CalcularSueldo()
        {
            return SueldoBase + CalcularBonificacion()-DescontarSueldo();
        }


    }
}
