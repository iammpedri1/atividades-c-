using System;

public class ContaBancaria
{
    public static void Main()
    {
        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite o saldo inicial: ");
        double saldo = double.Parse(Console.ReadLine());

        Console.WriteLine("Quanto deseja sacar?: ");
        double saque = double.Parse(Console.ReadLine());

        if (saque <= 0)
        {
            Console.WriteLine("Valor de saque inválido.");
            return;
        }

        if (saldo < saque)
        {
            Console.WriteLine("Saldo insuficiente.");
            return;
        }

        double saldoAtual = saldo - saque;
        Console.WriteLine("Saque efetuado.");
        Console.WriteLine($"Olá, {nome}! Seu saldo atual é: {saldoAtual:F2}");
    }
}