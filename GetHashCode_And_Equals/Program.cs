using GetHashCode_And_Equals.Entities;
using System;

namespace GetHashCode_And_Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client b = new Client { Name = "Alex", Email = "maria@gmail.com" };

            Console.WriteLine(a.Equals(b)); //compara referencia de conteudo
            Console.WriteLine(a == b); //compara referencia do ponteiro de memoria do objeto, como são objetos diferentes, vai dar falso
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
