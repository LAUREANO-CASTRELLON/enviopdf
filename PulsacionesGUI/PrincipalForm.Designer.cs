namespace PulsacionesGUI
{
    partial class PrincipalForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pulsacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarPersonaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pulsacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(502, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pulsacionesToolStripMenuItem
            // 
            this.pulsacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarPersonaToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.consultarToolStripMenuItem1});
            this.pulsacionesToolStripMenuItem.Name = "pulsacionesToolStripMenuItem";
            this.pulsacionesToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.pulsacionesToolStripMenuItem.Text = "Pulsaciones";
            this.pulsacionesToolStripMenuItem.Click += new System.EventHandler(this.pulsacionesToolStripMenuItem_Click);
            // 
            // ingresarPersonaToolStripMenuItem
            // 
            this.ingresarPersonaToolStripMenuItem.Name = "ingresarPersonaToolStripMenuItem";
            this.ingresarPersonaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ingresarPersonaToolStripMenuItem.Text = "Ingresar Persona";
            this.ingresarPersonaToolStripMenuItem.Click += new System.EventHandler(this.ingresarPersonaToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarToolStripMenuItem.Text = "Consultar Persona";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem1
            // 
            this.consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            this.consultarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.consultarToolStripMenuItem1.Text = "Consultar";
            this.consultarToolStripMenuItem1.Click += new System.EventHandler(this.consultarToolStripMenuItem1_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(502, 468);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pulsacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarPersonaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem1;
    }
}

