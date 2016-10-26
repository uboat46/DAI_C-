namespace RegistroAlumno
{
    partial class Elimina
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_cu = new System.Windows.Forms.TextBox();
            this.btn_elimina = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLAVE UNICA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_cu
            // 
            this.tb_cu.Location = new System.Drawing.Point(327, 151);
            this.tb_cu.Name = "tb_cu";
            this.tb_cu.Size = new System.Drawing.Size(100, 20);
            this.tb_cu.TabIndex = 1;
            this.tb_cu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_elimina
            // 
            this.btn_elimina.Location = new System.Drawing.Point(204, 218);
            this.btn_elimina.Name = "btn_elimina";
            this.btn_elimina.Size = new System.Drawing.Size(339, 122);
            this.btn_elimina.TabIndex = 2;
            this.btn_elimina.Text = "ELIMINA";
            this.btn_elimina.UseVisualStyleBackColor = true;
            this.btn_elimina.Click += new System.EventHandler(this.btn_elimina_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "<-----";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Elimina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 452);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_elimina);
            this.Controls.Add(this.tb_cu);
            this.Controls.Add(this.label1);
            this.Name = "Elimina";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_cu;
        private System.Windows.Forms.Button btn_elimina;
        private System.Windows.Forms.Button button1;
    }
}