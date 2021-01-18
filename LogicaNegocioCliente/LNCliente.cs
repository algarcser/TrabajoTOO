﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistenciaCliente;
using LogicaModeloCliente;
namespace LogicaNegocioCliente
{
    class LNCliente
    {
        //private Comercial comercial;
        public bool altaCliente(Cliente c)
        {
            PersistenciaCliente.CREATE(c);
            return true;
        }

        public bool bajaCliente(Cliente c)
        {
            PersistenciaCliente.DELETE(c);
            return true;
        }
    
    }
}
