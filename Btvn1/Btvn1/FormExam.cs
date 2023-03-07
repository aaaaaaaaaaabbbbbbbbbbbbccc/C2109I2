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
    public partial class FormExam : Form
    {
        public FormExam()
        {
            InitializeComponent();
        }

        public List<OBJExam> GetListFull()
        {
            using (var ef = new BTVNCSharpEntities())
            {
                var examGet = ef.Exams.ToList();
                List<OBJExam> listFull = new List<OBJExam>();
                OBJExam objExam;
                foreach (var item in examGet)
                {
                    var stuName = "";
                    var couName = "";
                    objExam = new OBJExam();
                    objExam.examId = item.examId;
                    objExam.examName = item.examName;
                    objExam.examMark = item.examMark;
                    objExam.examDate = item.examDate;
                    objExam.couId = item.couId;
                    objExam.stuId = item.stuId;
                    foreach (var item2 in ef.Students)
                    {
                        if (item.stuId == item2.stuId)
                        {
                            stuName = item2.stuName;
                        }
                    }
                    objExam.stuName = stuName;


                    listFull.Add(objExam);
                }
                return listFull;
            }
        }

                private void FormExam_Load(object sender, EventArgs e)
        {
            using (var ef = new BTVNCSharpEntities())
            {
                bindingSource1.DataSource = GetListFull();
                dataGridView1.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;
                textExamId.DataBindings.Add("Text", bindingSource1, "examId", true, DataSourceUpdateMode.OnPropertyChanged);
                textExamName.DataBindings.Add("Text", bindingSource1, "examName", true, DataSourceUpdateMode.OnPropertyChanged);
                textExamMark.DataBindings.Add("Text", bindingSource1, "examMark", true, DataSourceUpdateMode.OnPropertyChanged);
                cbbStuId.DataBindings.Add("Text", bindingSource1, "stuId", true, DataSourceUpdateMode.OnPropertyChanged);
                cbbCouId.DataBindings.Add("Text", bindingSource1, "couId", true, DataSourceUpdateMode.OnPropertyChanged);
                dtpExamDob.DataBindings.Add("Value", bindingSource1, "examDate", true, DataSourceUpdateMode.OnPropertyChanged);

                foreach (var cou in ef.Courses)
                {
                    cbbCouId.Items.Add(cou.couId);
                }
                foreach (var stu in ef.Students)
                {
                    cbbStuId.Items.Add(stu.stuId);
                }

            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            using (var ef = new BTVNCSharpEntities())
            {
                var exam = new Exam();
                exam.examName = textExamName.Text;
                exam.examMark = Convert.ToDouble(textExamMark.Text);
                exam.stuId = Convert.ToInt32(cbbStuId.SelectedItem);
                exam.couId = Convert.ToInt32(cbbCouId.SelectedItem);
                exam.examDate = dtpExamDob.Value;
                ef.Exams.Add(exam);
                await ef.SaveChangesAsync();
                bindingSource1.DataSource = GetListFull();
                MessageBox.Show("Build Success", "Alert", MessageBoxButtons.OK);

            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            using (var ef = new BTVNCSharpEntities())
            {
                var findIdExam = Convert.ToInt32(textExamId.Text);
                int count = 0;
                foreach (var stu in ef.Students)
                {
                    if (stu.deptId == findIdExam) count++;
                }

                if (count > 0)
                {
                    MessageBox.Show("Can't delete because the table Student is in use!", "Warning", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    foreach (var exam in ef.Exams)
                    {
                        if (exam.examId == findIdExam)
                            ef.Exams.Remove(exam);
                    }
                }
                await ef.SaveChangesAsync();
                bindingSource1.DataSource = GetListFull();
                MessageBox.Show("Build Success", "Alert", MessageBoxButtons.OK);
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var ef = new BTVNCSharpEntities())
            {
                var findId = Convert.ToInt32(textExamId.Text);
                var obj = await ef.Exams.FirstOrDefaultAsync(exam => exam.examId == findId);
                if (obj != null)
                {
                    obj.examName = textExamName.Text;
                    obj.examMark = Convert.ToDouble(textExamMark.Text);
                    obj.stuId = Convert.ToInt32(cbbStuId.SelectedItem);
                    obj.couId = Convert.ToInt32(cbbCouId.SelectedItem);
                    obj.examDate = dtpExamDob.Value;
                }
                await ef.SaveChangesAsync();
                bindingSource1.DataSource = GetListFull();
                MessageBox.Show("Build Success", "Alert", MessageBoxButtons.OK);
            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            List<OBJExam> listSearch = new List<OBJExam>();

            int count = 0;
            foreach (var item in GetListFull())
            {
                string str = "";
                str = item.examName.ToLower();
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
                bindingSource1.DataSource = GetListFull();
            }
        }
    }
}
