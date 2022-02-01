namespace Pichugin_Test_TeamIdea
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1_CurrencyConvertor = new System.Windows.Forms.Label();
            this.label_CurrencyHUF = new System.Windows.Forms.Label();
            this.label3_NowDate = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_CurrencyRUB = new System.Windows.Forms.Label();
            this.label_CurrencyNOK = new System.Windows.Forms.Label();
            this.button_Calculate = new System.Windows.Forms.Button();
            this.textBox_CurrencyHUFQuantity = new System.Windows.Forms.TextBox();
            this.textBox_CurrencyRUBQuantity = new System.Windows.Forms.TextBox();
            this.textBox_CurrencyNOKQuantity = new System.Windows.Forms.TextBox();
            this.label_CurrencyCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1_CurrencyConvertor
            // 
            this.label1_CurrencyConvertor.AutoSize = true;
            this.label1_CurrencyConvertor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1_CurrencyConvertor.Location = new System.Drawing.Point(341, 9);
            this.label1_CurrencyConvertor.Name = "label1_CurrencyConvertor";
            this.label1_CurrencyConvertor.Size = new System.Drawing.Size(206, 26);
            this.label1_CurrencyConvertor.TabIndex = 0;
            this.label1_CurrencyConvertor.Text = "Конвертор валюты";
            // 
            // label_CurrencyHUF
            // 
            this.label_CurrencyHUF.AutoSize = true;
            this.label_CurrencyHUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_CurrencyHUF.Location = new System.Drawing.Point(126, 91);
            this.label_CurrencyHUF.Name = "label_CurrencyHUF";
            this.label_CurrencyHUF.Size = new System.Drawing.Size(161, 20);
            this.label_CurrencyHUF.TabIndex = 1;
            this.label_CurrencyHUF.Text = "Венгерский форинт";
            // 
            // label3_NowDate
            // 
            this.label3_NowDate.AutoSize = true;
            this.label3_NowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3_NowDate.Location = new System.Drawing.Point(343, 47);
            this.label3_NowDate.Name = "label3_NowDate";
            this.label3_NowDate.Size = new System.Drawing.Size(62, 17);
            this.label3_NowDate.TabIndex = 2;
            this.label3_NowDate.Text = "сейчас: ";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_Date.Location = new System.Drawing.Point(411, 47);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(72, 17);
            this.label_Date.TabIndex = 3;
            this.label_Date.Text = "________";
            // 
            // label_CurrencyRUB
            // 
            this.label_CurrencyRUB.AutoSize = true;
            this.label_CurrencyRUB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_CurrencyRUB.Location = new System.Drawing.Point(342, 91);
            this.label_CurrencyRUB.Name = "label_CurrencyRUB";
            this.label_CurrencyRUB.Size = new System.Drawing.Size(144, 20);
            this.label_CurrencyRUB.TabIndex = 4;
            this.label_CurrencyRUB.Text = "Российский рубль";
            // 
            // label_CurrencyNOK
            // 
            this.label_CurrencyNOK.AutoSize = true;
            this.label_CurrencyNOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_CurrencyNOK.Location = new System.Drawing.Point(560, 91);
            this.label_CurrencyNOK.Name = "label_CurrencyNOK";
            this.label_CurrencyNOK.Size = new System.Drawing.Size(150, 20);
            this.label_CurrencyNOK.TabIndex = 5;
            this.label_CurrencyNOK.Text = "Норвежская крона";
            // 
            // button_Calculate
            // 
            this.button_Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_Calculate.Location = new System.Drawing.Point(367, 265);
            this.button_Calculate.Name = "button_Calculate";
            this.button_Calculate.Size = new System.Drawing.Size(107, 49);
            this.button_Calculate.TabIndex = 7;
            this.button_Calculate.Text = "рассчитать\r\n";
            this.button_Calculate.UseVisualStyleBackColor = true;
            this.button_Calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_CurrencyHUFQuantity
            // 
            this.textBox_CurrencyHUFQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_CurrencyHUFQuantity.Location = new System.Drawing.Point(130, 174);
            this.textBox_CurrencyHUFQuantity.Name = "textBox_CurrencyHUFQuantity";
            this.textBox_CurrencyHUFQuantity.Size = new System.Drawing.Size(157, 23);
            this.textBox_CurrencyHUFQuantity.TabIndex = 13;
            this.textBox_CurrencyHUFQuantity.Text = "1,00";
            this.textBox_CurrencyHUFQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_CurrencyHUFQuantity.TextChanged += new System.EventHandler(this.textBox_CurrencyHUFQuantity_TextChanged);
            this.textBox_CurrencyHUFQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_CurrencyHUFQuantity_KeyPress_1);
            // 
            // textBox_CurrencyRUBQuantity
            // 
            this.textBox_CurrencyRUBQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_CurrencyRUBQuantity.Location = new System.Drawing.Point(346, 174);
            this.textBox_CurrencyRUBQuantity.Name = "textBox_CurrencyRUBQuantity";
            this.textBox_CurrencyRUBQuantity.ReadOnly = true;
            this.textBox_CurrencyRUBQuantity.Size = new System.Drawing.Size(157, 23);
            this.textBox_CurrencyRUBQuantity.TabIndex = 14;
            this.textBox_CurrencyRUBQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_CurrencyNOKQuantity
            // 
            this.textBox_CurrencyNOKQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_CurrencyNOKQuantity.Location = new System.Drawing.Point(564, 174);
            this.textBox_CurrencyNOKQuantity.Name = "textBox_CurrencyNOKQuantity";
            this.textBox_CurrencyNOKQuantity.ReadOnly = true;
            this.textBox_CurrencyNOKQuantity.Size = new System.Drawing.Size(157, 23);
            this.textBox_CurrencyNOKQuantity.TabIndex = 15;
            this.textBox_CurrencyNOKQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_CurrencyCount
            // 
            this.label_CurrencyCount.AutoSize = true;
            this.label_CurrencyCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_CurrencyCount.Location = new System.Drawing.Point(126, 134);
            this.label_CurrencyCount.Name = "label_CurrencyCount";
            this.label_CurrencyCount.Size = new System.Drawing.Size(121, 34);
            this.label_CurrencyCount.TabIndex = 16;
            this.label_CurrencyCount.Text = "Введите сумму \r\nдля конвертации";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 491);
            this.Controls.Add(this.label_CurrencyCount);
            this.Controls.Add(this.textBox_CurrencyNOKQuantity);
            this.Controls.Add(this.textBox_CurrencyRUBQuantity);
            this.Controls.Add(this.textBox_CurrencyHUFQuantity);
            this.Controls.Add(this.button_Calculate);
            this.Controls.Add(this.label_CurrencyNOK);
            this.Controls.Add(this.label_CurrencyRUB);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.label3_NowDate);
            this.Controls.Add(this.label_CurrencyHUF);
            this.Controls.Add(this.label1_CurrencyConvertor);
            this.Name = "MainForm";
            this.Text = "Конвертор валюты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_CurrencyConvertor;
        private System.Windows.Forms.Label label_CurrencyHUF;
        private System.Windows.Forms.Label label3_NowDate;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_CurrencyRUB;
        private System.Windows.Forms.Label label_CurrencyNOK;
        private System.Windows.Forms.Button button_Calculate;
        private System.Windows.Forms.TextBox textBox_CurrencyHUFQuantity;
        private System.Windows.Forms.TextBox textBox_CurrencyRUBQuantity;
        private System.Windows.Forms.TextBox textBox_CurrencyNOKQuantity;
        private System.Windows.Forms.Label label_CurrencyCount;
    }
}

