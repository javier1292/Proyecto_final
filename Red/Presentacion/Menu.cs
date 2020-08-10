using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home ss = new Home();
            ss.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gestionar_amigos ss = new Gestionar_amigos();
            ss.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inicio ss = new Inicio();
            ss.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Eventos ss = new Eventos();
            ss.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
