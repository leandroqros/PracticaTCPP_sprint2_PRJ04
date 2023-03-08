using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.IO;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace PracticaTCP
{
    public partial class frmServer : Form
    {
        public frmServer()
        {
            InitializeComponent();
        }

        //----------------Objetos---------------------
        private TcpListener servidor;
        private Thread listenThread;
        //--------------------------------------------

        private void btn_connect_Click(object sender, EventArgs e)
        {
            int puerta = int.Parse(txb_port.Text);
            // Empezar a escuchar 
            servidor = new TcpListener(IPAddress.Any, puerta);
            servidor.Start();

            // Hilos de pedidos de clientes
            listenThread = new Thread(new ThreadStart(escucharSolicitudes));
            listenThread.Start();

            btn_connect.Enabled = false;

            lbx_Missatges.Items.Add("Servidor Iniciado.");
        }

        private void escucharSolicitudes()
        {
            try
            {
                while (true)
                {
                    // Esperar por el cliente
                    TcpClient client = servidor.AcceptTcpClient();

                    Thread clientThread = new Thread(new ParameterizedThreadStart(escucharMensajes));
                    clientThread.Start(client);
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur while listening for clients
                MessageBox.Show(ex.Message);
            }
        }
        private void escucharMensajes(object client)
        {
            TcpClient tcpClient = (TcpClient)client;

            string clientIP = ((IPEndPoint)tcpClient.Client.RemoteEndPoint).Address.ToString();

            this.Invoke(new Action(() =>
            {
                lbx_Missatges.Items.Add($"IP:{clientIP} ha enviado:");
            }));

            byte[] buffer = new byte[1024];
            int bytesReceived = tcpClient.GetStream().Read(buffer, 0, buffer.Length);
            string message = System.Text.Encoding.ASCII.GetString(buffer, 0, bytesReceived);

            this.Invoke(new Action(() =>
            {
                lbx_Missatges.Items.Add($"{message}");
            }));

            tcpClient.Close();
        }

        private void btn_desconnect_Click(object sender, EventArgs e)
        {
            if (servidor != null)
            {
                servidor.Stop();
                servidor = null;
            }

            // Cerrar la conexión
            listenThread.Abort();
            Application.Exit();
        }
    }
}

