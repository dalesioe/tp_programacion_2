using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_12_Library_2
{
    public abstract class Vehiculo
    {
        #region Enum
        public enum EMarca
        {
            Yamaha, Chevrolet, Ford, Iveco, Scania, BMW
        }
        #endregion
        protected EMarca _marca;
        protected string _patente;
        protected ConsoleColor _color;

        #region Constructor
        public Vehiculo (string patente, EMarca marca, ConsoleColor color)
        {
            this._color = color;
            this._marca = marca;
            this._patente = patente;
        }
        #endregion
        #region Propiedades
        /// <summary>
        /// Retornará la cantidad de ruedas del vehículo
        /// </summary>
        public abstract short CantidadRuedas { get; set; }
        /// <summary>
        /// Retornará la patente
        /// </summary>
        public string Patente
        {
            get { return _patente; }
            set { _patente = value; }
        }
        #endregion
        #region Sobrecarga
        /// <summary>
        /// Metodo mostrar que se sobrecargara
        /// </summary>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("PATENTE: {0}\r\n", this._patente);
            sb.AppendFormat("MARCA  : {0}\r\n", this._marca.ToString());
            sb.AppendFormat("COLOR  : {0}\r\n", this._color.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Dos vehículos son iguales si comparten la misma patente
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.Patente == v2.Patente);
        }
        /// <summary>
        /// Dos vehículos son distintos si su patente es distinta
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
        #endregion
    }
}
