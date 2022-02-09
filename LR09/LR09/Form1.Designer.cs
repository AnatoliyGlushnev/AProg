namespace LR09
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.panel_Variants = new System.Windows.Forms.Panel();
            this.radioButton_VariantTask = new System.Windows.Forms.RadioButton();
            this.radioButton_VariantDefault = new System.Windows.Forms.RadioButton();
            this.button_CheckVariant = new System.Windows.Forms.Button();
            this.button_FindAllLucky = new System.Windows.Forms.Button();
            this.listBox_Enumerate = new System.Windows.Forms.ListBox();
            this.panel_Variants.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Input
            // 
            this.textBox_Input.Location = new System.Drawing.Point(12, 12);
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.Size = new System.Drawing.Size(149, 20);
            this.textBox_Input.TabIndex = 0;
            // 
            // panel_Variants
            // 
            this.panel_Variants.Controls.Add(this.radioButton_VariantTask);
            this.panel_Variants.Controls.Add(this.radioButton_VariantDefault);
            this.panel_Variants.Location = new System.Drawing.Point(12, 38);
            this.panel_Variants.Name = "panel_Variants";
            this.panel_Variants.Size = new System.Drawing.Size(150, 59);
            this.panel_Variants.TabIndex = 1;
            // 
            // radioButton_VariantTask
            // 
            this.radioButton_VariantTask.AutoSize = true;
            this.radioButton_VariantTask.Location = new System.Drawing.Point(8, 31);
            this.radioButton_VariantTask.Name = "radioButton_VariantTask";
            this.radioButton_VariantTask.Size = new System.Drawing.Size(129, 17);
            this.radioButton_VariantTask.TabIndex = 1;
            this.radioButton_VariantTask.Text = "Вариант по заданию";
            this.radioButton_VariantTask.UseVisualStyleBackColor = true;
            // 
            // radioButton_VariantDefault
            // 
            this.radioButton_VariantDefault.AutoSize = true;
            this.radioButton_VariantDefault.Checked = true;
            this.radioButton_VariantDefault.Location = new System.Drawing.Point(8, 8);
            this.radioButton_VariantDefault.Name = "radioButton_VariantDefault";
            this.radioButton_VariantDefault.Size = new System.Drawing.Size(141, 17);
            this.radioButton_VariantDefault.TabIndex = 0;
            this.radioButton_VariantDefault.TabStop = true;
            this.radioButton_VariantDefault.Text = "Вариант по умолчанию";
            this.radioButton_VariantDefault.UseVisualStyleBackColor = true;
            this.radioButton_VariantDefault.CheckedChanged += new System.EventHandler(this.radioButton_VriantDefault_CheckedChanged);
            // 
            // button_CheckVariant
            // 
            this.button_CheckVariant.Location = new System.Drawing.Point(11, 101);
            this.button_CheckVariant.Name = "button_CheckVariant";
            this.button_CheckVariant.Size = new System.Drawing.Size(150, 34);
            this.button_CheckVariant.TabIndex = 2;
            this.button_CheckVariant.Text = "Проверить вариант";
            this.button_CheckVariant.UseVisualStyleBackColor = true;
            this.button_CheckVariant.Click += new System.EventHandler(this.button_CheckVariant_Click);
            // 
            // button_FindAllLucky
            // 
            this.button_FindAllLucky.Location = new System.Drawing.Point(12, 135);
            this.button_FindAllLucky.Name = "button_FindAllLucky";
            this.button_FindAllLucky.Size = new System.Drawing.Size(150, 37);
            this.button_FindAllLucky.TabIndex = 3;
            this.button_FindAllLucky.Text = "Найти все счастлилвые числа";
            this.button_FindAllLucky.UseVisualStyleBackColor = true;
            this.button_FindAllLucky.Click += new System.EventHandler(this.button_FindAllLucky_Click);
            // 
            // listBox_Enumerate
            // 
            this.listBox_Enumerate.FormattingEnabled = true;
            this.listBox_Enumerate.Items.AddRange(new object[] {
            " "});
            this.listBox_Enumerate.Location = new System.Drawing.Point(168, 12);
            this.listBox_Enumerate.Name = "listBox_Enumerate";
            this.listBox_Enumerate.Size = new System.Drawing.Size(120, 160);
            this.listBox_Enumerate.TabIndex = 4;
            this.listBox_Enumerate.SelectedIndexChanged += new System.EventHandler(this.listBox_Enumerate_SelectedIndexChanged);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(294, 179);
            this.Controls.Add(this.listBox_Enumerate);
            this.Controls.Add(this.button_FindAllLucky);
            this.Controls.Add(this.button_CheckVariant);
            this.Controls.Add(this.panel_Variants);
            this.Controls.Add(this.textBox_Input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Main";
            this.Text = "Проверка счстливого билета";
            this.panel_Variants.ResumeLayout(false);
            this.panel_Variants.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.Panel panel_Variants;
        private System.Windows.Forms.RadioButton radioButton_VariantTask;
        private System.Windows.Forms.RadioButton radioButton_VariantDefault;
        private System.Windows.Forms.Button button_CheckVariant;
        private System.Windows.Forms.Button button_FindAllLucky;
        private System.Windows.Forms.ListBox listBox_Enumerate;
    }
}

