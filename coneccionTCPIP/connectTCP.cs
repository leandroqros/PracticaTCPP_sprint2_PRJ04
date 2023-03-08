using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace coneccionTCPIP
{
    public class connectTCP
    {
        TcpListener server;
        NetworkStream ns;
        TcpClient client;
        public void iniciarServidor(int puerta)
        {
            
            
        }

        public void cerrarServidor()
        {
            if (server != null)
            {
                server.Stop();
                server = null;
            }
        }

        public bool verificarConnectTCP(string IP, int port)
        {
            bool connected = false;
            try
            {
                    using (TcpClient client = new TcpClient())
                {
                    client.Connect(IP, port);
                    connected = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectarse al servidor TCP: " + ex.Message);
            }
            return connected;
        }

        public string leerXMLip(string archivo)
        {
            string ip;
            XmlDocument doc = new XmlDocument();
            doc.Load(archivo);

            XmlNode tcpNode = doc.SelectSingleNode("/ConfigurationData/Protocol/TCP/IP");
            if (tcpNode != null)
            {
                return tcpNode.InnerText;
            }

            return null;
        }
        
        public string leerXMLpuerta(string archivo)
        {
            string ip;
            XmlDocument doc = new XmlDocument();
            doc.Load(archivo);

            XmlNode tcpNode = doc.SelectSingleNode("/ConfigurationData/Protocol/TCP/Port");
            if (tcpNode != null)
            {
                return tcpNode.InnerText;
            }

            return null;
        }
    }
}
