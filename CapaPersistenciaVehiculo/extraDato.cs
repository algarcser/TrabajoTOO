using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistenciaVehiculo
{
    public class extraDato : IEquatable<extraDato>
    {
        private int id;
        private string descripcion;
        private float precio;


        /// <summary>
        /// constructor de extraDAto
        /// </summary>
        /// <param name="id"> representa la id del extra dato</param>
        /// <param name="descripcion"> representa la descripcion del extra dato</param>
        /// <param name="precio"> representa el precio que tiene asociado tal extra dato</param>
        internal extraDato(int id, string descripcion, float precio)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.precio = precio;
        }

        /// <summary>
        /// constructor de extra dato, con solo la id
        /// </summary>
        /// <param name="id"> representa la id del extra dato</param>
        internal extraDato(int id)
        {
            this.id = id;
            this.descripcion = "";
            this.precio = 0;
        }

        /// <summary>
        /// get: devuelve descripcion
        /// </summary>
        internal string Descripcion
        {
            get
            {
                return this.descripcion;
            }
        }

        /// <summary>
        /// get: devuelve la id asociada al extra dato
        /// </summary>
        internal int Id
        {
            get
            {
                return this.id;
            }
        }


        /// <summary>
        /// redefinicion del hascode de un extra dato
        /// </summary>
        /// <returns> devuevle 0</returns>
        public override int GetHashCode()
        {
            return 0;
        }

        /// <summary>
        /// get: devuelve precio
        /// </summary>
        internal float Precio
        {
            get
            {
                return this.precio;
            }
        }


        public override string ToString()
        {
            return this.Descripcion + "   Precio: " + this.Precio;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            extraDato objAsExtra = obj as extraDato;
            if (objAsExtra == null) return false;
            else return Equals(objAsExtra);
        }

        public bool Equals(extraDato other)
        {
            if (other == null) return false;
            return (this.Descripcion.Equals(other.Descripcion));
        }
    }
}
