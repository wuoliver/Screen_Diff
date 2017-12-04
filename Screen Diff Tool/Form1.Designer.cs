namespace Screen_Diff_Tool
{
    partial class Screen_Diff
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
            this.startDiffButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.diffLabel = new System.Windows.Forms.Label();
            this.screenshotMode_Checkbox = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // startDiffButton
            // 
            this.startDiffButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.startDiffButton.Location = new System.Drawing.Point(167, 269);
            this.startDiffButton.Name = "startDiffButton";
            this.startDiffButton.Size = new System.Drawing.Size(169, 23);
            this.startDiffButton.TabIndex = 0;
            this.startDiffButton.Text = "Start";
            this.startDiffButton.UseVisualStyleBackColor = true;
            this.startDiffButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(465, 251);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // diffLabel
            // 
            this.diffLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.diffLabel.AutoSize = true;
            this.diffLabel.BackColor = System.Drawing.Color.Gold;
            this.diffLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diffLabel.Location = new System.Drawing.Point(27, 95);
            this.diffLabel.Name = "diffLabel";
            this.diffLabel.Size = new System.Drawing.Size(437, 76);
            this.diffLabel.TabIndex = 2;
            this.diffLabel.Text = "DIFF FOUND";
            // 
            // screenshotMode_Checkbox
            // 
            this.screenshotMode_Checkbox.AutoSize = true;
            this.screenshotMode_Checkbox.Location = new System.Drawing.Point(368, 273);
            this.screenshotMode_Checkbox.Name = "screenshotMode_Checkbox";
            this.screenshotMode_Checkbox.Size = new System.Drawing.Size(110, 17);
            this.screenshotMode_Checkbox.TabIndex = 3;
            this.screenshotMode_Checkbox.Text = "Screenshot Mode";
            this.toolTip1.SetToolTip(this.screenshotMode_Checkbox, "Saves a screenshot instead of running the difference program.");
            this.screenshotMode_Checkbox.UseVisualStyleBackColor = true;
            // 
            // Screen_Diff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 306);
            this.Controls.Add(this.screenshotMode_Checkbox);
            this.Controls.Add(this.diffLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.startDiffButton);
            this.Name = "Screen_Diff";
            this.Text = "Screen Difference Tool";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Screen_Diff_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startDiffButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label diffLabel;
        private System.Windows.Forms.CheckBox screenshotMode_Checkbox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

