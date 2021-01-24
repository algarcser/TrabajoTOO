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

        public extraDato(int id, string descripcion, float precio)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.precio = precio;
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

        public int Id
        {
            get
            {
                return this.id;
            }
        }

        public override int GetHashCode()
        {
            return 0;
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
