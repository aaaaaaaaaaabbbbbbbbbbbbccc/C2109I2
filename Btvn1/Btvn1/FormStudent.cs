using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Btvn1
{
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            using (var ef = new BTVNCSharpEntities())
            {
                bindingSource1.DataSource = ef.Students.ToList();
                dataGridView1.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;
                textStuId.DataBindings.Add("Text", bindingSource1, "stuId", true, DataSourceUpdateMode.OnPropertyChanged);
                textStuPass.DataBindings.Add("Text", bindingSource1, "stuPass", true, DataSourceUpdateMode.OnPropertyChanged);
                textStuName.DataBindings.Add("Text", bindingSource1, "stuName", true, DataSourceUpdateMode.OnPropertyChanged);
                textStuAddress.DataBindings.Add("Text", bindingSource1, "stuAddress", true, DataSourceUpdateMode.OnPropertyChanged);
                textStuPhone.DataBindings.Add("Text", bindingSource1, "stuPhone", true, DataSourceUpdateMode.OnPropertyChanged);
                textStuEmail.DataBindings.Add("Text", bindingSource1, "stuEmail", true, DataSourceUpdateMode.OnPropertyChanged);
                cbbDeptId.DataBindings.Add("Text", bindingSource1, "deptId", true, DataSourceUpdateMode.OnPropertyChanged);
                foreach (var item in ef.Exams)
                {
                    cbbDeptId.Items.Add(item.examId);
                }
            }
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            
           

                using (var ef = new BTVNCSharpEntities())
                {
                    var stu = new Student();
                    stu.stuName = textStuName.Text;
                    stu.stuPass = textStuPass.Text;
                    stu.stuAddress = textStuAddress.Text;
                    stu.stuPhone = Convert.ToInt32(textStuPhone.Text);
                    stu.stuEmail = textStuEmail.Text;
                    stu.deptId = Convert.ToInt32(cbbDeptId.SelectedItem);
                    ef.Students.Add(stu);
                    await ef.SaveChangesAsync();
                    bindingSource1.DataSource = await ef.Students.ToListAsync();
                    MessageBox.Show("Build Success", "Alert", MessageBoxButtons.OK);
                }
            }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var ef = new BTVNCSharpEntities())
            {
                var findId = Convert.ToInt32(textStuId.Text);
                var count = 0;
                foreach (var exam in ef.Exams)
                {
                    if (exam.stuId == findId)
                        count++;
                }
                if (count > 0)
                {
                    MessageBox.Show("Can't delete because the table exam is in use!", "Warning", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    foreach (var stu in ef.Students)
                    {
                        if (stu.stuId == findId)
                            ef.Students.Remove(stu);

                    }
                }
             }
    }

   

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            
          
                using (var ef = new BTVNCSharpEntities())
                {
                    var findId = Convert.ToInt32(textStuId.Text);
                    var obj = await ef.Students.FirstOrDefaultAsync(stu => stu.stuId == findId);
                    if (obj != null)
                    {
                        obj.stuName = textStuName.Text;
                        obj.stuPass = textStuPass.Text;
                        obj.stuAddress = textStuAddress.Text;
                        obj.stuEmail = textStuEmail.Text;
                        obj.stuPhone = Convert.ToInt32(textStuPhone.Text);
                        obj.deptId = Convert.ToInt32(cbbDeptId.SelectedItem);
                    }
                    await ef.SaveChangesAsync();
                    bindingSource1.DataSource = await ef.Students.ToListAsync();
                    MessageBox.Show("Build Success", "Alert", MessageBoxButtons.OK);
                }
            }

        private async void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            using (var ef = new BTVNCSharpEntities())
            {
                List<Student> listSearch = new List<Student>();

                int count = 0;
                foreach (var item in ef.Students)
                {
                    string str = "";
                    str = item.stuName.ToLower();
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
                    bindingSource1.DataSource = await ef.Students.ToListAsync();
                }
            }
        }
    }


   
 }

