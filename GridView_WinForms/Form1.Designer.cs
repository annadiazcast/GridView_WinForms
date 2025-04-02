namespace GridView_WinForms
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
            dgDatos = new DataGridView();
            button2 = new Button();
            Eliminar = new TextBox();
            label1 = new Label();
            btn_Mostrar = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            btn_agregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgDatos).BeginInit();
            SuspendLayout();
            // 
            // dgDatos
            // 
            dgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDatos.Location = new Point(12, 12);
            dgDatos.Name = "dgDatos";
            dgDatos.Size = new Size(776, 180);
            dgDatos.TabIndex = 0;
            dgDatos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.Location = new Point(55, 394);
            button2.Name = "button2";
            button2.Size = new Size(71, 29);
            button2.TabIndex = 2;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Eliminar
            // 
            Eliminar.Location = new Point(43, 365);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(100, 23);
            Eliminar.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 347);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 4;
            label1.Text = "Matricula";
            label1.Click += label1_Click;
            // 
            // btn_Mostrar
            // 
            btn_Mostrar.Location = new Point(315, 198);
            btn_Mostrar.Name = "btn_Mostrar";
            btn_Mostrar.Size = new Size(143, 33);
            btn_Mostrar.TabIndex = 5;
            btn_Mostrar.Text = "Mostrar";
            btn_Mostrar.UseVisualStyleBackColor = true;
            btn_Mostrar.Click += btn_Mostrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(688, 198);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 7;
            label2.Text = "Matricula";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(667, 216);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(688, 250);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 9;
            label3.Text = "Matricula";
            label3.Click +=label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(667, 268);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 8;
            textBox2.TextChanged += this.textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(688, 347);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 13;
            label4.Text = "Matricula";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(667, 365);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(688, 303);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 11;
            label5.Text = "Matricula";
            label5.Click += this.label5_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(667, 321);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 10;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(686, 394);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(71, 29);
            btn_agregar.TabIndex = 14;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_agregar);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(btn_Mostrar);
            Controls.Add(label1);
            Controls.Add(Eliminar);
            Controls.Add(button2);
            Controls.Add(dgDatos);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgDatos;
        private Button button2;
        private TextBox Eliminar;
        private Label label1;
        private Button btn_Mostrar;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Button btn_agregar;
    }
}
