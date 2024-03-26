namespace Formulario_clase_200324
{
    partial class frmTrabajo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrabajo));
            lblTarifa = new Label();
            lblHoras = new Label();
            lblTotal = new Label();
            btnOk = new Button();
            btnNuevo = new Button();
            btnSalir = new Button();
            txtTarifa = new TextBox();
            txtHoras = new TextBox();
            SuspendLayout();
            // 
            // lblTarifa
            // 
            lblTarifa.AutoSize = true;
            lblTarifa.Location = new Point(96, 92);
            lblTarifa.Name = "lblTarifa";
            lblTarifa.Size = new Size(172, 15);
            lblTarifa.TabIndex = 0;
            lblTarifa.Text = "INGRESÁ LA TARIFA POR HORA";
            // 
            // lblHoras
            // 
            lblHoras.AutoSize = true;
            lblHoras.Location = new Point(96, 153);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(196, 15);
            lblHoras.TabIndex = 1;
            lblHoras.Text = "INGRESÁ LAS HORAS TRABAJADAS ";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(148, 219);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(78, 15);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Tu sueldo es: ";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(111, 286);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 22);
            btnOk.TabIndex = 3;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(261, 286);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 22);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(417, 286);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 22);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // txtTarifa
            // 
            txtTarifa.Location = new Point(320, 92);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(100, 23);
            txtTarifa.TabIndex = 6;
            // 
            // txtHoras
            // 
            txtHoras.Location = new Point(320, 153);
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(100, 23);
            txtHoras.TabIndex = 7;
            // 
            // frmTrabajo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(539, 355);
            Controls.Add(txtHoras);
            Controls.Add(txtTarifa);
            Controls.Add(btnSalir);
            Controls.Add(btnNuevo);
            Controls.Add(btnOk);
            Controls.Add(lblTotal);
            Controls.Add(lblHoras);
            Controls.Add(lblTarifa);
            Name = "frmTrabajo";
            Text = "frmTrabajo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTarifa;
        private Label lblHoras;
        private Label lblTotal;
        private Button btnOk;
        private Button btnNuevo;
        private Button btnSalir;
        private TextBox txtTarifa;
        private TextBox txtHoras;
    }
}