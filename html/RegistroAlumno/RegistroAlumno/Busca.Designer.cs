namespace RegistroAlumno
{
    partial class Busca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btn_elimina = new System.Windows.Forms.Button();
            this.tb_cu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_folio = new System.Windows.Forms.TextBox();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.tb_sexo = new System.Windows.Forms.TextBox();
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.tb_semestre = new System.Windows.Forms.TextBox();
            this.tb_programa = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "<-----";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_elimina
            // 
            this.btn_elimina.Location = new System.Drawing.Point(50, 221);
            this.btn_elimina.Name = "btn_elimina";
            this.btn_elimina.Size = new System.Drawing.Size(339, 122);
            this.btn_elimina.TabIndex = 10;
            this.btn_elimina.Text = "BUSCA";
            this.btn_elimina.UseVisualStyleBackColor = true;
            this.btn_elimina.Click += new System.EventHandler(this.btn_elimina_Click);
            // 
            // tb_cu
            // 
            this.tb_cu.Location = new System.Drawing.Point(184, 151);
            this.tb_cu.Name = "tb_cu";
            this.tb_cu.Size = new System.Drawing.Size(100, 20);
            this.tb_cu.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "CLAVE UNICA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(606, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Alumno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Folio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(498, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(498, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Sexo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(498, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Correo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(498, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Semestre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(498, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Programa";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // tb_folio
            // 
            this.tb_folio.Location = new System.Drawing.Point(572, 140);
            this.tb_folio.Name = "tb_folio";
            this.tb_folio.ReadOnly = true;
            this.tb_folio.Size = new System.Drawing.Size(187, 20);
            this.tb_folio.TabIndex = 19;
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(572, 172);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.ReadOnly = true;
            this.tb_nombre.Size = new System.Drawing.Size(187, 20);
            this.tb_nombre.TabIndex = 20;
            // 
            // tb_sexo
            // 
            this.tb_sexo.Location = new System.Drawing.Point(572, 198);
            this.tb_sexo.Name = "tb_sexo";
            this.tb_sexo.ReadOnly = true;
            this.tb_sexo.Size = new System.Drawing.Size(187, 20);
            this.tb_sexo.TabIndex = 21;
            // 
            // tb_mail
            // 
            this.tb_mail.Location = new System.Drawing.Point(572, 220);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.ReadOnly = true;
            this.tb_mail.Size = new System.Drawing.Size(187, 20);
            this.tb_mail.TabIndex = 22;
            this.tb_mail.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // tb_semestre
            // 
            this.tb_semestre.Location = new System.Drawing.Point(572, 246);
            this.tb_semestre.Name = "tb_semestre";
            this.tb_semestre.ReadOnly = true;
            this.tb_semestre.Size = new System.Drawing.Size(187, 20);
            this.tb_semestre.TabIndex = 23;
            // 
            // tb_programa
            // 
            this.tb_programa.Location = new System.Drawing.Point(572, 270);
            this.tb_programa.Name = "tb_programa";
            this.tb_programa.ReadOnly = true;
            this.tb_programa.Size = new System.Drawing.Size(187, 20);
            this.tb_programa.TabIndex = 24;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(862, 486);
            this.shapeContainer1.TabIndex = 25;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 433;
            this.lineShape1.X2 = 433;
            this.lineShape1.Y1 = -4;
            this.lineShape1.Y2 = 487;
            // 
            // Busca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 486);
            this.Controls.Add(this.tb_programa);
            this.Controls.Add(this.tb_semestre);
            this.Controls.Add(this.tb_mail);
            this.Controls.Add(this.tb_sexo);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.tb_folio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_elimina);
            this.Controls.Add(this.tb_cu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Busca";
            this.Text = "Busca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_elimina;
        private System.Windows.Forms.TextBox tb_cu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_folio;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.TextBox tb_sexo;
        private System.Windows.Forms.TextBox tb_mail;
        private System.Windows.Forms.TextBox tb_semestre;
        private System.Windows.Forms.TextBox tb_programa;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}