using System.IO.Ports;

namespace VirtualPortTest
{
    public partial class Form1 : Form
    {

        private SerialPort port4;
        private SerialPort port5;

        public Form1()
        {
            InitializeComponent();
            InitPorts();
            btnOpenConnection.Tag = false;
        }

        // 시리얼포트 설정
        private void InitPorts()
        {
            try
            {
                port4 = new SerialPort("COM4", 9600, Parity.None, 8, StopBits.One);
                port4.Encoding = System.Text.Encoding.UTF8;
                port4.DataReceived += Port4_DataReceived;

                port5 = new SerialPort("COM5", 9600, Parity.None, 8, StopBits.One);
                port5.Encoding = System.Text.Encoding.UTF8;
                port5.DataReceived += Port5_DataReceived;
            }
            catch
            {

            }
        }

        private void btnOpenConnection_Clicked(object sender, EventArgs e)
        {
            try
            {

                if (!(bool)btnOpenConnection.Tag)
                {
                    if (!port4.IsOpen)
                    {
                        port4.Open();
                        logging(tboxCom4, "COM4 연결완료");
                    }

                    if (!port5.IsOpen)
                    {
                        port5.Open();
                        logging(tboxCom5, "COM5 연결완료");
                    }
                    lblStatus.Text = "연결 됨";
                    btnOpenConnection.Tag = true;
                    btnOpenConnection.Text = "포트해제";
                    tboxCom4.Enabled = true;
                    tboxCom5.Enabled = true;
                    tboxCom4Send.Enabled = true;
                    tboxCom5Send.Enabled = true;
                }
                else
                {
                    if (port4.IsOpen)
                    {
                        port4.Close();
                        logging(tboxCom4, "COM4 연결해제");
                    }

                    if (port5.IsOpen)
                    {
                        port5.Close();
                        logging(tboxCom5, "COM5 연결해제");
                    }
                    lblStatus.Text = "연결 안됨";
                    btnOpenConnection.Tag = false;
                    btnOpenConnection.Text = "포트연결";
                    tboxCom4.Enabled = false;
                    tboxCom5.Enabled = false;
                    tboxCom4Send.Enabled = false;
                    tboxCom5Send.Enabled = false;
                }

            }
            catch
            {

            }
        }


        //이벤트 핸들러
        private void Port4_DataReceived(Object sender, SerialDataReceivedEventArgs e)
        {
            string data = port4.ReadExisting();
            logging(tboxCom4, $"데이터 받음: {data}");
        }

        private void Port5_DataReceived(Object sender, SerialDataReceivedEventArgs e)
        {
            string data = port5.ReadExisting();
            logging(tboxCom5, $"데이터 받음: {data}");
        }



        //기타 함수
        private void logging(TextBox tbox, string content)
        {
            if (tbox.InvokeRequired)
            {
                tbox.Invoke(new Action(() => logging(tbox, content)));
                return;
            }

            if (!string.IsNullOrWhiteSpace(tbox.Text))
                tbox.Text += "\r\n";
            tbox.Text += content;

            tbox.SelectionStart = tbox.Text.Length;
            tbox.ScrollToCaret();
        }

        private void tboxSendKeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    TextBox tbox = (TextBox)sender;
                    string sendText = tbox.Text;
                    if (string.IsNullOrWhiteSpace(sendText)) return;

                    if (tbox.Name.Contains("4"))
                    {
                        if (port4.IsOpen)
                        {
                            port4.WriteLine(sendText);
                            //logging(tboxCom4, $"COM4-Send: {sendText}");
                            tbox.Clear();
                            tbox.Focus();
                        }
                    }

                    if (tbox.Name.Contains("5"))
                    {
                        if (port5.IsOpen)
                        {
                            port5.WriteLine(sendText);
                            //logging(tboxCom5, $"COM5-Send: {sendText}");
                            tbox.Clear();
                            tbox.Focus();
                        }
                    }
                }

            }
            catch
            {

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (port4?.IsOpen == true) port4.Close();
                if (port5?.IsOpen == true) port5.Close();
                port4?.Dispose();
                port5?.Dispose();
            }
            catch 
            {
            }
        }
    }
}
