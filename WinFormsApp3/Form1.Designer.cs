
namespace WinFormsApp3
{
    partial class Form1
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
            this.listanombres = new System.Windows.Forms.ListBox();
            this.txnombre = new System.Windows.Forms.TextBox();
            this.agregar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listanombres
            // 
            this.listanombres.FormattingEnabled = true;
            this.listanombres.ItemHeight = 15;
            this.listanombres.Location = new System.Drawing.Point(449, 97);
            this.listanombres.Name = "listanombres";
            this.listanombres.Size = new System.Drawing.Size(176, 94);
            this.listanombres.TabIndex = 0;
            // 
            // txnombre
            // 
            this.txnombre.Location = new System.Drawing.Point(449, 52);
            this.txnombre.Name = "txnombre";
            this.txnombre.Size = new System.Drawing.Size(176, 23);
            this.txnombre.TabIndex = 1;
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(449, 212);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 2;
            this.agregar.Text = "agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(550, 212);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 23);
            this.eliminar.TabIndex = 3;
            this.eliminar.Text = "eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "nombres";
            // 
            // mostrar
            // 
            this.mostrar.Location = new System.Drawing.Point(499, 241);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(75, 23);
            this.mostrar.TabIndex = 5;
            this.mostrar.Text = "mostrar";
            this.mostrar.UseVisualStyleBackColor = true;
            this.mostrar.Click += new System.EventHandler(this.mostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mostrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.txnombre);
            this.Controls.Add(this.listanombres);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listanombres;
        private System.Windows.Forms.TextBox txnombre;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mostrar;
    }
}

