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
    public partial class Añadir_publicacion : Form
    {


        Class1 obj = new Class1();

        public Añadir_publicacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fecha = System.DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            string titulo = textBox1.Text;
            string contenido = textBox2.Text;
            obj.InsertarP(titulo, contenido, fecha);
            MessageBox.Show("Se agrego correctamente  ");

            Home ss = new Home();
            ss.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home ss = new Home();
            ss.Show();
            this.Hide();
        }
    }
}
