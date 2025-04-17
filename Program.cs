using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.Json;
using Modul8_103022300023;

class Program
{
    static void Main(string[] args)
    {
        UIConfig config = new UIConfig();

        if (config.config.lang == "en") {
            Console.WriteLine("Please insert the amount of money to transfer:");
            int nominal = Convert.ToInt32(Console.ReadLine());
            if (nominal <= config.config.transfer.threshold)
            {

                Console.WriteLine($"Transfer fee = {config.config.transfer.low_fee}, Total amount = {config.config.transfer.low_fee + nominal}");
            } else
            {
                Console.WriteLine($"Biaya Transfer = {config.config.transfer.high_fee}, Total biaya = {config.config.transfer.high_fee + nominal}");
            }
        }
        else if (config.config.lang == "id")
        {
            Console.WriteLine("Masukkan jumlah uang yang akan di-transfer:");
            int nominal = Convert.ToInt32(Console.ReadLine());
        }


    }
    
}