using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine
{
    public partial class Cartelera : Form
    {
        static asientos Salas1 = new asientos();
        static asientos Salas2 = new asientos();
        static asientos Salas3 = new asientos();
        static asientos Salas4 = new asientos();
        static asientos Salas5 = new asientos();

        public Cartelera()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Sala1_Click(object sender, EventArgs e)
        {
            Salas1.Visible = true;
            this.Visible = false;
        }

        private void Sala2_Click(object sender, EventArgs e)
        {
            Salas2.Visible = true;
            this.Visible = false;
        }

        private void Sala3_Click(object sender, EventArgs e)
        {
            Salas3.Visible = true;
            this.Visible = false;
        }

        private void Sala4_Click(object sender, EventArgs e)
        {
            Salas4.Visible = true;
            this.Visible = false;
        }

        private void Sala5_Click(object sender, EventArgs e)
        {
            Salas5.Visible = true;
            this.Visible = false;
        }
    }
}
