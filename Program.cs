using System.Net.NetworkInformation;
using System.Reflection.Metadata;

namespace AulaCsharp;

public class Program
{
    public static void Main()
    {

        Console.WriteLine("----------------CADASTRO----------------");

        string senha = "";
        int tamanho = 5;

        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite seu email: ");
        string email = Console.ReadLine();

        Console.Write("Digite sua senha: ");
        senha = Console.ReadLine();

        if (senha.Length < tamanho)
        {
            Console.WriteLine($"A senha deve conter no minímo {tamanho} caracteres");
            while (senha.Length < tamanho)
            {
                Console.Write("Digite sua senha novamente: ");
                senha = Console.ReadLine();
            }
        }

        Console.WriteLine("Seu cadastro foi bem sucedido!\n");
        Console.WriteLine("--------------------------------");
        Console.WriteLine(".");
        Console.WriteLine(".");
        Console.WriteLine(".");
        Console.WriteLine(".");
        Console.WriteLine(".");
        Console.WriteLine(".");
        Console.WriteLine(".");
        Console.WriteLine(".");
        Console.WriteLine(".");
        Console.WriteLine(".");

        Console.WriteLine("----------------LOGIN----------------");

        Console.Write("Digite seu email: ");
        string emailLogin = Console.ReadLine();

        Console.Write("Digite sua senha: ");
        string senhaLogin = Console.ReadLine();
        if (emailLogin != email || senhaLogin != senha)
        {
            Console.WriteLine("Suas informações estão incorretas!");
            while (emailLogin != email || senhaLogin != senha)
            {
                Console.WriteLine("----------------LOGIN----------------");
                Console.Write("Digite seu email: ");
                emailLogin = Console.ReadLine();

                Console.Write("Digite sua senha: ");
                senhaLogin = Console.ReadLine();
            }
        }
        Console.WriteLine(".");
        Console.WriteLine(".");
        Console.WriteLine(".");
        Console.WriteLine(".");
        Console.WriteLine(".");
        Console.WriteLine(".");
        Console.WriteLine(".");
        Console.WriteLine(".");
        Console.WriteLine(".");
        Console.WriteLine(".");
        Console.WriteLine($"--------------Olá {nome}, Bem vindo ao nosso site!------------ ");










    }
}