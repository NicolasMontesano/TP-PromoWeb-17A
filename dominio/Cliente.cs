﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Cliente
    {
        public int ID {get; set;}
        public string DNI {get; set;}
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public string Mail {get; set;}
        public string Direccion {get; set;}
        public string Ciudad {get; set;}
        public int CP {get; set;} 
    }
}
