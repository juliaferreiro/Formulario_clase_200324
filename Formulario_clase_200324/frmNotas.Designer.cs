namespace Formulario_clase_200324
{
    partial class frmNotas
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
            lblNota1 = new Label();
            lblNota2 = new Label();
            label3 = new Label();
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            txtNota3 = new TextBox();
            lblPromedio = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblNota1
            // 
            lblNota1.AutoSize = true;
            lblNota1.Location = new Point(192, 82);
            lblNota1.Name = "lblNota1";
            lblNota1.Size = new Size(42, 15);
            lblNota1.TabIndex = 0;
            lblNota1.Text = "Nota 1";
            lblNota1.Click += label1_Click;
            // 
            // lblNota2
            // 
            lblNota2.AutoSize = true;
            lblNota2.Location = new Point(192, 123);
            lblNota2.Name = "lblNota2";
            lblNota2.Size = new Size(42, 15);
            lblNota2.TabIndex = 1;
            lblNota2.Text = "Nota 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(192, 163);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Nota 3";
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(394, 74);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(100, 23);
            txtNota1.TabIndex = 3;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(394, 115);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(100, 23);
            txtNota2.TabIndex = 4;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(394, 155);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(100, 23);
            txtNota3.TabIndex = 5;
            txtNota3.TextChanged += textBox3_TextChanged;
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Location = new Point(277, 245);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(85, 15);
            lblPromedio.TabIndex = 6;
            lblPromedio.Text = "El promedio es";
            lblPromedio.Click += label4_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(277, 284);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // frmNotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(lblPromedio);
            Controls.Add(txtNota3);
            Controls.Add(txtNota2);
            Controls.Add(txtNota1);
            Controls.Add(label3);
            Controls.Add(lblNota2);
            Controls.Add(lblNota1);
            Name = "frmNotas";
            Text = "frmNotas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNota1;
        private Label lblNota2;
        private Label label3;
        private TextBox txtNota1;
        private TextBox txtNota2;
        private TextBox txtNota3;
        private Label lblPromedio;
        private Button btnCalcular;
    }
}