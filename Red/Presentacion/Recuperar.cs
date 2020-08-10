using BD;
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
    public partial class Recuperar : Form
    {
        Class1 onj = new Class1();

        public Recuperar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            onj.recuperar(textBox1.Text);
            if (onj.Recuperar == false)
            {
                MessageBox.Show("Nombre de usuario invalido");


            }
            else {
                MessageBox.Show("Contraseña actualizada y enviada a su email");
                Inicio ss = new Inicio();
                ss.Show();
                this.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inicio ss = new Inicio();
            ss.Show();
            this.Hide();
        }
    }
}
