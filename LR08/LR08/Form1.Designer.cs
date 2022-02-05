namespace LR08
{
    partial class form_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_main));
            this.listBox_Input = new System.Windows.Forms.ListBox();
            this.textbox_Letter = new System.Windows.Forms.TextBox();
            this.button_Open = new System.Windows.Forms.Button();
            this.button_FindLetter1 = new System.Windows.Forms.Button();
            this.Button_Clear = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.label_AboutInput = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu_About = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Input
            // 
            this.listBox_Input.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBox_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_Input.ForeColor = System.Drawing.SystemColors.MenuText;
            this.listBox_Input.FormattingEnabled = true;
            this.listBox_Input.Items.AddRange(new object[] {
            "[Файл > открыть] | [\"Открыть\"]"});
            this.listBox_Input.Location = new System.Drawing.Point(12, 52);
            this.listBox_Input.Name = "listBox_Input";
            this.listBox_Input.Size = new System.Drawing.Size(248, 108);
            this.listBox_Input.TabIndex = 0;
            // 
            // textbox_Letter
            // 
            this.textbox_Letter.Location = new System.Drawing.Point(12, 184);
            this.textbox_Letter.Name = "textbox_Letter";
            this.textbox_Letter.Size = new System.Drawing.Size(248, 20);
            this.textbox_Letter.TabIndex = 1;
            this.textbox_Letter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_Open
            // 
            this.button_Open.Location = new System.Drawing.Point(12, 210);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(75, 23);
            this.button_Open.TabIndex = 2;
            this.button_Open.Text = "Открыть";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // button_FindLetter1
            // 
            this.button_FindLetter1.Location = new System.Drawing.Point(185, 210);
            this.button_FindLetter1.Name = "button_FindLetter1";
            this.button_FindLetter1.Size = new System.Drawing.Size(75, 23);
            this.button_FindLetter1.TabIndex = 3;
            this.button_FindLetter1.Text = "Посчитать";
            this.button_FindLetter1.UseVisualStyleBackColor = true;
            this.button_FindLetter1.Click += new System.EventHandler(this.button_FindLetter1_Click);
            // 
            // Button_Clear
            // 
            this.Button_Clear.Location = new System.Drawing.Point(12, 239);
            this.Button_Clear.Name = "Button_Clear";
            this.Button_Clear.Size = new System.Drawing.Size(75, 23);
            this.Button_Clear.TabIndex = 4;
            this.Button_Clear.Text = "Очистить";
            this.Button_Clear.UseVisualStyleBackColor = true;
            this.Button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(185, 239);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 5;
            this.button_Exit.Text = "Выход";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // label_AboutInput
            // 
            this.label_AboutInput.AutoSize = true;
            this.label_AboutInput.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AboutInput.ForeColor = System.Drawing.SystemColors.Control;
            this.label_AboutInput.Location = new System.Drawing.Point(37, 31);
            this.label_AboutInput.Name = "label_AboutInput";
            this.label_AboutInput.Size = new System.Drawing.Size(199, 18);
            this.label_AboutInput.TabIndex = 6;
            this.label_AboutInput.Text = "Набор строк для поиска";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenu_File,
            this.ToolStripMenu_Help});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(267, 24);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "menuStrip1";
            // 
            // ToolStripMenu_File
            // 
            this.ToolStripMenu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenu_Open,
            this.ToolStripMenu_Clear,
            this.ToolStripMenu_Exit});
            this.ToolStripMenu_File.Name = "ToolStripMenu_File";
            this.ToolStripMenu_File.Size = new System.Drawing.Size(48, 20);
            this.ToolStripMenu_File.Text = "&Файл";
            // 
            // ToolStripMenu_Open
            // 
            this.ToolStripMenu_Open.Name = "ToolStripMenu_Open";
            this.ToolStripMenu_Open.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenu_Open.Text = "&Открыть";
            this.ToolStripMenu_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // ToolStripMenu_Clear
            // 
            this.ToolStripMenu_Clear.Name = "ToolStripMenu_Clear";
            this.ToolStripMenu_Clear.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenu_Clear.Text = "&Очистить";
            this.ToolStripMenu_Clear.Click += new System.EventHandler(this.ToolStripMenu_Clear_Click);
            // 
            // ToolStripMenu_Exit
            // 
            this.ToolStripMenu_Exit.Name = "ToolStripMenu_Exit";
            this.ToolStripMenu_Exit.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenu_Exit.Text = "&Выход";
            this.ToolStripMenu_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // ToolStripMenu_Help
            // 
            this.ToolStripMenu_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenu_About});
            this.ToolStripMenu_Help.Name = "ToolStripMenu_Help";
            this.ToolStripMenu_Help.Size = new System.Drawing.Size(68, 20);
            this.ToolStripMenu_Help.Text = "&Помощь";
            // 
            // ToolStripMenu_About
            // 
            this.ToolStripMenu_About.Name = "ToolStripMenu_About";
            this.ToolStripMenu_About.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenu_About.Text = "&О программе";
            this.ToolStripMenu_About.Click += new System.EventHandler(this.ToolStripMenu_About_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 277);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(267, 22);
            this.statusStrip.TabIndex = 9;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripStatusLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(196, 17);
            this.toolStripStatusLabel.Text = "Приложение загружено успешно!";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "*.txt | *.txt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(78, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Буква поиска";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 52);
            this.button1.TabIndex = 11;
            this.button1.Text = "Инд. задание";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(267, 299);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.label_AboutInput);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.Button_Clear);
            this.Controls.Add(this.button_FindLetter1);
            this.Controls.Add(this.button_Open);
            this.Controls.Add(this.textbox_Letter);
            this.Controls.Add(this.listBox_Input);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "form_main";
            this.Text = "Работа со строками";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Input;
        private System.Windows.Forms.TextBox textbox_Letter;
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.Button button_FindLetter1;
        private System.Windows.Forms.Button Button_Clear;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Label label_AboutInput;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_File;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Open;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Clear;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Exit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Help;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_About;
        private System.Windows.Forms.Button button1;
    }
}

