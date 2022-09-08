using System;

namespace Teste
{
    class Name
    {
        private string fullname;
        private int age;

        public Name(string name, int age)
        {
            this.fullname = name;
            this.Age = age;
        }

        public int Age { get => age; set => age = value; }
        public string Fullname { get => fullname; set => fullname = value; }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Name myName = new Name("Ramirez", 40);
            Console.WriteLine("Minha idade é: " + myName.Age + "  Meu nome é: " + myName.Fullname);

            Console.WriteLine("Digite seu nome!");
            string yourName = Console.ReadLine();

            Console.WriteLine("Digite sua idade!");
            int yourAge = Convert.ToInt32(Console.ReadLine());

            Name youtName = new(yourName, yourAge);
            Console.WriteLine("Sua idade é: " + youtName.Age + "  Seu nome é: " + youtName.Fullname);

            Console.ReadKey();
        }

    }
}
