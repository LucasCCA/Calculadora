using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora.Operações;

namespace Calculadora
{
    public class CalculadoraControle
    {
        public Somar Somar { get; private set; }
        public Subtrair Subtrair { get; private set; }
        public Multiplicar Multiplicar { get; private set; }
        public Dividir Dividir { get; private set; }

        public CalculadoraControle()
        {
            this.Somar = new Somar();
            this.Subtrair= new Subtrair();
            this.Multiplicar= new Multiplicar();
            this.Dividir = new Dividir();
        }
    }
}
