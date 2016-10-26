using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroAlumno
{
    public partial class Elimina : Form
    {
        public Elimina()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_elimina_Click(object sender, EventArgs e)
        {
            if (tb_cu.Text != "")
            {
                Alumno a = new Alumno(int.Parse(tb_cu.Text), "nombre", "sexo", "mail", 1, 1);
                Conexion con = new Conexion();
                int res = con.eliminaAlumno(a);
                tb_cu.Text = "";
                if (res > 0)
                {
                    MessageBox.Show("Alumno Dado de Baja");

                }
                else
                {
                    MessageBox.Show("Alumno NO Dado de Baja");
                }
            }
            else
            {
                MessageBox.Show("Porfavor Rellene todos los campos");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MainWindow main_frm = new MainWindow();
            main_frm.Show();
        }
    }
}
