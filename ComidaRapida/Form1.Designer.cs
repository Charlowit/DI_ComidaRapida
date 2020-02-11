namespace ComidaRapida
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnComplementos = new System.Windows.Forms.Button();
            this.btnBebidas = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panelControlDeUsuario = new System.Windows.Forms.Panel();
            this.controlCarrito1 = new ComidaRapida.ControlCarrito();
            this.controlInicio1 = new ComidaRapida.ControlInicio();
            this.controldePostres1 = new ComidaRapida.ControldePostres();
            this.controlComplementos1 = new ComidaRapida.ControlComplementos();
            this.controlBebidas1 = new ComidaRapida.ControlBebidas();
            this.controlHamburguesas1 = new ComidaRapida.ControlHamburguesas();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelControlDeUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnComplementos);
            this.panel1.Controls.Add(this.btnBebidas);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 611);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Location = new System.Drawing.Point(0, 434);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(175, 177);
            this.panel6.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(175, 177);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 64);
            this.button1.TabIndex = 4;
            this.button1.Text = "Postres";
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnComplementos
            // 
            this.btnComplementos.FlatAppearance.BorderSize = 0;
            this.btnComplementos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplementos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplementos.Location = new System.Drawing.Point(0, 247);
            this.btnComplementos.Name = "btnComplementos";
            this.btnComplementos.Size = new System.Drawing.Size(175, 64);
            this.btnComplementos.TabIndex = 3;
            this.btnComplementos.Text = "Complementos";
            this.btnComplementos.UseVisualStyleBackColor = true;
            this.btnComplementos.Click += new System.EventHandler(this.btnComplementos_Click);
            // 
            // btnBebidas
            // 
            this.btnBebidas.FlatAppearance.BorderSize = 0;
            this.btnBebidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBebidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBebidas.Location = new System.Drawing.Point(0, 183);
            this.btnBebidas.Name = "btnBebidas";
            this.btnBebidas.Size = new System.Drawing.Size(175, 64);
            this.btnBebidas.TabIndex = 2;
            this.btnBebidas.Text = "Bebidas";
            this.btnBebidas.UseVisualStyleBackColor = true;
            this.btnBebidas.Click += new System.EventHandler(this.btnBebidas_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(0, 119);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(175, 64);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Hamburguesas";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 65);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(174, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(904, 543);
            this.panel4.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Location = new System.Drawing.Point(176, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(907, 65);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button2);
            this.panel5.Location = new System.Drawing.Point(729, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(103, 65);
            this.panel5.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 65);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelControlDeUsuario
            // 
            this.panelControlDeUsuario.Controls.Add(this.controlCarrito1);
            this.panelControlDeUsuario.Controls.Add(this.controlInicio1);
            this.panelControlDeUsuario.Controls.Add(this.controldePostres1);
            this.panelControlDeUsuario.Controls.Add(this.controlComplementos1);
            this.panelControlDeUsuario.Controls.Add(this.controlBebidas1);
            this.panelControlDeUsuario.Controls.Add(this.controlHamburguesas1);
            this.panelControlDeUsuario.Location = new System.Drawing.Point(174, 65);
            this.panelControlDeUsuario.Name = "panelControlDeUsuario";
            this.panelControlDeUsuario.Size = new System.Drawing.Size(907, 546);
            this.panelControlDeUsuario.TabIndex = 2;
            // 
            // controlCarrito1
            // 
            this.controlCarrito1.BackColor = System.Drawing.Color.Gold;
            this.controlCarrito1.Location = new System.Drawing.Point(0, -1);
            this.controlCarrito1.Name = "controlCarrito1";
            this.controlCarrito1.Size = new System.Drawing.Size(909, 547);
            this.controlCarrito1.TabIndex = 5;
            // 
            // controlInicio1
            // 
            this.controlInicio1.BackColor = System.Drawing.Color.Gold;
            this.controlInicio1.Location = new System.Drawing.Point(0, 0);
            this.controlInicio1.Name = "controlInicio1";
            this.controlInicio1.Size = new System.Drawing.Size(909, 546);
            this.controlInicio1.TabIndex = 4;
            // 
            // controldePostres1
            // 
            this.controldePostres1.BackColor = System.Drawing.Color.Gold;
            this.controldePostres1.Location = new System.Drawing.Point(2, -1);
            this.controldePostres1.Name = "controldePostres1";
            this.controldePostres1.Size = new System.Drawing.Size(904, 546);
            this.controldePostres1.TabIndex = 3;
            // 
            // controlComplementos1
            // 
            this.controlComplementos1.BackColor = System.Drawing.Color.Gold;
            this.controlComplementos1.Location = new System.Drawing.Point(0, 0);
            this.controlComplementos1.Name = "controlComplementos1";
            this.controlComplementos1.Size = new System.Drawing.Size(907, 546);
            this.controlComplementos1.TabIndex = 2;
            // 
            // controlBebidas1
            // 
            this.controlBebidas1.BackColor = System.Drawing.Color.Gold;
            this.controlBebidas1.Location = new System.Drawing.Point(3, 0);
            this.controlBebidas1.Name = "controlBebidas1";
            this.controlBebidas1.Size = new System.Drawing.Size(904, 546);
            this.controlBebidas1.TabIndex = 1;
            // 
            // controlHamburguesas1
            // 
            this.controlHamburguesas1.BackColor = System.Drawing.Color.Gold;
            this.controlHamburguesas1.Location = new System.Drawing.Point(0, 0);
            this.controlHamburguesas1.Name = "controlHamburguesas1";
            this.controlHamburguesas1.Size = new System.Drawing.Size(907, 546);
            this.controlHamburguesas1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 611);
            this.Controls.Add(this.panelControlDeUsuario);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comida Rápida";
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panelControlDeUsuario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnComplementos;
        private System.Windows.Forms.Button btnBebidas;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelControlDeUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ControlHamburguesas controlHamburguesas1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ControlBebidas controlBebidas1;
        private ControldePostres controldePostres1;
        private ControlComplementos controlComplementos1;
        private ControlInicio controlInicio1;
        private System.Windows.Forms.Button button2;
        private ControlCarrito controlCarrito1;
    }
}

