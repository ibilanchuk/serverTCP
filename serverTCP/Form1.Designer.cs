namespace serverTCP
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
            this.text_Port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DisConncet = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Conncet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_Port
            // 
            this.text_Port.Location = new System.Drawing.Point(113, 42);
            this.text_Port.Name = "text_Port";
            this.text_Port.Size = new System.Drawing.Size(104, 20);
            this.text_Port.TabIndex = 21;
            this.text_Port.Text = "5000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Port";
            // 
            // DisConncet
            // 
            this.DisConncet.Enabled = false;
            this.DisConncet.Location = new System.Drawing.Point(338, 40);
            this.DisConncet.Name = "DisConncet";
            this.DisConncet.Size = new System.Drawing.Size(76, 23);
            this.DisConncet.TabIndex = 19;
            this.DisConncet.Text = "Disconnect";
            this.DisConncet.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(78, 68);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(370, 160);
            this.listBox1.TabIndex = 18;
            // 
            // Conncet
            // 
            this.Conncet.Location = new System.Drawing.Point(223, 39);
            this.Conncet.Name = "Conncet";
            this.Conncet.Size = new System.Drawing.Size(109, 23);
            this.Conncet.TabIndex = 17;
            this.Conncet.Text = "Start The Server";
            this.Conncet.UseVisualStyleBackColor = true;
            this.Conncet.Click += new System.EventHandler(this.Conncet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 267);
            this.Controls.Add(this.text_Port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DisConncet);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Conncet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_Port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DisConncet;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Conncet;
    }
}

