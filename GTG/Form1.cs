using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.UseVisualStyleBackColor = false;
            button5.BackColor = Color.Green;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.UseVisualStyleBackColor = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            lblhora.Text = DateTime.Now.ToShortTimeString();
            lblfecha.Text = DateTime.Now.ToShortDateString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void facturacion_Click(object sender, EventArgs e)
        {
            
        }

        private void btnalumno_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            Alumnos A = new Alumnos();
            A.Show();
        }
    }
}
