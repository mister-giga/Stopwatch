
namespace Stopwatch
{
    partial class StopwatchForm
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
            if(disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StopwatchForm));
            this.timeDisplayLbl = new System.Windows.Forms.Label();
            this.actionBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timeDisplayLbl
            // 
            this.timeDisplayLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeDisplayLbl.Location = new System.Drawing.Point(0, -2);
            this.timeDisplayLbl.Name = "timeDisplayLbl";
            this.timeDisplayLbl.Size = new System.Drawing.Size(116, 50);
            this.timeDisplayLbl.TabIndex = 0;
            this.timeDisplayLbl.Text = "00:00:00";
            this.timeDisplayLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeDisplayLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.timeDisplayLbl_MouseDown);
            // 
            // actionBtn
            // 
            this.actionBtn.BackColor = System.Drawing.Color.Transparent;
            this.actionBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("actionBtn.BackgroundImage")));
            this.actionBtn.Location = new System.Drawing.Point(119, 2);
            this.actionBtn.Margin = new System.Windows.Forms.Padding(0);
            this.actionBtn.Name = "actionBtn";
            this.actionBtn.Size = new System.Drawing.Size(14, 14);
            this.actionBtn.TabIndex = 1;
            this.actionBtn.UseVisualStyleBackColor = false;
            this.actionBtn.Click += new System.EventHandler(this.actionBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.Transparent;
            this.resetBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resetBtn.BackgroundImage")));
            this.resetBtn.Location = new System.Drawing.Point(119, 17);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(0);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(14, 14);
            this.resetBtn.TabIndex = 2;
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitBtn.BackgroundImage")));
            this.exitBtn.Location = new System.Drawing.Point(119, 31);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(14, 14);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // StopwatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(142, 47);
            this.ControlBox = false;
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.actionBtn);
            this.Controls.Add(this.timeDisplayLbl);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StopwatchForm";
            this.Opacity = 0.8D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Stopwatch";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.StopwatchForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label timeDisplayLbl;
        private System.Windows.Forms.Button actionBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}