﻿namespace softwareInc_mod_exe
{
    partial class start_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(start_screen));
            this.label1 = new System.Windows.Forms.Label();
            this.button_it = new System.Windows.Forms.Button();
            this.button_en = new System.Windows.Forms.Button();
            this.button_de = new System.Windows.Forms.Button();
            this.button_fr = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_version = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(722, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to my Modding Program for Software Inc. the Game";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_it
            // 
            this.button_it.BackgroundImage = global::softwareInc_mod_exe.Properties.Resources.Italian_flag;
            this.button_it.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_it.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_it.Location = new System.Drawing.Point(12, 338);
            this.button_it.Name = "button_it";
            this.button_it.Size = new System.Drawing.Size(189, 189);
            this.button_it.TabIndex = 1;
            this.button_it.Text = "Italiano";
            this.button_it.UseVisualStyleBackColor = true;
            this.button_it.Click += new System.EventHandler(this.button_it_Click);
            // 
            // button_en
            // 
            this.button_en.BackgroundImage = global::softwareInc_mod_exe.Properties.Resources.England_flag;
            this.button_en.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_en.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_en.Location = new System.Drawing.Point(208, 338);
            this.button_en.Name = "button_en";
            this.button_en.Size = new System.Drawing.Size(189, 189);
            this.button_en.TabIndex = 2;
            this.button_en.Text = "English";
            this.button_en.UseVisualStyleBackColor = true;
            this.button_en.Click += new System.EventHandler(this.button_en_Click);
            // 
            // button_de
            // 
            this.button_de.BackgroundImage = global::softwareInc_mod_exe.Properties.Resources.German_flag;
            this.button_de.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_de.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_de.Location = new System.Drawing.Point(412, 338);
            this.button_de.Name = "button_de";
            this.button_de.Size = new System.Drawing.Size(189, 189);
            this.button_de.TabIndex = 3;
            this.button_de.Text = "Deutsch";
            this.button_de.UseVisualStyleBackColor = true;
            this.button_de.Click += new System.EventHandler(this.button_de_Click);
            // 
            // button_fr
            // 
            this.button_fr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_fr.BackgroundImage")));
            this.button_fr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_fr.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_fr.Location = new System.Drawing.Point(616, 338);
            this.button_fr.Name = "button_fr";
            this.button_fr.Size = new System.Drawing.Size(189, 189);
            this.button_fr.TabIndex = 4;
            this.button_fr.Text = "Français";
            this.button_fr.UseVisualStyleBackColor = true;
            this.button_fr.Click += new System.EventHandler(this.button_fr_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Version :";
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.BackColor = System.Drawing.Color.Transparent;
            this.label_version.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_version.Location = new System.Drawing.Point(93, 20);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(11, 13);
            this.label_version.TabIndex = 6;
            this.label_version.Text = "-";
            this.label_version.Click += new System.EventHandler(this.label_version_Click);
            // 
            // start_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::softwareInc_mod_exe.Properties.Resources.main_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(817, 539);
            this.Controls.Add(this.label_version);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_fr);
            this.Controls.Add(this.button_de);
            this.Controls.Add(this.button_en);
            this.Controls.Add(this.button_it);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "start_screen";
            this.Text = "Software Inc. Modding Program by amensch";
            this.Load += new System.EventHandler(this.start_screen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_it;
        private System.Windows.Forms.Button button_en;
        private System.Windows.Forms.Button button_de;
        private System.Windows.Forms.Button button_fr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_version;
    }
}