namespace softwareInc_mod_exe
{
    partial class Event_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Event_));
            this.label_name = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_company = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_add_company = new System.Windows.Forms.Button();
            this.button_add_event = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(12, 9);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(96, 18);
            this.label_name.TabIndex = 6;
            this.label_name.Text = "Event name";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(11, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 29);
            this.textBox1.TabIndex = 5;
            // 
            // label_company
            // 
            this.label_company.AutoSize = true;
            this.label_company.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_company.Location = new System.Drawing.Point(267, 9);
            this.label_company.Name = "label_company";
            this.label_company.Size = new System.Drawing.Size(79, 18);
            this.label_company.TabIndex = 8;
            this.label_company.Text = "Company";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(266, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(254, 29);
            this.textBox2.TabIndex = 7;
            // 
            // button_add_company
            // 
            this.button_add_company.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add_company.Location = new System.Drawing.Point(266, 68);
            this.button_add_company.Name = "button_add_company";
            this.button_add_company.Size = new System.Drawing.Size(254, 51);
            this.button_add_company.TabIndex = 10;
            this.button_add_company.Text = "Add Company";
            this.button_add_company.UseVisualStyleBackColor = true;
            this.button_add_company.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_add_event
            // 
            this.button_add_event.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add_event.Location = new System.Drawing.Point(16, 135);
            this.button_add_event.Name = "button_add_event";
            this.button_add_event.Size = new System.Drawing.Size(504, 51);
            this.button_add_event.TabIndex = 19;
            this.button_add_event.Text = "Add Event";
            this.button_add_event.UseVisualStyleBackColor = true;
            this.button_add_event.Click += new System.EventHandler(this.button4_Click);
            // 
            // Event_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 198);
            this.Controls.Add(this.button_add_event);
            this.Controls.Add(this.button_add_company);
            this.Controls.Add(this.label_company);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Event_";
            this.Text = "Event";
            this.Load += new System.EventHandler(this.Event__Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_company;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button_add_company;
        private System.Windows.Forms.Button button_add_event;
    }
}