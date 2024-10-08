using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEncrypter
{
    internal class ReverseAlphabetEncryptor : IEncryptor
    {
        public string Decrypt(string toDecrypt)
        {
            return ZetOm(toDecrypt);
        }

        public string Encrypt(string toEncrypt)
        {
            return ZetOm(toEncrypt);
        }


        private string ZetOm(string text)
        {

            string result="";

            foreach (char c in text)
            {
                if (Char.IsUpper(c))
                {
                    result += Char.ToUpper(GetReverseAlfabetChar(Char.ToLower(c)));
                } else
                {
                    result+= GetReverseAlfabetChar(c);
                }
            }

            return result;
        }

        private char GetReverseAlfabetChar(char c)
        {
            switch (c)
            {
                case 'a': return 'z';
                case 'b': return 'y';
                case 'c': return 'x';
                case 'd': return 'w';
                case 'e': return 'v';
                case 'f': return 'u';
                case 'g': return 't';
                case 'h': return 's';
                case 'i': return 'r';
                case 'j': return 'q';
                case 'k': return 'p';
                case 'l': return 'o';
                case 'm': return 'n';
                case 'n': return 'm';
                case 'o': return 'l';
                case 'p': return 'k';
                case 'q': return 'j';
                case 'r': return 'i';
                case 's': return 'h';
                case 't': return 'g';
                case 'u': return 'f';
                case 'v': return 'e';
                case 'w': return 'd';
                case 'x': return 'c';
                case 'y': return 'b';
                case 'z': return 'a';

                default:
                    return c;
            }
        }
    }
}
