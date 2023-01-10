
namespace WindowsFormsApp1
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
            this.y_s = new System.Windows.Forms.TextBox();
            this.y_f = new System.Windows.Forms.TextBox();
            this.x_f = new System.Windows.Forms.TextBox();
            this.y_k = new System.Windows.Forms.TextBox();
            this.x_k = new System.Windows.Forms.TextBox();
            this.x_s = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // y_s
            // 
            this.y_s.Location = new System.Drawing.Point(248, 65);
            this.y_s.Name = "y_s";
            this.y_s.Size = new System.Drawing.Size(100, 22);
            this.y_s.TabIndex = 0;
            // 
            // y_f
            // 
            this.y_f.Location = new System.Drawing.Point(248, 121);
            this.y_f.Name = "y_f";
            this.y_f.Size = new System.Drawing.Size(100, 22);
            this.y_f.TabIndex = 1;
            // 
            // x_f
            // 
            this.x_f.Location = new System.Drawing.Point(131, 121);
            this.x_f.Name = "x_f";
            this.x_f.Size = new System.Drawing.Size(100, 22);
            this.x_f.TabIndex = 2;
            // 
            // y_k
            // 
            this.y_k.Location = new System.Drawing.Point(248, 93);
            this.y_k.Name = "y_k";
            this.y_k.Size = new System.Drawing.Size(100, 22);
            this.y_k.TabIndex = 3;
            // 
            // x_k
            // 
            this.x_k.Location = new System.Drawing.Point(131, 93);
            this.x_k.Name = "x_k";
            this.x_k.Size = new System.Drawing.Size(100, 22);
            this.x_k.TabIndex = 4;
            // 
            // x_s
            // 
            this.x_s.Location = new System.Drawing.Point(131, 65);
            this.x_s.Name = "x_s";
            this.x_s.Size = new System.Drawing.Size(100, 22);
            this.x_s.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(131, 149);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 22);
            this.result.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 261);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.x_s);
            this.Controls.Add(this.x_k);
            this.Controls.Add(this.y_k);
            this.Controls.Add(this.x_f);
            this.Controls.Add(this.y_f);
            this.Controls.Add(this.y_s);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox y_s;
        private System.Windows.Forms.TextBox y_f;
        private System.Windows.Forms.TextBox x_f;
        private System.Windows.Forms.TextBox y_k;
        private System.Windows.Forms.TextBox x_k;
        private System.Windows.Forms.TextBox x_s;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox result;
    }
}

