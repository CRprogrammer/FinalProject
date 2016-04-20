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
    public partial class Administrador : Form
    {
       public static Cartelera abrir4 = new Cartelera();
        public static String Editar = "";
        public static String Cambio = "";
        public Administrador()
        {
            InitializeComponent();
        }

        private void configurarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Usuarios abrir = new Usuarios();
            abrir.MdiParent = this;
            abrir.Show();
        }

        private void configurarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Salas abrir2 = new Salas();
            abrir2.MdiParent = this;
            abrir2.Show();
        }

        private void configurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Peliculas abrir3 = new Peliculas();
            abrir3.MdiParent = this;
            abrir3.Show();
        }

        private void cambiarImagenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
            Editar = "Imagenes";
            abrir4.MdiParent = this;
            abrir4.Visible = true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InicioMenu salir = new InicioMenu();
            salir.Visible = true;
            this.Visible = false;
        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
