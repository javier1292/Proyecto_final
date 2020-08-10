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
    public partial class Gestion_de_publicacion : Form
    {
        public Gestion_de_publicacion()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();


        }

        private string ID;
        private bool Editar= false;
        clase obj = new clase();


        private void MostarMisP()
        {
            clase obj = new clase();
            dataGridView1.DataSource = obj.mostrarMP();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
               
                Editar = true;
                ID = dataGridView1.CurrentRow.Cells["IDP"].Value.ToString();
                textBox1.Text = dataGridView1.CurrentRow.Cells["titulo"].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells["contenido"].Value.ToString();
            }
            else
            {
                MessageBox.Show("seleccione una fila ");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int IDP= Int32.Parse(ID);
            obj.Editar(IDP ,textBox1.Text,textBox2.Text);

            MessageBox.Show("Se edito correctamente   ");
            limpiar();
            MostarMisP();
        }

        private void Gestion_de_publicacion_Load(object sender, EventArgs e)
        {
            MostarMisP();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                ID = dataGridView1.CurrentRow.Cells["IDP"].Value.ToString();
                obj.EliminiarP(ID);

                MessageBox.Show("se elmino correctamente");
                MostarMisP();
            }
            else
            {
                MessageBox.Show("seleccione una fila");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home ss = new Home();
            ss.Show();
            this.Hide();
        }
    }
}
