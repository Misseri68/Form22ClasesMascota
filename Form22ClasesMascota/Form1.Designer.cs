namespace Form22ClasesMascota
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtRaza = new TextBox();
            lstMascotas = new ListBox();
            btnNew = new Button();
            btnRead = new Button();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 93);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "Raza";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(220, 9);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Mascotas";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 31);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 3;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(12, 124);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(100, 23);
            txtRaza.TabIndex = 4;
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(220, 40);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(221, 304);
            lstMascotas.TabIndex = 5;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(12, 180);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(119, 43);
            btnNew.TabIndex = 6;
            btnNew.Text = "Nueva mascota";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += button1_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(12, 240);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(119, 42);
            btnRead.TabIndex = 7;
            btnRead.Text = "Leer mascotas";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(12, 303);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(119, 41);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar Mascotas";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 365);
            Controls.Add(btnGuardar);
            Controls.Add(btnRead);
            Controls.Add(btnNew);
            Controls.Add(lstMascotas);
            Controls.Add(txtRaza);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtRaza;
        private ListBox lstMascotas;
        private Button btnNew;
        private Button btnRead;
        private Button btnGuardar;
    }
}
