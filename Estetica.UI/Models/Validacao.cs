using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetica.UI.Models
{
    public class Validacao
    {

        //Verifica de há dados no campo
        public bool ValidarCampoVazio(string d1, string d2, string d3, string d4, string d5)
        {
            if (d1 == string.Empty || d2 == string.Empty || d3 == string.Empty || d4 == string.Empty || d5 == string.Empty)
            {
                return false;
            }
            return true;
        }

        public bool ValidarCampoVazio(string d1)
        {
            if (d1 == string.Empty)
            {
                return false;
            }
            return true;
        }


        //Verifica se é um número
        public bool ValidarNumero(string d1, string d2, string d3)
        {
            long result = 0;
            bool sucesso1 = Int64.TryParse(d1, out result);
            bool sucesso2 = Int64.TryParse(d2, out result);
            bool sucesso3 = Int64.TryParse(d3, out result);

            if (sucesso1 && sucesso2 && sucesso3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidarNumero(string d1)
        {
            long result = 0;
            bool sucesso1 = Int64.TryParse(d1, out result);

            if (sucesso1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /*public bool ValidarCpf(string cpf)
        {
            if (cpf.Count() != 11)
            {
                return false;
            }
            return true;
        }*/


    }
}
