namespace Stopwatch
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.clockText = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.resetButton = new System.Windows.Forms.Button();
            this.contestantTextBox = new System.Windows.Forms.TextBox();
            this.ageGroupTextBox = new System.Windows.Forms.TextBox();
            this.contestantLabel = new System.Windows.Forms.Label();
            this.ageGroupLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clockText
            // 
            this.clockText.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockText.Location = new System.Drawing.Point(0, 70);
            this.clockText.Name = "clockText";
            this.clockText.Size = new System.Drawing.Size(606, 100);
            this.clockText.TabIndex = 0;
            this.clockText.Text = "00:00";
            this.clockText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(237, 251);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(117, 62);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(360, 266);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(103, 47);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // contestantTextBox
            // 
            this.contestantTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contestantTextBox.Location = new System.Drawing.Point(12, 208);
            this.contestantTextBox.Name = "contestantTextBox";
            this.contestantTextBox.Size = new System.Drawing.Size(181, 30);
            this.contestantTextBox.TabIndex = 3;
            // 
            // ageGroupTextBox
            // 
            this.ageGroupTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageGroupTextBox.Location = new System.Drawing.Point(12, 303);
            this.ageGroupTextBox.Name = "ageGroupTextBox";
            this.ageGroupTextBox.Size = new System.Drawing.Size(181, 30);
            this.ageGroupTextBox.TabIndex = 4;
            // 
            // contestantLabel
            // 
            this.contestantLabel.AutoSize = true;
            this.contestantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contestantLabel.Location = new System.Drawing.Point(7, 180);
            this.contestantLabel.Name = "contestantLabel";
            this.contestantLabel.Size = new System.Drawing.Size(177, 25);
            this.contestantLabel.TabIndex = 5;
            this.contestantLabel.Text = "Current Contestant";
            // 
            // ageGroupLabel
            // 
            this.ageGroupLabel.AutoSize = true;
            this.ageGroupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageGroupLabel.Location = new System.Drawing.Point(7, 275);
            this.ageGroupLabel.Name = "ageGroupLabel";
            this.ageGroupLabel.Size = new System.Drawing.Size(107, 25);
            this.ageGroupLabel.TabIndex = 6;
            this.ageGroupLabel.Text = "Age Group";
            // 
            // updateButton
            // 
            this.updateButton.AutoSize = true;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(12, 109);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(131, 35);
            this.updateButton.TabIndex = 7;
            this.updateButton.Text = "Update Data";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(590, 376);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.ageGroupLabel);
            this.Controls.Add(this.contestantLabel);
            this.Controls.Add(this.ageGroupTextBox);
            this.Controls.Add(this.contestantTextBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.clockText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clockText;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox contestantTextBox;
        private System.Windows.Forms.TextBox ageGroupTextBox;
        private System.Windows.Forms.Label contestantLabel;
        private System.Windows.Forms.Label ageGroupLabel;
        private System.Windows.Forms.Button updateButton;
    }
}

