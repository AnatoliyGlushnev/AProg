namespace LR06
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
            this.hScrollBar_Red = new System.Windows.Forms.HScrollBar();
            this.hScrollBar_Green = new System.Windows.Forms.HScrollBar();
            this.hScrollBar_Blue = new System.Windows.Forms.HScrollBar();
            this.textBox_Red = new System.Windows.Forms.TextBox();
            this.textBox_Green = new System.Windows.Forms.TextBox();
            this.textBox_Blue = new System.Windows.Forms.TextBox();
            this.panel_Colored = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Button_Color = new System.Windows.Forms.Button();
            this.colorDialog1_ChooseColor = new System.Windows.Forms.ColorDialog();
            this.panel_Colored.SuspendLayout();
            this.SuspendLayout();
            // 
            // hScrollBar_Red
            // 
            this.hScrollBar_Red.LargeChange = 1;
            this.hScrollBar_Red.Location = new System.Drawing.Point(9, 148);
            this.hScrollBar_Red.Maximum = 255;
            this.hScrollBar_Red.Name = "hScrollBar_Red";
            this.hScrollBar_Red.Size = new System.Drawing.Size(224, 23);
            this.hScrollBar_Red.TabIndex = 0;
            this.hScrollBar_Red.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // hScrollBar_Green
            // 
            this.hScrollBar_Green.LargeChange = 1;
            this.hScrollBar_Green.Location = new System.Drawing.Point(9, 203);
            this.hScrollBar_Green.Maximum = 255;
            this.hScrollBar_Green.Name = "hScrollBar_Green";
            this.hScrollBar_Green.Size = new System.Drawing.Size(224, 23);
            this.hScrollBar_Green.TabIndex = 1;
            this.hScrollBar_Green.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar_Green_Scroll);
            // 
            // hScrollBar_Blue
            // 
            this.hScrollBar_Blue.LargeChange = 1;
            this.hScrollBar_Blue.Location = new System.Drawing.Point(9, 268);
            this.hScrollBar_Blue.Maximum = 255;
            this.hScrollBar_Blue.Name = "hScrollBar_Blue";
            this.hScrollBar_Blue.Size = new System.Drawing.Size(224, 23);
            this.hScrollBar_Blue.TabIndex = 2;
            this.hScrollBar_Blue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar_Blue_Scroll);
            // 
            // textBox_Red
            // 
            this.textBox_Red.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_Red.Location = new System.Drawing.Point(246, 151);
            this.textBox_Red.Name = "textBox_Red";
            this.textBox_Red.ReadOnly = true;
            this.textBox_Red.Size = new System.Drawing.Size(113, 20);
            this.textBox_Red.TabIndex = 3;
            this.textBox_Red.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Green
            // 
            this.textBox_Green.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_Green.Location = new System.Drawing.Point(246, 206);
            this.textBox_Green.Name = "textBox_Green";
            this.textBox_Green.ReadOnly = true;
            this.textBox_Green.Size = new System.Drawing.Size(113, 20);
            this.textBox_Green.TabIndex = 4;
            this.textBox_Green.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Blue
            // 
            this.textBox_Blue.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_Blue.Location = new System.Drawing.Point(246, 271);
            this.textBox_Blue.Name = "textBox_Blue";
            this.textBox_Blue.ReadOnly = true;
            this.textBox_Blue.Size = new System.Drawing.Size(113, 20);
            this.textBox_Blue.TabIndex = 5;
            this.textBox_Blue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel_Colored
            // 
            this.panel_Colored.Controls.Add(this.label4);
            this.panel_Colored.Location = new System.Drawing.Point(12, 12);
            this.panel_Colored.Name = "panel_Colored";
            this.panel_Colored.Size = new System.Drawing.Size(334, 100);
            this.panel_Colored.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(107, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Control Color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(8, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(8, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(8, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Blue";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Задание";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Button_Color
            // 
            this.Button_Color.Location = new System.Drawing.Point(246, 309);
            this.Button_Color.Name = "Button_Color";
            this.Button_Color.Size = new System.Drawing.Size(113, 23);
            this.Button_Color.TabIndex = 11;
            this.Button_Color.Text = "Выбрать цвет";
            this.Button_Color.UseVisualStyleBackColor = true;
            this.Button_Color.Click += new System.EventHandler(this.Button_Color_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(369, 341);
            this.Controls.Add(this.Button_Color);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_Colored);
            this.Controls.Add(this.textBox_Blue);
            this.Controls.Add(this.textBox_Green);
            this.Controls.Add(this.textBox_Red);
            this.Controls.Add(this.hScrollBar_Blue);
            this.Controls.Add(this.hScrollBar_Green);
            this.Controls.Add(this.hScrollBar_Red);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_Colored.ResumeLayout(false);
            this.panel_Colored.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hScrollBar_Red;
        private System.Windows.Forms.HScrollBar hScrollBar_Green;
        private System.Windows.Forms.HScrollBar hScrollBar_Blue;
        private System.Windows.Forms.TextBox textBox_Red;
        private System.Windows.Forms.TextBox textBox_Green;
        private System.Windows.Forms.TextBox textBox_Blue;
        private System.Windows.Forms.Panel panel_Colored;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Button_Color;
        private System.Windows.Forms.ColorDialog colorDialog1_ChooseColor;
    }
}

