namespace Proiect_IP_Quizzes.Forms
{
    partial class UserForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.lbl_user_name = new System.Windows.Forms.Label();
            this.groupBox_statistics = new System.Windows.Forms.GroupBox();
            this.labelFailedQuizzes = new System.Windows.Forms.Label();
            this.labelPassedQuizzes = new System.Windows.Forms.Label();
            this.labelAttemptedQuizzes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_history = new System.Windows.Forms.GroupBox();
            this.textBoxAttemptsHistory = new System.Windows.Forms.TextBox();
            this.groupBox_generator = new System.Windows.Forms.GroupBox();
            this.numericUpDownNoQuestions = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.buttonStartQuiz = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox_statistics.SuspendLayout();
            this.groupBox_history.SuspendLayout();
            this.groupBox_generator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lbl_welcome);
            this.panel1.Controls.Add(this.lbl_user_name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 72);
            this.panel1.TabIndex = 0;
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_welcome.Location = new System.Drawing.Point(210, 26);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(101, 25);
            this.lbl_welcome.TabIndex = 1;
            this.lbl_welcome.Text = "Welcome";
            // 
            // lbl_user_name
            // 
            this.lbl_user_name.AutoSize = true;
            this.lbl_user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_name.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_user_name.Location = new System.Drawing.Point(307, 26);
            this.lbl_user_name.Name = "lbl_user_name";
            this.lbl_user_name.Size = new System.Drawing.Size(107, 25);
            this.lbl_user_name.TabIndex = 0;
            this.lbl_user_name.Text = "username";
            // 
            // groupBox_statistics
            // 
            this.groupBox_statistics.Controls.Add(this.labelFailedQuizzes);
            this.groupBox_statistics.Controls.Add(this.labelPassedQuizzes);
            this.groupBox_statistics.Controls.Add(this.labelAttemptedQuizzes);
            this.groupBox_statistics.Controls.Add(this.label4);
            this.groupBox_statistics.Controls.Add(this.label3);
            this.groupBox_statistics.Controls.Add(this.label2);
            this.groupBox_statistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_statistics.ForeColor = System.Drawing.Color.Teal;
            this.groupBox_statistics.Location = new System.Drawing.Point(12, 90);
            this.groupBox_statistics.Name = "groupBox_statistics";
            this.groupBox_statistics.Size = new System.Drawing.Size(327, 114);
            this.groupBox_statistics.TabIndex = 1;
            this.groupBox_statistics.TabStop = false;
            this.groupBox_statistics.Text = "Statistics";
            // 
            // labelFailedQuizzes
            // 
            this.labelFailedQuizzes.AutoSize = true;
            this.labelFailedQuizzes.Location = new System.Drawing.Point(187, 76);
            this.labelFailedQuizzes.Name = "labelFailedQuizzes";
            this.labelFailedQuizzes.Size = new System.Drawing.Size(20, 24);
            this.labelFailedQuizzes.TabIndex = 5;
            this.labelFailedQuizzes.Text = "0";
            // 
            // labelPassedQuizzes
            // 
            this.labelPassedQuizzes.AutoSize = true;
            this.labelPassedQuizzes.Location = new System.Drawing.Point(187, 53);
            this.labelPassedQuizzes.Name = "labelPassedQuizzes";
            this.labelPassedQuizzes.Size = new System.Drawing.Size(20, 24);
            this.labelPassedQuizzes.TabIndex = 4;
            this.labelPassedQuizzes.Text = "0";
            // 
            // labelAttemptedQuizzes
            // 
            this.labelAttemptedQuizzes.AutoSize = true;
            this.labelAttemptedQuizzes.Location = new System.Drawing.Point(187, 29);
            this.labelAttemptedQuizzes.Name = "labelAttemptedQuizzes";
            this.labelAttemptedQuizzes.Size = new System.Drawing.Size(20, 24);
            this.labelAttemptedQuizzes.TabIndex = 3;
            this.labelAttemptedQuizzes.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Failed quizzes: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Passed quizzes: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Attempted quizzes: ";
            // 
            // groupBox_history
            // 
            this.groupBox_history.Controls.Add(this.textBoxAttemptsHistory);
            this.groupBox_history.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_history.ForeColor = System.Drawing.Color.Teal;
            this.groupBox_history.Location = new System.Drawing.Point(12, 219);
            this.groupBox_history.Name = "groupBox_history";
            this.groupBox_history.Size = new System.Drawing.Size(327, 149);
            this.groupBox_history.TabIndex = 2;
            this.groupBox_history.TabStop = false;
            this.groupBox_history.Text = "Attempts history";
            // 
            // textBoxAttemptsHistory
            // 
            this.textBoxAttemptsHistory.Location = new System.Drawing.Point(6, 29);
            this.textBoxAttemptsHistory.Multiline = true;
            this.textBoxAttemptsHistory.Name = "textBoxAttemptsHistory";
            this.textBoxAttemptsHistory.ReadOnly = true;
            this.textBoxAttemptsHistory.Size = new System.Drawing.Size(315, 114);
            this.textBoxAttemptsHistory.TabIndex = 0;
            // 
            // groupBox_generator
            // 
            this.groupBox_generator.Controls.Add(this.numericUpDownNoQuestions);
            this.groupBox_generator.Controls.Add(this.label1);
            this.groupBox_generator.Controls.Add(this.lbl_type);
            this.groupBox_generator.Controls.Add(this.buttonStartQuiz);
            this.groupBox_generator.Controls.Add(this.comboBoxType);
            this.groupBox_generator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_generator.ForeColor = System.Drawing.Color.Teal;
            this.groupBox_generator.Location = new System.Drawing.Point(367, 90);
            this.groupBox_generator.Name = "groupBox_generator";
            this.groupBox_generator.Size = new System.Drawing.Size(243, 278);
            this.groupBox_generator.TabIndex = 3;
            this.groupBox_generator.TabStop = false;
            this.groupBox_generator.Text = "Quiz generator";
            // 
            // numericUpDownNoQuestions
            // 
            this.numericUpDownNoQuestions.Location = new System.Drawing.Point(70, 159);
            this.numericUpDownNoQuestions.Name = "numericUpDownNoQuestions";
            this.numericUpDownNoQuestions.Size = new System.Drawing.Size(115, 29);
            this.numericUpDownNoQuestions.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "No. of questions";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(97, 42);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(53, 24);
            this.lbl_type.TabIndex = 3;
            this.lbl_type.Text = "Type";
            // 
            // buttonStartQuiz
            // 
            this.buttonStartQuiz.Location = new System.Drawing.Point(70, 216);
            this.buttonStartQuiz.Name = "buttonStartQuiz";
            this.buttonStartQuiz.Size = new System.Drawing.Size(120, 33);
            this.buttonStartQuiz.TabIndex = 2;
            this.buttonStartQuiz.Text = "START QUIZ";
            this.buttonStartQuiz.UseVisualStyleBackColor = true;
            this.buttonStartQuiz.Click += new System.EventHandler(this.buttonStartQuiz_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "C++",
            "Java",
            "SQL",
            "JavaScript"});
            this.comboBoxType.Location = new System.Drawing.Point(38, 76);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(171, 32);
            this.comboBoxType.TabIndex = 0;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 380);
            this.Controls.Add(this.groupBox_generator);
            this.Controls.Add(this.groupBox_history);
            this.Controls.Add(this.groupBox_statistics);
            this.Controls.Add(this.panel1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox_statistics.ResumeLayout(false);
            this.groupBox_statistics.PerformLayout();
            this.groupBox_history.ResumeLayout(false);
            this.groupBox_history.PerformLayout();
            this.groupBox_generator.ResumeLayout(false);
            this.groupBox_generator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoQuestions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label lbl_user_name;
        private System.Windows.Forms.GroupBox groupBox_statistics;
        private System.Windows.Forms.GroupBox groupBox_history;
        private System.Windows.Forms.GroupBox groupBox_generator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Button buttonStartQuiz;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelFailedQuizzes;
        private System.Windows.Forms.Label labelPassedQuizzes;
        private System.Windows.Forms.Label labelAttemptedQuizzes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAttemptsHistory;
        private System.Windows.Forms.NumericUpDown numericUpDownNoQuestions;
    }
}