namespace Tree_5
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
            this.textBoxIn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSerialize = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxIn
            // 
            this.textBoxIn.Location = new System.Drawing.Point(51, 13);
            this.textBoxIn.Name = "textBoxIn";
            this.textBoxIn.Size = new System.Drawing.Size(530, 20);
            this.textBoxIn.TabIndex = 0;
            this.textBoxIn.Text = "[1,2,3,null,null,4,null,null,5,null,null]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вхід";
            // 
            // buttonSerialize
            // 
            this.buttonSerialize.Location = new System.Drawing.Point(15, 39);
            this.buttonSerialize.Name = "buttonSerialize";
            this.buttonSerialize.Size = new System.Drawing.Size(566, 23);
            this.buttonSerialize.TabIndex = 2;
            this.buttonSerialize.Text = "Перевести";
            this.buttonSerialize.UseVisualStyleBackColor = true;
            this.buttonSerialize.Click += new System.EventHandler(this.buttonSerialize_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Вихід";
            // 
            // textBoxOut
            // 
            this.textBoxOut.Location = new System.Drawing.Point(51, 68);
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.ReadOnly = true;
            this.textBoxOut.Size = new System.Drawing.Size(530, 20);
            this.textBoxOut.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(587, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Важливо: без пробілів";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 98);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxOut);
            this.Controls.Add(this.buttonSerialize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIn);
            this.Name = "Form1";
            this.Text = "Tree_5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSerialize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.Label label3;
    }
}

