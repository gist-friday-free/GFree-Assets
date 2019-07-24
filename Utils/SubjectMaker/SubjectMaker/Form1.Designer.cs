namespace SubjectMaker {
    partial class Form1 {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_export = new System.Windows.Forms.Button();
            this.label_current_index = new System.Windows.Forms.Label();
            this.button_right = new System.Windows.Forms.Button();
            this.button_left = new System.Windows.Forms.Button();
            this.button_import = new System.Windows.Forms.Button();
            this.textBox_filePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_code = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_professor = new System.Windows.Forms.TextBox();
            this.textBox_place = new System.Windows.Forms.TextBox();
            this.numeric_size = new System.Windows.Forms.NumericUpDown();
            this.numeric_grade = new System.Windows.Forms.NumericUpDown();
            this.numeric_year = new System.Windows.Forms.NumericUpDown();
            this.numeric_semester = new System.Windows.Forms.NumericUpDown();
            this.listBox_timeslot = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBox_class = new System.Windows.Forms.CheckBox();
            this.numeric_class = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numeric_start_hour = new System.Windows.Forms.NumericUpDown();
            this.numeric_start_min = new System.Windows.Forms.NumericUpDown();
            this.numeric_end_hour = new System.Windows.Forms.NumericUpDown();
            this.numeric_end_min = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_week = new System.Windows.Forms.ComboBox();
            this.button_apply = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_grade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_semester)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_class)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_start_hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_start_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_end_hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_end_min)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_export);
            this.groupBox1.Controls.Add(this.label_current_index);
            this.groupBox1.Controls.Add(this.button_right);
            this.groupBox1.Controls.Add(this.button_left);
            this.groupBox1.Controls.Add(this.button_import);
            this.groupBox1.Controls.Add(this.textBox_filePath);
            this.groupBox1.Location = new System.Drawing.Point(688, 478);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "JSON";
            // 
            // button_export
            // 
            this.button_export.Location = new System.Drawing.Point(215, 145);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(110, 38);
            this.button_export.TabIndex = 5;
            this.button_export.Text = "내보내기";
            this.button_export.UseVisualStyleBackColor = true;
            this.button_export.Click += new System.EventHandler(this.button_export_Click);
            // 
            // label_current_index
            // 
            this.label_current_index.AutoSize = true;
            this.label_current_index.Location = new System.Drawing.Point(225, 104);
            this.label_current_index.Name = "label_current_index";
            this.label_current_index.Size = new System.Drawing.Size(41, 21);
            this.label_current_index.TabIndex = 4;
            this.label_current_index.Text = "0/0";
            // 
            // button_right
            // 
            this.button_right.Location = new System.Drawing.Point(89, 94);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(45, 41);
            this.button_right.TabIndex = 3;
            this.button_right.Text = ">";
            this.button_right.UseVisualStyleBackColor = true;
            this.button_right.Click += new System.EventHandler(this.button_right_Click);
            // 
            // button_left
            // 
            this.button_left.Location = new System.Drawing.Point(24, 94);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(45, 41);
            this.button_left.TabIndex = 2;
            this.button_left.Text = "<";
            this.button_left.UseVisualStyleBackColor = true;
            this.button_left.Click += new System.EventHandler(this.button_left_Click);
            // 
            // button_import
            // 
            this.button_import.Location = new System.Drawing.Point(272, 46);
            this.button_import.Name = "button_import";
            this.button_import.Size = new System.Drawing.Size(53, 32);
            this.button_import.TabIndex = 1;
            this.button_import.Text = "...";
            this.button_import.UseVisualStyleBackColor = true;
            this.button_import.Click += new System.EventHandler(this.button_import_Click);
            // 
            // textBox_filePath
            // 
            this.textBox_filePath.Location = new System.Drawing.Point(24, 46);
            this.textBox_filePath.Name = "textBox_filePath";
            this.textBox_filePath.Size = new System.Drawing.Size(242, 32);
            this.textBox_filePath.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "년도";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "학기";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "코드";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "과목명";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "교수";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "장소";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 512);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "정원";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(74, 579);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "학점";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(571, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 21);
            this.label10.TabIndex = 9;
            this.label10.Text = "시간 목록";
            // 
            // textBox_code
            // 
            this.textBox_code.Location = new System.Drawing.Point(147, 177);
            this.textBox_code.Name = "textBox_code";
            this.textBox_code.Size = new System.Drawing.Size(358, 32);
            this.textBox_code.TabIndex = 12;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(147, 311);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(358, 32);
            this.textBox_name.TabIndex = 13;
            // 
            // textBox_professor
            // 
            this.textBox_professor.Location = new System.Drawing.Point(147, 378);
            this.textBox_professor.Name = "textBox_professor";
            this.textBox_professor.Size = new System.Drawing.Size(358, 32);
            this.textBox_professor.TabIndex = 14;
            // 
            // textBox_place
            // 
            this.textBox_place.Location = new System.Drawing.Point(147, 445);
            this.textBox_place.Name = "textBox_place";
            this.textBox_place.Size = new System.Drawing.Size(358, 32);
            this.textBox_place.TabIndex = 15;
            // 
            // numeric_size
            // 
            this.numeric_size.Location = new System.Drawing.Point(147, 512);
            this.numeric_size.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numeric_size.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numeric_size.Name = "numeric_size";
            this.numeric_size.Size = new System.Drawing.Size(358, 32);
            this.numeric_size.TabIndex = 16;
            // 
            // numeric_grade
            // 
            this.numeric_grade.Location = new System.Drawing.Point(147, 579);
            this.numeric_grade.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numeric_grade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numeric_grade.Name = "numeric_grade";
            this.numeric_grade.Size = new System.Drawing.Size(358, 32);
            this.numeric_grade.TabIndex = 17;
            // 
            // numeric_year
            // 
            this.numeric_year.Location = new System.Drawing.Point(147, 43);
            this.numeric_year.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numeric_year.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numeric_year.Name = "numeric_year";
            this.numeric_year.Size = new System.Drawing.Size(358, 32);
            this.numeric_year.TabIndex = 18;
            this.numeric_year.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // numeric_semester
            // 
            this.numeric_semester.Location = new System.Drawing.Point(147, 110);
            this.numeric_semester.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numeric_semester.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_semester.Name = "numeric_semester";
            this.numeric_semester.Size = new System.Drawing.Size(358, 32);
            this.numeric_semester.TabIndex = 19;
            this.numeric_semester.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // listBox_timeslot
            // 
            this.listBox_timeslot.FormattingEnabled = true;
            this.listBox_timeslot.ItemHeight = 21;
            this.listBox_timeslot.Location = new System.Drawing.Point(700, 51);
            this.listBox_timeslot.Name = "listBox_timeslot";
            this.listBox_timeslot.Size = new System.Drawing.Size(335, 172);
            this.listBox_timeslot.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(74, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 21);
            this.label11.TabIndex = 21;
            this.label11.Text = "분반";
            // 
            // checkBox_class
            // 
            this.checkBox_class.AutoSize = true;
            this.checkBox_class.Location = new System.Drawing.Point(283, 245);
            this.checkBox_class.Name = "checkBox_class";
            this.checkBox_class.Size = new System.Drawing.Size(78, 25);
            this.checkBox_class.TabIndex = 22;
            this.checkBox_class.Text = "없음";
            this.checkBox_class.UseVisualStyleBackColor = true;
            this.checkBox_class.CheckedChanged += new System.EventHandler(this.checkBox_class_CheckedChanged);
            // 
            // numeric_class
            // 
            this.numeric_class.Location = new System.Drawing.Point(385, 244);
            this.numeric_class.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numeric_class.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numeric_class.Name = "numeric_class";
            this.numeric_class.Size = new System.Drawing.Size(120, 32);
            this.numeric_class.TabIndex = 23;
            this.numeric_class.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(571, 361);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 21);
            this.label12.TabIndex = 24;
            this.label12.Text = "시작 시간";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(550, 425);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 21);
            this.label13.TabIndex = 25;
            this.label13.Text = "끝나는 시간";
            // 
            // numeric_start_hour
            // 
            this.numeric_start_hour.Location = new System.Drawing.Point(700, 355);
            this.numeric_start_hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numeric_start_hour.Name = "numeric_start_hour";
            this.numeric_start_hour.Size = new System.Drawing.Size(80, 32);
            this.numeric_start_hour.TabIndex = 26;
            // 
            // numeric_start_min
            // 
            this.numeric_start_min.Location = new System.Drawing.Point(823, 355);
            this.numeric_start_min.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numeric_start_min.Name = "numeric_start_min";
            this.numeric_start_min.Size = new System.Drawing.Size(80, 32);
            this.numeric_start_min.TabIndex = 27;
            // 
            // numeric_end_hour
            // 
            this.numeric_end_hour.Location = new System.Drawing.Point(700, 420);
            this.numeric_end_hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numeric_end_hour.Name = "numeric_end_hour";
            this.numeric_end_hour.Size = new System.Drawing.Size(80, 32);
            this.numeric_end_hour.TabIndex = 28;
            // 
            // numeric_end_min
            // 
            this.numeric_end_min.Location = new System.Drawing.Point(823, 420);
            this.numeric_end_min.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numeric_end_min.Name = "numeric_end_min";
            this.numeric_end_min.Size = new System.Drawing.Size(80, 32);
            this.numeric_end_min.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(786, 361);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 21);
            this.label14.TabIndex = 30;
            this.label14.Text = "시";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(910, 361);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 21);
            this.label15.TabIndex = 31;
            this.label15.Text = "분";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(786, 426);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 21);
            this.label16.TabIndex = 32;
            this.label16.Text = "시";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(910, 426);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 21);
            this.label17.TabIndex = 33;
            this.label17.Text = "분";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(758, 233);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(93, 32);
            this.button_add.TabIndex = 34;
            this.button_add.Text = "추가";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(884, 233);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(93, 32);
            this.button_delete.TabIndex = 35;
            this.button_delete.Text = "삭제";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(620, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 36;
            this.label1.Text = "요일";
            // 
            // comboBox_week
            // 
            this.comboBox_week.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_week.FormattingEnabled = true;
            this.comboBox_week.Items.AddRange(new object[] {
            "mon",
            "tue",
            "wed",
            "thu",
            "fri"});
            this.comboBox_week.Location = new System.Drawing.Point(700, 293);
            this.comboBox_week.Name = "comboBox_week";
            this.comboBox_week.Size = new System.Drawing.Size(203, 29);
            this.comboBox_week.TabIndex = 37;
            // 
            // button_apply
            // 
            this.button_apply.Location = new System.Drawing.Point(372, 630);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(133, 41);
            this.button_apply.TabIndex = 6;
            this.button_apply.Text = "적용";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Coral;
            this.label18.Location = new System.Drawing.Point(890, 697);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(145, 21);
            this.label18.TabIndex = 38;
            this.label18.Text = "MJ Studio 2019";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1060, 734);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.button_apply);
            this.Controls.Add(this.comboBox_week);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.numeric_end_min);
            this.Controls.Add(this.numeric_end_hour);
            this.Controls.Add(this.numeric_start_min);
            this.Controls.Add(this.numeric_start_hour);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.numeric_class);
            this.Controls.Add(this.checkBox_class);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.listBox_timeslot);
            this.Controls.Add(this.numeric_semester);
            this.Controls.Add(this.numeric_year);
            this.Controls.Add(this.numeric_grade);
            this.Controls.Add(this.numeric_size);
            this.Controls.Add(this.textBox_place);
            this.Controls.Add(this.textBox_professor);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_code);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Subject Maker v1.0.0 - MJ Studio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_grade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_semester)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_class)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_start_hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_start_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_end_hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_end_min)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_export;
        private System.Windows.Forms.Label label_current_index;
        private System.Windows.Forms.Button button_right;
        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.Button button_import;
        private System.Windows.Forms.TextBox textBox_filePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_code;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_professor;
        private System.Windows.Forms.TextBox textBox_place;
        private System.Windows.Forms.NumericUpDown numeric_size;
        private System.Windows.Forms.NumericUpDown numeric_grade;
        private System.Windows.Forms.NumericUpDown numeric_year;
        private System.Windows.Forms.NumericUpDown numeric_semester;
        private System.Windows.Forms.ListBox listBox_timeslot;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBox_class;
        private System.Windows.Forms.NumericUpDown numeric_class;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numeric_start_hour;
        private System.Windows.Forms.NumericUpDown numeric_start_min;
        private System.Windows.Forms.NumericUpDown numeric_end_hour;
        private System.Windows.Forms.NumericUpDown numeric_end_min;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_week;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.Label label18;
    }
}

