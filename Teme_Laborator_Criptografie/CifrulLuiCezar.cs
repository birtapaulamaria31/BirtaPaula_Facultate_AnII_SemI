using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_Lab_1
{



    public class CifrulLuiCezar
    {


        static char[] Decriptare(string textIn, int n)
        {
            char[] textOut;
            textOut = textIn.ToCharArray();
            for (int i = 0; i < textIn.Length; i++)
            {
                if (Char.IsLetter(textOut[i]))
                {
                    if (Char.IsLower((textOut[i])))
                    {
                        int offset = textOut[i] - 'a';
                        int newOffset = (offset +26 - n) % 26;
                        textOut[i] = (char) ('a' + newOffset);
                        /*if (textOut[i] - n < 97)
                            textOut[i] = (char)((int)textOut[i] + 26 - n);
                        else
                            textOut[i] = (char)((int)textOut[i] - n);*/
                    }
                    else
                    {
                        if (textOut[i] - n < 65)
                            textOut[i] = (char)((int)textOut[i] + 26 - n);
                        else
                            textOut[i] = (char)((int)textOut[i] - n);
                    }
                }
            }
            return textOut;
        }

        static char[] Criptare(string textIn, int n)
        {
            char[] textOut;
            textOut = textIn.ToCharArray();
            for (int i = 0; i < textIn.Length; i++)
            {
                if (Char.IsLetter(textOut[i]))
                {
                    if (Char.IsLower((textOut[i])))
                    {
                        if (textOut[i] - n > 122)
                            textOut[i] = (char)((int)textOut[i] - 26 + n);
                        else
                            textOut[i] = (char)((int)textOut[i] + n);
                    }
                    else
                    {
                        if (textOut[i] - n > 90)
                            textOut[i] = (char)((int)textOut[i] - 26 + n);
                        else
                            textOut[i] = (char)((int)textOut[i] + n);
                    }
                }
            }
            return textOut;
        }

        public static void RezolvareCifru()
        {
            string input;
            Console.WriteLine("Introduceti un text:");
            input = Console.ReadLine();

            char[] output = input.ToCharArray();
            Console.WriteLine("Pentru decriptare apasati tasta 'D' , iar pentru criptare tasta 'C' ");
            char decizie = (char)Console.Read();

            if (decizie == 'd')
                output = Decriptare(input, 3);
            else
                output = Criptare(input, 3);

            Console.WriteLine(output);
            Console.ReadKey();
        }

    }
}
