using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_Lab_1
{
    public class CifrulN
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
                        if (textOut[i] - n < 97)
                            textOut[i] = (char)((int)textOut[i] + 26 - n);
                        else
                            textOut[i] = (char)((int)textOut[i] - n);
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
                        if (textOut[i] + n > 122)
                            textOut[i] = (char)((int)textOut[i] - 26 + n);
                        else
                            textOut[i] = (char)((int)textOut[i] + n);
                    }
                    else
                    {
                        if (textOut[i] + n > 90)
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
            string inputText;
            Console.WriteLine("Introduceti un text:");
            inputText = Console.ReadLine();
            Console.WriteLine("Introduceti un nr natural intre 0 - 26 ce reprezinta cheia de criptare/decriptare:");
            int cheie = Convert.ToInt32(Console.ReadLine());
            char[] output = inputText.ToCharArray();
            Console.WriteLine("Pentru decriptare apasati tasta 'D' , iar pentru criptare tasta 'C' ");
            char decizie = (char)Console.Read();

            if (decizie == 'd')
                output = Decriptare(inputText, cheie);
            else
                output = Criptare(inputText, cheie);

            Console.WriteLine(output);
            Console.ReadKey();
        }

    }
}
