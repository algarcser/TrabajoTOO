﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistenciaVehiculo
{
    class extraDato : IEquatable<extraDato>
    {
        private int extraID;
        private string descripcion;
        private float precio;


        public int ExtraID
        {
            get
            {
                return this.extraID;
            }
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
        /// get: devuelve precio
        /// </summary>
        public float Precio
        {
            get
            {
                return this.precio;
            }
        }

        public override int GetHashCode()
        {
            return this.ExtraID;
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