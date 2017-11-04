namespace CalcWinForm
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
            this.text_a = new System.Windows.Forms.TextBox();
            this.text_b = new System.Windows.Forms.TextBox();
            this.text_op = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_res = new System.Windows.Forms.TextBox();
            this.btn_res = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_a
            // 
            this.text_a.Location = new System.Drawing.Point(116, 28);
            this.text_a.Name = "text_a";
            this.text_a.Size = new System.Drawing.Size(100, 20);
            this.text_a.TabIndex = 0;
            // 
            // text_b
            // 
            this.text_b.Location = new System.Drawing.Point(116, 68);
            this.text_b.Name = "text_b";
            this.text_b.Size = new System.Drawing.Size(100, 20);
            this.text_b.TabIndex = 1;
            // 
            // text_op
            // 
            this.text_op.Location = new System.Drawing.Point(116, 108);
            this.text_op.Name = "text_op";
            this.text_op.Size = new System.Drawing.Size(100, 20);
            this.text_op.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(75, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(75, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(75, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "op";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(75, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "res";
            // 
            // text_res
            // 
            this.text_res.Location = new System.Drawing.Point(116, 152);
            this.text_res.Name = "text_res";
            this.text_res.Size = new System.Drawing.Size(100, 20);
            this.text_res.TabIndex = 7;
            // 
            // btn_res
            // 
            this.btn_res.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_res.Location = new System.Drawing.Point(126, 193);
            this.btn_res.Name = "btn_res";
            this.btn_res.Size = new System.Drawing.Size(75, 23);
            this.btn_res.TabIndex = 8;
            this.btn_res.Text = "result";
            this.btn_res.UseVisualStyleBackColor = true;
            this.btn_res.Click += new System.EventHandler(this.btn_res_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_res);
            this.Controls.Add(this.text_res);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_op);
            this.Controls.Add(this.text_b);
            this.Controls.Add(this.text_a);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_a;
        private System.Windows.Forms.TextBox text_b;
        private System.Windows.Forms.TextBox text_op;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_res;
        private System.Windows.Forms.Button btn_res;
    }
}

