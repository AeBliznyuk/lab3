
namespace lab3
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
            this.ResultLabel = new System.Windows.Forms.Label();
            this.FirstArgTextBox = new System.Windows.Forms.TextBox();
            this.SecondArgTextBox = new System.Windows.Forms.TextBox();
            this.SignLabel = new System.Windows.Forms.Label();
            this.SignTextBox = new System.Windows.Forms.TextBox();
            this.OperationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "=";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(244, 59);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 13);
            this.ResultLabel.TabIndex = 7;
            // 
            // FirstArgTextBox
            // 
            this.FirstArgTextBox.Location = new System.Drawing.Point(64, 56);
            this.FirstArgTextBox.MaxLength = 3;
            this.FirstArgTextBox.Name = "FirstArgTextBox";
            this.FirstArgTextBox.Size = new System.Drawing.Size(35, 20);
            this.FirstArgTextBox.TabIndex = 8;
            this.FirstArgTextBox.TextChanged += new System.EventHandler(this.FirstArgTextBox_TextChanged);
            this.FirstArgTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstArgTextBox_KeyPress);
            // 
            // SecondArgTextBox
            // 
            this.SecondArgTextBox.Location = new System.Drawing.Point(174, 56);
            this.SecondArgTextBox.MaxLength = 3;
            this.SecondArgTextBox.Name = "SecondArgTextBox";
            this.SecondArgTextBox.Size = new System.Drawing.Size(35, 20);
            this.SecondArgTextBox.TabIndex = 9;
            this.SecondArgTextBox.TextChanged += new System.EventHandler(this.SecondArgTextBox_TextChanged);
            this.SecondArgTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SecondArgTextBox_KeyPress);
            // 
            // SignLabel
            // 
            this.SignLabel.AutoSize = true;
            this.SignLabel.Location = new System.Drawing.Point(138, 31);
            this.SignLabel.Name = "SignLabel";
            this.SignLabel.Size = new System.Drawing.Size(0, 13);
            this.SignLabel.TabIndex = 11;
            // 
            // SignTextBox
            // 
            this.SignTextBox.Location = new System.Drawing.Point(125, 56);
            this.SignTextBox.MaxLength = 1;
            this.SignTextBox.Name = "SignTextBox";
            this.SignTextBox.Size = new System.Drawing.Size(22, 20);
            this.SignTextBox.TabIndex = 12;
            this.SignTextBox.TextChanged += new System.EventHandler(this.SignTextBox_TextChanged);
            this.SignTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SignTextBox_KeyPress);
            // 
            // OperationLabel
            // 
            this.OperationLabel.AutoSize = true;
            this.OperationLabel.Location = new System.Drawing.Point(138, 9);
            this.OperationLabel.Name = "OperationLabel";
            this.OperationLabel.Size = new System.Drawing.Size(0, 13);
            this.OperationLabel.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 120);
            this.Controls.Add(this.OperationLabel);
            this.Controls.Add(this.SignTextBox);
            this.Controls.Add(this.SignLabel);
            this.Controls.Add(this.SecondArgTextBox);
            this.Controls.Add(this.FirstArgTextBox);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox FirstArgTextBox;
        private System.Windows.Forms.TextBox SecondArgTextBox;
        private System.Windows.Forms.Label SignLabel;
        private System.Windows.Forms.TextBox SignTextBox;
        private System.Windows.Forms.Label OperationLabel;
    }
}

