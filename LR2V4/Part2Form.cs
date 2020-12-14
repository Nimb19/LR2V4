using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace LR2V4
{
    public partial class Part2Form : Form
    {
        Socket _socket;

        public Part2Form()
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
            tbMessage.ScrollBars = ScrollBars.Both; tbLogger.ScrollBars = ScrollBars.Both;
            LoggerWriteLine("Start Logger");
        }

        private void BtOpenPort_Click(object sender, EventArgs e)
        {
            CatchException(() =>
            {
                var localPort = Convert.ToInt32(tbLocalPort.Text.Trim());
                _socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                _socket.Bind(new IPEndPoint(IPAddress.Any, localPort));

                timer.Enabled = true;
                LoggerWriteLine($"[INF] Открыт UDP порт: {localPort}");
            });
        }

        private void BtSend_Click(object sender, EventArgs e)
        {
            CatchException(() =>
            {
                var ipAdresses = Dns.GetHostAddresses(tbHost.Text.Trim());
                if (ipAdresses.Length > 0)
                {
                    var port = int.Parse(tbPort.Text.Trim());
                    var reciever = new IPEndPoint(IPAddress.Any, port);
                    var data = Encoding.UTF8.GetBytes(tbMessage.Text.Trim());
                    _socket.SendTo(data, reciever);
                    LoggerWriteLine($"[MSG] Отправлено {tbHost.Text.Trim()}:{tbPort.Text.Trim()}: {tbMessage.Text.Trim()}");
                }
            });
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (_socket.Available > 0)
            {
                CatchException(() =>
                {
                    EndPoint dataSenderEP = new IPEndPoint(IPAddress.Any, 0);
                    var data = new byte[1000];
                    var bytesReadCount = _socket.ReceiveFrom(data, ref dataSenderEP);
                    if (bytesReadCount > 0)
                    {
                        var recievedText = Encoding.UTF8.GetString(data, 0, bytesReadCount);
                        LoggerWriteLine($"[MSG] Получено от {dataSenderEP}: {recievedText}");
                    }
                });
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

        #region Обработка событий LabelBack
        private void LabelBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void LabelBack_MouseEnter(object sender, EventArgs e)
        {
            labelBack.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Underline);
        }

        private void LabelBack_MouseLeave(object sender, EventArgs e)
        {
            labelBack.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular);
        }
        #endregion
    }
}
