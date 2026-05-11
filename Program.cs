using System.Net.NetworkInformation;
using System.Reflection.Metadata;

namespace AulaCsharp;

public class Program
{
    public static void Main()
    {
        string myName = "Victor"; // Variáveis são esseciais para reutilização do código; armazena um valor numa palavra.
        int number = 90;            
        double numberdouble = 7.5;
        float numberfloat = 8.5f;
        decimal numberdecimal = 5.5m;
        bool boolean = true;

        char caractere = 'V'; // Armazena apenas um caracter, apenas 1 item;

        const double pi = 3.14; // O valor é constante, não pode ser alterado

        dynamic variable = 40; // A variável dinâmica pode ter o valor trocado para outro tipo, uma variavel int pode ser alterada pra string
        variable = "Vito";

        var variavel = "variavel"; // var pode ter um valor de qualquer tipo

        Console.WriteLine($"Está Funcionando {number}");

        

       
    }
}