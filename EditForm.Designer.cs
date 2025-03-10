namespace FormsApp
{
    partial class EditForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.ContactNumberLabel = new System.Windows.Forms.Label();
            this.ContactNumberTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.CourseLabel = new System.Windows.Forms.Label();
            this.CourseComboBox = new System.Windows.Forms.ComboBox();
            this.YearLabel = new System.Windows.Forms.Label();
            this.YearComboBox = new System.Windows.Forms.ComboBox();
            this.ParentNameLabel = new System.Windows.Forms.Label();
            this.ParentNameTextBox = new System.Windows.Forms.TextBox();
            this.ParentContactLabel = new System.Windows.Forms.Label();
            this.ParentContactTextBox = new System.Windows.Forms.TextBox();
            this.HobbiesLabel = new System.Windows.Forms.Label();
            this.HobbiesTextBox = new System.Windows.Forms.TextBox();
            this.NicknameLabel = new System.Windows.Forms.Label();
            this.NicknameTextBox = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.NameLabel.Location = new System.Drawing.Point(40, 37);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(56, 19);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(160, 33);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(265, 22);
            this.NameTextBox.TabIndex = 1;
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.AgeLabel.Location = new System.Drawing.Point(40, 74);
            this.AgeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(41, 19);
            this.AgeLabel.TabIndex = 2;
            this.AgeLabel.Text = "Age:";
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(160, 70);
            this.AgeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(65, 22);
            this.AgeTextBox.TabIndex = 2;
            this.AgeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AgeTextBox_KeyPress);
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.AddressLabel.Location = new System.Drawing.Point(40, 111);
            this.AddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(66, 19);
            this.AddressLabel.TabIndex = 4;
            this.AddressLabel.Text = "Address:";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(160, 107);
            this.AddressTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(265, 22);
            this.AddressTextBox.TabIndex = 3;
            // 
            // ContactNumberLabel
            // 
            this.ContactNumberLabel.AutoSize = true;
            this.ContactNumberLabel.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNumberLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.ContactNumberLabel.Location = new System.Drawing.Point(31, 147);
            this.ContactNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ContactNumberLabel.Name = "ContactNumberLabel";
            this.ContactNumberLabel.Size = new System.Drawing.Size(131, 19);
            this.ContactNumberLabel.TabIndex = 6;
            this.ContactNumberLabel.Text = "Contact Number:";
            // 
            // ContactNumberTextBox
            // 
            this.ContactNumberTextBox.Location = new System.Drawing.Point(160, 144);
            this.ContactNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ContactNumberTextBox.Name = "ContactNumberTextBox";
            this.ContactNumberTextBox.Size = new System.Drawing.Size(199, 22);
            this.ContactNumberTextBox.TabIndex = 4;
            this.ContactNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ContactNumberTextBox_KeyPress);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.EmailLabel.Location = new System.Drawing.Point(40, 185);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(53, 19);
            this.EmailLabel.TabIndex = 8;
            this.EmailLabel.Text = "Email:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(160, 181);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(265, 22);
            this.EmailTextBox.TabIndex = 5;
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.CourseLabel.Location = new System.Drawing.Point(40, 222);
            this.CourseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(60, 19);
            this.CourseLabel.TabIndex = 10;
            this.CourseLabel.Text = "Course:";
            // 
            // CourseComboBox
            // 
            this.CourseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CourseComboBox.FormattingEnabled = true;
            this.CourseComboBox.Location = new System.Drawing.Point(160, 218);
            this.CourseComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CourseComboBox.Name = "CourseComboBox";
            this.CourseComboBox.Size = new System.Drawing.Size(159, 24);
            this.CourseComboBox.TabIndex = 6;
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.YearLabel.Location = new System.Drawing.Point(40, 258);
            this.YearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(46, 19);
            this.YearLabel.TabIndex = 12;
            this.YearLabel.Text = "Year:";
            // 
            // YearComboBox
            // 
            this.YearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearComboBox.FormattingEnabled = true;
            this.YearComboBox.Location = new System.Drawing.Point(160, 255);
            this.YearComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.YearComboBox.Name = "YearComboBox";
            this.YearComboBox.Size = new System.Drawing.Size(159, 24);
            this.YearComboBox.TabIndex = 7;
            // 
            // ParentNameLabel
            // 
            this.ParentNameLabel.AutoSize = true;
            this.ParentNameLabel.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParentNameLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.ParentNameLabel.Location = new System.Drawing.Point(40, 295);
            this.ParentNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ParentNameLabel.Name = "ParentNameLabel";
            this.ParentNameLabel.Size = new System.Drawing.Size(109, 19);
            this.ParentNameLabel.TabIndex = 14;
            this.ParentNameLabel.Text = "Parent Name:";
            // 
            // ParentNameTextBox
            // 
            this.ParentNameTextBox.Location = new System.Drawing.Point(160, 292);
            this.ParentNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ParentNameTextBox.Name = "ParentNameTextBox";
            this.ParentNameTextBox.Size = new System.Drawing.Size(265, 22);
            this.ParentNameTextBox.TabIndex = 8;
            // 
            // ParentContactLabel
            // 
            this.ParentContactLabel.AutoSize = true;
            this.ParentContactLabel.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParentContactLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.ParentContactLabel.Location = new System.Drawing.Point(31, 332);
            this.ParentContactLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ParentContactLabel.Name = "ParentContactLabel";
            this.ParentContactLabel.Size = new System.Drawing.Size(122, 19);
            this.ParentContactLabel.TabIndex = 16;
            this.ParentContactLabel.Text = "Parent Contact:";
            // 
            // ParentContactTextBox
            // 
            this.ParentContactTextBox.Location = new System.Drawing.Point(160, 329);
            this.ParentContactTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ParentContactTextBox.Name = "ParentContactTextBox";
            this.ParentContactTextBox.Size = new System.Drawing.Size(199, 22);
            this.ParentContactTextBox.TabIndex = 9;
            this.ParentContactTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ParentContactTextBox_KeyPress);
            // 
            // HobbiesLabel
            // 
            this.HobbiesLabel.AutoSize = true;
            this.HobbiesLabel.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HobbiesLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.HobbiesLabel.Location = new System.Drawing.Point(40, 369);
            this.HobbiesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HobbiesLabel.Name = "HobbiesLabel";
            this.HobbiesLabel.Size = new System.Drawing.Size(69, 19);
            this.HobbiesLabel.TabIndex = 18;
            this.HobbiesLabel.Text = "Hobbies:";
            // 
            // HobbiesTextBox
            // 
            this.HobbiesTextBox.Location = new System.Drawing.Point(160, 366);
            this.HobbiesTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HobbiesTextBox.Name = "HobbiesTextBox";
            this.HobbiesTextBox.Size = new System.Drawing.Size(265, 22);
            this.HobbiesTextBox.TabIndex = 10;
            // 
            // NicknameLabel
            // 
            this.NicknameLabel.AutoSize = true;
            this.NicknameLabel.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NicknameLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.NicknameLabel.Location = new System.Drawing.Point(40, 406);
            this.NicknameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NicknameLabel.Name = "NicknameLabel";
            this.NicknameLabel.Size = new System.Drawing.Size(85, 19);
            this.NicknameLabel.TabIndex = 20;
            this.NicknameLabel.Text = "Nickname:";
            // 
            // NicknameTextBox
            // 
            this.NicknameTextBox.Location = new System.Drawing.Point(160, 402);
            this.NicknameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NicknameTextBox.Name = "NicknameTextBox";
            this.NicknameTextBox.Size = new System.Drawing.Size(265, 22);
            this.NicknameTextBox.TabIndex = 11;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.Firebrick;
            this.SaveBtn.Location = new System.Drawing.Point(209, 453);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(110, 31);
            this.SaveBtn.TabIndex = 12;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(533, 554);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.NicknameTextBox);
            this.Controls.Add(this.NicknameLabel);
            this.Controls.Add(this.HobbiesTextBox);
            this.Controls.Add(this.HobbiesLabel);
            this.Controls.Add(this.ParentContactTextBox);
            this.Controls.Add(this.ParentContactLabel);
            this.Controls.Add(this.ParentNameTextBox);
            this.Controls.Add(this.ParentNameLabel);
            this.Controls.Add(this.YearComboBox);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.CourseComboBox);
            this.Controls.Add(this.CourseLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.ContactNumberTextBox);
            this.Controls.Add(this.ContactNumberLabel);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditForm";
            this.Text = "Edit Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private StudentForm _studentForm;

        public EditForm(StudentForm studentForm)
        {
            InitializeComponent();
            _studentForm = studentForm;

        
            CourseComboBox.Items.AddRange(new string[] { "ABEL", "BSBA", "BSIT", "BPA" });
            YearComboBox.Items.AddRange(new string[] { "1st", "2nd", "3rd", "4th" });

            
            LoadUserProfile();
        }



        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label ContactNumberLabel;
        private System.Windows.Forms.TextBox ContactNumberTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label CourseLabel;
        private System.Windows.Forms.ComboBox CourseComboBox;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.ComboBox YearComboBox;
        private System.Windows.Forms.Label ParentNameLabel;
        private System.Windows.Forms.TextBox ParentNameTextBox;
        private System.Windows.Forms.Label ParentContactLabel;
        private System.Windows.Forms.TextBox ParentContactTextBox;
        private System.Windows.Forms.Label HobbiesLabel;
        private System.Windows.Forms.TextBox HobbiesTextBox;
        private System.Windows.Forms.Label NicknameLabel;
        private System.Windows.Forms.TextBox NicknameTextBox;
        private System.Windows.Forms.Button SaveBtn;
    }
}