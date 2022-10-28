
namespace SistemaAsistenciaQR
{
    partial class FormScanner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cvoDevice = new System.Windows.Forms.ComboBox();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.process1 = new System.Diagnostics.Process();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnCerrarForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnDetener = new System.Windows.Forms.Button();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cvoDevice
            // 
            this.cvoDevice.FormattingEnabled = true;
            this.cvoDevice.Location = new System.Drawing.Point(149, 23);
            this.cvoDevice.Name = "cvoDevice";
            this.cvoDevice.Size = new System.Drawing.Size(375, 21);
            this.cvoDevice.TabIndex = 7;
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.videoSourcePlayer1.Location = new System.Drawing.Point(56, 50);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(548, 449);
            this.videoSourcePlayer1.TabIndex = 10;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BtnCerrarForm
            // 
            this.BtnCerrarForm.BackColor = System.Drawing.Color.Red;
            this.BtnCerrarForm.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BtnCerrarForm.FlatAppearance.BorderSize = 0;
            this.BtnCerrarForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarForm.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarForm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnCerrarForm.Location = new System.Drawing.Point(544, -5);
            this.BtnCerrarForm.Name = "BtnCerrarForm";
            this.BtnCerrarForm.Size = new System.Drawing.Size(90, 33);
            this.BtnCerrarForm.TabIndex = 11;
            this.BtnCerrarForm.Text = "Cerrar";
            this.BtnCerrarForm.UseVisualStyleBackColor = false;
            this.BtnCerrarForm.Click += new System.EventHandler(this.BtnCerrarForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Camara";
            // 
            // BtnDetener
            // 
            this.BtnDetener.BackColor = System.Drawing.SystemColors.Control;
            this.BtnDetener.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnDetener.FlatAppearance.BorderSize = 0;
            this.BtnDetener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDetener.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDetener.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDetener.Image = global::SistemaAsistenciaQR.Properties.Resources.Pararuwu;
            this.BtnDetener.Location = new System.Drawing.Point(-3, 300);
            this.BtnDetener.Name = "BtnDetener";
            this.BtnDetener.Size = new System.Drawing.Size(63, 60);
            this.BtnDetener.TabIndex = 9;
            this.BtnDetener.UseVisualStyleBackColor = false;
            this.BtnDetener.Click += new System.EventHandler(this.BtnDetener_Click);
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnIniciar.FlatAppearance.BorderSize = 0;
            this.BtnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIniciar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnIniciar.Image = global::SistemaAsistenciaQR.Properties.Resources.Reproduciiruwu;
            this.BtnIniciar.Location = new System.Drawing.Point(0, 224);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(60, 58);
            this.BtnIniciar.TabIndex = 8;
            this.BtnIniciar.UseVisualStyleBackColor = false;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // FormScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCerrarForm);
            this.Controls.Add(this.videoSourcePlayer1);
            this.Controls.Add(this.BtnDetener);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.cvoDevice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormScanner";
            this.Text = "FormScanner";
            this.Load += new System.EventHandler(this.FormScanner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnDetener;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.ComboBox cvoDevice;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnCerrarForm;
        private System.Windows.Forms.Label label1;
    }
}