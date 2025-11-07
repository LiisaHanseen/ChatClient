using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text.Json;
using System.Threading.Tasks;

namespace ChatClient
{
    class Program
    {
        // ----------------------------------------------------- Programmets start - Main ----------------------------------------------------------
        static async Task Main()
        {
            Console.WriteLine("Välkommen till chatten!");
            Console.WriteLine("Ange ett användarnamn: ");
            string username = Console.ReadLine()?.Trim() ?? "username";

            while (string.IsNullOrWhiteSpace(username))
            {
                Console.WriteLine("Användarnamnet kan inte vara tomt. Vänligen ange ett giltigt användarnamn: ");
                username = Console.ReadLine()?.Trim() ?? "username";
            }

            // await

            Console.WriteLine("Skriv ett meddelande eller ett kommando (/help):");
            // loop, kommandon, meddelanden, hsitorik, avslutning

            Console.WriteLine("Avslutar...");
        }
    }
}