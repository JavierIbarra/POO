using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro
{
    public class Persona
    {
        public bool VerifivarRut(string rut)    // Indicamos el metodo
        {
            int valor = 0;
            int verificador = 12;
            int div, resto;

            int n = 0;
            while (n < 9)       // Recoremos el string rut dado
            {
                if (n == 8)     // Al obtener el codigo verificador dado por el usuario
                {

                    if (rut[n].Equals('K') || rut[n].Equals('k'))
                    {
                        verificador = 10;       // Asignamos el valor 10 a la letra K (codigo verificador)
                    }
                    else if (Int16.Parse(Convert.ToString(rut[n])) == 0)
                    {
                        verificador = 11;       // Asignamos el valor 11 a la al codigo verificador 0
                    }
                    else
                    {
                        try
                        {
                            verificador = Int16.Parse(Convert.ToString(rut[n]));    // Asignamos el numero que le corresponde a cado codigo verificador
                        }
                        catch       // En  caso que no se pueda convertir en int
                        {
                            return false;       
                        }
                    }
                }
                else
                {
                    try     // Obtenemos la suma de los digitos por sus multiplicadores
                    {
                        if (n  <= 1)
                        {
                            valor += Int16.Parse(Convert.ToString(rut[n])) * (3 - n);
                        }
                        else
                        {
                            valor += Int16.Parse(Convert.ToString(rut[n])) * (9 - n);
                        }
                       
                    }
                    catch   // En  caso que no se pueda convertir en int
                    {
                        return false;
                    }
                }
                n++;
            }
            // Parte de la formula para calcular el digito verificador
            div = valor / 11;
            resto = valor - (11 * div);
            resto = 11 - resto;

            if (verificador == resto)   // Comprobamos que el digito verificador dado es igual al que hemos calculado 
            {
                return true;    
            }
            else        
            {
                return false;
            }

        }
    }
}