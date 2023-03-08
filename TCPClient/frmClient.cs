using System;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Xml;
using System.Drawing;
using System.Threading;

namespace TCPClient
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }

        //----------------Objetos---------------------
        bool connecExito = false;
        TcpListener servidor;
        //--------------------------------------------

        private void btn_config_Click(object sender, EventArgs e)
        {
            string archivoXML = "TCPSettings.xml";

            //Leer XML
            XmlDocument documentoXML = new XmlDocument();
            documentoXML.Load(archivoXML);

            //Escribir XML IP
            XmlNode nodoIP = documentoXML.SelectSingleNode("/ConfigurationData/Protocol/TCP/IP");
            nodoIP.InnerText = txb_ip.Text;

            //Escribir XML Puesta
            XmlNode nodoPuerta = documentoXML.SelectSingleNode("/ConfigurationData/Protocol/TCP/Puerta");
            nodoPuerta.InnerText = txb_port.Text;

            documentoXML.Save(archivoXML);
        }


        private void btn_comprovarXarxa_Click(object sender, EventArgs e)
        {
            btn_comprovarXarxa.Enabled = false;
            // 1.Cambiar el color del panel a amarillo
            Thread tarea1 = new Thread(() => pnl_status.BackColor = Color.Yellow);
            tarea1.Start();

            // 2.Verificar si el ordenador tiene conexión a internet
            Thread tarea2 = new Thread(internetAvaliable);
            tarea2.Start();

            // 3.Realizar 10 pings a 8.8.8.8
            Thread tarea3 = new Thread(new ThreadStart(pingGoogle));
            tarea3.Start();

            string archivoXML = "TCPSettings.xml";

            //Leer XML
            XmlDocument documentoXML = new XmlDocument();
            documentoXML.Load(archivoXML);

            //IP
            XmlNode tcpNodeIP = documentoXML.SelectSingleNode("/ConfigurationData/Protocol/TCP/IP");
            if (tcpNodeIP != null)
            {
                txb_ip.Text = tcpNodeIP.InnerText;
            }
            //Puerta
            XmlNode tcpNodePuerta = documentoXML.SelectSingleNode("/ConfigurationData/Protocol/TCP/Port");
            if (tcpNodePuerta != null)
            {
                txb_port.Text = tcpNodePuerta.InnerText;
            }


        }

        private void internetAvaliable()
        {
            bool networkAvaliable = false;
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                networkAvaliable = true;
            }
            else
            {
                pnl_status.Invoke((MethodInvoker)delegate
                {
                    pnl_status.BackColor = Color.Red;
                });
            };
        }

        private void pingGoogle()
        {
            Ping pingSender = new Ping();
            for (int i = 1; i <= 10; i++)
            {
                PingReply reply = pingSender.Send("8.8.8.8");
                if (reply.Status == IPStatus.Success)
                {
                    lbx_console.Invoke((MethodInvoker)delegate
                    {
                        lbx_console.Items.Add("Ping" + i + " - OK " + reply.RoundtripTime + "ms");
                    });
                    if (i >= 9)
                    {
                        pnl_status.Invoke((MethodInvoker)delegate
                        {
                            pnl_status.BackColor = Color.Green;
                        });
                    }
                }
                else
                {
                    lbx_console.Invoke((MethodInvoker)delegate
                    {
                        lbx_console.Items.Add("Ping" + i + " - NO OK");
                    });
                    if (i >= 9)
                    {
                        pnl_status.Invoke((MethodInvoker)delegate
                        {
                            pnl_status.BackColor = Color.Red;
                        });
                    }
                }
            }
        }

        private void btn_sendMessage_Click(object sender, EventArgs e)
        {
            if (txb_message.Text != "")
            {
                EnviarMensaje();
            }
        }

        private void btn_desconnect_Click(object sender, EventArgs e)
        {
            if (servidor != null)
            {
                servidor.Stop();
                servidor = null;
            }

            // Cerrar la conexión
            Application.Exit();
        }

        public void EnviarMensaje()
        {
            string direccionIP = txb_ip.Text;
            int puerto = int.Parse(txb_port.Text);

            TcpClient cliente = new TcpClient(direccionIP, puerto);

            string mensaje = txb_message.Text;

            byte[] datos = Encoding.ASCII.GetBytes(mensaje);
            NetworkStream flujoRed = cliente.GetStream();
            flujoRed.Write(datos, 0, datos.Length);

            txb_message.Text = "";

            cliente.Close();
        }

    }
}
