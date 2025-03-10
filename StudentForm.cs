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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
 
            StudentNameLabel.Text = "Barcena Eya Nichole";
            StudentAgeLabel.Text = "21";
            StudentAddressLabel.Text = "Tambac";
            StudentContactLabel.Text = "09987654321";
            StudentEmailLabel.Text = "email@gmail.com";
            StudentCourseYearLabel.Text = "BSIT 3rd";
            ParentNameLabel.Text = "Lorena Barcena";
            ParentContactLabel.Text = "09987654321";
            HobbiesLabel.Text = "Reading";
            NicknameLabel.Text = "Eya";
        }

        private void AddImageBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Image functionality is not implemented.", "Feature Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChangeImageBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Change Image functionality is not implemented.", "Feature Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditUpdateBtn_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(this);
            this.Hide();
            editForm.Show();
        }

    }
}