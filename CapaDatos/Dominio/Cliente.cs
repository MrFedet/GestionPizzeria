﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Datos;

namespace CapaDatos.Dominio
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Tipo_Cliente TipoCliente { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public Socio socio = new Socio();
        public int Baja_logica { get; set; }
        public string NombreCompleto { get; set; }
        public int Altura { get; set; }
        public string Departamento { get; set; }
        public int Piso { get; set; }
        public Localidad locali { get; set; }
        public long tel { get; set; }

    }
}
