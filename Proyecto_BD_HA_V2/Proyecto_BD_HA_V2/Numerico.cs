using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_BD_HA_V2
{
    class Numerico
    {
        public static bool EsNumerico(string num)
        {
            try
            {
                int x = Convert.ToInt32(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool EsNumericoFloat(string num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
