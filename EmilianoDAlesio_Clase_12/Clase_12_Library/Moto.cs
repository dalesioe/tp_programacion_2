using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Clase_12_Library_2;

namespace Clase_12_Library
{
    public class Moto:Vehiculo
    {
        #region Constructores
        public Moto(EMarca marca, string patente, ConsoleColor color)
            : base(patente, marca, color)
        {
        }
        #endregion
        #region Propiedades
        /// <summary>
        /// Las motos tienen 2 ruedas
        /// </summary>
        public override short CantidadRuedas
        {
            get
            {
                return 2;
            }
            set { }
        }
        #endregion
        #region Sobrecarga
        /// <summary>
        /// Metodo que mostrara las propiedades de la moto llamando al metodo Mostrar que hereda
        /// </summary>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("MOTO");
            sb.AppendLine(base.Mostrar());
            sb.Append("RUEDAS : ");
            sb.AppendLine(this.CantidadRuedas.ToString());
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
