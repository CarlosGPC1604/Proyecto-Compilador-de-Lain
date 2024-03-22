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
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            archivoToolStripMenuItem1 = new ToolStripMenuItem();
            outConsole = new WindowsForms.Console.FConsole();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // bttCerrar
            // 
            bttCerrar.FlatAppearance.BorderColor = Color.FromArgb(203, 166, 174);
            bttCerrar.FlatAppearance.BorderSize = 3;
            bttCerrar.FlatStyle = FlatStyle.Flat;
            bttCerrar.ForeColor = Color.FromArgb(203, 166, 174);
            bttCerrar.Location = new Point(723, 46);
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
            bttSeleccionarArchivo.ForeColor = Color.FromArgb(203, 166, 174);
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
            bttValidar.ForeColor = Color.FromArgb(203, 166, 174);
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
            bttLimpiar.ForeColor = Color.FromArgb(203, 166, 174);
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
            bttVerCodigo.ForeColor = Color.FromArgb(203, 166, 174);
            bttVerCodigo.Location = new Point(96, 368);
            bttVerCodigo.Name = "bttVerCodigo";
            bttVerCodigo.Size = new Size(157, 41);
            bttVerCodigo.TabIndex = 1;
            bttVerCodigo.Text = "Ver código";
            bttVerCodigo.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, archivoToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(59, 24);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(121, 26);
            archivoToolStripMenuItem.Text = "Salir";
            // 
            // archivoToolStripMenuItem1
            // 
            archivoToolStripMenuItem1.Name = "archivoToolStripMenuItem1";
            archivoToolStripMenuItem1.Size = new Size(73, 24);
            archivoToolStripMenuItem1.Text = "Archivo";
            // 
            // outConsole
            // 
            outConsole.AutoScrollToEndLine = true;
            outConsole.BackColor = Color.Black;
            outConsole.BorderStyle = BorderStyle.None;
            outConsole.Font = new Font("Consolas", 10F);
            outConsole.ForeColor = Color.FromArgb(223, 216, 194);
            outConsole.HyperlinkColor = Color.Empty;
            outConsole.Location = new Point(96, 46);
            outConsole.MaxLength = 32767;
            outConsole.MinimumSize = new Size(470, 200);
            outConsole.Name = "outConsole";
            outConsole.ReadOnly = true;
            outConsole.ScrollBars = RichTextBoxScrollBars.Vertical;
            outConsole.SecureReadLine = true;
            outConsole.Size = new Size(552, 229);
            outConsole.State = WindowsForms.Console.Enums.ConsoleState.Writing;
            outConsole.TabIndex = 5;
            outConsole.Text = "";
            outConsole.Title = "Proyecto - Parcial 2";
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(22, 14, 18);
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(outConsole);
            Controls.Add(bttVerCodigo);
            Controls.Add(bttLimpiar);
            Controls.Add(bttValidar);
            Controls.Add(bttSeleccionarArchivo);
            Controls.Add(bttCerrar);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MenuPrincipal";
            Opacity = 0.9D;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Proyecto - Parcial 2";
            Load += MenuPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttCerrar;
        private OpenFileDialog dialogoAbrirArchivo;
        private Button bttSeleccionarArchivo;
        private Button bttValidar;
        private Button bttLimpiar;
        private Button bttVerCodigo;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem archivoToolStripMenuItem1;
        private WindowsForms.Console.FConsole outConsole;
    }
}
