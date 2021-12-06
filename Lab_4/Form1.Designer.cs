namespace Lab_4
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
            this.textInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.krn_Output = new System.Windows.Forms.Label();
            this.errorLable = new System.Windows.Forms.Label();
            this.H_Matrix = new System.Windows.Forms.Label();
            this.GOutput = new System.Windows.Forms.Label();
            this.BOutput = new System.Windows.Forms.Label();
            this.ErBOutput = new System.Windows.Forms.Label();
            this.SOutput = new System.Windows.Forms.Label();
            this.ResOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(56, 10);
            this.textInput.Margin = new System.Windows.Forms.Padding(4);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(357, 22);
            this.textInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "a =";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(423, 7);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(100, 28);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Начать";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // krn_Output
            // 
            this.krn_Output.AutoSize = true;
            this.krn_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krn_Output.Location = new System.Drawing.Point(681, 11);
            this.krn_Output.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.krn_Output.Name = "krn_Output";
            this.krn_Output.Size = new System.Drawing.Size(0, 20);
            this.krn_Output.TabIndex = 3;
            // 
            // errorLable
            // 
            this.errorLable.AutoSize = true;
            this.errorLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLable.ForeColor = System.Drawing.Color.Red;
            this.errorLable.Location = new System.Drawing.Point(139, 45);
            this.errorLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLable.Name = "errorLable";
            this.errorLable.Size = new System.Drawing.Size(179, 20);
            this.errorLable.TabIndex = 4;
            this.errorLable.Text = "Некорректный ввод";
            this.errorLable.Visible = false;
            // 
            // H_Matrix
            // 
            this.H_Matrix.AutoSize = true;
            this.H_Matrix.Location = new System.Drawing.Point(59, 86);
            this.H_Matrix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.H_Matrix.Name = "H_Matrix";
            this.H_Matrix.Size = new System.Drawing.Size(0, 17);
            this.H_Matrix.TabIndex = 5;
            // 
            // GOutput
            // 
            this.GOutput.AutoSize = true;
            this.GOutput.Location = new System.Drawing.Point(59, 121);
            this.GOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GOutput.Name = "GOutput";
            this.GOutput.Size = new System.Drawing.Size(0, 17);
            this.GOutput.TabIndex = 7;
            // 
            // BOutput
            // 
            this.BOutput.AutoSize = true;
            this.BOutput.Location = new System.Drawing.Point(59, 203);
            this.BOutput.Name = "BOutput";
            this.BOutput.Size = new System.Drawing.Size(0, 17);
            this.BOutput.TabIndex = 9;
            this.BOutput.Click += new System.EventHandler(this.BOutput_Click);
            // 
            // ErBOutput
            // 
            this.ErBOutput.AutoSize = true;
            this.ErBOutput.Location = new System.Drawing.Point(59, 290);
            this.ErBOutput.Name = "ErBOutput";
            this.ErBOutput.Size = new System.Drawing.Size(0, 17);
            this.ErBOutput.TabIndex = 10;
            // 
            // SOutput
            // 
            this.SOutput.AutoSize = true;
            this.SOutput.Location = new System.Drawing.Point(59, 333);
            this.SOutput.Name = "SOutput";
            this.SOutput.Size = new System.Drawing.Size(0, 17);
            this.SOutput.TabIndex = 11;
            // 
            // ResOutput
            // 
            this.ResOutput.AutoSize = true;
            this.ResOutput.Location = new System.Drawing.Point(59, 408);
            this.ResOutput.Name = "ResOutput";
            this.ResOutput.Size = new System.Drawing.Size(0, 17);
            this.ResOutput.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 634);
            this.Controls.Add(this.ResOutput);
            this.Controls.Add(this.SOutput);
            this.Controls.Add(this.ErBOutput);
            this.Controls.Add(this.BOutput);
            this.Controls.Add(this.GOutput);
            this.Controls.Add(this.H_Matrix);
            this.Controls.Add(this.errorLable);
            this.Controls.Add(this.krn_Output);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textInput);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label krn_Output;
        private System.Windows.Forms.Label errorLable;
        private System.Windows.Forms.Label H_Matrix;
        private System.Windows.Forms.Label GOutput;
        private System.Windows.Forms.Label BOutput;
        private System.Windows.Forms.Label ErBOutput;
        private System.Windows.Forms.Label SOutput;
        private System.Windows.Forms.Label ResOutput;
    }
}

