﻿using Clase_12_Library_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_12_Library
{
    public class Camion:Vehiculo
    {
        #region Constructores
        public Camion(EMarca marca, string patente, ConsoleColor color)
            : base(patente, marca, color)
        {
        }
        #endregion
        #region Propiedades
        /// <summary>
        /// Los camiones tienen 8 ruedas
        /// </summary>
        public override short CantidadRuedas
        {
            get
            {
                return 8;
            }
            set { }
        }
        #endregion
        #region Sobrecargas
        /// <summary>
        /// Metodo que mostrara las propiedades de la moto llamando al metodo Mostrar que hereda
        /// </summary>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CAMION");
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
