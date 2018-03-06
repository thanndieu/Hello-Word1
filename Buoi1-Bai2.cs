using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace ConsoleApplication1
{
    class Program
    {
        public void netResolve()
        {
           
        }
            

        static void Main(string[] args)
        {
            Console.Write("Nhap vao ten Host: ");
            string host = Console.ReadLine();
            IPHostEntry e = Dns.GetHostEntry(host);
            Console.WriteLine("Ten: " + host);
            foreach (IPAddress ip in Dns.GetHostAddresses("google.com"))
            {
                Console.WriteLine(ip.ToString());
            }
        }
    }
}
