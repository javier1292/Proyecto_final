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
    public partial class Registro : Form
    {
        string foto;

        public Registro()
        {
            InitializeComponent();
        }
        private Class1 objetoc = new Class1();

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            DialogResult rs = op.ShowDialog();
            if (rs == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(op.FileName);
                foto = op.FileName;
            }
    }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom = textBox1.Text;
            string ape = textBox2.Text;
            string core = textBox3.Text;
            string user = textBox4.Text;
            string pass = textBox5.Text;
            string passc = textBox6.Text;

            if (nom != "" || ape != "" || core != "" || user != "" || pass != "" || passc != "")
            {
                if (pass.Equals(passc))
                {
                    try
                    {

                        objetoc.Insertar(textBox1.Text, textBox2.Text, foto, textBox3.Text, textBox4.Text, textBox5.Text, textBox5.Text);
                        MessageBox.Show("Registro completado ");


                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo registrar " + ex);
                    }

                    Inicio ss = new Inicio();
                    ss.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
            }
            else
            {
                MessageBox.Show("Aun faltan campos por llenar");
            }
        }
    }
    }
