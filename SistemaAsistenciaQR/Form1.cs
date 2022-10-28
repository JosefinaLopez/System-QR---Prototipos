using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAsistenciaQR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PersonalizarDesigh();
        }
        private void PersonalizarDesigh()
        {
            panelQR.Visible = false;
            panelEvento.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelQR.Visible == true)
                panelQR.Visible = false;
            if (panelEvento.Visible == true)
                panelEvento.Visible = false;
        }
        private void showSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                hideSubMenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }
        private Form ActiveForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (ActiveForm != null)
                ActiveForm.Close();
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void BtnQR_Click_1(object sender, EventArgs e)
        {
            
            showSubMenu(panelQR);
        }

        private void BtnEvento_Click(object sender, EventArgs e)
        {
            showSubMenu(panelEvento);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnGenerador_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormGeneradorQR());
            hideSubMenu();
        }

        private void BtnEscaner_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormScanner());
            hideSubMenu();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToLongTimeString();
            lbFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
