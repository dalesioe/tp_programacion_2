using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emiliano.Dalesio2C
{
    class Calculadora
    {
      
        public static double Operar(Numero num01, Numero num02, string op)
        {
            double rta=0;
            switch (validarOperador(op))
            {
                case "+":
                    rta= num01.getNumero() + num02.getNumero();
                    break;
                case "-":
                    rta= num01.getNumero() - num02.getNumero();
                    break;
                case "*":
                    rta= num01.getNumero() * num02.getNumero();
                    break;
                case "/":
                    if (num02.getNumero() == 0)
                    {
                        rta= 0;
                    }
                    else
                    {
                        rta= num01.getNumero() / num02.getNumero();
                    }
                    break;
               
            }
            return rta;
        }

        public static string validarOperador(string op)
        {
            string rta=op;
            if (op != "+" && op != "-" && op != "*" && op != "/" || op==null)
            { rta = "+"; }
            return rta;
        }
    }
}
