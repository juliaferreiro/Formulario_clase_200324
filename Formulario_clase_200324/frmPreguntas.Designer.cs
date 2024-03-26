namespace Formulario_clase_200324
{
    partial class frmPreguntas
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
            lblTotal = new Label();
            txtBlanco = new TextBox();
            txtIncorrectas = new TextBox();
            txtCorrectas = new TextBox();
            btnSalir = new Button();
            btnNuevo = new Button();
            btnOk = new Button();
            lblBlanco = new Label();
            lblIncorrectas = new Label();
            lblCorrectas = new Label();
            SuspendLayout();
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(194, 244);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(88, 15);
            lblTotal.TabIndex = 19;
            lblTotal.Text = "El resultado es: ";
            // 
            // txtBlanco
            // 
            txtBlanco.Location = new Point(508, 196);
            txtBlanco.Name = "txtBlanco";
            txtBlanco.Size = new Size(100, 23);
            txtBlanco.TabIndex = 18;
            // 
            // txtIncorrectas
            // 
            txtIncorrectas.Location = new Point(508, 138);
            txtIncorrectas.Name = "txtIncorrectas";
            txtIncorrectas.Size = new Size(100, 23);
            txtIncorrectas.TabIndex = 17;
            txtIncorrectas.TextChanged += txtIncorrectas_TextChanged;
            // 
            // txtCorrectas
            // 
            txtCorrectas.Location = new Point(508, 80);
            txtCorrectas.Name = "txtCorrectas";
            txtCorrectas.Size = new Size(100, 23);
            txtCorrectas.TabIndex = 16;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(481, 280);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(349, 280);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 14;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(216, 280);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 13;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // lblBlanco
            // 
            lblBlanco.AutoSize = true;
            lblBlanco.Location = new Point(194, 196);
            lblBlanco.Name = "lblBlanco";
            lblBlanco.Size = new Size(275, 15);
            lblBlanco.TabIndex = 12;
            lblBlanco.Text = "INGRESA EL NUMERO DE RESPUESTAS EN BLANCO";
            // 
            // lblIncorrectas
            // 
            lblIncorrectas.AutoSize = true;
            lblIncorrectas.Location = new Point(194, 141);
            lblIncorrectas.Name = "lblIncorrectas";
            lblIncorrectas.Size = new Size(286, 15);
            lblIncorrectas.TabIndex = 11;
            lblIncorrectas.Text = "INGRESA EL NUMERO DE RESPUESTAS INCORRECTAS";
            // 
            // lblCorrectas
            // 
            lblCorrectas.AutoSize = true;
            lblCorrectas.Location = new Point(194, 87);
            lblCorrectas.Name = "lblCorrectas";
            lblCorrectas.Size = new Size(274, 15);
            lblCorrectas.TabIndex = 10;
            lblCorrectas.Text = "INGRESA EL NUMERO DE RESPUESTAS CORRECTAS";
            // 
            // frmPreguntas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotal);
            Controls.Add(txtBlanco);
            Controls.Add(txtIncorrectas);
            Controls.Add(txtCorrectas);
            Controls.Add(btnSalir);
            Controls.Add(btnNuevo);
            Controls.Add(btnOk);
            Controls.Add(lblBlanco);
            Controls.Add(lblIncorrectas);
            Controls.Add(lblCorrectas);
            Name = "frmPreguntas";
            Text = "frmPreguntas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotal;
        private TextBox txtBlanco;
        private TextBox txtIncorrectas;
        private TextBox txtCorrectas;
        private Button btnSalir;
        private Button btnNuevo;
        private Button btnOk;
        private Label lblBlanco;
        private Label lblIncorrectas;
        private Label lblCorrectas;
    }
}