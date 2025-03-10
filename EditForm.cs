using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
            
            CourseComboBox.Items.AddRange(new string[] { "ABEL", "BSBA", "BSIT", "BPA" });
            YearComboBox.Items.AddRange(new string[] { "1st", "2nd", "3rd", "4th" });

            
            LoadUserProfile();
        }

        private void LoadUserProfile()
        {
            
            var userProfile = GetUserProfile();

            
            NameTextBox.Text = userProfile.Name;
            AgeTextBox.Text = userProfile.Age.ToString();
            AddressTextBox.Text = userProfile.Address;
            ContactNumberTextBox.Text = userProfile.ContactNumber;
            EmailTextBox.Text = userProfile.Email;
            CourseComboBox.SelectedItem = userProfile.Course;
            YearComboBox.SelectedItem = userProfile.Year;
            ParentNameTextBox.Text = userProfile.ParentName;
            ParentContactTextBox.Text = userProfile.ParentContact;
            HobbiesTextBox.Text = userProfile.Hobbies;
            NicknameTextBox.Text = userProfile.Nickname;
        }

        private UserProfile GetUserProfile()
        {
            
            return new UserProfile
            {
                Name = "Barcena Eya Nichole",
                Age = 21,
                Address = "Tambac",
                ContactNumber = "09987654321",
                Email = "email@gmail.com",
                Course = "BSIT",
                Year = "3rd",
                ParentName = "Lorena Barcena",
                ParentContact = "09987654321",
                Hobbies = "Reading",
                Nickname = "Eya"
            };
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(NameTextBox.Text) ||
                string.IsNullOrEmpty(AgeTextBox.Text) ||
                string.IsNullOrEmpty(AddressTextBox.Text) ||
                string.IsNullOrEmpty(ContactNumberTextBox.Text) ||
                string.IsNullOrEmpty(CourseComboBox.SelectedItem?.ToString()) ||
                string.IsNullOrEmpty(YearComboBox.SelectedItem?.ToString()) ||
                string.IsNullOrEmpty(EmailTextBox.Text) ||
                string.IsNullOrEmpty(ParentNameTextBox.Text) ||
                string.IsNullOrEmpty(ParentContactTextBox.Text))
            {
                MessageBox.Show("Please fill in all the required fields: Name, Age, Address, Contact Number, Course and Year, Email Address, Guardian/Parent, Guardian/Parent’s Contact Number.", "Required Fields Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (!int.TryParse(AgeTextBox.Text, out _))
            {
                MessageBox.Show("Age field should only accept numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!long.TryParse(ContactNumberTextBox.Text, out _))
            {
                MessageBox.Show("Contact Number field should only accept numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!long.TryParse(ParentContactTextBox.Text, out _))
            {
                MessageBox.Show("Parent Contact Number field should only accept numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            
            var updatedProfile = new UserProfile
            {
                Name = NameTextBox.Text,
                Age = int.Parse(AgeTextBox.Text),
                Address = AddressTextBox.Text,
                ContactNumber = ContactNumberTextBox.Text,
                Email = EmailTextBox.Text,
                Course = CourseComboBox.SelectedItem.ToString(),
                Year = YearComboBox.SelectedItem.ToString(),
                ParentName = ParentNameTextBox.Text,
                ParentContact = ParentContactTextBox.Text,
                Hobbies = HobbiesTextBox.Text,
                Nickname = NicknameTextBox.Text
            };

            
            _studentForm.UpdateStudentInfo(updatedProfile);

            
            MessageBox.Show("Profile successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            this.Hide();
            _studentForm.Show(); 
        }



        private void AgeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void ContactNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void ParentContactTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
    }
    public class UserProfile
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        public string Year { get; set; }
        public string ParentName { get; set; }
        public string ParentContact { get; set; }
        public string Hobbies { get; set; }
        public string Nickname { get; set; }
    }

}
