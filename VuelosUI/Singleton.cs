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
        public static Vuelos.DS.Interfaces.IPiloto opPiloto = new Vuelos.DS.Metodos.MPiloto();
        public static Vuelos.DS.Interfaces.IDestino opDestino = new Vuelos.DS.Metodos.MDestino();
        public static Vuelos.DS.Interfaces.IVuelos opVuelos = new Vuelos.DS.Metodos.MVuelos();
        public static Vuelos.DS.Interfaces.IAvion opavion = new Vuelos.DS.Metodos.MAvion();
        public static Vuelos.DS.Interfaces.ITipoVuelo optipovuelo = new Vuelos.DS.Metodos.MTipoVuelo();
        public static Vuelos.DS.Interfaces.IVuelosDestino opVuelosDestino = new Vuelos.DS.Metodos.MVuelosDestino();
        public static Vuelos.DS.Interfaces.ITipoLicencia optipolicencia = new Vuelos.DS.Metodos.MTipoLicencia();
        public static Vuelos.DS.Interfaces.IPIlotoLicencia opPilotoLicencia = new Vuelos.DS.Metodos.MPilotoLicencia();

    }

}
