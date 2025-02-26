namespace Aula1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int idade = 39;
            string nomeCompleto = "Danyelle";



            Console.WriteLine("Digite seu nome: ");
            string nomeUsuario =Console.ReadLine();
            Console.WriteLine("Digite a sua idade: ");
            string idadeUsuario = Console.ReadLine();


            Console.WriteLine($"Meu nome é {nomeCompleto} e a minha idade é {idadeUsuario}");
        }
    }
}
