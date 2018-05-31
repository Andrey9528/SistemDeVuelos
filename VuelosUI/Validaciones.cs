using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace VuelosUI
{
  public  class Validaciones
    {

        public static bool EsNumerico(string valor)
        {
            bool isnum;
            double retnum;
            isnum = Double.TryParse(Convert.ToString(valor),
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,out retnum);


            return isnum;


        }

        public static bool TelefonoValido(string telefono)
        {
            try
            {
                if (string.IsNullOrEmpty(telefono))
                    return false;
                var r = new Regex(@"^[0-9]{10}$");
                return r.IsMatch(telefono);

            }
            catch (Exception)
            {
                throw;
            }
        }
        public static Boolean ValidarEmail(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        


    }
}
