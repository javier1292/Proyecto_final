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
    public partial class Ver_comentarios : Form
    {
        public Ver_comentarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home ss = new Home();
            ss.Show();
            this.Hide();
        }

        private void Ver_comentarios_Load(object sender, EventArgs e)
        {
            Mostrar();
        }
        private void Mostrar()
        {
            Class1 obj = new Class1();
            dataGridView1.DataSource = obj.MostrarC();
        }
    }
}
