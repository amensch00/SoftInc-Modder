namespace softwareInc_mod_exe
{
    partial class forms_choice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forms_choice));
            this.SoftwareTypes = new System.Windows.Forms.Button();
            this.NameGen = new System.Windows.Forms.Button();
            this.Scenarios = new System.Windows.Forms.Button();
            this.Event = new System.Windows.Forms.Button();
            this.Companies = new System.Windows.Forms.Button();
            this.CompanyTypes = new System.Windows.Forms.Button();
            this.button_settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SoftwareTypes
            // 
            this.SoftwareTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoftwareTypes.Location = new System.Drawing.Point(12, 12);
            this.SoftwareTypes.Name = "SoftwareTypes";
            this.SoftwareTypes.Size = new System.Drawing.Size(217, 72);
            this.SoftwareTypes.TabIndex = 0;
            this.SoftwareTypes.Text = "Software Types";
            this.SoftwareTypes.UseVisualStyleBackColor = true;
            this.SoftwareTypes.Click += new System.EventHandler(this.button1_Click);
            // 
            // NameGen
            // 
            this.NameGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameGen.Location = new System.Drawing.Point(344, 12);
            this.NameGen.Name = "NameGen";
            this.NameGen.Size = new System.Drawing.Size(217, 72);
            this.NameGen.TabIndex = 1;
            this.NameGen.Text = "Name generator";
            this.NameGen.UseVisualStyleBackColor = true;
            this.NameGen.Click += new System.EventHandler(this.button2_Click);
            // 
            // Scenarios
            // 
            this.Scenarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scenarios.Location = new System.Drawing.Point(12, 127);
            this.Scenarios.Name = "Scenarios";
            this.Scenarios.Size = new System.Drawing.Size(217, 72);
            this.Scenarios.TabIndex = 2;
            this.Scenarios.Text = "Scenarios";
            this.Scenarios.UseVisualStyleBackColor = true;
            this.Scenarios.Click += new System.EventHandler(this.button3_Click);
            // 
            // Event
            // 
            this.Event.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Event.Location = new System.Drawing.Point(344, 127);
            this.Event.Name = "Event";
            this.Event.Size = new System.Drawing.Size(217, 72);
            this.Event.TabIndex = 3;
            this.Event.Text = "Event";
            this.Event.UseVisualStyleBackColor = true;
            this.Event.Click += new System.EventHandler(this.button4_Click);
            // 
            // Companies
            // 
            this.Companies.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Companies.Location = new System.Drawing.Point(344, 249);
            this.Companies.Name = "Companies";
            this.Companies.Size = new System.Drawing.Size(217, 72);
            this.Companies.TabIndex = 5;
            this.Companies.Text = "Companies";
            this.Companies.UseVisualStyleBackColor = true;
            this.Companies.Click += new System.EventHandler(this.button5_Click);
            // 
            // CompanyTypes
            // 
            this.CompanyTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyTypes.Location = new System.Drawing.Point(12, 249);
            this.CompanyTypes.Name = "CompanyTypes";
            this.CompanyTypes.Size = new System.Drawing.Size(217, 72);
            this.CompanyTypes.TabIndex = 4;
            this.CompanyTypes.Text = "Company Types";
            this.CompanyTypes.UseVisualStyleBackColor = true;
            this.CompanyTypes.Click += new System.EventHandler(this.button6_Click);
            // 
            // button_settings
            // 
            this.button_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_settings.Location = new System.Drawing.Point(12, 381);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(549, 72);
            this.button_settings.TabIndex = 6;
            this.button_settings.Text = "Settings";
            this.button_settings.UseVisualStyleBackColor = true;
            this.button_settings.Click += new System.EventHandler(this.button7_Click);
            // 
            // forms_choice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(573, 463);
            this.Controls.Add(this.button_settings);
            this.Controls.Add(this.Companies);
            this.Controls.Add(this.CompanyTypes);
            this.Controls.Add(this.Event);
            this.Controls.Add(this.Scenarios);
            this.Controls.Add(this.NameGen);
            this.Controls.Add(this.SoftwareTypes);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "forms_choice";
            this.Text = "Software Inc. Modding Program by amensch";
            this.Load += new System.EventHandler(this.forms_choice_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SoftwareTypes;
        private System.Windows.Forms.Button NameGen;
        private System.Windows.Forms.Button Scenarios;
        private System.Windows.Forms.Button Event;
        private System.Windows.Forms.Button Companies;
        private System.Windows.Forms.Button CompanyTypes;
        private System.Windows.Forms.Button button_settings;
    }
}