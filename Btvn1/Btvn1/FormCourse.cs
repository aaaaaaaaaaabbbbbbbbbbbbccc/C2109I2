using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Btvn1
{
    public partial class FormCourse : Form
    {
        public FormCourse()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormCourse_Load(object sender, EventArgs e)
        {
            using (var ef = new BTVNCSharpEntities())
            {
                bindingSource1.DataSource = ef.Courses.ToList();
                dataGridView1.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;
                textCouID.DataBindings.Add("Text", bindingSource1, "couID", true, DataSourceUpdateMode.OnPropertyChanged);
                textCouName.DataBindings.Add("Text", bindingSource1, "couName", true, DataSourceUpdateMode.OnPropertyChanged);
                textCouSemester.DataBindings.Add("Text", bindingSource1, "couSemester", true, DataSourceUpdateMode.OnPropertyChanged);
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            using (var ef = new BTVNCSharpEntities())
            {
                var cou = new Course();
                cou.couName = textCouName.Text;
                cou.couSemester = Convert.ToInt32(textCouSemester.Text);
                ef.Courses.Add(cou);
                await ef.SaveChangesAsync();
                bindingSource1.DataSource = await ef.Courses.ToListAsync();
                MessageBox.Show("Build Success", "Alert", MessageBoxButtons.OK);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            using (var ef = new BTVNCSharpEntities())
            {
                var findId = Convert.ToInt32(textCouID.Text);
                var count = 0;
                foreach (var exam in ef.Exams)
                {
                    if (exam.couId == findId)
                        count++;
                }
                if (count > 0)
                {
                    MessageBox.Show("Can't delete because the table exam is in use!", "Warning", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    foreach (var cou in ef.Courses)
                    {
                        if (cou.couId == findId)
                            ef.Courses.Remove(cou);

                    }
                }

                await ef.SaveChangesAsync();
                bindingSource1.DataSource = await ef.Courses.ToListAsync();
                MessageBox.Show("Build Success", "Alert", MessageBoxButtons.OK);
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var ef = new BTVNCSharpEntities())
            {
                var findId = Convert.ToInt32(textCouID.Text);
                var obj = await ef.Courses.FirstOrDefaultAsync(cou => cou.couId == findId);
                if (obj != null)
                {
                    obj.couName = textCouName.Text;
                    obj.couSemester = Convert.ToInt32(textCouSemester.Text);
                }
                await ef.SaveChangesAsync();
                bindingSource1.DataSource = await ef.Courses.ToListAsync();
                MessageBox.Show("Build Success", "Alert", MessageBoxButtons.OK);
            }
        }

        private async void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            using (var ef = new BTVNCSharpEntities())
            {
                List<Course> listSearch = new List<Course>();
                int count = 0;
                foreach (var item in ef.Courses)
                {
                    string str = "";
                    str = item.couName.ToLower();
                    string str2 = toolStripTextBox1.Text.ToLower();
                    if (str.Contains(str2))
                    {
                        listSearch.Add(item);
                        count++;
                    }
                }
                if (count > 0)
                {
                    bindingSource1.DataSource = listSearch;
                }
                else
                {
                    bindingSource1.DataSource = await ef.Courses.ToListAsync();
                }
            }
        }
    }
}
