namespace Timer
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.tabTimer = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonHoursPlus = new System.Windows.Forms.Button();
            this.buttonMinutesPlus = new System.Windows.Forms.Button();
            this.buttonSecondsPlus = new System.Windows.Forms.Button();
            this.buttonHoursMinus = new System.Windows.Forms.Button();
            this.buttonMinutesMinus = new System.Windows.Forms.Button();
            this.buttonSecondsMinus = new System.Windows.Forms.Button();
            this.tabTimer.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 293);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(416, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // mainTimer
            // 
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // tabTimer
            // 
            this.tabTimer.Controls.Add(this.tabPage1);
            this.tabTimer.Controls.Add(this.tabPage2);
            this.tabTimer.Location = new System.Drawing.Point(13, 13);
            this.tabTimer.Name = "tabTimer";
            this.tabTimer.SelectedIndex = 0;
            this.tabTimer.Size = new System.Drawing.Size(391, 277);
            this.tabTimer.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.buttonSecondsMinus);
            this.tabPage1.Controls.Add(this.buttonMinutesMinus);
            this.tabPage1.Controls.Add(this.buttonHoursMinus);
            this.tabPage1.Controls.Add(this.buttonSecondsPlus);
            this.tabPage1.Controls.Add(this.buttonMinutesPlus);
            this.tabPage1.Controls.Add(this.buttonHoursPlus);
            this.tabPage1.Controls.Add(this.buttonReset);
            this.tabPage1.Controls.Add(this.buttonStop);
            this.tabPage1.Controls.Add(this.buttonStart);
            this.tabPage1.Controls.Add(this.labelTime);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(383, 251);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Timer";
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReset.FlatAppearance.BorderSize = 0;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReset.Location = new System.Drawing.Point(230, 138);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 30);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.Red;
            this.buttonStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStop.FlatAppearance.BorderSize = 0;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStop.Location = new System.Drawing.Point(149, 138);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 30);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Lime;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonStart.Location = new System.Drawing.Point(68, 138);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 30);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(71, 53);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(234, 51);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "00 : 00 : 00";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(383, 251);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonHoursPlus
            // 
            this.buttonHoursPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHoursPlus.FlatAppearance.BorderSize = 0;
            this.buttonHoursPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHoursPlus.Location = new System.Drawing.Point(68, 32);
            this.buttonHoursPlus.Name = "buttonHoursPlus";
            this.buttonHoursPlus.Size = new System.Drawing.Size(75, 18);
            this.buttonHoursPlus.TabIndex = 4;
            this.buttonHoursPlus.Text = "button1";
            this.buttonHoursPlus.UseVisualStyleBackColor = true;
            this.buttonHoursPlus.Click += new System.EventHandler(this.buttonHoursPlus_Click);
            // 
            // buttonMinutesPlus
            // 
            this.buttonMinutesPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinutesPlus.FlatAppearance.BorderSize = 0;
            this.buttonMinutesPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinutesPlus.Location = new System.Drawing.Point(149, 32);
            this.buttonMinutesPlus.Name = "buttonMinutesPlus";
            this.buttonMinutesPlus.Size = new System.Drawing.Size(75, 18);
            this.buttonMinutesPlus.TabIndex = 5;
            this.buttonMinutesPlus.Text = "button2";
            this.buttonMinutesPlus.UseVisualStyleBackColor = true;
            this.buttonMinutesPlus.Click += new System.EventHandler(this.buttonMinutesPlus_Click);
            // 
            // buttonSecondsPlus
            // 
            this.buttonSecondsPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSecondsPlus.FlatAppearance.BorderSize = 0;
            this.buttonSecondsPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSecondsPlus.Location = new System.Drawing.Point(230, 32);
            this.buttonSecondsPlus.Name = "buttonSecondsPlus";
            this.buttonSecondsPlus.Size = new System.Drawing.Size(75, 18);
            this.buttonSecondsPlus.TabIndex = 6;
            this.buttonSecondsPlus.Text = "button3";
            this.buttonSecondsPlus.UseVisualStyleBackColor = true;
            this.buttonSecondsPlus.Click += new System.EventHandler(this.buttonSecondsPlus_Click);
            // 
            // buttonHoursMinus
            // 
            this.buttonHoursMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHoursMinus.FlatAppearance.BorderSize = 0;
            this.buttonHoursMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHoursMinus.Location = new System.Drawing.Point(68, 107);
            this.buttonHoursMinus.Name = "buttonHoursMinus";
            this.buttonHoursMinus.Size = new System.Drawing.Size(75, 18);
            this.buttonHoursMinus.TabIndex = 7;
            this.buttonHoursMinus.Text = "button4";
            this.buttonHoursMinus.UseVisualStyleBackColor = true;
            this.buttonHoursMinus.Click += new System.EventHandler(this.buttonHoursMinus_Click);
            // 
            // buttonMinutesMinus
            // 
            this.buttonMinutesMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinutesMinus.FlatAppearance.BorderSize = 0;
            this.buttonMinutesMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinutesMinus.Location = new System.Drawing.Point(149, 107);
            this.buttonMinutesMinus.Name = "buttonMinutesMinus";
            this.buttonMinutesMinus.Size = new System.Drawing.Size(75, 18);
            this.buttonMinutesMinus.TabIndex = 8;
            this.buttonMinutesMinus.Text = "button5";
            this.buttonMinutesMinus.UseVisualStyleBackColor = true;
            this.buttonMinutesMinus.Click += new System.EventHandler(this.buttonMinutesMinus_Click);
            // 
            // buttonSecondsMinus
            // 
            this.buttonSecondsMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSecondsMinus.FlatAppearance.BorderSize = 0;
            this.buttonSecondsMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSecondsMinus.Location = new System.Drawing.Point(230, 107);
            this.buttonSecondsMinus.Name = "buttonSecondsMinus";
            this.buttonSecondsMinus.Size = new System.Drawing.Size(75, 18);
            this.buttonSecondsMinus.TabIndex = 9;
            this.buttonSecondsMinus.Text = "button6";
            this.buttonSecondsMinus.UseVisualStyleBackColor = true;
            this.buttonSecondsMinus.Click += new System.EventHandler(this.buttonSecondsMinus_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 315);
            this.Controls.Add(this.tabTimer);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MainForm";
            this.Text = "Timer v1.0";
            this.tabTimer.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.TabControl tabTimer;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonSecondsMinus;
        private System.Windows.Forms.Button buttonMinutesMinus;
        private System.Windows.Forms.Button buttonHoursMinus;
        private System.Windows.Forms.Button buttonSecondsPlus;
        private System.Windows.Forms.Button buttonMinutesPlus;
        private System.Windows.Forms.Button buttonHoursPlus;
    }
}

