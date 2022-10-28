
namespace SistemaAsistenciaQR
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelEvento = new System.Windows.Forms.Panel();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEvento = new System.Windows.Forms.Button();
            this.panelQR = new System.Windows.Forms.Panel();
            this.BtnEscaner = new System.Windows.Forms.Button();
            this.BtnGenerador = new System.Windows.Forms.Button();
            this.BtnQR = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelDateTime = new System.Windows.Forms.Panel();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelEvento.SuspendLayout();
            this.panelQR.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelChildForm.SuspendLayout();
            this.panelDateTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.panelEvento);
            this.panelMenu.Controls.Add(this.BtnEvento);
            this.panelMenu.Controls.Add(this.panelQR);
            this.panelMenu.Controls.Add(this.BtnQR);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 511);
            this.panelMenu.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::SistemaAsistenciaQR.Properties.Resources.REPORTE;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 414);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(200, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Reportes";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelEvento
            // 
            this.panelEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(92)))), ((int)(((byte)(176)))));
            this.panelEvento.Controls.Add(this.BtnMostrar);
            this.panelEvento.Controls.Add(this.BtnAgregar);
            this.panelEvento.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEvento.Location = new System.Drawing.Point(0, 325);
            this.panelEvento.Name = "panelEvento";
            this.panelEvento.Size = new System.Drawing.Size(200, 89);
            this.panelEvento.TabIndex = 4;
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.BackColor = System.Drawing.Color.Goldenrod;
            this.BtnMostrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMostrar.FlatAppearance.BorderSize = 0;
            this.BtnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMostrar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnMostrar.Image = global::SistemaAsistenciaQR.Properties.Resources.MostrarEvento;
            this.BtnMostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMostrar.Location = new System.Drawing.Point(0, 40);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnMostrar.Size = new System.Drawing.Size(200, 49);
            this.BtnMostrar.TabIndex = 1;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMostrar.UseVisualStyleBackColor = false;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Goldenrod;
            this.BtnAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAgregar.Image = global::SistemaAsistenciaQR.Properties.Resources.AgregaEvento;
            this.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregar.Location = new System.Drawing.Point(0, 0);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnAgregar.Size = new System.Drawing.Size(200, 40);
            this.BtnAgregar.TabIndex = 0;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEvento
            // 
            this.BtnEvento.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnEvento.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEvento.FlatAppearance.BorderSize = 0;
            this.BtnEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEvento.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEvento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEvento.Image = global::SistemaAsistenciaQR.Properties.Resources.eventooo;
            this.BtnEvento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEvento.Location = new System.Drawing.Point(0, 285);
            this.BtnEvento.Name = "BtnEvento";
            this.BtnEvento.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnEvento.Size = new System.Drawing.Size(200, 40);
            this.BtnEvento.TabIndex = 3;
            this.BtnEvento.Text = "Evento";
            this.BtnEvento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEvento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEvento.UseVisualStyleBackColor = false;
            this.BtnEvento.Click += new System.EventHandler(this.BtnEvento_Click);
            // 
            // panelQR
            // 
            this.panelQR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(92)))), ((int)(((byte)(176)))));
            this.panelQR.Controls.Add(this.BtnEscaner);
            this.panelQR.Controls.Add(this.BtnGenerador);
            this.panelQR.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQR.Location = new System.Drawing.Point(0, 196);
            this.panelQR.Name = "panelQR";
            this.panelQR.Size = new System.Drawing.Size(200, 89);
            this.panelQR.TabIndex = 2;
            // 
            // BtnEscaner
            // 
            this.BtnEscaner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnEscaner.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEscaner.FlatAppearance.BorderSize = 0;
            this.BtnEscaner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEscaner.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEscaner.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnEscaner.Image = global::SistemaAsistenciaQR.Properties.Resources.scanner;
            this.BtnEscaner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEscaner.Location = new System.Drawing.Point(0, 40);
            this.BtnEscaner.Name = "BtnEscaner";
            this.BtnEscaner.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnEscaner.Size = new System.Drawing.Size(200, 49);
            this.BtnEscaner.TabIndex = 1;
            this.BtnEscaner.Text = "Scanner";
            this.BtnEscaner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEscaner.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEscaner.UseVisualStyleBackColor = false;
            this.BtnEscaner.Click += new System.EventHandler(this.BtnEscaner_Click_1);
            // 
            // BtnGenerador
            // 
            this.BtnGenerador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnGenerador.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnGenerador.FlatAppearance.BorderSize = 0;
            this.BtnGenerador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenerador.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerador.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnGenerador.Image = global::SistemaAsistenciaQR.Properties.Resources.GeneradorQRIcon;
            this.BtnGenerador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGenerador.Location = new System.Drawing.Point(0, 0);
            this.BtnGenerador.Name = "BtnGenerador";
            this.BtnGenerador.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnGenerador.Size = new System.Drawing.Size(200, 40);
            this.BtnGenerador.TabIndex = 0;
            this.BtnGenerador.Text = "Generador";
            this.BtnGenerador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGenerador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGenerador.UseVisualStyleBackColor = false;
            this.BtnGenerador.Click += new System.EventHandler(this.BtnGenerador_Click_1);
            // 
            // BtnQR
            // 
            this.BtnQR.BackColor = System.Drawing.Color.Brown;
            this.BtnQR.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnQR.FlatAppearance.BorderSize = 0;
            this.BtnQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQR.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnQR.Image = global::SistemaAsistenciaQR.Properties.Resources.QR;
            this.BtnQR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnQR.Location = new System.Drawing.Point(0, 156);
            this.BtnQR.Name = "BtnQR";
            this.BtnQR.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnQR.Size = new System.Drawing.Size(200, 40);
            this.BtnQR.TabIndex = 1;
            this.BtnQR.Text = "QR";
            this.BtnQR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnQR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnQR.UseVisualStyleBackColor = false;
            this.BtnQR.Click += new System.EventHandler(this.BtnQR_Click_1);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 156);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-4, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(204, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.AutoScroll = true;
            this.panelChildForm.BackColor = System.Drawing.Color.White;
            this.panelChildForm.Controls.Add(this.panelDateTime);
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Location = new System.Drawing.Point(195, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(627, 511);
            this.panelChildForm.TabIndex = 1;
            // 
            // panelDateTime
            // 
            this.panelDateTime.Controls.Add(this.lbFecha);
            this.panelDateTime.Controls.Add(this.lbHora);
            this.panelDateTime.Location = new System.Drawing.Point(196, 56);
            this.panelDateTime.Name = "panelDateTime";
            this.panelDateTime.Size = new System.Drawing.Size(273, 100);
            this.panelDateTime.TabIndex = 2;
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbFecha.Location = new System.Drawing.Point(37, 49);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(46, 16);
            this.lbFecha.TabIndex = 1;
            this.lbFecha.Text = "label2";
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbHora.Location = new System.Drawing.Point(78, 25);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(49, 19);
            this.lbHora.TabIndex = 0;
            this.lbHora.Text = "label";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(215, 198);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(822, 511);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelChildForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(838, 550);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Asistencia QR";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.MenuHighlight;
            this.panelMenu.ResumeLayout(false);
            this.panelEvento.ResumeLayout(false);
            this.panelQR.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.panelDateTime.ResumeLayout(false);
            this.panelDateTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelEvento;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEvento;
        private System.Windows.Forms.Panel panelQR;
        private System.Windows.Forms.Button BtnEscaner;
        private System.Windows.Forms.Button BtnGenerador;
        private System.Windows.Forms.Button BtnQR;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelDateTime;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Timer timer1;
    }
}

