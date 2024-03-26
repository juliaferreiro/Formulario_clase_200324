namespace Formulario_clase_200324
{
    partial class frmPartidos
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
            lblGanados = new Label();
            lblPerdidos = new Label();
            lblEmpatados = new Label();
            txtGanados = new TextBox();
            txtPerdidos = new TextBox();
            txtEmpatados = new TextBox();
            btnOk = new Button();
            btnNuevo = new Button();
            btnSalir = new Button();
            lblTotal = new Label();
            SuspendLayout();
            // 
            // lblGanados
            // 
            lblGanados.AutoSize = true;
            lblGanados.Location = new Point(142, 74);
            lblGanados.Name = "lblGanados";
            lblGanados.Size = new Size(188, 15);
            lblGanados.TabIndex = 0;
            lblGanados.Text = "NUMERO DE PARTIDOS GANADOS";
            lblGanados.Click += label1_Click;
            // 
            // lblPerdidos
            // 
            lblPerdidos.AutoSize = true;
            lblPerdidos.Location = new Point(142, 132);
            lblPerdidos.Name = "lblPerdidos";
            lblPerdidos.Size = new Size(186, 15);
            lblPerdidos.TabIndex = 1;
            lblPerdidos.Text = "NUMERO DE PARTIDOS PERDIDOS";
            // 
            // lblEmpatados
            // 
            lblEmpatados.AutoSize = true;
            lblEmpatados.Location = new Point(142, 190);
            lblEmpatados.Name = "lblEmpatados";
            lblEmpatados.Size = new Size(198, 15);
            lblEmpatados.TabIndex = 2;
            lblEmpatados.Text = "NUMERO DE PARTIDOS EMPATADOS";
            // 
            // txtGanados
            // 
            txtGanados.Location = new Point(391, 74);
            txtGanados.Name = "txtGanados";
            txtGanados.Size = new Size(100, 23);
            txtGanados.TabIndex = 3;
            // 
            // txtPerdidos
            // 
            txtPerdidos.Location = new Point(391, 132);
            txtPerdidos.Name = "txtPerdidos";
            txtPerdidos.Size = new Size(100, 23);
            txtPerdidos.TabIndex = 4;
            // 
            // txtEmpatados
            // 
            txtEmpatados.Location = new Point(391, 190);
            txtEmpatados.Name = "txtEmpatados";
            txtEmpatados.Size = new Size(100, 23);
            txtEmpatados.TabIndex = 5;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(193, 270);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 6;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(346, 270);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 7;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(499, 270);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(265, 236);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(85, 15);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "El resultado es:";
            lblTotal.Click += label1_Click_1;
            // 
            // frmPartidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotal);
            Controls.Add(btnSalir);
            Controls.Add(btnNuevo);
            Controls.Add(btnOk);
            Controls.Add(txtEmpatados);
            Controls.Add(txtPerdidos);
            Controls.Add(txtGanados);
            Controls.Add(lblEmpatados);
            Controls.Add(lblPerdidos);
            Controls.Add(lblGanados);
            Name = "frmPartidos";
            Text = "frmPartidos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGanados;
        private Label lblPerdidos;
        private Label lblEmpatados;
        private TextBox txtGanados;
        private TextBox txtPerdidos;
        private TextBox txtEmpatados;
        private Button btnOk;
        private Button btnNuevo;
        private Button btnSalir;
        private Label lblTotal;
    }
}