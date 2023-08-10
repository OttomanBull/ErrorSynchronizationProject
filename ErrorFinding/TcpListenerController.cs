using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ErrorFinding
{
    public class TcpListenerController
    {

        public static void TcpListenerControl()
        {
            TcpListener server;
           
            try
            {
                server = new TcpListener(IPAddress.Parse(GitProcessCompiler.GetAppSettingsLocation("TcpProtokol", "IpAdress")), Convert.ToInt32(GitProcessCompiler.GetAppSettingsLocation("TcpProtokol", "Port")));
                server.Start();
                byte[] buffer = new byte[256];
                while(true)
                {
                    Console.WriteLine("CLient Bekleniyor");
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("CLient Bağlandı");
                    NetworkStream stream = client.GetStream();
                    while (stream.Read(buffer, 0, buffer.Length) != 0)
                    {
                        GitProcessCompiler.GitCloneOperation();
                        GitProcessCompiler.GitPullOperation();
                        ToFolder.ChangeUIFile();
                        GitProcessCompiler.GitPushOperation();
                    }
                    client.Close();
                }
            }
            catch(SocketException exc)
            {
                Console.WriteLine(exc.Message);
            }
           

        }
    }
}
