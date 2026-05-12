using System.Net.NetworkInformation;
using System.Reflection.Metadata;

namespace AulaCsharp;

public class Program
{
    public static void Main()
    {

        string nomeUsuario = "Victor";
        string senhaUsuario = "victor@123";

        Console.WriteLine("---------LOGIN---------");

        Console.Write("Digite seu nome:");
        string nome = Console.ReadLine();

        Console.Write("Digite sua senha:");
        string senha = Console.ReadLine();

        Console.WriteLine("-----------------------");

        if (nome == nomeUsuario && senha == senhaUsuario)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Login bem-sucedido!");
            Console.WriteLine("Bem vindo Victor Mori Santos");
            Console.WriteLine("-----------------------");
        }
        else if (nome != nomeUsuario && senha == senhaUsuario)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Nome do usuário incorreto!");
            Console.WriteLine("-----------------------");
        }
        else if (nome == nomeUsuario && senha != senhaUsuario)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Senha do usuário incorreta!");
            Console.WriteLine("-----------------------");
        }
        else
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Nome e Senha do usuário incorreta!");
            Console.WriteLine("-----------------------");
        }

        Console.WriteLine("Digite sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine()); // ou int idade = int.Parse(Console.ReadLine())




        
    

        

       
    }
}