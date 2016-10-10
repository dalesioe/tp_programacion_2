using Clase_12_Library_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_12_Library
{
    public class Concecionaria
    {
        List<Vehiculo> _vehiculos = new List<Vehiculo>();
        int _espacioDisponible;
        #region Enum
        public enum ETipo
        {
            Moto, Camion, Automovil, Todos
        }
        #endregion

        #region "Constructores"
        public Concecionaria()
        {
            this._vehiculos = new List<Vehiculo>();
        }
        public Concecionaria(int espacioDisponible)
        {
            this._espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Muestro la concecionaria y TODOS los vehículos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Mostrar(this, ETipo.Todos);
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos de la concecionaria y sus vehículos (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="concecionaria">Concecionaria a exponer</param>
        /// <param name="ETipo">Tipos de Vehiculos a mostrar</param>
        /// <returns></returns>
        public static string Mostrar(Concecionaria concecionaria, ETipo tipoDeVehiculo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", concecionaria._vehiculos.Count, concecionaria._espacioDisponible);
            sb.AppendLine("");

            switch (tipoDeVehiculo)
            {
                case ETipo.Automovil:
                    foreach (Vehiculo v in concecionaria._vehiculos)
                    {
                        if (v is Automovil)
                            sb.AppendLine(v.Mostrar());
                    }
                    break;
                case ETipo.Moto:
                    foreach (Vehiculo v in concecionaria._vehiculos)
                    {
                        if (v is Moto)
                            sb.AppendLine(v.Mostrar());
                    }
                    break;
                case ETipo.Camion:
                    foreach (Vehiculo v in concecionaria._vehiculos)
                    {
                        if (v is Camion)
                            sb.AppendLine(v.Mostrar());
                    }
                    break;
                default:
                    foreach (Vehiculo v in concecionaria._vehiculos)
                    {
                        sb.AppendLine(v.Mostrar());
                    }
                    break;
            }
            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un vehículo a la concecionaria, siempre que haya espacio disponible
        /// Agregará un vehículo a la concecionaria, siempre que este no este en la concesionaria
        /// Se modifico el foreach por for dado que al manipular indices pueden aparecer errores en tiempo de ejecucion
        /// </summary>
        /// <param name="concecionaria">Objeto del tipo Concecionaria donde se agregará el vehículo</param>
        /// <param name="vehiculo">Objeto del tipo Vehículo a agregar</param>
        /// <returns></returns>
        public static Concecionaria operator +(Concecionaria concecionaria, Vehiculo vehiculo)
        {
            if (concecionaria._vehiculos.Count >= concecionaria._espacioDisponible)
            {
                return concecionaria;
            }
            else
            {
                if (concecionaria._vehiculos.Count == 0)
                {
                    concecionaria._vehiculos.Add(vehiculo);
                }
                else
                {
                    for (int i = 0; i < concecionaria._vehiculos.Count; i++)
                    {
                        if (concecionaria._vehiculos[i] == vehiculo)
                        {
                            return concecionaria;
                        }
                        else
                        {
                            concecionaria._vehiculos.Add(vehiculo);
                            break;
                        }
                    }
                }
            }
            return concecionaria;
        }
        /// <summary>
        /// Quitará un vehículo de la concecionaria
        /// Se modifico el foreach por for dado que al manipular indices pueden aparecer errores en tiempo de ejecucion
        /// </summary>
        /// <param name="concecionaria">Objeto del tipo Concecionaria donde se eliminara el vehículo</param>
        /// <param name="vehiculo">Objeto del tipo Vehículo a eliminar</param>
        /// <returns></returns>
        public static Concecionaria operator -(Concecionaria concecionaria, Vehiculo vehiculo)
        {
            for (int i = 0; i < concecionaria._vehiculos.Count; i++)
            {
                if (concecionaria._vehiculos[i].Patente == vehiculo.Patente)
                {
                    concecionaria._vehiculos.Remove(vehiculo);
                    break;
                }
            }

            return concecionaria;
        }
        #endregion
    }
}
