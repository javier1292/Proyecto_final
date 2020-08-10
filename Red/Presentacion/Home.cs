using BD;
using Metodo;
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
    public partial class Home : Form
    {
        private Class1 objetoc = new Class1();
        clase obja = new clase();

        public Home()
        {
            InitializeComponent();
        }


        private void Mostrar()
        {
            Class1 obj = new Class1();
            dataGridView1.DataSource = obj.MostrarP();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Añadir_publicacion ss = new Añadir_publicacion();
            ss.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {

            Mostrar();
            if (objetoc.foto != "") { 
            pictureBox1.Image = Image.FromFile(objetoc.foto);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Añadir_amigo ss = new Añadir_amigo();
            ss.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string IDP = dataGridView1.CurrentRow.Cells["IDP"].Value.ToString();
                obja.IDP(IDP);
                Comentar ss = new Comentar();
                ss.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("seleccione una fila ");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu ss = new Menu();
            ss.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string IDP = dataGridView1.CurrentRow.Cells["IDP"].Value.ToString();
                obja.IDP(IDP);
                
                Ver_comentarios ss = new Ver_comentarios();
                ss.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("seleccione una fila ");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Gestion_de_publicacion ss = new Gestion_de_publicacion();
            ss.Show();
            this.Hide();
        }
    }
}
