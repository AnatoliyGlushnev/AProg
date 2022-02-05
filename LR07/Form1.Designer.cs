namespace LR07
{
    partial class Form_Main
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
            this.colorDialog_Pen = new System.Windows.Forms.ColorDialog();
            this.colorDialog_Brush = new System.Windows.Forms.ColorDialog();
            this.listBox_Primitives = new System.Windows.Forms.ListBox();
            this.button_ColorPen = new System.Windows.Forms.Button();
            this.button_ColorBrush = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Primitives
            // 
            this.listBox_Primitives.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_Primitives.FormattingEnabled = true;
            this.listBox_Primitives.ItemHeight = 16;
            this.listBox_Primitives.Items.AddRange(new object[] {
            "[Нет данных]",
            "50203.AS",
            "Квадрат",
            "Дуга",
            "Линия"});
            this.listBox_Primitives.Location = new System.Drawing.Point(12, 12);
            this.listBox_Primitives.Name = "listBox_Primitives";
            this.listBox_Primitives.Size = new System.Drawing.Size(159, 116);
            this.listBox_Primitives.TabIndex = 0;
            this.listBox_Primitives.SelectedIndexChanged += new System.EventHandler(this.listBox_Primitives_SelectedIndexChanged);
            // 
            // button_ColorPen
            // 
            this.button_ColorPen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_ColorPen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ColorPen.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button_ColorPen.Location = new System.Drawing.Point(12, 139);
            this.button_ColorPen.Name = "button_ColorPen";
            this.button_ColorPen.Size = new System.Drawing.Size(159, 23);
            this.button_ColorPen.TabIndex = 1;
            this.button_ColorPen.Text = "Выбор цвета линии";
            this.button_ColorPen.UseVisualStyleBackColor = false;
            this.button_ColorPen.Click += new System.EventHandler(this.button_ColorPen_Click);
            // 
            // button_ColorBrush
            // 
            this.button_ColorBrush.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_ColorBrush.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ColorBrush.Location = new System.Drawing.Point(12, 168);
            this.button_ColorBrush.Name = "button_ColorBrush";
            this.button_ColorBrush.Size = new System.Drawing.Size(159, 23);
            this.button_ColorBrush.TabIndex = 2;
            this.button_ColorBrush.Text = "Выбор цвета закрашивания";
            this.button_ColorBrush.UseVisualStyleBackColor = false;
            this.button_ColorBrush.Click += new System.EventHandler(this.button_ColorBrush_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Exit.Location = new System.Drawing.Point(12, 197);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(159, 23);
            this.button_Exit.TabIndex = 3;
            this.button_Exit.Text = "Закрыть";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(177, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(255, 208);
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(444, 226);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_ColorBrush);
            this.Controls.Add(this.button_ColorPen);
            this.Controls.Add(this.listBox_Primitives);
            this.Name = "Form_Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog_Pen;
        private System.Windows.Forms.ColorDialog colorDialog_Brush;
        private System.Windows.Forms.ListBox listBox_Primitives;
        private System.Windows.Forms.Button button_ColorPen;
        private System.Windows.Forms.Button button_ColorBrush;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

