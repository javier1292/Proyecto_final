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
    public partial class Gestionar_amigos : Form
    {

        clase obj = new clase();

        private string IDA;



        public Gestionar_amigos()
        {
            InitializeComponent();
        }


        private void Mostrar()
        {
            Class1 obj = new Class1();
            dataGridView1.DataSource = obj.MostrarA();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                IDA = dataGridView1.CurrentRow.Cells["IDA"].Value.ToString();
                obj.EliminiarA(IDA);

                MessageBox.Show("se elmino de su lista de amigos");
                Mostrar();
            }
            else
            {
                MessageBox.Show("seleccione un amigo");
            }
        }

        private void Gestionar_amigos_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu ss = new Menu();
            ss.Show();
            this.Hide();
        }
    }
}
