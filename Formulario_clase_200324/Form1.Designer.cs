namespace Formulario_clase_200324
{
    partial class lblBienvenidos
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
            lblBIENVENIDO = new Label();
            textNombre = new TextBox();
            btnOk = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblBIENVENIDO
            // 
            lblBIENVENIDO.AutoSize = true;
            lblBIENVENIDO.Font = new Font("Segoe UI", 15F);
            lblBIENVENIDO.Location = new Point(43, 74);
            lblBIENVENIDO.Name = "lblBIENVENIDO";
            lblBIENVENIDO.Size = new Size(124, 28);
            lblBIENVENIDO.TabIndex = 0;
            lblBIENVENIDO.Text = "BIENVENIDO";
            lblBIENVENIDO.Click += label1_Click;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(164, 129);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(412, 23);
            textNombre.TabIndex = 1;
            textNombre.TextChanged += textNombre_TextChanged;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(164, 249);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(123, 54);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // button1
            // 
            button1.Location = new Point(429, 249);
            button1.Name = "button1";
            button1.Size = new Size(123, 54);
            button1.TabIndex = 3;
            button1.Text = "CERRAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblBienvenidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(794, 450);
            Controls.Add(button1);
            Controls.Add(btnOk);
            Controls.Add(textNombre);
            Controls.Add(lblBIENVENIDO);
            Name = "lblBienvenidos";
            Text = "OK";
            Load += lblBienvenidos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBIENVENIDO;
        private TextBox textNombre;
        private Button btnOk;
        private Button button1;
    }
}
