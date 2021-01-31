using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaModeloVehiculo
{
    public class extra : IEquatable<extra>
    {
        private int id;
        private string descripcion;
        private float precio;

        /// <summary>
        /// constructor de extra
        /// </summary>
        /// <param name="id"> un entero que se usa para identificar un extra</param>
        /// <param name="descripcion"> es la descripcion de que es el extra</param>
        /// <param name="precio">un float que representa el precio del extra</param>
        public extra(int id, string descripcion, float precio)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.precio = precio;
        }

        /// <summary>
        /// definicion de la funcion hash de un extra
        /// </summary>
        /// <returns> devuelve siempre 0</returns>
        public override int GetHashCode()
        {
            return 0;
        }
        /// <summary>
        /// get: devuelve descripcion
        /// </summary>
        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
        }


        /// <summary>
        /// get: devuelve el entero id del extra
        /// </summary>
        public int Id
        {
            get
            {
                return this.id;
            }
        }
        /// <summary>
        /// get: devuelve precio
        /// </summary>
        public float Precio
        {
            get
            {
                return this.precio;
            }
        }


        /// <summary>
        /// redefinicion del metodo toString de extra
        /// </summary>
        /// <returns> devuelve un string con la descripcion del extra y el precio de este</returns>
        public override string ToString()
        {
            return this.Descripcion + "   Precio: " + this.Precio;
        }


        /// <summary>
        /// redefinicion del metodo equals para object
        /// </summary>
        /// <param name="obj"> objeto con el que queremos comparar el extra</param>
        /// <returns>devuelve cierto en el caso de que el objeto pasado sea de tipo extra y la funcion Equals(extra) sea cierta. Devuelve false en caso contrario</returns>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            extra objAsExtra = obj as extra;
            if (objAsExtra == null) return false;
            else return Equals(objAsExtra);
        }


        /// <summary>
        /// redefiniicon del metodo equals para extra
        /// </summary>
        /// <param name="other"> el extra con el que comparamos</param>
        /// <returns> devuelve true en el caso de que las id de los extras coincidan. devuelve falso en caso contrario.  </returns>
        public bool Equals(extra other)
        {
            if (other == null) return false;
            return (this.Id.Equals(other.Id));
        }


    }
}
