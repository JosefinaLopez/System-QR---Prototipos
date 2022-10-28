using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using BarcodeLib.BarcodeReader;

namespace SistemaAsistenciaQR
{
    public partial class FormScanner : Form
    {
        public FormScanner()
        {
            InitializeComponent();
        }
        private FilterInfoCollection Dispositivos;
        private VideoCaptureDevice FuenteDeVideo;

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
          
            timer1.Enabled = true;
            FuenteDeVideo = new VideoCaptureDevice(Dispositivos[cvoDevice.SelectedIndex].MonikerString);
            videoSourcePlayer1.VideoSource = FuenteDeVideo;
            videoSourcePlayer1.Start();
        }

        private void FormScanner_Load(object sender, EventArgs e)
        {
           
            Dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo x in Dispositivos)
            {
                cvoDevice.Items.Add(x.Name);
            }
            cvoDevice.SelectedIndex = 0;
        }

        private void BtnDetener_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            videoSourcePlayer1.SignalToStop();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (videoSourcePlayer1.GetCurrentVideoFrame() != null)
            {
               
                Bitmap img = new Bitmap(videoSourcePlayer1.GetCurrentVideoFrame());
               
                string[] resultados = BarcodeReader.read(img, BarcodeReader.QRCODE);

            
                img.Dispose();
              
                if (resultados != null && resultados.Count() > 0)
                {
                    MessageBox.Show(resultados[0]);
                }
            }
        }

        private void BtnCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
