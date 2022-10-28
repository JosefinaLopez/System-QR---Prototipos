using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QRCoder.PayloadGenerator;

namespace SistemaAsistenciaQR
{
    public partial class FormGeneradorQR : Form
    {
        public FormGeneradorQR()
        {
            InitializeComponent();
        }
        public class INNOVPayload : Payload
        {
            private String _Nom;
            private String _Inst;
            private String _Sexo;
            private String _Code;

            public INNOVPayload(String Nom, String Inst, String Sexo, String Code)
            {
                _Nom = Nom;
                _Inst = Inst;
                _Sexo = Sexo;
                _Code = Code;
            }

            public override string ToString()
            {
                return $"{_Code}" +","+ $"{_Nom}" +","+ $"{_Sexo}" +","+ $"{_Inst}";
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Timer timer = new Timer();

            INNOVPayload generador = new INNOVPayload(Texto.Text, TextInst.Text, TextSexo.Text, textCodigo.Text);
            String payload = generador.ToString();

            QRCodeGenerator GenQr = new QRCodeGenerator();
            QRCodeData QrDatos = GenQr.CreateQrCode(payload, QRCodeGenerator.ECCLevel.H);
            QRCode qrcod = new QRCode(QrDatos);

            Bitmap qrImagen = qrcod.GetGraphic(5, Color.Black, Color.White,true);
            pictureBox1.Image = qrImagen;
            BtnGuardar.Enabled = true;
        }

        private void BtnLimpiar_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Limpiando Datos");
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
        }

        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Escoja la Ruta para Guardar Imagen PNG ");
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.CreatePrompt = true;
            guardar.OverwritePrompt = true;
            guardar.FileName = Texto.Text;
            guardar.Filter = "Archivos PNG (.png) | *.png ";
            if (guardar.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(guardar.FileName);
                guardar.InitialDirectory = Environment.GetFolderPath
                    (Environment.SpecialFolder.Desktop);

            }
        }

        private void BtnCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
