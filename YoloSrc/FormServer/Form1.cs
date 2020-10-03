using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Alturos.Yolo;
using Alturos.Yolo.Model;
using Yolo;

namespace FormServer
{
    public partial class Form1 : Form
    {
        Image image;
        //byte[] imagebyte;


        public Form1()
        {
            InitializeComponent();
        }

        private void TcpServerRun()
        {
            TcpListener TL = new TcpListener(IPAddress.Any, 8763);  // 設定以8763埠號聽取TCP連線
            TL.Start();  // 開起聽取TCP連線
            UIUpdate("Listening");  // 在UI介面顯示Listening
            while (true)
            {
                TcpClient TC = TL.AcceptTcpClient();  // 取得聽取到的TCP Client
                UIUpdate("Connected");  // 在UI介面顯示Connected
                NetworkStream stream = TC.GetStream();  // 取得TCP Client的網路資料流
                if (stream.CanRead)  // 若是網路資料流可讀則做以下事項
                {
                    Thread TcpHandlerThread = new Thread(new ParameterizedThreadStart(TcpHandler));  // 設定線程處理TCP傳輸的資料
                    TcpHandlerThread.Start(TC);  // 啟用線程
                }
            }
        }



        private void TcpHandler(object TC)
        {
            TcpClient mTC = (TcpClient)TC;
            NetworkStream stream = mTC.GetStream();
            byte[] imagebyte = new byte[1000000];
            byte[] fullbytes = new byte[3000000];
            int length = 0;
            int offset = 0;

            do
            {
                length = stream.Read(imagebyte, 0, imagebyte.Length);  // 將網路資料流的資料儲存至imagebyte裡，並使用length儲存其長度
                System.Buffer.BlockCopy(imagebyte, 0, fullbytes, offset, length);  // 將imagebyte複製到fullbytes裡
                offset += length;  // 更新fullbytes目前的長度
                UIUpdate("length = " + length.ToString());  // UI顯示讀取到的長度
                Thread.Sleep(500);  // 稍微等待Client端傳送資料
            }
            while (stream.DataAvailable);  // 如果有資料可以讀取則繼續上述事項

            UIUpdate("Receive image");
            image = ByteArrayToImage(fullbytes);
            UIUpdate("Offset :" + offset);
            UIUpdate("Saving image.....");
            image.Save("image.jpg");
            UIUpdate("Done!!!!");
            string response = "image" + ',' + image.Width.ToString() + ',' + image.Height.ToString() + ';';
            response += Detection(fullbytes);
            UIUpdate("fullbytes" + response);

            byte[] message = Encoding.Unicode.GetBytes(response);  // 將結果字串轉成bytes，以方便傳輸
            stream.Write(message, 0, message.Length);  // 將結果傳送回Client端
            UIUpdate("Success Send");  // UI顯示成功傳送

            stream.Close();
            mTC.Close();
        }

        private string Detection(byte[] imagebyte)
        {
            UIUpdate("In detect"); 
            var configurationDetector = new ConfigurationDetector();
            var config = configurationDetector.Detect();

            YoloWrapper yoloWrapper = new YoloWrapper(config);  // 使用YoloWrapper物件(Alturos裡的主要辨識程式)
            IEnumerable<YoloItem> items = yoloWrapper.Detect(imagebyte);  // 呼叫偵測函式，結果儲存於items裡
            string message = string.Empty; 
            foreach (YoloItem item in items)
            {
                //if (item.Type == "TroopsHeadquarters")
                //{
                //    message += "1,";
                //}
                //else message += item.Type + ',';

                message += (item.Type == "TroopsHeadquarters" ? "1" : item.Type) + ',' +
                            item.X + ',' + 
                            item.Y + ',' + 
                            item.Width +',' + 
                            item.Height + ',' + 
                            item.Confidence + ';';  // 將目標的種類、座標及信賴值存成字串，以方便傳輸
                
            }
            
            return message;
        }

        private void UIUpdate(string s)
        {
            
            Func<int> del = delegate ()
            {
                textBox1.AppendText(s + System.Environment.NewLine);
                return 0;
            };
            Invoke(del);
        }


        private Image ByteArrayToImage(byte[] byteArray)
        {
            //MemoryStream ms = new MemoryStream(byteArray);
            //Image image = Image.FromStream(ms);
            //return image;
            Image returnImage = null;
            try
            {
                MemoryStream ms = new MemoryStream(byteArray, 0, byteArray.Length);
                ms.Write(byteArray, 0, byteArray.Length);
                returnImage = Image.FromStream(ms, true);//Exception occurs here
            }
            catch { }
            return returnImage;




            //if (byteArray == null || byteArray.Length == 0) { return null; }
            //byte[] data = null;
            //Image oImage = null;
            //Bitmap oBitmap = null;
            ////建立副本
            //data = (byte[])byteArray.Clone();
            //try
            //{
            //    MemoryStream oMemoryStream = new MemoryStream(byteArray);
            //    //設定資料流位置
            //    oMemoryStream.Position = 0;
            //    oImage = System.Drawing.Image.FromStream(oMemoryStream);
            //    //建立副本
            //    oBitmap = new Bitmap(oImage);
            //}
            //catch
            //{
            //    throw;
            //}
            ////return oImage;
            //return oBitmap;


        }

        /*private Image ByteArrayToBitmap(byte[] byteArray)
        {
            MemoryStream ms = new MemoryStream(byteArray);
            Bitmap Bmage = new Bitmap(ms); 
            return Bmage;
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            Thread TcpServerRunThread = new Thread(new ThreadStart(TcpServerRun));
            TcpServerRunThread.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
