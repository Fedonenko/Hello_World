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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Resistor = new System.Windows.Forms.Button();
            this.Capacitor = new System.Windows.Forms.Button();
            this.Diod = new System.Windows.Forms.Button();
            this.Battary = new System.Windows.Forms.Button();
            this.Gnd = new System.Windows.Forms.Button();
            this.Connection = new System.Windows.Forms.Button();
            this.textAmperage = new System.Windows.Forms.TextBox();
            this.textResist = new System.Windows.Forms.TextBox();
            this.textCapacitance = new System.Windows.Forms.TextBox();
            this.textVoltage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ContextMenuStripPictureBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Change_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ContextMenuStripPictureBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(12, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(674, 306);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Resistor
            // 
            this.Resistor.Image = ((System.Drawing.Image)(resources.GetObject("Resistor.Image")));
            this.Resistor.Location = new System.Drawing.Point(12, 52);
            this.Resistor.Name = "Resistor";
            this.Resistor.Size = new System.Drawing.Size(34, 34);
            this.Resistor.TabIndex = 1;
            this.Resistor.UseVisualStyleBackColor = true;
            this.Resistor.Click += new System.EventHandler(this.Resistor_Click);
            // 
            // Capacitor
            // 
            this.Capacitor.Image = ((System.Drawing.Image)(resources.GetObject("Capacitor.Image")));
            this.Capacitor.Location = new System.Drawing.Point(52, 12);
            this.Capacitor.Name = "Capacitor";
            this.Capacitor.Size = new System.Drawing.Size(34, 34);
            this.Capacitor.TabIndex = 2;
            this.Capacitor.UseVisualStyleBackColor = true;
            this.Capacitor.Click += new System.EventHandler(this.Capacitor_Click);
            // 
            // Diod
            // 
            this.Diod.Image = ((System.Drawing.Image)(resources.GetObject("Diod.Image")));
            this.Diod.Location = new System.Drawing.Point(12, 12);
            this.Diod.Name = "Diod";
            this.Diod.Size = new System.Drawing.Size(34, 34);
            this.Diod.TabIndex = 3;
            this.Diod.UseVisualStyleBackColor = true;
            this.Diod.Click += new System.EventHandler(this.Diod_Click);
            // 
            // Battary
            // 
            this.Battary.Image = ((System.Drawing.Image)(resources.GetObject("Battary.Image")));
            this.Battary.Location = new System.Drawing.Point(52, 52);
            this.Battary.Name = "Battary";
            this.Battary.Size = new System.Drawing.Size(34, 34);
            this.Battary.TabIndex = 4;
            this.Battary.UseVisualStyleBackColor = true;
            this.Battary.Click += new System.EventHandler(this.Battary_Click);
            // 
            // Gnd
            // 
            this.Gnd.Image = ((System.Drawing.Image)(resources.GetObject("Gnd.Image")));
            this.Gnd.Location = new System.Drawing.Point(92, 52);
            this.Gnd.Name = "Gnd";
            this.Gnd.Size = new System.Drawing.Size(34, 34);
            this.Gnd.TabIndex = 5;
            this.Gnd.UseVisualStyleBackColor = true;
            this.Gnd.Click += new System.EventHandler(this.Gnd_Click);
            // 
            // Connection
            // 
            this.Connection.Image = ((System.Drawing.Image)(resources.GetObject("Connection.Image")));
            this.Connection.Location = new System.Drawing.Point(92, 12);
            this.Connection.Name = "Connection";
            this.Connection.Size = new System.Drawing.Size(34, 34);
            this.Connection.TabIndex = 6;
            this.Connection.UseVisualStyleBackColor = true;
            this.Connection.Click += new System.EventHandler(this.Connection_Click);
            // 
            // textAmperage
            // 
            this.textAmperage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textAmperage.Location = new System.Drawing.Point(620, 20);
            this.textAmperage.Name = "textAmperage";
            this.textAmperage.Size = new System.Drawing.Size(66, 20);
            this.textAmperage.TabIndex = 7;
            // 
            // textResist
            // 
            this.textResist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textResist.Location = new System.Drawing.Point(548, 60);
            this.textResist.Name = "textResist";
            this.textResist.Size = new System.Drawing.Size(66, 20);
            this.textResist.TabIndex = 8;
            // 
            // textCapacitance
            // 
            this.textCapacitance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textCapacitance.Location = new System.Drawing.Point(620, 60);
            this.textCapacitance.Name = "textCapacitance";
            this.textCapacitance.Size = new System.Drawing.Size(66, 20);
            this.textCapacitance.TabIndex = 9;
            // 
            // textVoltage
            // 
            this.textVoltage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textVoltage.Location = new System.Drawing.Point(548, 20);
            this.textVoltage.Name = "textVoltage";
            this.textVoltage.Size = new System.Drawing.Size(66, 20);
            this.textVoltage.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Voltage";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(635, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Amperage";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Resist";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(623, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Capacitance";
            // 
            // ContextMenuStripPictureBox
            // 
            this.ContextMenuStripPictureBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.удалитьToolStripMenuItem});
            this.ContextMenuStripPictureBox.Name = "ContextMenuStripPictureBox";
            this.ContextMenuStripPictureBox.Size = new System.Drawing.Size(134, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItem1.Text = "Повернуть";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.Turn_Figure_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.Del_Figure);
            // 
            // Change_button
            // 
            this.Change_button.Location = new System.Drawing.Point(481, 56);
            this.Change_button.Name = "Change_button";
            this.Change_button.Size = new System.Drawing.Size(58, 26);
            this.Change_button.TabIndex = 17;
            this.Change_button.Text = "Change";
            this.Change_button.UseVisualStyleBackColor = true;
            this.Change_button.Click += new System.EventHandler(this.Change_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 409);
            this.Controls.Add(this.Change_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textVoltage);
            this.Controls.Add(this.textCapacitance);
            this.Controls.Add(this.textResist);
            this.Controls.Add(this.textAmperage);
            this.Controls.Add(this.Connection);
            this.Controls.Add(this.Gnd);
            this.Controls.Add(this.Battary);
            this.Controls.Add(this.Diod);
            this.Controls.Add(this.Capacitor);
            this.Controls.Add(this.Resistor);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Цепи";
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ContextMenuStripPictureBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Resistor;
        private System.Windows.Forms.Button Capacitor;
        private System.Windows.Forms.Button Diod;
        private System.Windows.Forms.Button Battary;
        private System.Windows.Forms.Button Gnd;
        private System.Windows.Forms.Button Connection;
        private System.Windows.Forms.TextBox textAmperage;
        private System.Windows.Forms.TextBox textResist;
        private System.Windows.Forms.TextBox textCapacitance;
        private System.Windows.Forms.TextBox textVoltage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripPictureBox;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.Button Change_button;
    }
}

