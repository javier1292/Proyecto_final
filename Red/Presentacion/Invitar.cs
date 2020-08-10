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
    public partial class Invitar : Form
    {
        Class1 obja = new Class1();
        public Invitar()
        {
            InitializeComponent();
        }

        private void Mostrar()
        {
            Class1 obj = new Class1();
            dataGridView1.DataSource = obj.MostrarAE();
        }

        private void Invitar_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                string idua = dataGridView1.CurrentRow.Cells["IDUA"].Value.ToString();
                int IDUA = Convert.ToInt32(idua);
                string Nombre = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
                string Apellido = dataGridView1.CurrentRow.Cells["apellido"].Value.ToString();
                string NombreU = dataGridView1.CurrentRow.Cells["usuario"].Value.ToString();

                obja.InsertarAE(IDUA, Nombre, Apellido, NombreU);

                MessageBox.Show("se añadio a tu lista de amigos");

            }
            else
            {
                MessageBox.Show("seleccione una encuesta");
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
