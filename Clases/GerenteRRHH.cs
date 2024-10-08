using Examen02CodigoClase15.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen02CodigoClase15.Clases
{
    public class GerenteRRHH : EmpleadoBase,ISueldoBonificable,IDescuentoImpuesto
    {
        public override double SueldoBase => 7000;
        public double descuento;
        
        
        public double CalcularBonificacion()
        {
            return 2000;
        }

         public double DescontarSueldo()
        {
            descuento = (double)Constantes.DescuentoGerenteRRHH20Porciento;
           return SueldoBase *descuento ;
        }

        public override double CalcularSueldo()
        {
            return SueldoBase + CalcularBonificacion()-DescontarSueldo();
        }
    }
}
