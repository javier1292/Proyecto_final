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
    public partial class Eventos : Form
    {

        Class1 obja = new Class1();
        private string respuesta;

        public Eventos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Crear_evento ss = new Crear_evento();
            ss.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {

                string ide = dataGridView2.CurrentRow.Cells["IDE"].Value.ToString();
                int IDE = Convert.ToInt32(ide);

                obja.IDE(IDE);

                Invitar ss = new Invitar();
                ss.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("seleccione un evento");
            }
        }

        private void MostrarME()
        {
            Class1 obj = new Class1();
            dataGridView2.DataSource = obj.MostrarME();
        }
        private void MostrarEI()
        {
            Class1 obj = new Class1();
            dataGridView1.DataSource = obj.MostrarEI();
        }

        private void Eventos_Load(object sender, EventArgs e)
        {
            MostrarME();
            MostrarEI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            respuesta = "Asistire";
            if (dataGridView1.SelectedRows.Count > 0)
            {

                string idi = dataGridView1.CurrentRow.Cells["IDE"].Value.ToString();
                int IDI = Convert.ToInt32(idi);

                obja.EditarR(IDI, respuesta);
                MostrarEI();
                MessageBox.Show("Respuesta sastifactoria");

            }
            else
            {
                MessageBox.Show("seleccione un evento");
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            respuesta = "Puede ser que asista";
            if (dataGridView1.SelectedRows.Count > 0)
            {

                string idi = dataGridView1.CurrentRow.Cells["IDE"].Value.ToString();
                int IDI = Convert.ToInt32(idi);

                obja.EditarR(IDI, respuesta);
                MostrarEI();
                MessageBox.Show("Respuesta sastifactoria");

            }
            else
            {
                MessageBox.Show("seleccione un evento");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            respuesta = "No asistire";
            if (dataGridView1.SelectedRows.Count > 0)
            {

                string idi = dataGridView1.CurrentRow.Cells["IDE"].Value.ToString();
                int IDI = Convert.ToInt32(idi);

                obja.EditarR(IDI, respuesta);
                MostrarEI();
                MessageBox.Show("Respuesta sastifactoria");

            }
            else
            {
                MessageBox.Show("seleccione un evento");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {

                string ide = dataGridView2.CurrentRow.Cells["IDE"].Value.ToString();
                int IDE = Convert.ToInt32(ide);

                obja.IDE(IDE);

                Ver_invitados ss = new Ver_invitados();
                ss.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("seleccione un evento");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {

                string idE = dataGridView2.CurrentRow.Cells["IDE"].Value.ToString();
                int IDE = Convert.ToInt32(idE);


                obja.EliminarE(IDE);

                MessageBox.Show("se elimino el evento");
                MostrarME();
                MostrarEI();
            }
            else
            {
                MessageBox.Show("seleccione un evento");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
           Menu ss = new Menu();
            ss.Show();
            this.Hide();
        }
    }
}
