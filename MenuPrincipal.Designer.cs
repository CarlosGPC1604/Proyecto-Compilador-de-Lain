namespace Proyecto_Compilador_de_Lain
{
    partial class MenuPrincipal
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
            bttCerrar = new Button();
            dialogoAbrirArchivo = new OpenFileDialog();
            SuspendLayout();
            // 
            // bttCerrar
            // 
            bttCerrar.FlatAppearance.BorderColor = Color.FromArgb(203, 166, 174);
            bttCerrar.FlatAppearance.BorderSize = 3;
            bttCerrar.FlatStyle = FlatStyle.Flat;
            bttCerrar.ForeColor = Color.FromArgb(203, 166, 174);
            bttCerrar.Location = new Point(723, 12);
            bttCerrar.Name = "bttCerrar";
            bttCerrar.Size = new Size(65, 56);
            bttCerrar.TabIndex = 0;
            bttCerrar.Text = "X";
            bttCerrar.UseVisualStyleBackColor = true;
            bttCerrar.Click += bttCerrar_Click;
            // 
            // dialogoAbrirArchivo
            // 
            dialogoAbrirArchivo.FileName = "codigoFuente";
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(22, 14, 18);
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(bttCerrar);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MenuPrincipal";
            Opacity = 0.9D;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Proyecto - Parcial 2";
            Load += MenuPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button bttCerrar;
        private OpenFileDialog dialogoAbrirArchivo;
    }
}
