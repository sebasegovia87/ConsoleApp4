
namespace WinFormsApp2
{
    partial class mostrargenero
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mostrardni = new System.Windows.Forms.Button();
            this.Txdni = new System.Windows.Forms.TextBox();
            this.borrardni = new System.Windows.Forms.Button();
            this.lbdni = new System.Windows.Forms.Label();
            this.salir = new System.Windows.Forms.Button();
            this.tenis = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mostrardeporte = new System.Windows.Forms.Button();
            this.futbol = new System.Windows.Forms.CheckBox();
            this.femenino = new System.Windows.Forms.RadioButton();
            this.masculino = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mostrardni
            // 
            this.mostrardni.Location = new System.Drawing.Point(454, 98);
            this.mostrardni.Name = "mostrardni";
            this.mostrardni.Size = new System.Drawing.Size(76, 36);
            this.mostrardni.TabIndex = 0;
            this.mostrardni.Text = "mostrar dni";
            this.mostrardni.UseVisualStyleBackColor = true;
            this.mostrardni.Click += new System.EventHandler(this.mostrardni_Click);
            // 
            // Txdni
            // 
            this.Txdni.Location = new System.Drawing.Point(454, 69);
            this.Txdni.Name = "Txdni";
            this.Txdni.Size = new System.Drawing.Size(160, 23);
            this.Txdni.TabIndex = 1;
            // 
            // borrardni
            // 
            this.borrardni.Location = new System.Drawing.Point(536, 98);
            this.borrardni.Name = "borrardni";
            this.borrardni.Size = new System.Drawing.Size(76, 36);
            this.borrardni.TabIndex = 2;
            this.borrardni.Text = "borrar dni";
            this.borrardni.UseVisualStyleBackColor = true;
            this.borrardni.Click += new System.EventHandler(this.borrardni_Click);
            // 
            // lbdni
            // 
            this.lbdni.AutoSize = true;
            this.lbdni.Location = new System.Drawing.Point(454, 48);
            this.lbdni.Name = "lbdni";
            this.lbdni.Size = new System.Drawing.Size(24, 15);
            this.lbdni.TabIndex = 3;
            this.lbdni.Text = "dni";
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(666, 277);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(76, 36);
            this.salir.TabIndex = 4;
            this.salir.Text = "salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // tenis
            // 
            this.tenis.AutoSize = true;
            this.tenis.Location = new System.Drawing.Point(26, 22);
            this.tenis.Name = "tenis";
            this.tenis.Size = new System.Drawing.Size(52, 19);
            this.tenis.TabIndex = 5;
            this.tenis.Text = "Tenis";
            this.tenis.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mostrardeporte);
            this.groupBox1.Controls.Add(this.futbol);
            this.groupBox1.Controls.Add(this.tenis);
            this.groupBox1.Location = new System.Drawing.Point(113, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deportes";
            // 
            // mostrardeporte
            // 
            this.mostrardeporte.Location = new System.Drawing.Point(109, 48);
            this.mostrardeporte.Name = "mostrardeporte";
            this.mostrardeporte.Size = new System.Drawing.Size(76, 46);
            this.mostrardeporte.TabIndex = 7;
            this.mostrardeporte.Text = "mostrar deporte";
            this.mostrardeporte.UseVisualStyleBackColor = true;
            this.mostrardeporte.Click += new System.EventHandler(this.mostrardeporte_Click);
            // 
            // futbol
            // 
            this.futbol.AutoSize = true;
            this.futbol.Location = new System.Drawing.Point(26, 48);
            this.futbol.Name = "futbol";
            this.futbol.Size = new System.Drawing.Size(58, 19);
            this.futbol.TabIndex = 6;
            this.futbol.Text = "futbol";
            this.futbol.UseVisualStyleBackColor = true;
            this.futbol.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // femenino
            // 
            this.femenino.AutoSize = true;
            this.femenino.Location = new System.Drawing.Point(379, 259);
            this.femenino.Name = "femenino";
            this.femenino.Size = new System.Drawing.Size(94, 19);
            this.femenino.TabIndex = 7;
            this.femenino.TabStop = true;
            this.femenino.Text = "radioButton1";
            this.femenino.UseVisualStyleBackColor = true;
            // 
            // masculino
            // 
            this.masculino.AutoSize = true;
            this.masculino.Location = new System.Drawing.Point(379, 234);
            this.masculino.Name = "masculino";
            this.masculino.Size = new System.Drawing.Size(80, 19);
            this.masculino.TabIndex = 8;
            this.masculino.TabStop = true;
            this.masculino.Text = "masculino";
            this.masculino.UseVisualStyleBackColor = true;
            this.masculino.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.masculino);
            this.Controls.Add(this.femenino);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.lbdni);
            this.Controls.Add(this.borrardni);
            this.Controls.Add(this.Txdni);
            this.Controls.Add(this.mostrardni);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mostrardni;
        private System.Windows.Forms.TextBox Txdni;
        private System.Windows.Forms.Button borrardni;
        private System.Windows.Forms.Label lbdni;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.CheckBox tenis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox futbol;
        private System.Windows.Forms.Button mostrardeporte;
        private System.Windows.Forms.RadioButton femenino;
        private System.Windows.Forms.RadioButton masculino;
    }
}

