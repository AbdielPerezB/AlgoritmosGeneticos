namespace AlgoritmosGeneticos
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
            this.components = new System.ComponentModel.Container();
            this.lblGeneracion = new System.Windows.Forms.Label();
            this.gbAltura = new System.Windows.Forms.GroupBox();
            this.rbBajo = new System.Windows.Forms.RadioButton();
            this.rbMedio = new System.Windows.Forms.RadioButton();
            this.rbAlto = new System.Windows.Forms.RadioButton();
            this.gbColorFlor = new System.Windows.Forms.GroupBox();
            this.rbAmarillo = new System.Windows.Forms.RadioButton();
            this.rbRojo = new System.Windows.Forms.RadioButton();
            this.rbAzul = new System.Windows.Forms.RadioButton();
            this.gbTamañoFlor = new System.Windows.Forms.GroupBox();
            this.rbGrande = new System.Windows.Forms.RadioButton();
            this.rbPequeno = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.aplicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuParo = new System.Windows.Forms.ToolStripMenuItem();
            this.gbAltura.SuspendLayout();
            this.gbColorFlor.SuspendLayout();
            this.gbTamañoFlor.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGeneracion
            // 
            this.lblGeneracion.AutoSize = true;
            this.lblGeneracion.Location = new System.Drawing.Point(33, 133);
            this.lblGeneracion.Name = "lblGeneracion";
            this.lblGeneracion.Size = new System.Drawing.Size(70, 15);
            this.lblGeneracion.TabIndex = 0;
            this.lblGeneracion.Text = "Generación:";
            // 
            // gbAltura
            // 
            this.gbAltura.Controls.Add(this.rbBajo);
            this.gbAltura.Controls.Add(this.rbMedio);
            this.gbAltura.Controls.Add(this.rbAlto);
            this.gbAltura.Location = new System.Drawing.Point(33, 27);
            this.gbAltura.Name = "gbAltura";
            this.gbAltura.Size = new System.Drawing.Size(172, 100);
            this.gbAltura.TabIndex = 1;
            this.gbAltura.TabStop = false;
            this.gbAltura.Text = "Altura:";
            // 
            // rbBajo
            // 
            this.rbBajo.AutoSize = true;
            this.rbBajo.Location = new System.Drawing.Point(14, 68);
            this.rbBajo.Name = "rbBajo";
            this.rbBajo.Size = new System.Drawing.Size(48, 19);
            this.rbBajo.TabIndex = 2;
            this.rbBajo.TabStop = true;
            this.rbBajo.Text = "Bajo";
            this.rbBajo.UseVisualStyleBackColor = true;
            // 
            // rbMedio
            // 
            this.rbMedio.AutoSize = true;
            this.rbMedio.Location = new System.Drawing.Point(14, 45);
            this.rbMedio.Name = "rbMedio";
            this.rbMedio.Size = new System.Drawing.Size(59, 19);
            this.rbMedio.TabIndex = 1;
            this.rbMedio.TabStop = true;
            this.rbMedio.Text = "Medio";
            this.rbMedio.UseVisualStyleBackColor = true;
            // 
            // rbAlto
            // 
            this.rbAlto.AutoSize = true;
            this.rbAlto.Location = new System.Drawing.Point(14, 22);
            this.rbAlto.Name = "rbAlto";
            this.rbAlto.Size = new System.Drawing.Size(47, 19);
            this.rbAlto.TabIndex = 0;
            this.rbAlto.TabStop = true;
            this.rbAlto.Text = "Alto";
            this.rbAlto.UseVisualStyleBackColor = true;
            // 
            // gbColorFlor
            // 
            this.gbColorFlor.Controls.Add(this.rbAmarillo);
            this.gbColorFlor.Controls.Add(this.rbRojo);
            this.gbColorFlor.Controls.Add(this.rbAzul);
            this.gbColorFlor.Location = new System.Drawing.Point(228, 27);
            this.gbColorFlor.Name = "gbColorFlor";
            this.gbColorFlor.Size = new System.Drawing.Size(172, 100);
            this.gbColorFlor.TabIndex = 2;
            this.gbColorFlor.TabStop = false;
            this.gbColorFlor.Text = "Color de flor:";
            // 
            // rbAmarillo
            // 
            this.rbAmarillo.AutoSize = true;
            this.rbAmarillo.Location = new System.Drawing.Point(16, 68);
            this.rbAmarillo.Name = "rbAmarillo";
            this.rbAmarillo.Size = new System.Drawing.Size(70, 19);
            this.rbAmarillo.TabIndex = 5;
            this.rbAmarillo.TabStop = true;
            this.rbAmarillo.Text = "Amarillo";
            this.rbAmarillo.UseVisualStyleBackColor = true;
            // 
            // rbRojo
            // 
            this.rbRojo.AutoSize = true;
            this.rbRojo.Location = new System.Drawing.Point(16, 22);
            this.rbRojo.Name = "rbRojo";
            this.rbRojo.Size = new System.Drawing.Size(49, 19);
            this.rbRojo.TabIndex = 3;
            this.rbRojo.TabStop = true;
            this.rbRojo.Text = "Rojo";
            this.rbRojo.UseVisualStyleBackColor = true;
            // 
            // rbAzul
            // 
            this.rbAzul.AutoSize = true;
            this.rbAzul.Location = new System.Drawing.Point(16, 45);
            this.rbAzul.Name = "rbAzul";
            this.rbAzul.Size = new System.Drawing.Size(48, 19);
            this.rbAzul.TabIndex = 4;
            this.rbAzul.TabStop = true;
            this.rbAzul.Text = "Azul";
            this.rbAzul.UseVisualStyleBackColor = true;
            // 
            // gbTamañoFlor
            // 
            this.gbTamañoFlor.Controls.Add(this.rbGrande);
            this.gbTamañoFlor.Controls.Add(this.rbPequeno);
            this.gbTamañoFlor.Controls.Add(this.rbNormal);
            this.gbTamañoFlor.Location = new System.Drawing.Point(425, 27);
            this.gbTamañoFlor.Name = "gbTamañoFlor";
            this.gbTamañoFlor.Size = new System.Drawing.Size(172, 100);
            this.gbTamañoFlor.TabIndex = 2;
            this.gbTamañoFlor.TabStop = false;
            this.gbTamañoFlor.Text = "Tamaño de la flor:";
            // 
            // rbGrande
            // 
            this.rbGrande.AutoSize = true;
            this.rbGrande.Location = new System.Drawing.Point(16, 68);
            this.rbGrande.Name = "rbGrande";
            this.rbGrande.Size = new System.Drawing.Size(63, 19);
            this.rbGrande.TabIndex = 5;
            this.rbGrande.TabStop = true;
            this.rbGrande.Text = "Grande";
            this.rbGrande.UseVisualStyleBackColor = true;
            // 
            // rbPequeno
            // 
            this.rbPequeno.AutoSize = true;
            this.rbPequeno.Location = new System.Drawing.Point(16, 22);
            this.rbPequeno.Name = "rbPequeno";
            this.rbPequeno.Size = new System.Drawing.Size(72, 19);
            this.rbPequeno.TabIndex = 3;
            this.rbPequeno.TabStop = true;
            this.rbPequeno.Text = "Pequeño";
            this.rbPequeno.UseVisualStyleBackColor = true;
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Location = new System.Drawing.Point(16, 45);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(65, 19);
            this.rbNormal.TabIndex = 4;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Interval = 2000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.aplicaciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSalir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(180, 22);
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // aplicaciónToolStripMenuItem
            // 
            this.aplicaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuInicio,
            this.mnuParo});
            this.aplicaciónToolStripMenuItem.Name = "aplicaciónToolStripMenuItem";
            this.aplicaciónToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.aplicaciónToolStripMenuItem.Text = "Aplicación";
            // 
            // mnuInicio
            // 
            this.mnuInicio.Name = "mnuInicio";
            this.mnuInicio.Size = new System.Drawing.Size(180, 22);
            this.mnuInicio.Text = "Inicio";
            this.mnuInicio.Click += new System.EventHandler(this.mnuInicio_Click);
            // 
            // mnuParo
            // 
            this.mnuParo.Name = "mnuParo";
            this.mnuParo.Size = new System.Drawing.Size(180, 22);
            this.mnuParo.Text = "Parar";
            this.mnuParo.Click += new System.EventHandler(this.mnuParo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbTamañoFlor);
            this.Controls.Add(this.gbColorFlor);
            this.Controls.Add(this.gbAltura);
            this.Controls.Add(this.lblGeneracion);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Algoritmos Genéticos";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.gbAltura.ResumeLayout(false);
            this.gbAltura.PerformLayout();
            this.gbColorFlor.ResumeLayout(false);
            this.gbColorFlor.PerformLayout();
            this.gbTamañoFlor.ResumeLayout(false);
            this.gbTamañoFlor.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblGeneracion;
        private GroupBox gbAltura;
        private RadioButton rbBajo;
        private RadioButton rbMedio;
        private RadioButton rbAlto;
        private GroupBox gbColorFlor;
        private RadioButton rbAmarillo;
        private RadioButton rbRojo;
        private RadioButton rbAzul;
        private GroupBox gbTamañoFlor;
        private RadioButton rbGrande;
        private RadioButton rbPequeno;
        private RadioButton rbNormal;
        private System.Windows.Forms.Timer timer;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem mnuSalir;
        private ToolStripMenuItem aplicaciónToolStripMenuItem;
        private ToolStripMenuItem mnuInicio;
        private ToolStripMenuItem mnuParo;
    }
}