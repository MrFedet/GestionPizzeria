﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaCapaNegocio.Interfaces;
using CapaDatos.Datos.Implementacion;
using CapaDatos.Datos.Interfaces;
using CapaDatos.Dominio;

namespace CapaNegocio.Implementacion
{
    public class ng_Cbos : ing_Cbos
    {

        private ICbos lg;

        public ng_Cbos()
        {
            lg = new Im_Cbos();
        }
        public List<Roles> ObtenerRoles()
        {
            return lg.ObtenerRoles();
        }
    }
}
