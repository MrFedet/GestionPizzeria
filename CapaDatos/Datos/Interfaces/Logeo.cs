﻿using CapaDatos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Datos.Interfaces
{    //las interfaces sirven para crear metodos abstractos y en donde se le aplique la herencia se firma como un contrato en el cual deben estar estos metodos si o si

    public interface Logeo
    {
        bool Logeado(Usuarios u);
        Usuarios GetUsuario(Usuarios u);

        void RegistroInicio(int usuario);
        void RegistroSalida(int usuario);
    }
}
