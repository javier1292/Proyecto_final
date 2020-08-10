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
    public partial class Comentar : Form
    {
        
            
        clase obj = new clase();
        
        public Comentar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            string comentario = textBox1.Text;
            obj.InsertarC(comentario);

            MessageBox.Show("Se añadio el comentario");

            Home ss = new Home();
            ss.Show();
            this.Hide();
        }
    }
}
