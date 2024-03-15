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
            bttSeleccionarArchivo = new Button();
            bttValidar = new Button();
            bttLimpiar = new Button();
            bttVerCodigo = new Button();
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
            // bttSeleccionarArchivo
            // 
            bttSeleccionarArchivo.FlatStyle = FlatStyle.Flat;
            bttSeleccionarArchivo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttSeleccionarArchivo.ForeColor = Color.White;
            bttSeleccionarArchivo.Location = new Point(96, 297);
            bttSeleccionarArchivo.Name = "bttSeleccionarArchivo";
            bttSeleccionarArchivo.Size = new Size(157, 41);
            bttSeleccionarArchivo.TabIndex = 1;
            bttSeleccionarArchivo.Text = "Agregar archivo";
            bttSeleccionarArchivo.UseVisualStyleBackColor = true;
            bttSeleccionarArchivo.Click += bttSeleccionarArchivo_Click;
            // 
            // bttValidar
            // 
            bttValidar.FlatStyle = FlatStyle.Flat;
            bttValidar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttValidar.ForeColor = Color.White;
            bttValidar.Location = new Point(297, 297);
            bttValidar.Name = "bttValidar";
            bttValidar.Size = new Size(157, 41);
            bttValidar.TabIndex = 1;
            bttValidar.Text = "Validar";
            bttValidar.UseVisualStyleBackColor = true;
            bttValidar.Click += bttValidar_Click;
            // 
            // bttLimpiar
            // 
            bttLimpiar.FlatStyle = FlatStyle.Flat;
            bttLimpiar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttLimpiar.ForeColor = Color.White;
            bttLimpiar.Location = new Point(491, 297);
            bttLimpiar.Name = "bttLimpiar";
            bttLimpiar.Size = new Size(157, 41);
            bttLimpiar.TabIndex = 1;
            bttLimpiar.Text = "Limpiar";
            bttLimpiar.UseVisualStyleBackColor = true;
            // 
            // bttVerCodigo
            // 
            bttVerCodigo.FlatStyle = FlatStyle.Flat;
            bttVerCodigo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttVerCodigo.ForeColor = Color.White;
            bttVerCodigo.Location = new Point(96, 368);
            bttVerCodigo.Name = "bttVerCodigo";
            bttVerCodigo.Size = new Size(157, 41);
            bttVerCodigo.TabIndex = 1;
            bttVerCodigo.Text = "Ver código";
            bttVerCodigo.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(22, 14, 18);
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(bttVerCodigo);
            Controls.Add(bttLimpiar);
            Controls.Add(bttValidar);
            Controls.Add(bttSeleccionarArchivo);
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
        private Button bttSeleccionarArchivo;
        private Button bttValidar;
        private Button bttLimpiar;
        private Button bttVerCodigo;
    }
}
