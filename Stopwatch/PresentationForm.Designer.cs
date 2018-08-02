namespace Stopwatch
{
    partial class PresentationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PresentationForm));
            this.label1 = new System.Windows.Forms.Label();
            this.currentContestant = new System.Windows.Forms.Label();
            this.ageGroup = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 99.74999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(479, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 159);
            this.label1.TabIndex = 0;
            this.label1.Text = "00:00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentContestant
            // 
            this.currentContestant.Font = new System.Drawing.Font("Lato", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentContestant.ForeColor = System.Drawing.Color.White;
            this.currentContestant.Location = new System.Drawing.Point(361, 249);
            this.currentContestant.Name = "currentContestant";
            this.currentContestant.Size = new System.Drawing.Size(644, 84);
            this.currentContestant.TabIndex = 1;
            this.currentContestant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.currentContestant.Click += new System.EventHandler(this.label2_Click);
            // 
            // ageGroup
            // 
            this.ageGroup.Font = new System.Drawing.Font("Lato", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageGroup.ForeColor = System.Drawing.Color.White;
            this.ageGroup.Location = new System.Drawing.Point(361, 443);
            this.ageGroup.Name = "ageGroup";
            this.ageGroup.Size = new System.Drawing.Size(644, 84);
            this.ageGroup.TabIndex = 2;
            this.ageGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PresentationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.ageGroup);
            this.Controls.Add(this.currentContestant);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(-1366, 0);
            this.Name = "PresentationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Display - RaceDisplay";
            this.Load += new System.EventHandler(this.PresentationForm_Load);
            this.SizeChanged += new System.EventHandler(this.PresentationForm_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label currentContestant;
        public System.Windows.Forms.Label ageGroup;
    }
}