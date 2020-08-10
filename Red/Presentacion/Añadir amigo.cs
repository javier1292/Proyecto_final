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
    public partial class Añadir_amigo : Form
    {
        public Añadir_amigo()
        {
            InitializeComponent();
        }

        private void Mostrar()
        {
            Class1 obj = new Class1();
            dataGridView1.DataSource = obj.MostrarU();
        }



        clase obj = new clase();

        private string ida;
        private int IDA;
        private string NombreU;


        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                ida = dataGridView1.CurrentRow.Cells["IDU"].Value.ToString();
                IDA = Convert.ToInt32(ida);
                NombreU = dataGridView1.CurrentRow.Cells["usuario"].Value.ToString();
                obj.InsertarA(NombreU, IDA);

                MessageBox.Show("se añadio a tu lista de amigos");
                
            }
            else
            {
                MessageBox.Show("seleccione un usuario");
            }
        }

        private void Añadir_amigo_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home ss = new Home();
            ss.Show();
            this.Hide();
        }
    }
}
