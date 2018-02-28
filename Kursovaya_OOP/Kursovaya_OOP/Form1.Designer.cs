namespace Kursovaya_OOP
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Resistor = new System.Windows.Forms.Button();
            this.Capacitor = new System.Windows.Forms.Button();
            this.Diod = new System.Windows.Forms.Button();
            this.Battary = new System.Windows.Forms.Button();
            this.Gnd = new System.Windows.Forms.Button();
            this.Connection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(12, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(674, 340);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Resistor
            // 
            this.Resistor.Location = new System.Drawing.Point(16, 17);
            this.Resistor.Name = "Resistor";
            this.Resistor.Size = new System.Drawing.Size(74, 22);
            this.Resistor.TabIndex = 1;
            this.Resistor.Text = "resistor";
            this.Resistor.UseVisualStyleBackColor = true;
            this.Resistor.Click += new System.EventHandler(this.Resistor_Click);
            // 
            // Capacitor
            // 
            this.Capacitor.Location = new System.Drawing.Point(96, 17);
            this.Capacitor.Name = "Capacitor";
            this.Capacitor.Size = new System.Drawing.Size(83, 22);
            this.Capacitor.TabIndex = 2;
            this.Capacitor.Text = "capacitor";
            this.Capacitor.UseVisualStyleBackColor = true;
            this.Capacitor.Click += new System.EventHandler(this.Capacitor_Click);
            // 
            // Diod
            // 
            this.Diod.Location = new System.Drawing.Point(185, 17);
            this.Diod.Name = "Diod";
            this.Diod.Size = new System.Drawing.Size(78, 22);
            this.Diod.TabIndex = 3;
            this.Diod.Text = "diod";
            this.Diod.UseVisualStyleBackColor = true;
            this.Diod.Click += new System.EventHandler(this.Diod_Click);
            // 
            // Battary
            // 
            this.Battary.Location = new System.Drawing.Point(269, 17);
            this.Battary.Name = "Battary";
            this.Battary.Size = new System.Drawing.Size(71, 22);
            this.Battary.TabIndex = 4;
            this.Battary.Text = "battary";
            this.Battary.UseVisualStyleBackColor = true;
            this.Battary.Click += new System.EventHandler(this.Battary_Click);
            // 
            // Gnd
            // 
            this.Gnd.Location = new System.Drawing.Point(346, 17);
            this.Gnd.Name = "Gnd";
            this.Gnd.Size = new System.Drawing.Size(66, 22);
            this.Gnd.TabIndex = 5;
            this.Gnd.Text = "gnd";
            this.Gnd.UseVisualStyleBackColor = true;
            this.Gnd.Click += new System.EventHandler(this.Gnd_Click);
            // 
            // Connection
            // 
            this.Connection.Location = new System.Drawing.Point(418, 17);
            this.Connection.Name = "Connection";
            this.Connection.Size = new System.Drawing.Size(62, 22);
            this.Connection.TabIndex = 6;
            this.Connection.Text = "connect";
            this.Connection.UseVisualStyleBackColor = true;
            this.Connection.Click += new System.EventHandler(this.Connection_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 409);
            this.Controls.Add(this.Connection);
            this.Controls.Add(this.Gnd);
            this.Controls.Add(this.Battary);
            this.Controls.Add(this.Diod);
            this.Controls.Add(this.Capacitor);
            this.Controls.Add(this.Resistor);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Resistor;
        private System.Windows.Forms.Button Capacitor;
        private System.Windows.Forms.Button Diod;
        private System.Windows.Forms.Button Battary;
        private System.Windows.Forms.Button Gnd;
        private System.Windows.Forms.Button Connection;
    }
}

