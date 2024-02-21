namespace VegaJuego
{
    partial class PantallaInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaInicio));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            button1 = new Button();
            checkSonido = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(512, 28);
            label1.Name = "label1";
            label1.Size = new Size(238, 19);
            label1.TabIndex = 0;
            label1.Text = "Creado por Hamza Daoudi Jaafari";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.ZeldaLogo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(521, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 123);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.LogoBueno;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(219, 207);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(594, 200);
            label2.Name = "label2";
            label2.Size = new Size(106, 19);
            label2.TabIndex = 3;
            label2.Text = "Sonido On/Off";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.BackgroundImage = Properties.Resources.Boton;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Gold;
            button1.Location = new Point(295, 383);
            button1.Name = "button1";
            button1.Size = new Size(263, 49);
            button1.TabIndex = 4;
            button1.Text = "           Comienza la aventura";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkSonido
            // 
            checkSonido.AutoSize = true;
            checkSonido.BackColor = Color.Transparent;
            checkSonido.Location = new Point(582, 203);
            checkSonido.Name = "checkSonido";
            checkSonido.Size = new Size(15, 14);
            checkSonido.TabIndex = 5;
            checkSonido.UseVisualStyleBackColor = false;
            // 
            // PantallaInicio
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.FondoPantalla;
            ClientSize = new Size(806, 467);
            Controls.Add(checkSonido);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "PantallaInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PantallaInicio";
            FormClosed += PantallaInicio_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private Button button1;
        private CheckBox checkSonido;
    }
}