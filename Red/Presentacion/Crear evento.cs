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
    public partial class Crear_evento : Form
    {

        Class1 obj = new Class1();

        public Crear_evento()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           

            DateTime dd = dateTimePicker1.Value;
            string nombreE = textBox1.Text;
            string Lugar = textBox2.Text;
            int Cantidad = Convert.ToInt32(textBox3.Text);
            DateTime fecha = System.DateTime.Now;

            int result = DateTime.Compare(dd, fecha);
            if (result > 0)
            {
                obj.InsertarE(nombreE, Lugar, Cantidad, dd);
                MessageBox.Show("Se agrego correctamente  ");

                Eventos ss = new Eventos();
                ss.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Fecha Invalida");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Eventos ss = new Eventos();
            ss.Show();
            this.Hide();
        }
    }
}
