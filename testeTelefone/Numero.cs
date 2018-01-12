using System;

namespace testeTelefone
{
    internal class Numero
    {
        public Numero()
        {

        }
     //Conversão de caracteres
    internal static object gerar(string caracter)
        {
        if(caracter == "a" || caracter == "b" || caracter == "c")
            {
                return "2";
            }
          
            else if (caracter == "d" || caracter == "e" || caracter == "f")
            {
                return "3";
            }

            else if (caracter == "g" || caracter == "h" || caracter == "i")
            {
                return "4";
            }

            else if (caracter == "j" || caracter == "k" || caracter == "l")
            {
                return "5";
            }

            else if (caracter == "m" || caracter == "n" || caracter == "o")
            {
                return "6";
            }
            else if (caracter == "p" || caracter == "q" || caracter == "r" || caracter == "s")
            {
                return "7";
            }
            else if (caracter == "t" || caracter == "u" || caracter == "v")
            {
                return "8";
            }
            else if (caracter == "w" || caracter == "x" || caracter == "y" || caracter == "z")
            {
                return "9";
            }
            else if (caracter == "1" || caracter == "0")
            {
                return caracter;
            }
            return "entrada inválida";
        }

        //Converte caso aja mais de uma caractere de entrada
        internal static object lerCaracteres(String caracteres)
        {
            
            String numeroConvertido = "";

            for (int i = 0; i < caracteres.Length; i++)
            {
                numeroConvertido = numeroConvertido + gerar(Char.ToString(caracteres[i]));
            }
            return numeroConvertido;
        }
    }
}