namespace Calculadora1
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
            groupBox1 = new GroupBox();
            lblResultado = new Label();
            Resulta = new Label();
            btDividir = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txtNro2 = new TextBox();
            numero2 = new Label();
            txtNro1 = new TextBox();
            numero1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblResultado);
            groupBox1.Controls.Add(Resulta);
            groupBox1.Controls.Add(btDividir);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtNro2);
            groupBox1.Controls.Add(numero2);
            groupBox1.Controls.Add(txtNro1);
            groupBox1.Controls.Add(numero1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(395, 410);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(76, 265);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(18, 20);
            lblResultado.TabIndex = 10;
            lblResultado.Text = "0";
            // 
            // Resulta
            // 
            Resulta.AutoSize = true;
            Resulta.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Resulta.Location = new Point(4, 265);
            Resulta.Name = "Resulta";
            Resulta.Size = new Size(66, 17);
            Resulta.TabIndex = 8;
            Resulta.Text = "Resultado";
            // 
            // btDividir
            // 
            btDividir.Location = new Point(294, 195);
            btDividir.Name = "btDividir";
            btDividir.Size = new Size(95, 37);
            btDividir.TabIndex = 7;
            btDividir.Text = "Dividir";
            btDividir.UseVisualStyleBackColor = true;
            btDividir.Click += btDividir_Click;
            // 
            // button3
            // 
            button3.Location = new Point(190, 195);
            button3.Name = "button3";
            button3.Size = new Size(101, 37);
            button3.TabIndex = 6;
            button3.Text = "Multiplicar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(96, 195);
            button2.Name = "button2";
            button2.Size = new Size(88, 37);
            button2.TabIndex = 5;
            button2.Text = "Subtrair";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(6, 195);
            button1.Name = "button1";
            button1.Size = new Size(84, 37);
            button1.TabIndex = 4;
            button1.Text = "Soma";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtNro2
            // 
            txtNro2.Location = new Point(25, 133);
            txtNro2.Name = "txtNro2";
            txtNro2.Size = new Size(139, 23);
            txtNro2.TabIndex = 3;
            // 
            // numero2
            // 
            numero2.AutoSize = true;
            numero2.Location = new Point(35, 115);
            numero2.Name = "numero2";
            numero2.Size = new Size(99, 15);
            numero2.TabIndex = 2;
            numero2.Text = "Segundo numero";
            // 
            // txtNro1
            // 
            txtNro1.Location = new Point(25, 78);
            txtNro1.Name = "txtNro1";
            txtNro1.Size = new Size(139, 23);
            txtNro1.TabIndex = 1;
            // 
            // numero1
            // 
            numero1.AutoSize = true;
            numero1.Location = new Point(35, 49);
            numero1.Name = "numero1";
            numero1.Size = new Size(97, 15);
            numero1.TabIndex = 0;
            numero1.Text = "Primeiro numero";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 434);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNro2;
        private Label numero2;
        private TextBox txtNro1;
        private Label numero1;
        private Label lblResultado;
        private Label Resulta;
        private Button btDividir;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}
