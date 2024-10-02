namespace Zoo_interface
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.Exit = new System.Windows.Forms.Button();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.Soul = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ManageBtn = new System.Windows.Forms.RadioButton();
            this.Zoo = new System.Windows.Forms.TabPage();
            this.ZButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AnimalType = new System.Windows.Forms.ComboBox();
            this.ManagementPage = new System.Windows.Forms.TabPage();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Mammals = new System.Windows.Forms.TabPage();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.MHBack = new System.Windows.Forms.Button();
            this.MHTextBox2 = new System.Windows.Forms.TextBox();
            this.MHtextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Birds = new System.Windows.Forms.TabPage();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Reptiles = new System.Windows.Forms.TabPage();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.TabControl.SuspendLayout();
            this.Home.SuspendLayout();
            this.Zoo.SuspendLayout();
            this.ManagementPage.SuspendLayout();
            this.Mammals.SuspendLayout();
            this.Birds.SuspendLayout();
            this.Reptiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Home);
            this.TabControl.Controls.Add(this.Zoo);
            this.TabControl.Controls.Add(this.ManagementPage);
            this.TabControl.Controls.Add(this.Mammals);
            this.TabControl.Controls.Add(this.Birds);
            this.TabControl.Controls.Add(this.Reptiles);
            this.TabControl.Location = new System.Drawing.Point(3, 5);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1076, 625);
            this.TabControl.TabIndex = 4;
            // 
            // Home
            // 
            this.Home.BackgroundImage = global::Zoo_interface.Properties.Resources.openart_image_HQ0hsFQ0_1713258403099_raw;
            this.Home.Controls.Add(this.Exit);
            this.Home.Controls.Add(this.EnterBtn);
            this.Home.Controls.Add(this.Soul);
            this.Home.Controls.Add(this.label1);
            this.Home.Controls.Add(this.ManageBtn);
            this.Home.Location = new System.Drawing.Point(4, 25);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(1068, 596);
            this.Home.TabIndex = 0;
            this.Home.Text = "1";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(635, 357);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(116, 32);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.MBtn_Click);
            // 
            // EnterBtn
            // 
            this.EnterBtn.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterBtn.Location = new System.Drawing.Point(332, 357);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(101, 32);
            this.EnterBtn.TabIndex = 4;
            this.EnterBtn.Text = "Enter";
            this.EnterBtn.UseVisualStyleBackColor = true;
            this.EnterBtn.Click += new System.EventHandler(this.SoulBtn_Click);
            // 
            // Soul
            // 
            this.Soul.AutoSize = true;
            this.Soul.BackColor = System.Drawing.Color.DarkCyan;
            this.Soul.Checked = true;
            this.Soul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Soul.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Soul.Location = new System.Drawing.Point(371, 225);
            this.Soul.Name = "Soul";
            this.Soul.Size = new System.Drawing.Size(75, 24);
            this.Soul.TabIndex = 2;
            this.Soul.TabStop = true;
            this.Soul.Text = "visitor";
            this.Soul.UseVisualStyleBackColor = false;
            this.Soul.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Highland Zoo\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ManageBtn
            // 
            this.ManageBtn.AutoSize = true;
            this.ManageBtn.BackColor = System.Drawing.Color.Teal;
            this.ManageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ManageBtn.Location = new System.Drawing.Point(592, 225);
            this.ManageBtn.Name = "ManageBtn";
            this.ManageBtn.Size = new System.Drawing.Size(126, 24);
            this.ManageBtn.TabIndex = 3;
            this.ManageBtn.Text = "Management";
            this.ManageBtn.UseVisualStyleBackColor = false;
            this.ManageBtn.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Zoo
            // 
            this.Zoo.BackColor = System.Drawing.Color.LightBlue;
            this.Zoo.BackgroundImage = global::Zoo_interface.Properties.Resources.openart_image_HQ0hsFQ0_1713258403099_raw;
            this.Zoo.Controls.Add(this.ZButton);
            this.Zoo.Controls.Add(this.textBox2);
            this.Zoo.Controls.Add(this.textBox1);
            this.Zoo.Controls.Add(this.AnimalType);
            this.Zoo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Zoo.Location = new System.Drawing.Point(4, 25);
            this.Zoo.Name = "Zoo";
            this.Zoo.Padding = new System.Windows.Forms.Padding(3);
            this.Zoo.Size = new System.Drawing.Size(1068, 596);
            this.Zoo.TabIndex = 1;
            this.Zoo.Text = "Zoo page";
            this.Zoo.Click += new System.EventHandler(this.SoulPage_Click);
            // 
            // ZButton
            // 
            this.ZButton.BackColor = System.Drawing.Color.CadetBlue;
            this.ZButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZButton.ForeColor = System.Drawing.Color.Black;
            this.ZButton.Location = new System.Drawing.Point(436, 332);
            this.ZButton.Name = "ZButton";
            this.ZButton.Size = new System.Drawing.Size(178, 37);
            this.ZButton.TabIndex = 3;
            this.ZButton.Text = "Explore";
            this.ZButton.UseVisualStyleBackColor = false;
            this.ZButton.Click += new System.EventHandler(this.ZButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DarkCyan;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(295, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(421, 21);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "What animal habitat would you like to visit today";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Teal;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(313, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(385, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Welcome All Vistiors To The Highland Zoo";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AnimalType
            // 
            this.AnimalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AnimalType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnimalType.FormattingEnabled = true;
            this.AnimalType.Items.AddRange(new object[] {
            "Mammals",
            "Birds",
            "Reptiles"});
            this.AnimalType.Location = new System.Drawing.Point(368, 216);
            this.AnimalType.Name = "AnimalType";
            this.AnimalType.Size = new System.Drawing.Size(283, 28);
            this.AnimalType.TabIndex = 1;
            this.AnimalType.Tag = "habitat";
            this.AnimalType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ManagementPage
            // 
            this.ManagementPage.BackgroundImage = global::Zoo_interface.Properties.Resources.openart_image_HQ0hsFQ0_1713258403099_raw;
            this.ManagementPage.Controls.Add(this.textBox22);
            this.ManagementPage.Controls.Add(this.textBox23);
            this.ManagementPage.Controls.Add(this.button10);
            this.ManagementPage.Controls.Add(this.textBox21);
            this.ManagementPage.Controls.Add(this.comboBox7);
            this.ManagementPage.Controls.Add(this.comboBox8);
            this.ManagementPage.Controls.Add(this.textBox19);
            this.ManagementPage.Controls.Add(this.textBox20);
            this.ManagementPage.Controls.Add(this.button9);
            this.ManagementPage.Controls.Add(this.button8);
            this.ManagementPage.Controls.Add(this.textBox17);
            this.ManagementPage.Controls.Add(this.textBox18);
            this.ManagementPage.Controls.Add(this.button3);
            this.ManagementPage.Controls.Add(this.button4);
            this.ManagementPage.Location = new System.Drawing.Point(4, 25);
            this.ManagementPage.Name = "ManagementPage";
            this.ManagementPage.Padding = new System.Windows.Forms.Padding(3);
            this.ManagementPage.Size = new System.Drawing.Size(1068, 596);
            this.ManagementPage.TabIndex = 2;
            this.ManagementPage.Text = "Management page";
            this.ManagementPage.UseVisualStyleBackColor = true;
            // 
            // textBox22
            // 
            this.textBox22.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox22.Location = new System.Drawing.Point(797, 350);
            this.textBox22.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(113, 26);
            this.textBox22.TabIndex = 53;
            this.textBox22.TextChanged += new System.EventHandler(this.textBox22_TextChanged);
            // 
            // textBox23
            // 
            this.textBox23.BackColor = System.Drawing.Color.DarkCyan;
            this.textBox23.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox23.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox23.ForeColor = System.Drawing.Color.Black;
            this.textBox23.Location = new System.Drawing.Point(766, 306);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(155, 25);
            this.textBox23.TabIndex = 52;
            this.textBox23.Text = "Give nickname";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.CadetBlue;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.Location = new System.Drawing.Point(786, 398);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(124, 37);
            this.button10.TabIndex = 51;
            this.button10.Tag = "Nickname";
            this.button10.Text = "Name";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // textBox21
            // 
            this.textBox21.BackColor = System.Drawing.Color.CadetBlue;
            this.textBox21.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox21.ForeColor = System.Drawing.Color.Black;
            this.textBox21.Location = new System.Drawing.Point(104, 306);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(219, 25);
            this.textBox21.TabIndex = 50;
            this.textBox21.Text = "Animal Food";
            this.textBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox7
            // 
            this.comboBox7.BackColor = System.Drawing.Color.LightCyan;
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "Meat",
            "Fish",
            "Fruits",
            "Seeds",
            "Berries"});
            this.comboBox7.Location = new System.Drawing.Point(135, 347);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(143, 28);
            this.comboBox7.TabIndex = 49;
            this.comboBox7.Tag = "MFeed";
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // comboBox8
            // 
            this.comboBox8.BackColor = System.Drawing.Color.LightCyan;
            this.comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "Lions",
            "Bears",
            "parrots",
            "flamingos",
            "snakes",
            "turtles"});
            this.comboBox8.Location = new System.Drawing.Point(387, 175);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(283, 28);
            this.comboBox8.TabIndex = 48;
            this.comboBox8.Tag = "Mhabitat";
            this.comboBox8.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            // 
            // textBox19
            // 
            this.textBox19.BackColor = System.Drawing.Color.DarkCyan;
            this.textBox19.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox19.ForeColor = System.Drawing.Color.Black;
            this.textBox19.Location = new System.Drawing.Point(323, 121);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(421, 21);
            this.textBox19.TabIndex = 47;
            this.textBox19.Text = "Which animal would like to work with today";
            this.textBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox20
            // 
            this.textBox20.BackColor = System.Drawing.Color.Teal;
            this.textBox20.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox20.Location = new System.Drawing.Point(343, 63);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(372, 23);
            this.textBox20.TabIndex = 46;
            this.textBox20.Text = "Welcome All Vistiors To The Highland Zoo";
            this.textBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.CadetBlue;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(468, 489);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(129, 37);
            this.button9.TabIndex = 45;
            this.button9.Text = "Closing time";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.CadetBlue;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(135, 417);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(126, 37);
            this.button8.TabIndex = 44;
            this.button8.Tag = "Feed";
            this.button8.Text = "Feed";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox17
            // 
            this.textBox17.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox17.Location = new System.Drawing.Point(546, 352);
            this.textBox17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(89, 26);
            this.textBox17.TabIndex = 43;
            this.textBox17.TextChanged += new System.EventHandler(this.textBox17_TextChanged);
            // 
            // textBox18
            // 
            this.textBox18.BackColor = System.Drawing.Color.DarkCyan;
            this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox18.ForeColor = System.Drawing.Color.Black;
            this.textBox18.Location = new System.Drawing.Point(377, 353);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(149, 25);
            this.textBox18.TabIndex = 42;
            this.textBox18.Text = "Amount move: ";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CadetBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(797, 489);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 37);
            this.button3.TabIndex = 13;
            this.button3.Tag = "Status";
            this.button3.Text = "Status";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.CadetBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(473, 398);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 37);
            this.button4.TabIndex = 12;
            this.button4.Tag = "Move";
            this.button4.Text = "Move";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Mammals
            // 
            this.Mammals.BackgroundImage = global::Zoo_interface.Properties.Resources.blank_banner_rainforest_scene_with_wild_animals_1308_60884;
            this.Mammals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Mammals.Controls.Add(this.textBox8);
            this.Mammals.Controls.Add(this.comboBox4);
            this.Mammals.Controls.Add(this.button5);
            this.Mammals.Controls.Add(this.MHBack);
            this.Mammals.Controls.Add(this.MHTextBox2);
            this.Mammals.Controls.Add(this.MHtextBox);
            this.Mammals.Controls.Add(this.comboBox1);
            this.Mammals.Location = new System.Drawing.Point(4, 25);
            this.Mammals.Name = "Mammals";
            this.Mammals.Padding = new System.Windows.Forms.Padding(3);
            this.Mammals.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Mammals.Size = new System.Drawing.Size(1068, 596);
            this.Mammals.TabIndex = 3;
            this.Mammals.Text = "MammalsPage";
            this.Mammals.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.SaddleBrown;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.Color.Black;
            this.textBox8.Location = new System.Drawing.Point(390, 319);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(283, 25);
            this.textBox8.TabIndex = 34;
            this.textBox8.Text = "Animal(Mammal) Food";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.Color.LightCyan;
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Meat",
            "Fish",
            "Fruits",
            "Seeds",
            "Berries"});
            this.comboBox4.Location = new System.Drawing.Point(457, 360);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(143, 28);
            this.comboBox4.TabIndex = 12;
            this.comboBox4.Tag = "MaFeed";
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SaddleBrown;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(349, 478);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 37);
            this.button5.TabIndex = 9;
            this.button5.Tag = "Feed";
            this.button5.Text = "Feed";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // MHBack
            // 
            this.MHBack.BackColor = System.Drawing.Color.ForestGreen;
            this.MHBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MHBack.ForeColor = System.Drawing.Color.Black;
            this.MHBack.Location = new System.Drawing.Point(599, 478);
            this.MHBack.Name = "MHBack";
            this.MHBack.Size = new System.Drawing.Size(129, 37);
            this.MHBack.TabIndex = 6;
            this.MHBack.Text = "Back";
            this.MHBack.UseVisualStyleBackColor = false;
            this.MHBack.Click += new System.EventHandler(this.MHBack_Click);
            // 
            // MHTextBox2
            // 
            this.MHTextBox2.BackColor = System.Drawing.Color.ForestGreen;
            this.MHTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MHTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MHTextBox2.ForeColor = System.Drawing.Color.Black;
            this.MHTextBox2.Location = new System.Drawing.Point(298, 157);
            this.MHTextBox2.Name = "MHTextBox2";
            this.MHTextBox2.Size = new System.Drawing.Size(519, 23);
            this.MHTextBox2.TabIndex = 4;
            this.MHTextBox2.Text = "Please set the animal you would like to interact with today";
            this.MHTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MHtextBox
            // 
            this.MHtextBox.BackColor = System.Drawing.Color.YellowGreen;
            this.MHtextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MHtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MHtextBox.ForeColor = System.Drawing.Color.Black;
            this.MHtextBox.Location = new System.Drawing.Point(340, 67);
            this.MHtextBox.Name = "MHtextBox";
            this.MHtextBox.Size = new System.Drawing.Size(421, 25);
            this.MHtextBox.TabIndex = 3;
            this.MHtextBox.Text = "Welcome to the Mammal Habitat";
            this.MHtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.LightCyan;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Lions",
            "Bears"});
            this.comboBox1.Location = new System.Drawing.Point(390, 263);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(283, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Tag = "habitat";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // Birds
            // 
            this.Birds.BackgroundImage = global::Zoo_interface.Properties.Resources.bird_4k_download_backgrounds_for_pc_wallpaper_preview;
            this.Birds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Birds.Controls.Add(this.textBox9);
            this.Birds.Controls.Add(this.comboBox5);
            this.Birds.Controls.Add(this.button1);
            this.Birds.Controls.Add(this.button2);
            this.Birds.Controls.Add(this.textBox4);
            this.Birds.Controls.Add(this.textBox5);
            this.Birds.Controls.Add(this.comboBox2);
            this.Birds.Location = new System.Drawing.Point(4, 25);
            this.Birds.Name = "Birds";
            this.Birds.Padding = new System.Windows.Forms.Padding(3);
            this.Birds.Size = new System.Drawing.Size(1068, 596);
            this.Birds.TabIndex = 4;
            this.Birds.Text = "BirdPage";
            this.Birds.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(29)))), ((int)(((byte)(23)))));
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox9.Location = new System.Drawing.Point(376, 305);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(283, 25);
            this.textBox9.TabIndex = 40;
            this.textBox9.Text = "Animal(Bird) Food";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox5
            // 
            this.comboBox5.BackColor = System.Drawing.Color.LightCyan;
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Seeds",
            "Fish",
            "Fruits",
            "Berries"});
            this.comboBox5.Location = new System.Drawing.Point(443, 346);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(143, 28);
            this.comboBox5.TabIndex = 37;
            this.comboBox5.Tag = "BFeed";
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(29)))), ((int)(((byte)(23)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(323, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 37);
            this.button1.TabIndex = 36;
            this.button1.Tag = "Feed";
            this.button1.Text = "Feed";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.ForestGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(585, 464);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 37);
            this.button2.TabIndex = 35;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(29)))), ((int)(((byte)(23)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox4.Location = new System.Drawing.Point(285, 188);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(519, 23);
            this.textBox4.TabIndex = 14;
            this.textBox4.Text = "Please set the Bird you would like to interact with today";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(18)))), ((int)(((byte)(17)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(323, 75);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(421, 25);
            this.textBox5.TabIndex = 13;
            this.textBox5.Text = "Welcome to the Bird Habitat";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.LightCyan;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "parrots",
            "flamboyance"});
            this.comboBox2.Location = new System.Drawing.Point(378, 239);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(283, 28);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.Tag = "Bhabitat";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged_1);
            // 
            // Reptiles
            // 
            this.Reptiles.BackgroundImage = global::Zoo_interface.Properties.Resources.Reptile;
            this.Reptiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Reptiles.Controls.Add(this.textBox12);
            this.Reptiles.Controls.Add(this.comboBox6);
            this.Reptiles.Controls.Add(this.button6);
            this.Reptiles.Controls.Add(this.button7);
            this.Reptiles.Controls.Add(this.textBox6);
            this.Reptiles.Controls.Add(this.textBox7);
            this.Reptiles.Controls.Add(this.comboBox3);
            this.Reptiles.Location = new System.Drawing.Point(4, 25);
            this.Reptiles.Name = "Reptiles";
            this.Reptiles.Padding = new System.Windows.Forms.Padding(3);
            this.Reptiles.Size = new System.Drawing.Size(1068, 596);
            this.Reptiles.TabIndex = 5;
            this.Reptiles.Text = "ReptilePage";
            this.Reptiles.UseVisualStyleBackColor = true;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.ForestGreen;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.ForeColor = System.Drawing.Color.Black;
            this.textBox12.Location = new System.Drawing.Point(390, 304);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(283, 25);
            this.textBox12.TabIndex = 40;
            this.textBox12.Text = "Animal(Reptile) Food";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox6
            // 
            this.comboBox6.BackColor = System.Drawing.Color.LightCyan;
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "Meat",
            "Fish",
            "Fruits"});
            this.comboBox6.Location = new System.Drawing.Point(457, 345);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(143, 28);
            this.comboBox6.TabIndex = 37;
            this.comboBox6.Tag = "BFeed";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Chartreuse;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(327, 463);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 37);
            this.button6.TabIndex = 36;
            this.button6.Tag = "Feed";
            this.button6.Text = "Feed";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.ForestGreen;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(601, 463);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(129, 37);
            this.button7.TabIndex = 35;
            this.button7.Text = "Back";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.ForestGreen;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.Black;
            this.textBox6.Location = new System.Drawing.Point(285, 188);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(519, 23);
            this.textBox6.TabIndex = 21;
            this.textBox6.Text = "Please set the Reptile you would like to interact with today";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.YellowGreen;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.Black;
            this.textBox7.Location = new System.Drawing.Point(327, 98);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(421, 25);
            this.textBox7.TabIndex = 20;
            this.textBox7.Text = "Welcome to the Reptile Habitat";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.LightCyan;
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "snakes",
            "turtles"});
            this.comboBox3.Location = new System.Drawing.Point(392, 236);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(283, 28);
            this.comboBox3.TabIndex = 19;
            this.comboBox3.Tag = "Rhabitat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 630);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            this.Zoo.ResumeLayout(false);
            this.Zoo.PerformLayout();
            this.ManagementPage.ResumeLayout(false);
            this.ManagementPage.PerformLayout();
            this.Mammals.ResumeLayout(false);
            this.Mammals.PerformLayout();
            this.Birds.ResumeLayout(false);
            this.Birds.PerformLayout();
            this.Reptiles.ResumeLayout(false);
            this.Reptiles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage Reptiles;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TabPage Birds;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TabPage Mammals;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button MHBack;
        private System.Windows.Forms.TextBox MHTextBox2;
        private System.Windows.Forms.TextBox MHtextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage ManagementPage;
        private System.Windows.Forms.TabPage Zoo;
        private System.Windows.Forms.Button ZButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox AnimalType;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button EnterBtn;
        private System.Windows.Forms.RadioButton Soul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton ManageBtn;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox23;
    }
}

