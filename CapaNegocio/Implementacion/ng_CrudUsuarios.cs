﻿using CapaDatos.Datos.Implementacion;
using CapaDatos.Datos.Interfaces;
using CapaDatos.Dominio;
using CapaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Implementacion
{//puente entre el back y el front
    public class ng_CrudUsuarios : ing_CrudUsuarios
    {
        private CrudUsuarios lg;

        public ng_CrudUsuarios()
        {
            lg = new Im_CrudUsuarios();
        }
        public bool AltaUsuario(Usuarios u, Usuarios admin)
        {
            return lg.AltaUsuario(u, admin);
        }

        public bool BloquearUsuario(string Alias)
        {
            return lg.BloquearUsuario(Alias);
        }

        public bool BuscarAliasUsuario(string alias)
        {
            return lg.BuscarAliasUsuario(alias);
        }

        public bool BuscarDniUsuario(long dni)
        {
            return lg.BuscarDniUsuario(dni);
        }

        public bool buscarId(int id, string alias)
        {
            return lg.buscarId(id,alias);
        }

        public bool BuscarUsuario(int id)
        {
            return lg.BuscarUsuario(id);
        }

        public bool ModificarUsuario(Usuarios u, Usuarios admin)
        {
            return lg.ModificarUsuario(u,admin);
        }

        public List<Usuarios> ObtenerUsuario(Usuarios u)
        {
            return lg.ObtenerUsuario(u);
        }

        public List<Usuarios> ObtenerUsuarios(int a)
        {
            return lg.ObtenerUsuarios(a);
        }

        public bool UsuarioAltaoBaja(string Alias)
        {
            return lg.UsuarioAltaoBaja(Alias);
        }
    }
}
