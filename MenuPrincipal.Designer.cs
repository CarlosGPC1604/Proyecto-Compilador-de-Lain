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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            dialogoAbrirArchivo = new OpenFileDialog();
            bttSeleccionarArchivo = new Button();
            bttValidar = new Button();
            bttLimpiar = new Button();
            bttVerCodigo = new Button();
            menuStrip = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            archivoToolStripMenuItem1 = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            cerrarActualToolStripMenuItem = new ToolStripMenuItem();
            compilarToolStripMenuItem = new ToolStripMenuItem();
            outConsole = new WindowsForms.Console.FConsole();
            errorProviderArchivo = new ErrorProvider(components);
            tbCodigo = new TextBox();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderArchivo).BeginInit();
            SuspendLayout();
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
            bttSeleccionarArchivo.Location = new Point(8, 520);
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
            bttValidar.Location = new Point(209, 520);
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
            bttLimpiar.Location = new Point(403, 520);
            bttLimpiar.Name = "bttLimpiar";
            bttLimpiar.Size = new Size(157, 41);
            bttLimpiar.TabIndex = 1;
            bttLimpiar.Text = "Limpiar";
            bttLimpiar.UseVisualStyleBackColor = true;
            bttLimpiar.Click += bttLimpiar_Click;
            // 
            // bttVerCodigo
            // 
            bttVerCodigo.FlatStyle = FlatStyle.Flat;
            bttVerCodigo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttVerCodigo.ForeColor = Color.FromArgb(203, 166, 174);
            bttVerCodigo.Location = new Point(597, 520);
            bttVerCodigo.Name = "bttVerCodigo";
            bttVerCodigo.Size = new Size(157, 41);
            bttVerCodigo.TabIndex = 1;
            bttVerCodigo.Text = "Ver código";
            bttVerCodigo.UseVisualStyleBackColor = true;
            // 
            // menuStrip
            // 
            menuStrip.BackgroundImage = (Image)resources.GetObject("menuStrip.BackgroundImage");
            menuStrip.BackgroundImageLayout = ImageLayout.None;
            menuStrip.Dock = DockStyle.None;
            menuStrip.GripMargin = new Padding(2, 4, 0, 4);
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, archivoToolStripMenuItem1, compilarToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Margin = new Padding(0, 10, 0, 10);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(6, 10, 0, 10);
            menuStrip.Size = new Size(257, 49);
            menuStrip.Stretch = false;
            menuStrip.TabIndex = 2;
            menuStrip.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.BackgroundImage = Properties.Resources.Captura_de_pantalla_2024_04_03_183334;
            inicioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            inicioToolStripMenuItem.Font = new Font("Segoe UI", 10F);
            inicioToolStripMenuItem.ForeColor = Color.White;
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(65, 29);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.BackColor = Color.FromArgb(22, 14, 18);
            archivoToolStripMenuItem.ForeColor = SystemColors.Control;
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(126, 28);
            archivoToolStripMenuItem.Text = "Salir";
            archivoToolStripMenuItem.Click += archivoToolStripMenuItem_Click;
            // 
            // archivoToolStripMenuItem1
            // 
            archivoToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, abrirToolStripMenuItem, cerrarActualToolStripMenuItem });
            archivoToolStripMenuItem1.Font = new Font("Segoe UI", 10.4F);
            archivoToolStripMenuItem1.ForeColor = Color.White;
            archivoToolStripMenuItem1.Name = "archivoToolStripMenuItem1";
            archivoToolStripMenuItem1.Size = new Size(86, 29);
            archivoToolStripMenuItem1.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(196, 30);
            nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(196, 30);
            abrirToolStripMenuItem.Text = "Abrir";
            // 
            // cerrarActualToolStripMenuItem
            // 
            cerrarActualToolStripMenuItem.Name = "cerrarActualToolStripMenuItem";
            cerrarActualToolStripMenuItem.Size = new Size(196, 30);
            cerrarActualToolStripMenuItem.Text = "Cerrar actual";
            // 
            // compilarToolStripMenuItem
            // 
            compilarToolStripMenuItem.Font = new Font("Segoe UI", 10.4F);
            compilarToolStripMenuItem.ForeColor = Color.White;
            compilarToolStripMenuItem.Name = "compilarToolStripMenuItem";
            compilarToolStripMenuItem.Size = new Size(98, 29);
            compilarToolStripMenuItem.Text = "Compilar";
            // 
            // outConsole
            // 
            outConsole.AutoScrollToEndLine = true;
            outConsole.BackColor = Color.Black;
            outConsole.BorderStyle = BorderStyle.None;
            outConsole.Font = new Font("Consolas", 10F);
            outConsole.ForeColor = Color.FromArgb(223, 216, 194);
            outConsole.HyperlinkColor = Color.Empty;
            outConsole.Location = new Point(8, 578);
            outConsole.MaxLength = 32767;
            outConsole.MinimumSize = new Size(470, 200);
            outConsole.Name = "outConsole";
            outConsole.ReadOnly = true;
            outConsole.ScrollBars = RichTextBoxScrollBars.Vertical;
            outConsole.SecureReadLine = true;
            outConsole.Size = new Size(785, 200);
            outConsole.State = WindowsForms.Console.Enums.ConsoleState.Writing;
            outConsole.TabIndex = 5;
            outConsole.TabStop = false;
            outConsole.Text = "";
            outConsole.Title = "Proyecto - Parcial 2";
            // 
            // errorProviderArchivo
            // 
            errorProviderArchivo.BlinkRate = 800;
            errorProviderArchivo.ContainerControl = this;
            // 
            // tbCodigo
            // 
            tbCodigo.BackColor = SystemColors.MenuText;
            tbCodigo.BorderStyle = BorderStyle.None;
            tbCodigo.Font = new Font("Segoe UI", 10.8F);
            tbCodigo.Location = new Point(11, 47);
            tbCodigo.Multiline = true;
            tbCodigo.Name = "tbCodigo";
            tbCodigo.PlaceholderText = "* Aquí se encontrará tu código de Lain *";
            tbCodigo.ScrollBars = ScrollBars.Both;
            tbCodigo.Size = new Size(782, 451);
            tbCodigo.TabIndex = 6;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(22, 14, 18);
            ClientSize = new Size(800, 790);
            ControlBox = false;
            Controls.Add(tbCodigo);
            Controls.Add(menuStrip);
            Controls.Add(outConsole);
            Controls.Add(bttVerCodigo);
            Controls.Add(bttLimpiar);
            Controls.Add(bttValidar);
            Controls.Add(bttSeleccionarArchivo);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MenuPrincipal";
            Opacity = 0.9D;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Proyecto - Parcial 2";
            Load += MenuPrincipal_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderArchivo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog dialogoAbrirArchivo;
        private Button bttSeleccionarArchivo;
        private Button bttValidar;
        private Button bttLimpiar;
        private Button bttVerCodigo;
        private MenuStrip menuStrip;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem archivoToolStripMenuItem1;
        private WindowsForms.Console.FConsole outConsole;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem cerrarActualToolStripMenuItem;
        private ToolStripMenuItem compilarToolStripMenuItem;
        private ErrorProvider errorProviderArchivo;
        private TextBox tbCodigo;
    }
}
