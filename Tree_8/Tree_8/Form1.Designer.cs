namespace Tree_8
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.buttonSum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Результат";
            // 
            // textBoxOut
            // 
            this.textBoxOut.Location = new System.Drawing.Point(103, 67);
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.ReadOnly = true;
            this.textBoxOut.Size = new System.Drawing.Size(475, 20);
            this.textBoxOut.TabIndex = 19;
            // 
            // buttonSum
            // 
            this.buttonSum.Location = new System.Drawing.Point(12, 38);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(566, 23);
            this.buttonSum.TabIndex = 18;
            this.buttonSum.Text = "Обійти";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Вхід";
            // 
            // textBoxIn
            // 
            this.textBoxIn.Location = new System.Drawing.Point(48, 12);
            this.textBoxIn.Name = "textBoxIn";
            this.textBoxIn.Size = new System.Drawing.Size(530, 20);
            this.textBoxIn.TabIndex = 16;
            this.textBoxIn.Text = "[1,2,4,null,null,5,null,null,3,6,null,null,7,null,null]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 97);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxOut);
            this.Controls.Add(this.buttonSum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIn);
            this.Name = "Form1";
            this.Text = "Tree_8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIn;
    }
}

