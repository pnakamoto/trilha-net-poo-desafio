using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Teste com a classe Nokia
            Console.WriteLine("=== Testando a classe Nokia ===");
            Smartphone nokia = new Nokia(numero: "123456", modelo: "Nokia 3310", imei: "1111111111", memoria: 64);
            Console.WriteLine($"Número: {nokia.Numero}, Modelo: {nokia.Modelo}, IMEI: {nokia.Imei}, Memória: {nokia.Memoria}GB");
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine();

            // Teste com a classe Iphone
            Console.WriteLine("=== Testando a classe Iphone ===");
            Smartphone iphone = new Iphone(numero: "654321", modelo: "iPhone X", imei: "2222222222", memoria: 128);
            Console.WriteLine($"Número: {iphone.Numero}, Modelo: {iphone.Modelo}, IMEI: {iphone.Imei}, Memória: {iphone.Memoria}GB");
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");
        }
    }
}
