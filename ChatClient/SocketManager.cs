using System;
using System.Collections.Generic;
using System.IO;
using SocketIOClient;
using System.Net.Sockets;
using System.Text.Json;
using System.Threading.Tasks;

namespace ChatClient_Exam
{
    public class SocketManager
    {
        private static SocketIO _client;
        private static readonly string Path = "/sys25d";
        public static List<string> messages;
        // server, eventnamn
        // hantering av meddelanden, anslutning, frånkoppling, väntetid, felhantering
    }
}
