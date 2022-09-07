using System;

namespace CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(caesarCipher("w", 87));
        }

        public static string caesarCipher(string s, int k)
        {
            string resposta = string.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                var originalIndex = (int)s[i];
                var newIndex = (int)s[i] + k;
                var index_A = 65;
                var index_Z = 90;
                var index_a = 97;
                var index_z = 122;
                if ((originalIndex < index_A || originalIndex > index_Z) && 
                    (originalIndex < index_a || originalIndex > index_z))
                {
                    resposta += s[i];
                    continue;
                }

                if (char.IsLower(s[i]))
                {
                    while (newIndex > index_z)
                        newIndex = (index_a - 1) + Math.Abs(newIndex - index_z);
                }
                else
                {
                    while (newIndex > index_Z)
                        newIndex = (index_A - 1) + Math.Abs(newIndex - index_Z);
                }

                resposta += char.ConvertFromUtf32(newIndex);
            }

            return resposta;
        }
    }
}