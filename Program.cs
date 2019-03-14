using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Dota dota = new Dota();
            TcpListener server = null;
            try
            {
                int port = 8910;
                IPAddress ip = IPAddress.Any;

                server = new TcpListener(ip, port);
                server.Start();

                byte[] bytes = new byte[100];
                string data = null;
                string a = "";

                Console.WriteLine("Waiting Connection...");
                TcpClient client = server.AcceptTcpClient();
                Console.WriteLine("Connected");
                NetworkStream stream = client.GetStream();


            }
            catch (SocketException e)
            {
                Console.WriteLine("Socket Exception : {0}", e);
            }
            Console.WriteLine("Hit enter to continue...");
            Console.ReadKey();
        }

        static void To_Send(string send, NetworkStream stream)
        {
            byte[] byte_paket = Encoding.ASCII.GetBytes(send);
            stream.Write(byte_paket, 0, byte_paket.Length);
        }

        static string To_Read(string write, NetworkStream stream)
        {
            byte[] bytes = new byte[100];
            int i = stream.Read(bytes, 0, bytes.Length);
            write = Encoding.ASCII.GetString(bytes, 0, i);
            return write;
        }


    }

    public class Dota
    {
        private long ID_Name = 4210161010;
        private int X;
        private int Y;
        private int Skill;
        private int Score;

        public long ID
        {
            get
            {
                return ID_Name;
            }
        }
        public long X_pos
        {
            get
            {
                return X;
            }
        }
        public long Y_pos
        {
            get
            {
                return Y;
            }
        }
        public long Skill_Pos
        {
            get
            {
                return Skill;
            }
        }
        public long Score_ID
        {
            get
            {
                return Score;
            }
        }
    }
}

