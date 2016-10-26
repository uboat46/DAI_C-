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
    public partial class Modifica : Form
    {
        public Modifica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MainWindow main_frm = new MainWindow();
            main_frm.Show();
        }

        private void btn_elimina_Click_1(object sender, EventArgs e)
        {
            if (tb_cu.Text != "")
            {
                int folio = int.Parse(tb_cu.Text);
                Console.WriteLine(folio);
                TextBox[] cartilla = { tb_folio, tb_nombre, tb_sexo, tb_mail, tb_semestre, tb_programa };
                Conexion con = new Conexion();
                con.buscaAlumno(folio, cartilla);
                tb_cu.Text = "";
                tb_folio_nuevo.Text = tb_folio.Text;
                tb_nombre_nuevo.Text = tb_nombre.Text;
                tb_sexo_nuevo.Text = tb_sexo.Text;
                tb_semestre_nuevo.Text = tb_semestre.Text;
            }
            else
            {
                MessageBox.Show("Porfavor Rellene todos los campos");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            MainWindow main_frm = new MainWindow();
            main_frm.Show();
        }

        private void Modifica_Load(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            con.llenarComboProgramas(cb_programa_nuevo);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
