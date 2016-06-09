namespace softwareInc_mod_exe
{
    partial class feature_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(feature_form));
            this.button_create_feature = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_description = new System.Windows.Forms.Label();
            this.textBox_desc = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label_dev = new System.Windows.Forms.Label();
            this.label_innovation = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label_usability = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label_stability = new System.Windows.Forms.Label();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.label_art = new System.Windows.Forms.Label();
            this.comboBox_depend = new System.Windows.Forms.ComboBox();
            this.label_dependencies = new System.Windows.Forms.Label();
            this.button_add_dependency = new System.Windows.Forms.Button();
            this.label_from = new System.Windows.Forms.Label();
            this.comboBox_from = new System.Windows.Forms.ComboBox();
            this.label_server = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.radioButton_forced = new System.Windows.Forms.RadioButton();
            this._hh1 = new System.Windows.Forms.Button();
            this._hh5 = new System.Windows.Forms.Button();
            this._hh6 = new System.Windows.Forms.Button();
            this._hh2 = new System.Windows.Forms.Button();
            this._hh3 = new System.Windows.Forms.Button();
            this._hh4 = new System.Windows.Forms.Button();
            this.textBox_server = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            this.SuspendLayout();
            // 
            // button_create_feature
            // 
            this.button_create_feature.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_create_feature.Location = new System.Drawing.Point(336, 374);
            this.button_create_feature.Name = "button_create_feature";
            this.button_create_feature.Size = new System.Drawing.Size(368, 111);
            this.button_create_feature.TabIndex = 0;
            this.button_create_feature.Text = "Create Feature";
            this.button_create_feature.UseVisualStyleBackColor = true;
            this.button_create_feature.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(12, 18);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(121, 20);
            this.label_name.TabIndex = 4;
            this.label_name.Text = "Feature name";
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_name.Location = new System.Drawing.Point(11, 41);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(217, 29);
            this.textBox_name.TabIndex = 3;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_description.Location = new System.Drawing.Point(12, 85);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(165, 20);
            this.label_description.TabIndex = 6;
            this.label_description.Text = "Feature description";
            // 
            // textBox_desc
            // 
            this.textBox_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_desc.Location = new System.Drawing.Point(11, 108);
            this.textBox_desc.Multiline = true;
            this.textBox_desc.Name = "textBox_desc";
            this.textBox_desc.Size = new System.Drawing.Size(297, 66);
            this.textBox_desc.TabIndex = 5;
            this.textBox_desc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox_desc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 2;
            this.trackBar1.Location = new System.Drawing.Point(11, 217);
            this.trackBar1.Maximum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(143, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label_dev
            // 
            this.label_dev.AutoSize = true;
            this.label_dev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dev.Location = new System.Drawing.Point(12, 196);
            this.label_dev.Name = "label_dev";
            this.label_dev.Size = new System.Drawing.Size(83, 20);
            this.label_dev.TabIndex = 8;
            this.label_dev.Text = "Dev Time";
            // 
            // label_innovation
            // 
            this.label_innovation.AutoSize = true;
            this.label_innovation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_innovation.Location = new System.Drawing.Point(16, 264);
            this.label_innovation.Name = "label_innovation";
            this.label_innovation.Size = new System.Drawing.Size(93, 20);
            this.label_innovation.TabIndex = 10;
            this.label_innovation.Text = "Innovation";
            // 
            // trackBar2
            // 
            this.trackBar2.LargeChange = 2;
            this.trackBar2.Location = new System.Drawing.Point(11, 285);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(143, 45);
            this.trackBar2.TabIndex = 9;
            // 
            // label_usability
            // 
            this.label_usability.AutoSize = true;
            this.label_usability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usability.Location = new System.Drawing.Point(19, 341);
            this.label_usability.Name = "label_usability";
            this.label_usability.Size = new System.Drawing.Size(77, 20);
            this.label_usability.TabIndex = 12;
            this.label_usability.Text = "Usability";
            // 
            // trackBar3
            // 
            this.trackBar3.LargeChange = 2;
            this.trackBar3.Location = new System.Drawing.Point(11, 362);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(143, 45);
            this.trackBar3.TabIndex = 11;
            // 
            // label_stability
            // 
            this.label_stability.AutoSize = true;
            this.label_stability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stability.Location = new System.Drawing.Point(20, 419);
            this.label_stability.Name = "label_stability";
            this.label_stability.Size = new System.Drawing.Size(73, 20);
            this.label_stability.TabIndex = 14;
            this.label_stability.Text = "Stability";
            // 
            // trackBar4
            // 
            this.trackBar4.LargeChange = 2;
            this.trackBar4.Location = new System.Drawing.Point(11, 440);
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(143, 45);
            this.trackBar4.TabIndex = 13;
            // 
            // trackBar5
            // 
            this.trackBar5.LargeChange = 2;
            this.trackBar5.Location = new System.Drawing.Point(165, 217);
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(143, 45);
            this.trackBar5.TabIndex = 15;
            // 
            // label_art
            // 
            this.label_art.AutoSize = true;
            this.label_art.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_art.Location = new System.Drawing.Point(172, 196);
            this.label_art.Name = "label_art";
            this.label_art.Size = new System.Drawing.Size(80, 20);
            this.label_art.TabIndex = 16;
            this.label_art.Text = "Code Art";
            // 
            // comboBox_depend
            // 
            this.comboBox_depend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_depend.FormattingEnabled = true;
            this.comboBox_depend.Items.AddRange(new object[] {
            "Audio Tool>Audio playback",
            "Audio Tool>Recording",
            "Operating System>Networking",
            "Operating System>Multithreading",
            "Operating System>Multitasking",
            "Operating System>64-bit",
            "Operating System>GUI",
            "Audio Tool>Music editor",
            "Visual Tool>Image viewing",
            "Visual Tool>Image editing"});
            this.comboBox_depend.Location = new System.Drawing.Point(448, 130);
            this.comboBox_depend.Name = "comboBox_depend";
            this.comboBox_depend.Size = new System.Drawing.Size(259, 28);
            this.comboBox_depend.TabIndex = 21;
            // 
            // label_dependencies
            // 
            this.label_dependencies.AutoSize = true;
            this.label_dependencies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dependencies.Location = new System.Drawing.Point(448, 108);
            this.label_dependencies.Name = "label_dependencies";
            this.label_dependencies.Size = new System.Drawing.Size(124, 20);
            this.label_dependencies.TabIndex = 20;
            this.label_dependencies.Text = "Dependencies";
            // 
            // button_add_dependency
            // 
            this.button_add_dependency.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add_dependency.Location = new System.Drawing.Point(448, 186);
            this.button_add_dependency.Name = "button_add_dependency";
            this.button_add_dependency.Size = new System.Drawing.Size(259, 35);
            this.button_add_dependency.TabIndex = 22;
            this.button_add_dependency.Text = "Add Dependency";
            this.button_add_dependency.UseVisualStyleBackColor = true;
            this.button_add_dependency.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_from
            // 
            this.label_from.AutoSize = true;
            this.label_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_from.Location = new System.Drawing.Point(448, 18);
            this.label_from.Name = "label_from";
            this.label_from.Size = new System.Drawing.Size(188, 20);
            this.label_from.TabIndex = 24;
            this.label_from.Text = "From (Parent Feature)";
            // 
            // comboBox_from
            // 
            this.comboBox_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_from.FormattingEnabled = true;
            this.comboBox_from.Location = new System.Drawing.Point(448, 41);
            this.comboBox_from.Name = "comboBox_from";
            this.comboBox_from.Size = new System.Drawing.Size(259, 28);
            this.comboBox_from.TabIndex = 25;
            // 
            // label_server
            // 
            this.label_server.AutoSize = true;
            this.label_server.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_server.Location = new System.Drawing.Point(172, 264);
            this.label_server.Name = "label_server";
            this.label_server.Size = new System.Drawing.Size(61, 20);
            this.label_server.TabIndex = 27;
            this.label_server.Text = "Server";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 312);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 16);
            this.label12.TabIndex = 29;
            this.label12.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 389);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 467);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 16);
            this.label14.TabIndex = 31;
            this.label14.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(173, 246);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 16);
            this.label15.TabIndex = 32;
            this.label15.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(129, 246);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(16, 16);
            this.label17.TabIndex = 34;
            this.label17.Text = "5";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(292, 246);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(16, 16);
            this.label18.TabIndex = 35;
            this.label18.Text = "1";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(129, 312);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(16, 16);
            this.label20.TabIndex = 37;
            this.label20.Text = "1";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(129, 389);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(24, 16);
            this.label21.TabIndex = 38;
            this.label21.Text = "10";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(129, 467);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(16, 16);
            this.label22.TabIndex = 39;
            this.label22.Text = "1";
            // 
            // radioButton_forced
            // 
            this.radioButton_forced.AutoSize = true;
            this.radioButton_forced.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_forced.Location = new System.Drawing.Point(625, 285);
            this.radioButton_forced.Name = "radioButton_forced";
            this.radioButton_forced.Size = new System.Drawing.Size(83, 24);
            this.radioButton_forced.TabIndex = 40;
            this.radioButton_forced.TabStop = true;
            this.radioButton_forced.Text = "Forced";
            this.radioButton_forced.UseVisualStyleBackColor = true;
            this.radioButton_forced.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // _hh1
            // 
            this._hh1.BackgroundImage = global::softwareInc_mod_exe.Properties.Resources.Help_Icon;
            this._hh1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._hh1.Location = new System.Drawing.Point(107, 195);
            this._hh1.Name = "_hh1";
            this._hh1.Size = new System.Drawing.Size(38, 24);
            this._hh1.TabIndex = 41;
            this._hh1.UseVisualStyleBackColor = true;
            // 
            // _hh5
            // 
            this._hh5.BackgroundImage = global::softwareInc_mod_exe.Properties.Resources.Help_Icon;
            this._hh5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._hh5.Location = new System.Drawing.Point(270, 194);
            this._hh5.Name = "_hh5";
            this._hh5.Size = new System.Drawing.Size(38, 24);
            this._hh5.TabIndex = 42;
            this._hh5.UseVisualStyleBackColor = true;
            // 
            // _hh6
            // 
            this._hh6.BackgroundImage = global::softwareInc_mod_exe.Properties.Resources.Help_Icon;
            this._hh6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._hh6.Location = new System.Drawing.Point(270, 263);
            this._hh6.Name = "_hh6";
            this._hh6.Size = new System.Drawing.Size(38, 24);
            this._hh6.TabIndex = 43;
            this._hh6.UseVisualStyleBackColor = true;
            this._hh6.Click += new System.EventHandler(this.button4_Click);
            // 
            // _hh2
            // 
            this._hh2.BackgroundImage = global::softwareInc_mod_exe.Properties.Resources.Help_Icon;
            this._hh2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._hh2.Location = new System.Drawing.Point(112, 265);
            this._hh2.Name = "_hh2";
            this._hh2.Size = new System.Drawing.Size(38, 24);
            this._hh2.TabIndex = 44;
            this._hh2.UseVisualStyleBackColor = true;
            // 
            // _hh3
            // 
            this._hh3.BackgroundImage = global::softwareInc_mod_exe.Properties.Resources.Help_Icon;
            this._hh3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._hh3.Location = new System.Drawing.Point(107, 340);
            this._hh3.Name = "_hh3";
            this._hh3.Size = new System.Drawing.Size(38, 24);
            this._hh3.TabIndex = 45;
            this._hh3.UseVisualStyleBackColor = true;
            // 
            // _hh4
            // 
            this._hh4.BackgroundImage = global::softwareInc_mod_exe.Properties.Resources.Help_Icon;
            this._hh4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._hh4.Location = new System.Drawing.Point(112, 418);
            this._hh4.Name = "_hh4";
            this._hh4.Size = new System.Drawing.Size(38, 24);
            this._hh4.TabIndex = 46;
            this._hh4.UseVisualStyleBackColor = true;
            // 
            // textBox_server
            // 
            this.textBox_server.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_server.Location = new System.Drawing.Point(176, 293);
            this.textBox_server.Name = "textBox_server";
            this.textBox_server.Size = new System.Drawing.Size(132, 29);
            this.textBox_server.TabIndex = 47;
            // 
            // feature_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 497);
            this.Controls.Add(this.textBox_server);
            this.Controls.Add(this._hh4);
            this.Controls.Add(this._hh3);
            this.Controls.Add(this._hh2);
            this.Controls.Add(this._hh6);
            this.Controls.Add(this._hh5);
            this.Controls.Add(this._hh1);
            this.Controls.Add(this.radioButton_forced);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label_server);
            this.Controls.Add(this.comboBox_from);
            this.Controls.Add(this.label_from);
            this.Controls.Add(this.button_add_dependency);
            this.Controls.Add(this.comboBox_depend);
            this.Controls.Add(this.label_dependencies);
            this.Controls.Add(this.label_art);
            this.Controls.Add(this.trackBar5);
            this.Controls.Add(this.label_stability);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.label_usability);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.label_innovation);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.label_dev);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.textBox_desc);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.button_create_feature);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "feature_form";
            this.Text = "Feature";
            this.Load += new System.EventHandler(this.feature_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_create_feature;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.TextBox textBox_desc;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label_dev;
        private System.Windows.Forms.Label label_innovation;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label_usability;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label label_stability;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.Label label_art;
        private System.Windows.Forms.ComboBox comboBox_depend;
        private System.Windows.Forms.Label label_dependencies;
        private System.Windows.Forms.Button button_add_dependency;
        private System.Windows.Forms.Label label_from;
        private System.Windows.Forms.ComboBox comboBox_from;
        private System.Windows.Forms.Label label_server;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.RadioButton radioButton_forced;
        private System.Windows.Forms.Button _hh1;
        private System.Windows.Forms.Button _hh5;
        private System.Windows.Forms.Button _hh6;
        private System.Windows.Forms.Button _hh2;
        private System.Windows.Forms.Button _hh3;
        private System.Windows.Forms.Button _hh4;
        private System.Windows.Forms.TextBox textBox_server;
    }
}