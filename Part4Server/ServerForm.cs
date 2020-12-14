using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Part4Server
{
    public partial class ServerForm : Form
    {
        TcpListener _listener;
        List<ClientInfo> _clients;
        readonly List<ClientInfo> _dismissalSheet = new List<ClientInfo>();

        public ServerForm()
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
            LoggerWriteLine("Start Logger");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            CatchException(() =>
            {
                CheckListener();
                foreach (var client in _clients)
                {
                    if (client.Socket.Available > 0)
                    {
                        byte[] data = new byte[client.Socket.Available];
                        int data_size = client.Socket.Receive(data);
                        string text_data = Cryptography.Decrypt(Encoding.UTF8.GetString(data, 0, data_size));

                        DoClient(client, text_data);
                    }
                }

                // Удаление из списка вышедших клиентов
                foreach (var client in _dismissalSheet)
                    _clients.Remove(client);
                _dismissalSheet.Clear();
            });
        }

        private void DoClient(ClientInfo client, string textData)
        {
            if (textData.StartsWith("name"))
            {
                client.Name = textData.Substring(4);
                listBoxUsers.Items.Add(client);

                SendToClients($"new{client.Name}", client);
                LoggerWriteLine($"[INF] Пользователь {client.Socket.RemoteEndPoint} выбрал имя {client.Name}");
            }
            else if (textData == "quit")
            {
                SendToClients($"exit{client.Name}", client);
                LoggerWriteLine($"[INF] Пользователь {client.Socket.RemoteEndPoint} покинул комнату");

                client.Socket.Shutdown(SocketShutdown.Both);
                client.Socket.Close();

                listBoxUsers.Items.Remove(client);
                _dismissalSheet.Add(client);
            }
            else if (textData.StartsWith("message"))
            {
                string message = textData.Substring(7);
                SendToClients($"message{client.Name} : {message}", client);
                LoggerWriteLine($"[MSG] {client.Name} : {message}");
            }
        }

        private void BtOpenPort_Click(object sender, EventArgs e)
        {
            CatchException(() =>
            {
                var localPort = int.Parse(tbLocalPort.Text.Trim());
                var localPoint = new IPEndPoint(IPAddress.Any, localPort);
                _listener = new TcpListener(localPoint); _listener.Start();
                _clients = new List<ClientInfo>();

                timer.Enabled = true;
                LoggerWriteLine($"[INF] Открыт TCP порт: {localPort}");
            });
        }

        private void SendToClients(string command, ClientInfo exceptOf)
        {
            foreach (var client in _clients)
            {
                if (client != exceptOf)
                    CatchException(() =>
                    {
                        byte[] data = Encoding.UTF8.GetBytes(Cryptography.Encrypt(command));
                        client.Socket.Send(data);
                    });
            }
        }

        private void CheckListener()
        {
            if (_listener.Pending())
            {
                ClientInfo newClient = new ClientInfo { Socket = _listener.AcceptSocket() };
                _clients.Add(newClient);

                LoggerWriteLine($"[INF] Пользователь {newClient.Socket.RemoteEndPoint} подключился");
            }
        }

        private void CatchException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception ex)
            {
                LoggerWriteLine($"[ERR] {ex.Message}\r\nStackTrace:\r\n{ex.StackTrace}");
            }
        }

        public void LoggerWriteLine(string text)
        {
            var time = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
            tbLogger.AppendText($"{time}: {text.Trim().Trim('.')};\r\n");
        }
    }

    public class ClientInfo
    {
        public Socket Socket { get; set; }
        public string Name { get; set; }

        public override string ToString() =>
            $"{Name} ({Socket.RemoteEndPoint})";
    }
}
