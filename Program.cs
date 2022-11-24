using System;

namespace Atividade_DoNotRepeat
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Favor Preencher o campo ****");
            Console.WriteLine("*********************************");

            string character = Console.ReadLine();

            while (string.IsNullOrEmpty(character))
            {
                Console.WriteLine("**Valor preenchido é invalido !**");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("**** Favor Preencher o campo ****");
                Console.WriteLine("*********************************");

                 character = Console.ReadLine();
            }

            Console.WriteLine("**** Resultado da string ****");
            Console.WriteLine(RemoveDuplicateCharacters(character));
            Console.ReadKey();

        }

        private static string RemoveDuplicateCharacters(string character)
        {
            int length = character.Length;
            int totalizer = 0;
            string result = string.Empty;
            string characterOld = string.Empty;
            var array = character.ToCharArray();

            if (length == 1)
                return character;

            while (totalizer < length)
            {
                if (totalizer == 0)
                {
                    result = array[0].ToString();

                    characterOld = array[0].ToString();

                    totalizer++;

                    continue;
                }

                string characterNew = array[totalizer].ToString();

                if (characterOld != characterNew)
                {
                    result += array[totalizer].ToString();

                    characterOld = array[totalizer].ToString();
                }

                totalizer++;
            }

            return result;
        }
    }

    
}

