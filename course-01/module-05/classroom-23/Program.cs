﻿// Aula 23 - Conversão explícita

internal class Program
{
    private static void Main(string[] args)
    {
        int inteiro = 100;
        string tipo = inteiro.GetType().ToString(); // descobrir o tipo de variável

        uint inteiroSemSinal = (uint)inteiro; //Conversão explícita
        string tipoConvertido = inteiroSemSinal.GetType().ToString();
        string tipoUint = inteiro.GetType().ToString();

        Console.WriteLine($"\nVariável inteiro do tipo inicialmente({tipo})\n");
        Console.WriteLine($"Variável inteiro do tipo ({tipo}) convertida p/ o tipo ({tipoConvertido}) para ser usado em algo sem comprometer a original\n");
        Console.WriteLine($"Resultado da variável inteiro que agora continua do tipo ({tipoUint})\n");
    }
}