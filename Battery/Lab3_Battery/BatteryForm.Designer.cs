namespace Lab3_Battery
{
    partial class BatteryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatteryForm));
            this.label1 = new System.Windows.Forms.Label();
            this.ConnectType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AvailableTime = new System.Windows.Forms.Label();
            this.AvailablePower = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TimeOfDisable = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.prbBatteryLevel = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Battery remaining time:";
            // 
            // ConnectType
            // 
            this.ConnectType.AutoSize = true;
            this.ConnectType.ForeColor = System.Drawing.Color.Red;
            this.ConnectType.Location = new System.Drawing.Point(285, 119);
            this.ConnectType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ConnectType.Name = "ConnectType";
            this.ConnectType.Size = new System.Drawing.Size(16, 17);
            this.ConnectType.TabIndex = 1;
            this.ConnectType.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Current battery capacity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Battery status:";
            // 
            // AvailableTime
            // 
            this.AvailableTime.AutoSize = true;
            this.AvailableTime.ForeColor = System.Drawing.Color.Red;
            this.AvailableTime.Location = new System.Drawing.Point(285, 89);
            this.AvailableTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AvailableTime.Name = "AvailableTime";
            this.AvailableTime.Size = new System.Drawing.Size(16, 17);
            this.AvailableTime.TabIndex = 4;
            this.AvailableTime.Text = "3";
            // 
            // AvailablePower
            // 
            this.AvailablePower.AutoSize = true;
            this.AvailablePower.ForeColor = System.Drawing.Color.Red;
            this.AvailablePower.Location = new System.Drawing.Point(285, 55);
            this.AvailablePower.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AvailablePower.Name = "AvailablePower";
            this.AvailablePower.Size = new System.Drawing.Size(16, 17);
            this.AvailablePower.TabIndex = 5;
            this.AvailablePower.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(14, 250);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Turn-off time (min.):";
            // 
            // TimeOfDisable
            // 
            this.TimeOfDisable.Location = new System.Drawing.Point(189, 250);
            this.TimeOfDisable.Margin = new System.Windows.Forms.Padding(4);
            this.TimeOfDisable.Name = "TimeOfDisable";
            this.TimeOfDisable.Size = new System.Drawing.Size(91, 22);
            this.TimeOfDisable.TabIndex = 7;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(303, 247);
            this.OKButton.Margin = new System.Windows.Forms.Padding(4);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(100, 28);
            this.OKButton.TabIndex = 8;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "Battery Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(74, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(284, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = "Discharges Information";
            // 
            // prbBatteryLevel
            // 
            this.prbBatteryLevel.Location = new System.Drawing.Point(16, 191);
            this.prbBatteryLevel.Name = "prbBatteryLevel";
            this.prbBatteryLevel.Size = new System.Drawing.Size(387, 40);
            this.prbBatteryLevel.TabIndex = 11;
            // 
            // BatteryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(420, 285);
            this.Controls.Add(this.prbBatteryLevel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.TimeOfDisable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AvailablePower);
            this.Controls.Add(this.AvailableTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConnectType);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BatteryForm";
            this.Text = "Battery Information";
            this.Load += new System.EventHandler(this.BatteryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ConnectType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label AvailableTime;
        private System.Windows.Forms.Label AvailablePower;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TimeOfDisable;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar prbBatteryLevel;
    }
}

