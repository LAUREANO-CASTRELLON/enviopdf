namespace PulsacionesGUI
{
    partial class ConsultarTodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarTodo));
            this.DtgPersona = new System.Windows.Forms.DataGridView();
            this.ConsultarCmb = new System.Windows.Forms.ComboBox();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.TotalMujeresTxt = new System.Windows.Forms.TextBox();
            this.TotalHombreTxt = new System.Windows.Forms.TextBox();
            this.TotalTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.TxtAdjuntarArchivo = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgPersona
            // 
            this.DtgPersona.BackgroundColor = System.Drawing.Color.LightGray;
            this.DtgPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgPersona.Location = new System.Drawing.Point(113, 91);
            this.DtgPersona.Name = "DtgPersona";
            this.DtgPersona.Size = new System.Drawing.Size(526, 154);
            this.DtgPersona.TabIndex = 0;
            this.DtgPersona.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgPersona_CellContentClick);
            // 
            // ConsultarCmb
            // 
            this.ConsultarCmb.FormattingEnabled = true;
            this.ConsultarCmb.Items.AddRange(new object[] {
            "Mujeres",
            "Hombres",
            "Todos"});
            this.ConsultarCmb.Location = new System.Drawing.Point(273, 39);
            this.ConsultarCmb.Name = "ConsultarCmb";
            this.ConsultarCmb.Size = new System.Drawing.Size(121, 21);
            this.ConsultarCmb.TabIndex = 35;
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.BackColor = System.Drawing.Color.Transparent;
            this.BuscarBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BuscarBtn.BackgroundImage")));
            this.BuscarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BuscarBtn.Location = new System.Drawing.Point(400, 34);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(26, 28);
            this.BuscarBtn.TabIndex = 36;
            this.BuscarBtn.UseVisualStyleBackColor = false;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // TotalMujeresTxt
            // 
            this.TotalMujeresTxt.Location = new System.Drawing.Point(660, 218);
            this.TotalMujeresTxt.Name = "TotalMujeresTxt";
            this.TotalMujeresTxt.Size = new System.Drawing.Size(100, 20);
            this.TotalMujeresTxt.TabIndex = 37;
            this.TotalMujeresTxt.TextChanged += new System.EventHandler(this.NombreTxt_TextChanged);
            // 
            // TotalHombreTxt
            // 
            this.TotalHombreTxt.Location = new System.Drawing.Point(660, 162);
            this.TotalHombreTxt.Name = "TotalHombreTxt";
            this.TotalHombreTxt.Size = new System.Drawing.Size(100, 20);
            this.TotalHombreTxt.TabIndex = 38;
            this.TotalHombreTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TotalTxt
            // 
            this.TotalTxt.Location = new System.Drawing.Point(660, 110);
            this.TotalTxt.Name = "TotalTxt";
            this.TotalTxt.Size = new System.Drawing.Size(100, 20);
            this.TotalTxt.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(657, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(657, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Total Hombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(657, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Total Mujeres";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 99);
            this.button1.TabIndex = 44;
            this.button1.Text = "Guardar PDF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(315, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 99);
            this.button2.TabIndex = 45;
            this.button2.Text = "Enviar Correo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(326, 390);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(100, 20);
            this.TxtCorreo.TabIndex = 46;
            // 
            // TxtAdjuntarArchivo
            // 
            this.TxtAdjuntarArchivo.Location = new System.Drawing.Point(529, 390);
            this.TxtAdjuntarArchivo.Name = "TxtAdjuntarArchivo";
            this.TxtAdjuntarArchivo.Size = new System.Drawing.Size(100, 20);
            this.TxtAdjuntarArchivo.TabIndex = 47;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(509, 285);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 99);
            this.button3.TabIndex = 48;
            this.button3.Text = "Examinar equipo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ConsultarTodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.TxtAdjuntarArchivo);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TotalTxt);
            this.Controls.Add(this.TotalHombreTxt);
            this.Controls.Add(this.TotalMujeresTxt);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.ConsultarCmb);
            this.Controls.Add(this.DtgPersona);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ConsultarTodo";
            this.Text = "ConsultarTodo";
            ((System.ComponentModel.ISupportInitialize)(this.DtgPersona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgPersona;
        private System.Windows.Forms.ComboBox ConsultarCmb;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.TextBox TotalMujeresTxt;
        private System.Windows.Forms.TextBox TotalHombreTxt;
        private System.Windows.Forms.TextBox TotalTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.TextBox TxtAdjuntarArchivo;
        private System.Windows.Forms.Button button3;
    }
}