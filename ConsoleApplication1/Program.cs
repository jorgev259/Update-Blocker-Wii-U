using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Make sure you are running FTPiiU Everywhere with Haxchi/Mocha before continuing \n Press a key to Continue");
            Console.ReadKey();
            Console.Clear();
            Console.Write("Write your console's ip addres. Example: 192.168.1.1 \n");
            var ip = Console.ReadLine();
            var inloop = true;
            while (inloop)
            {
                Console.Clear();
                Console.Write("Select an option \n 1)Delete update folder \n 2)Create update folder \n 3)Change Ip \n 4)Exit");

                FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://" + ip + "/storage_mlc/sys/update");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        ftpRequest.Method = WebRequestMethods.Ftp.DeleteFile;
                        break;

                    case "2":
                        Console.Clear();
                        ftpRequest.Method = WebRequestMethods.Ftp.MakeDirectory;
                        break;

                    case "3":
                        Console.Clear();
                        Console.Write("Write your console's ip addres. Example: 192.168.1.1 \n");
                        ip = Console.ReadLine();
                        break;

                    case "4":
                        inloop = false;
                        break;
                }

                ftpRequest.GetResponse();
                Console.Write("Press any key to continue. Behind this are the logs of the errors that ocurred");
                Console.ReadKey();
            }
        }
    }
}
