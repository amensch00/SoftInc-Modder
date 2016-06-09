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
            this.button_path = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_path = new System.Windows.Forms.Label();
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
            this.button_check.Location = new System.Drawing.Point(132, 278);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(394, 62);
            this.button_check.TabIndex = 9;
            this.button_check.Text = "Check for updates";
            this.button_check.UseVisualStyleBackColor = true;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            // 
            // button_path
            // 
            this.button_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_path.Location = new System.Drawing.Point(132, 205);
            this.button_path.Name = "button_path";
            this.button_path.Size = new System.Drawing.Size(394, 54);
            this.button_path.TabIndex = 10;
            this.button_path.Text = "Change Mod path";
            this.button_path.UseVisualStyleBackColor = true;
            this.button_path.Click += new System.EventHandler(this.button_path_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mod path :";
            // 
            // label_path
            // 
            this.label_path.AutoSize = true;
            this.label_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_path.Location = new System.Drawing.Point(86, 82);
            this.label_path.Name = "label_path";
            this.label_path.Size = new System.Drawing.Size(13, 13);
            this.label_path.TabIndex = 12;
            this.label_path.Text = "/";
            // 
            // Settings_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 352);
            this.Controls.Add(this.label_path);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_path);
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
        private System.Windows.Forms.Button button_path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_path;
    }
}