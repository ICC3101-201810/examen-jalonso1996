namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonJugar = new System.Windows.Forms.Button();
            this.textBoxNombreUsuario = new System.Windows.Forms.TextBox();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.labelBienvenido = new System.Windows.Forms.Label();
            this.pictureBoxFruit = new System.Windows.Forms.PictureBox();
            this.pictureBoxPacman = new System.Windows.Forms.PictureBox();
            this.pictureBoxPink = new System.Windows.Forms.PictureBox();
            this.pictureBoxRed = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelGameO = new System.Windows.Forms.Label();
            this.buttonPuntajes = new System.Windows.Forms.Button();
            this.listBoxPuntajes = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFruit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPacman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonJugar);
            this.panel1.Controls.Add(this.textBoxNombreUsuario);
            this.panel1.Controls.Add(this.labelNombreUsuario);
            this.panel1.Controls.Add(this.labelBienvenido);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(26, 25);
            this.panel1.TabIndex = 0;
            // 
            // buttonJugar
            // 
            this.buttonJugar.Location = new System.Drawing.Point(135, 199);
            this.buttonJugar.Name = "buttonJugar";
            this.buttonJugar.Size = new System.Drawing.Size(75, 23);
            this.buttonJugar.TabIndex = 3;
            this.buttonJugar.Text = "JUGAR!";
            this.buttonJugar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonJugar.UseVisualStyleBackColor = true;
            this.buttonJugar.Click += new System.EventHandler(this.buttonJugar_Click);
            // 
            // textBoxNombreUsuario
            // 
            this.textBoxNombreUsuario.Location = new System.Drawing.Point(135, 105);
            this.textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            this.textBoxNombreUsuario.Size = new System.Drawing.Size(161, 20);
            this.textBoxNombreUsuario.TabIndex = 2;
            this.textBoxNombreUsuario.TextChanged += new System.EventHandler(this.textBoxNombreUsuario_TextChanged);
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.AutoSize = true;
            this.labelNombreUsuario.Location = new System.Drawing.Point(21, 108);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(99, 13);
            this.labelNombreUsuario.TabIndex = 1;
            this.labelNombreUsuario.Text = "Ingrese su Nombre:";
            this.labelNombreUsuario.Click += new System.EventHandler(this.labelNombreUsuario_Click);
            // 
            // labelBienvenido
            // 
            this.labelBienvenido.AutoSize = true;
            this.labelBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenido.Location = new System.Drawing.Point(79, 44);
            this.labelBienvenido.Name = "labelBienvenido";
            this.labelBienvenido.Size = new System.Drawing.Size(200, 20);
            this.labelBienvenido.TabIndex = 0;
            this.labelBienvenido.Text = "¡Bienvenido a PACMAN!";
            this.labelBienvenido.Click += new System.EventHandler(this.labelBienvenido_Click);
            // 
            // pictureBoxFruit
            // 
            this.pictureBoxFruit.Image = global::WindowsFormsApp1.Properties.Resources.cherry;
            this.pictureBoxFruit.Location = new System.Drawing.Point(213, 112);
            this.pictureBoxFruit.Name = "pictureBoxFruit";
            this.pictureBoxFruit.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxFruit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFruit.TabIndex = 3;
            this.pictureBoxFruit.TabStop = false;
            this.pictureBoxFruit.Tag = "fruit";
            this.pictureBoxFruit.Click += new System.EventHandler(this.pictureBoxFruit_Click);
            // 
            // pictureBoxPacman
            // 
            this.pictureBoxPacman.Image = global::WindowsFormsApp1.Properties.Resources.pacman_right;
            this.pictureBoxPacman.Location = new System.Drawing.Point(213, 192);
            this.pictureBoxPacman.Name = "pictureBoxPacman";
            this.pictureBoxPacman.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxPacman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPacman.TabIndex = 2;
            this.pictureBoxPacman.TabStop = false;
            this.pictureBoxPacman.Click += new System.EventHandler(this.pictureBoxPacman_Click);
            // 
            // pictureBoxPink
            // 
            this.pictureBoxPink.Image = global::WindowsFormsApp1.Properties.Resources.pink_left1;
            this.pictureBoxPink.Location = new System.Drawing.Point(95, 164);
            this.pictureBoxPink.Name = "pictureBoxPink";
            this.pictureBoxPink.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxPink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPink.TabIndex = 1;
            this.pictureBoxPink.TabStop = false;
            this.pictureBoxPink.Tag = "ghost";
            this.pictureBoxPink.Click += new System.EventHandler(this.pictureBoxPink_Click);
            // 
            // pictureBoxRed
            // 
            this.pictureBoxRed.Image = global::WindowsFormsApp1.Properties.Resources.red_left1;
            this.pictureBoxRed.Location = new System.Drawing.Point(48, 97);
            this.pictureBoxRed.Name = "pictureBoxRed";
            this.pictureBoxRed.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRed.TabIndex = 0;
            this.pictureBoxRed.TabStop = false;
            this.pictureBoxRed.Tag = "ghost";
            this.pictureBoxRed.Click += new System.EventHandler(this.pictureBoxRed_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.tile114;
            this.pictureBox1.Location = new System.Drawing.Point(107, 223);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "fruit";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(58, 12);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(0, 13);
            this.labelScore.TabIndex = 5;
            this.labelScore.Click += new System.EventHandler(this.labelScore_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelGameO
            // 
            this.labelGameO.AutoSize = true;
            this.labelGameO.Location = new System.Drawing.Point(195, 23);
            this.labelGameO.Name = "labelGameO";
            this.labelGameO.Size = new System.Drawing.Size(74, 13);
            this.labelGameO.TabIndex = 6;
            this.labelGameO.Text = "GAME OVER!";
            this.labelGameO.Click += new System.EventHandler(this.labelGameO_Click);
            // 
            // buttonPuntajes
            // 
            this.buttonPuntajes.Location = new System.Drawing.Point(361, 23);
            this.buttonPuntajes.Name = "buttonPuntajes";
            this.buttonPuntajes.Size = new System.Drawing.Size(75, 23);
            this.buttonPuntajes.TabIndex = 7;
            this.buttonPuntajes.Text = "Puntajes";
            this.buttonPuntajes.UseVisualStyleBackColor = true;
            this.buttonPuntajes.Click += new System.EventHandler(this.buttonPuntajes_Click);
            // 
            // listBoxPuntajes
            // 
            this.listBoxPuntajes.FormattingEnabled = true;
            this.listBoxPuntajes.Location = new System.Drawing.Point(339, 52);
            this.listBoxPuntajes.Name = "listBoxPuntajes";
            this.listBoxPuntajes.Size = new System.Drawing.Size(120, 95);
            this.listBoxPuntajes.TabIndex = 8;
            this.listBoxPuntajes.SelectedIndexChanged += new System.EventHandler(this.listBoxPuntajes_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 434);
            this.Controls.Add(this.listBoxPuntajes);
            this.Controls.Add(this.buttonPuntajes);
            this.Controls.Add(this.labelGameO);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.pictureBoxFruit);
            this.Controls.Add(this.pictureBoxPacman);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxPink);
            this.Controls.Add(this.pictureBoxRed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFruit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPacman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.Label labelBienvenido;
        private System.Windows.Forms.TextBox textBoxNombreUsuario;
        private System.Windows.Forms.Button buttonJugar;
        private System.Windows.Forms.PictureBox pictureBoxPacman;
        private System.Windows.Forms.PictureBox pictureBoxPink;
        private System.Windows.Forms.PictureBox pictureBoxRed;
        private System.Windows.Forms.PictureBox pictureBoxFruit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelGameO;
        private System.Windows.Forms.Button buttonPuntajes;
        private System.Windows.Forms.ListBox listBoxPuntajes;
    }
}

