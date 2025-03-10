﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Dominio
{
    public class Socio
    {
        public int Id_Socio { get; set; }
        public long DNI { get; set; }
        public string Email { get; set; }
        public DateTime FechaAdhesion { get; set; }
        public int Baja_logica { get; set; }

        public Socio() 
        { 
            Id_Socio= 0;
            DNI= 0;
            Email= string.Empty;
            FechaAdhesion= DateTime.MinValue;
            Baja_logica= 2;
        }

    }
}
