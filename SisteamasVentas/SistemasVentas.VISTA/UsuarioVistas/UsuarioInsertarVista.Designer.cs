﻿namespace SistemasVentas.VISTA.UsuarioVistas
{
    partial class UsuarioInsertarVista
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
            button3 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(394, 24);
            button3.Name = "button3";
            button3.Size = new Size(102, 23);
            button3.TabIndex = 29;
            button3.Text = "SELECCIONAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(148, 106);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(217, 23);
            textBox3.TabIndex = 28;
            textBox3.UseSystemPasswordChar = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(148, 67);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(217, 23);
            textBox2.TabIndex = 27;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(148, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(217, 23);
            textBox1.TabIndex = 26;
            // 
            // button2
            // 
            button2.Location = new Point(205, 269);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 25;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(205, 206);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 24;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(106, 160);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(349, 23);
            dateTimePicker1.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 114);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 22;
            label3.Text = "CONTRASEÑA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 75);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 21;
            label2.Text = "NOMBREUSER";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 32);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 20;
            label1.Text = "IDPERSONA";
            // 
            // UsuarioInsertarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 313);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UsuarioInsertarVista";
            Text = "UsuarioInsertarVista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}