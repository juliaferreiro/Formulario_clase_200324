namespace Formulario_clase_200324
{
    partial class frmServicio
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
            lblNacimiento = new Label();
            lblActual = new Label();
            lblTotal = new Label();
            btnOk = new Button();
            btnNuevo = new Button();
            btnSalir = new Button();
            txtNacimiento = new TextBox();
            SuspendLayout();
            // 
            // lblNacimiento
            // 
            lblNacimiento.AutoSize = true;
            lblNacimiento.Location = new Point(178, 75);
            lblNacimiento.Name = "lblNacimiento";
            lblNacimiento.Size = new Size(191, 15);
            lblNacimiento.TabIndex = 0;
            lblNacimiento.Text = "INGRESA TU AÑO DE NACIMIENTO";
            // 
            // lblActual
            // 
            lblActual.AutoSize = true;
            lblActual.Location = new Point(178, 130);
            lblActual.Name = "lblActual";
            lblActual.Size = new Size(80, 15);
            lblActual.TabIndex = 1;
            lblActual.Text = "AÑO ACTUAL";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(178, 188);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(29, 15);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Tu...";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(203, 267);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 3;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(346, 267);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(494, 267);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // txtNacimiento
            // 
            txtNacimiento.Location = new Point(446, 75);
            txtNacimiento.Name = "txtNacimiento";
            txtNacimiento.Size = new Size(100, 23);
            txtNacimiento.TabIndex = 6;
            // 
            // frmServicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNacimiento);
            Controls.Add(btnSalir);
            Controls.Add(btnNuevo);
            Controls.Add(btnOk);
            Controls.Add(lblTotal);
            Controls.Add(lblActual);
            Controls.Add(lblNacimiento);
            Name = "frmServicio";
            Text = "frmServicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNacimiento;
        private Label lblActual;
        private Label lblTotal;
        private Button btnOk;
        private Button btnNuevo;
        private Button btnSalir;
        private TextBox txtNacimiento;
    }
}