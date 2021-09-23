using System;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            int counta = 0, counte = 0, counti = 0, counto = 0, countu = 0;

            Console.Write("Ingrese una palabra: ");
            word = Console.ReadLine();

            for(int i=0; i < word.Length; i++)
            {
                if (word[i].ToString().ToLower() == "a")
                {
                    counta++;
                }

                if (word[i].ToString().ToLower() == "e")
                {
                    counte++;
                }

                if (word[i].ToString().ToLower() == "i")
                {
                    counti++;
                }

                if (word[i].ToString().ToLower() == "o")
                {
                    counto++;
                }

                if (word[i].ToString().ToLower() == "u")
                {
                    countu++;
                }
            }

            Console.WriteLine("Existen " + counta.ToString() + " vocales A.");
            Console.WriteLine("Existen " + counte.ToString() + " vocales E.");
            Console.WriteLine("Existen " + counti.ToString() + " vocales I.");
            Console.WriteLine("Existen " + counto.ToString() + " vocales O.");
            Console.WriteLine("Existen " + countu.ToString() + " vocales u.");
        }
    }
}
