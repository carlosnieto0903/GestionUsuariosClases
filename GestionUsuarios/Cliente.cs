﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionUsuarios
{
    internal class Cliente
    {

        public string Nombre
        {
            get ; set ; 
        }
        public string Telefono
        {
            get; set;
        }
        public string Tarjeta
        {
            get; set;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
