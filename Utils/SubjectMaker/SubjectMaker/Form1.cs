using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubjectMaker {
    public partial class Form1 : Form {

        List<ClassData> classArray;
        String filePath;
        int curIndex = -1;

        public Form1() {
            InitializeComponent();

            comboBox_week.SelectedIndex = 0;

        }

        private void button_import_Click(object sender , EventArgs e) {
            using (OpenFileDialog dialog = new OpenFileDialog() {
                Title = "JSON파일 선택" ,
                Filter = "JSON Files (.json)|*.json"
            }) {
                if (dialog.ShowDialog() == DialogResult.OK) {

                    filePath = dialog.FileName;
                    textBox_filePath.Text = filePath;

                    //jsonArray = JArray.Parse(File.ReadAllText(filePath));

                    classArray = JsonConvert.DeserializeObject<List<ClassData>>(File.ReadAllText(filePath));

 

                    if (classArray.Count >= 1) {
                        curIndex = 0;
                        SetFields(curIndex);
                    } else {
                        curIndex = -1;
                        ClearFields();
                        label_current_index.Text = "0/0";
                    }
                }
            }
        }


        //필드를 인덱스에 따라 업데이트
        private void SetFields(int index) {
            try {
                if (classArray == null || classArray.Count < index) {
                    MessageBox.Show("SetFields 실패");
                    return;
                }
                ClearFields();

                label_current_index.Text = (curIndex + 1).ToString() + "/" + (classArray.Count).ToString();

                ClassData _class = classArray[index];

                numeric_year.Value = _class.year;
                numeric_semester.Value = _class.semester;
                textBox_code.Text = ClassData.GetCodeFromFullCode(_class.code);

                int classNumber = ClassData.GetClassFromFullCode(_class.code);
                if (classNumber == -1) {
                    checkBox_class.Checked = true;
                } else {
                    checkBox_class.Checked = false;
                    numeric_class.Value = classNumber;
                }

                textBox_name.Text = _class.name;
                textBox_professor.Text = _class.professor;
                textBox_place.Text = _class.place;
                numeric_size.Value = _class.size;
                numeric_grade.Value = _class.grade;


                foreach (var timeslot in _class.time)
                    AddTimeSlot(timeslot);
            } catch (Exception ex) {

            }
        }

        //필드로부터 ClassData 객체를 얻음
        private ClassData GetClassDataFromFields() {
            var output = new ClassData();

            int year = (int)numeric_year.Value;
            int semester = (int)numeric_semester.Value;
            string code="";

            if (checkBox_class.Checked) {
                code = textBox_code.Text;
            } else {
                code = textBox_code.Text +"-"+ String.Format("{0:00}" , numeric_class.Value);
            }

            string name = textBox_name.Text;
            string professor = textBox_professor.Text;
            string place = textBox_place.Text;
            int size = (int)numeric_size.Value;
            int grade = (int)numeric_grade.Value;

            var timeList = new List<TimeSlot>();

            foreach (String timeStr in listBox_timeslot.Items) {
                string week = timeStr.Substring(0 , 3);
                int startHour = int.Parse(timeStr.Substring(4 , 2));
                int startMin = int.Parse(timeStr.Substring(7 , 2));
                int endHour = int.Parse(timeStr.Substring(12 , 2));
                int endMin = int.Parse(timeStr.Substring(15 , 2));

                var timeslot = new TimeSlot();
                timeslot.week = week;
                timeslot.startTime = new HourMin(startHour , startMin);
                timeslot.endTime = new HourMin(endHour , endMin);
                timeList.Add(timeslot);
            }

            output.year = year;
            output.semester = semester;
            output.code = code;
            output.name = name;
            output.professor = professor;
            output.place = place;
            output.size = size;
            output.grade = grade;
            output.time = timeList;
           

            return output;
        }

        private void button_add_Click(object sender , EventArgs e) {
            string week = comboBox_week.SelectedItem.ToString();
            int startHour = (int)numeric_start_hour.Value;
            int startMin = (int)numeric_start_min.Value;
            int endHour = (int)numeric_end_hour.Value;
            int endMin = (int)numeric_end_min.Value;

            var timeslot = new TimeSlot();
            timeslot.week = week;
            timeslot.startTime = new HourMin(startHour , startMin);
            timeslot.endTime = new HourMin(endHour , endMin);

            AddTimeSlot(timeslot);
        }
        private void AddTimeSlot(TimeSlot timeslot) {
            listBox_timeslot.Items.Add(timeslot.ToString());
        }
        private void button_delete_Click(object sender , EventArgs e) {
            if(listBox_timeslot.SelectedIndex!=-1)
            DeleteTimeSlot(listBox_timeslot.SelectedIndex);
        }
        private void DeleteTimeSlot(int index) {
            listBox_timeslot.Items.RemoveAt(index);
        }
    
        //필드를 초기화
        private void ClearFields() {
            numeric_year.Value = 2019;
            numeric_semester.Value = 1;
            textBox_code.Clear();
            checkBox_class.Checked = false;
            numeric_class.Value = -1;
            textBox_name.Clear();
            textBox_professor.Clear();
            textBox_place.Clear();
            numeric_size.Value = -1;
            numeric_grade.Value = -1;
            listBox_timeslot.Items.Clear();
            numeric_start_hour.Value = 0;
            numeric_start_min.Value = 0;
            numeric_end_hour.Value = 0;
            numeric_end_min.Value = 0;
            comboBox_week.SelectedIndex = 0;
        }

        private void checkBox_class_CheckedChanged(object sender , EventArgs e) {
            if (checkBox_class.Checked)
                numeric_class.Enabled = false;
            else
                numeric_class.Enabled = true;
        }

        private void button_export_Click(object sender , EventArgs e) {
            WriteFile();
        }

        private void WriteFile() {
            try {
                File.WriteAllText(filePath , JsonConvert.SerializeObject(classArray));
            } catch (Exception ex) {
                
            }
        }

        private void button_left_Click(object sender , EventArgs e) {
            try {
                if (curIndex == 0)
                    return;

                curIndex--;
                SetFields(curIndex);
            } catch (Exception ex) {

            }
        }

        private void button_right_Click(object sender , EventArgs e) {
            try {
                if (curIndex == classArray.Count - 1)
                    return;

                curIndex++;
                SetFields(curIndex);
            } catch (Exception ex) {

            }
        }

        private void button_apply_Click(object sender , EventArgs e) {
            try {
                classArray[curIndex] = GetClassDataFromFields();
            } catch (Exception ex) {

            }
        }

        private void label18_Click(object sender , EventArgs e) {
            System.Diagnostics.Process.Start("https://github.com/mym0404/");
        }
    }
}
