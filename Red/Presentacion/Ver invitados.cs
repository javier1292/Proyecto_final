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
    public partial class Ver_invitados : Form
    {
        public Ver_invitados()
        {
            InitializeComponent();
        }

        Class1 obja = new Class1();


        public void mostrar()
        {
            Class1 obj = new Class1();
            dataGridView1.DataSource=
            obj.MostrarIR();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Eventos ss = new Eventos();
            ss.Show();
            this.Hide();
        }

        private void Ver_invitados_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {

                string idI = dataGridView1.CurrentRow.Cells["IDI"].Value.ToString();
                int IDI = Convert.ToInt32(idI);
                

                obja.EliminarI(IDI);

                MessageBox.Show("se elimino de la lista de invitados");
                mostrar();
            }
            else
            {
                MessageBox.Show("seleccione un invitado");
            }
        }
    }
}
