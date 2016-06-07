namespace softwareInc_mod_exe
{
    partial class Settings_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings_));
            this.checkBox_tutorial = new System.Windows.Forms.CheckBox();
            this.button_check = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox_tutorial
            // 
            this.checkBox_tutorial.AutoSize = true;
            this.checkBox_tutorial.Checked = true;
            this.checkBox_tutorial.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_tutorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_tutorial.Location = new System.Drawing.Point(12, 12);
            this.checkBox_tutorial.Name = "checkBox_tutorial";
            this.checkBox_tutorial.Size = new System.Drawing.Size(109, 28);
            this.checkBox_tutorial.TabIndex = 8;
            this.checkBox_tutorial.Text = "Tutorials";
            this.checkBox_tutorial.UseVisualStyleBackColor = true;
            this.checkBox_tutorial.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button_check
            // 
            this.button_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_check.Location = new System.Drawing.Point(12, 278);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(394, 62);
            this.button_check.TabIndex = 9;
            this.button_check.Text = "Check for updates";
            this.button_check.UseVisualStyleBackColor = true;
            this.button_check.Click += new System.EventHandler(this.button1_Click);
            // 
            // Settings_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 352);
            this.Controls.Add(this.button_check);
            this.Controls.Add(this.checkBox_tutorial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings_";
            this.Text = "settings";
            this.Load += new System.EventHandler(this.Settings__Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_tutorial;
        private System.Windows.Forms.Button button_check;
    }
}