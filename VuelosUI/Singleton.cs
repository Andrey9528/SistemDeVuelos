using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.DS;

namespace VuelosUI
{
    public class Singleton
    {
        public static Vuelos.DS.Interfaces.IUsuario opUsuarios = new Vuelos.DS.Metodos.MUsuario();
        public static Vuelos.DS.Interfaces.IRol opRoles = new Vuelos.DS.Metodos.MRol();

    }
}
