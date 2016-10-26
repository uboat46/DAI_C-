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
    public partial class Busca : Form
    {
        public Busca()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MainWindow main_frm = new MainWindow();
            main_frm.Show();
        }

        private void btn_elimina_Click(object sender, EventArgs e)
        {
            if (tb_cu.Text != "")
            {
                int folio = int.Parse(tb_cu.Text);
                Console.WriteLine(folio);
                TextBox[] cartilla = { tb_folio, tb_nombre, tb_sexo, tb_mail, tb_semestre, tb_programa };
                Conexion con = new Conexion();
                con.buscaAlumno(folio,cartilla);
                tb_cu.Text = "";
            }
            else
            {
                MessageBox.Show("Porfavor Rellene todos los campos");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
