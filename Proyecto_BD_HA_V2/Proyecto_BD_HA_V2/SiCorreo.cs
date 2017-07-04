using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Proyecto_BD_HA_V2
{
    class SiCorreo
    {
        bool invalido = false;
        
        public bool EsCorreo(string email)
        {
            invalido = false;
            if (String.IsNullOrEmpty(email))
                return false;

            try
            {
                email = Regex.Replace(email, @"(@)(.+)$", this.DominioMapa, RegexOptions.None, TimeSpan.FromMilliseconds(200));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
            if (invalido)
                return false;

            try
            {
                return Regex.IsMatch(email, @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private string DominioMapa(Match match)
        {
            IdnMapping idn = new IdnMapping();

            string dominioNombre = match.Groups[2].Value;
            try
            {
                dominioNombre = idn.GetAscii(dominioNombre);
            }
            catch (ArgumentException)
            {
                invalido = true;
            }
            return match.Groups[1].Value + dominioNombre;
        }
    }
}
