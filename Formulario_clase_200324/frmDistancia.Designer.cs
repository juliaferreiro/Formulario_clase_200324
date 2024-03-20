namespace Formulario_clase_200324
{
    partial class frmDistancia
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
            btnCalcular = new Button();
            lblResultado = new Label();
            txtTiempo = new TextBox();
            txtVelocidad = new TextBox();
            lblTiempo = new Label();
            lblVelocidad = new Label();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.ForeColor = SystemColors.ControlDarkDark;
            btnCalcular.Location = new Point(346, 289);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 13;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(336, 224);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(85, 15);
            lblResultado.TabIndex = 11;
            lblResultado.Text = "El resultado es:";
            lblResultado.Click += lblResultado_Click;
            // 
            // txtTiempo
            // 
            txtTiempo.Location = new Point(418, 128);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(100, 23);
            txtTiempo.TabIndex = 10;
            // 
            // txtVelocidad
            // 
            txtVelocidad.Location = new Point(418, 89);
            txtVelocidad.Name = "txtVelocidad";
            txtVelocidad.Size = new Size(100, 23);
            txtVelocidad.TabIndex = 9;
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(249, 136);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(97, 15);
            lblTiempo.TabIndex = 8;
            lblTiempo.Text = "INGRESE TIEMPO";
            // 
            // lblVelocidad
            // 
            lblVelocidad.AutoSize = true;
            lblVelocidad.Location = new Point(249, 89);
            lblVelocidad.Name = "lblVelocidad";
            lblVelocidad.Size = new Size(118, 15);
            lblVelocidad.TabIndex = 7;
            lblVelocidad.Text = "INGRESE VELOCIDAD";
            // 
            // frmDistancia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(lblResultado);
            Controls.Add(txtTiempo);
            Controls.Add(txtVelocidad);
            Controls.Add(lblTiempo);
            Controls.Add(lblVelocidad);
            Name = "frmDistancia";
            Text = "frmDistancia";
            Load += frmDistancia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label lblResultado;
        private TextBox txtTiempo;
        private TextBox txtVelocidad;
        private Label lblTiempo;
        private Label lblVelocidad;
    }
}