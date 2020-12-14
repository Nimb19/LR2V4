using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Part3Client
{
    public partial class ClientForm : Form
    {
        Socket _socket;

        public ClientForm()
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
            LoggerWriteLine("Start Logger");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            CatchException(() =>
            {
                if (_socket.Available > 0)
                {
                    byte[] data = new byte[_socket.Available];
                    int data_size = _socket.Receive(data);
                    string text_data = Encoding.UTF8.GetString(data, 0, data_size);

                    if (text_data.StartsWith("new"))
                        LoggerWriteLine($"[INF] {text_data.Substring(3)} вошел в чат");
                    else if (text_data.StartsWith("exit"))
                        LoggerWriteLine($"[INF] {text_data.Substring(4)} покинул чат");
                    else if (text_data.StartsWith("message"))
                        LoggerWriteLine($"[MSG] {text_data.Substring(7)}");
                }
            });
        }

        private void BtDisconnect_Click(object sender, EventArgs e)
        {
            CatchException(() => 
            {
                var endPoint = _socket.RemoteEndPoint;
                SendToServer("quit");
                _socket.Shutdown(SocketShutdown.Both);
                _socket.Close();

                timer.Enabled = false;
                btConnect.Enabled = true;
                btDisconnect.Enabled = false;

                LoggerWriteLine($"[INF] Отключение от {endPoint} прошло успешно");
            });
        }

        private void BtConnect_Click(object sender, EventArgs e)
        {
            CatchException(() =>
            {
                _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _socket.Connect(tbHost.Text, int.Parse(tbPort.Text));
                SendToServer($"name{tbName.Text}");
                timer.Enabled = true;
                LoggerWriteLine($"[INF] Подключено к {tbHost.Text} : {tbPort.Text}");

                btConnect.Enabled = false;
                btDisconnect.Enabled = true;
            });
        }

        private void BtSendMessage_Click(object sender, EventArgs e)
        {
            CatchException(() =>
            {
                SendToServer($"message{tbMessage.Text}");
                LoggerWriteLine($"[MSG] {tbName.Text} : {tbMessage.Text}");
            });
        }

        private void SendToServer(string command) =>
            _socket.Send(Encoding.UTF8.GetBytes(command));

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

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e) =>
            BtDisconnect_Click(sender, e);
    }
}
