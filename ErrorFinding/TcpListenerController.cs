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


            server = new TcpListener(IPAddress.Parse(GitProcessCompiler.GetAppSettingsLocation("TcpProtokol", "IpAdress")), Convert.ToInt32(GitProcessCompiler.GetAppSettingsLocation("TcpProtokol", "Port")));
            server.Start();
            Queue<TcpClient> clientQueue = new Queue<TcpClient>();
            Console.WriteLine("Sunucu başlatıldı. Bağlantı bekleniyor...");

            while (true)
            {
                Console.WriteLine("Client Bekleniyor");
                TcpClient client = server.AcceptTcpClient();
                Console.WriteLine("Client Bağlandı");
                lock (clientQueue)
                {
                    clientQueue.Enqueue(client);
                }
                ProcessNextRequest(clientQueue);
            }
            static void ProcessNextRequest(Queue<TcpClient> clientQueue)
            {
                TcpClient nextClient = null;

                lock (clientQueue)
                {
                    if (clientQueue.Count > 0)
                    {
                        nextClient = clientQueue.Dequeue();
                    }
                }
                if (nextClient != null)
                {
                    try
                    {     
                        NetworkStream stream = nextClient.GetStream();
                        byte[] buffer = new byte[256];
                        int bytesRead = stream.Read(buffer, 0, buffer.Length);
                        if (bytesRead > 0)
                        {
                            GitProcessCompiler.GitCloneOperation();
                            GitProcessCompiler.GitPullOperation();
                            GitProcessCompiler.GitPushOperation();
                            nextClient.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Hata: " + ex.Message);
                        // Hata durumunda kuyruktan isteği çıkartabilir veya başka bir işlem yapabilirsiniz
                    }
                }
            }
        }
    }
}
