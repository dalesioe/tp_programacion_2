using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emiliano.Dalesio2C
{
    class Numero
    {
        private double _numero;

        public double getNumero()
        {
            return this._numero;
        }

        public Numero()
        { }
        public Numero(double num)
        {
            this._numero = num;
        }
        public Numero(string numero)
        {
            setNumero(numero);
        }

        private void setNumero(string num)
        {
            this._numero = ValidarNumero(num);
            
        }
        private static double ValidarNumero(string num)
        {
            double rta;
            double.TryParse(num,out rta);
            return rta;
        }

    }

}
