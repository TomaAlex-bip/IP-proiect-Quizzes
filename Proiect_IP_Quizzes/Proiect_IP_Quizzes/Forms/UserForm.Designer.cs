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
            this.groupBox_history = new System.Windows.Forms.GroupBox();
            this.groupBox_generator = new System.Windows.Forms.GroupBox();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_type = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox_generator.SuspendLayout();
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
            this.lbl_welcome.Font = new System.Drawing.Font("David Libre", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_welcome.Location = new System.Drawing.Point(210, 26);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(91, 21);
            this.lbl_welcome.TabIndex = 1;
            this.lbl_welcome.Text = "Welcome";
            // 
            // lbl_user_name
            // 
            this.lbl_user_name.AutoSize = true;
            this.lbl_user_name.Font = new System.Drawing.Font("David Libre", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_name.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_user_name.Location = new System.Drawing.Point(307, 26);
            this.lbl_user_name.Name = "lbl_user_name";
            this.lbl_user_name.Size = new System.Drawing.Size(96, 21);
            this.lbl_user_name.TabIndex = 0;
            this.lbl_user_name.Text = "username";
            // 
            // groupBox_statistics
            // 
            this.groupBox_statistics.Font = new System.Drawing.Font("David Libre", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_statistics.ForeColor = System.Drawing.Color.Teal;
            this.groupBox_statistics.Location = new System.Drawing.Point(12, 90);
            this.groupBox_statistics.Name = "groupBox_statistics";
            this.groupBox_statistics.Size = new System.Drawing.Size(327, 114);
            this.groupBox_statistics.TabIndex = 1;
            this.groupBox_statistics.TabStop = false;
            this.groupBox_statistics.Text = "Statistics";
            // 
            // groupBox_history
            // 
            this.groupBox_history.Font = new System.Drawing.Font("David Libre", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_history.ForeColor = System.Drawing.Color.Teal;
            this.groupBox_history.Location = new System.Drawing.Point(12, 219);
            this.groupBox_history.Name = "groupBox_history";
            this.groupBox_history.Size = new System.Drawing.Size(327, 149);
            this.groupBox_history.TabIndex = 2;
            this.groupBox_history.TabStop = false;
            this.groupBox_history.Text = "Attempts history";
            // 
            // groupBox_generator
            // 
            this.groupBox_generator.Controls.Add(this.label1);
            this.groupBox_generator.Controls.Add(this.lbl_type);
            this.groupBox_generator.Controls.Add(this.button1);
            this.groupBox_generator.Controls.Add(this.comboBox1);
            this.groupBox_generator.Controls.Add(this.comboBox_type);
            this.groupBox_generator.Font = new System.Drawing.Font("David Libre", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_generator.ForeColor = System.Drawing.Color.Teal;
            this.groupBox_generator.Location = new System.Drawing.Point(367, 90);
            this.groupBox_generator.Name = "groupBox_generator";
            this.groupBox_generator.Size = new System.Drawing.Size(243, 278);
            this.groupBox_generator.TabIndex = 3;
            this.groupBox_generator.TabStop = false;
            this.groupBox_generator.Text = "Quiz generator";
            // 
            // comboBox_type
            // 
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "C++",
            "Java",
            "SQL",
            "JavaScript"});
            this.comboBox_type.Location = new System.Drawing.Point(38, 76);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(171, 27);
            this.comboBox_type.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "10",
            "15",
            "20"});
            this.comboBox1.Location = new System.Drawing.Point(38, 150);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 27);
            this.comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "START QUIZ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(97, 42);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(47, 19);
            this.lbl_type.TabIndex = 3;
            this.lbl_type.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "No. of questions";
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
            this.groupBox_generator.ResumeLayout(false);
            this.groupBox_generator.PerformLayout();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox_type;
    }
}