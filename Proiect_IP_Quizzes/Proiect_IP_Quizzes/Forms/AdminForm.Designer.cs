namespace Proiect_IP_Quizzes.Forms
{
    partial class AdminForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxQuestionText = new System.Windows.Forms.TextBox();
            this.textBoxQuestionId = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.textBoxA3 = new System.Windows.Forms.TextBox();
            this.textBoxA2 = new System.Windows.Forms.TextBox();
            this.textBoxA1 = new System.Windows.Forms.TextBox();
            this.lbl_correct = new System.Windows.Forms.Label();
            this.lbl_answer3 = new System.Windows.Forms.Label();
            this.lbl_answer2 = new System.Windows.Forms.Label();
            this.lbl_answer1 = new System.Windows.Forms.Label();
            this.lbl_text = new System.Windows.Forms.Label();
            this.lbl_questionid = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.textBoxQuestions = new System.Windows.Forms.TextBox();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_idlist = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.numericUpDownCorrAns = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCorrAns)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lbl_welcome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 53);
            this.panel1.TabIndex = 0;
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_welcome.Location = new System.Drawing.Point(168, 9);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(231, 25);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "Welcome administrator";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.numericUpDownCorrAns);
            this.panel2.Controls.Add(this.textBoxType);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxQuestionText);
            this.panel2.Controls.Add(this.textBoxQuestionId);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.btn_update);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.textBoxA3);
            this.panel2.Controls.Add(this.textBoxA2);
            this.panel2.Controls.Add(this.textBoxA1);
            this.panel2.Controls.Add(this.lbl_correct);
            this.panel2.Controls.Add(this.lbl_answer3);
            this.panel2.Controls.Add(this.lbl_answer2);
            this.panel2.Controls.Add(this.lbl_answer1);
            this.panel2.Controls.Add(this.lbl_text);
            this.panel2.Controls.Add(this.lbl_questionid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(215, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 327);
            this.panel2.TabIndex = 1;
            // 
            // textBoxQuestionText
            // 
            this.textBoxQuestionText.Location = new System.Drawing.Point(80, 54);
            this.textBoxQuestionText.Multiline = true;
            this.textBoxQuestionText.Name = "textBoxQuestionText";
            this.textBoxQuestionText.Size = new System.Drawing.Size(259, 66);
            this.textBoxQuestionText.TabIndex = 17;
            // 
            // textBoxQuestionId
            // 
            this.textBoxQuestionId.Location = new System.Drawing.Point(139, 21);
            this.textBoxQuestionId.Name = "textBoxQuestionId";
            this.textBoxQuestionId.Size = new System.Drawing.Size(52, 20);
            this.textBoxQuestionId.TabIndex = 17;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Teal;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_delete.Location = new System.Drawing.Point(287, 280);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 35);
            this.btn_delete.TabIndex = 16;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Teal;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_update.Location = new System.Drawing.Point(164, 280);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 35);
            this.btn_update.TabIndex = 15;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Teal;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add.Location = new System.Drawing.Point(35, 280);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 35);
            this.btn_add.TabIndex = 14;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // textBoxA3
            // 
            this.textBoxA3.Location = new System.Drawing.Point(113, 207);
            this.textBoxA3.Name = "textBoxA3";
            this.textBoxA3.Size = new System.Drawing.Size(226, 20);
            this.textBoxA3.TabIndex = 9;
            // 
            // textBoxA2
            // 
            this.textBoxA2.Location = new System.Drawing.Point(113, 176);
            this.textBoxA2.Name = "textBoxA2";
            this.textBoxA2.Size = new System.Drawing.Size(226, 20);
            this.textBoxA2.TabIndex = 8;
            // 
            // textBoxA1
            // 
            this.textBoxA1.Location = new System.Drawing.Point(113, 143);
            this.textBoxA1.Name = "textBoxA1";
            this.textBoxA1.Size = new System.Drawing.Size(226, 20);
            this.textBoxA1.TabIndex = 7;
            // 
            // lbl_correct
            // 
            this.lbl_correct.AutoSize = true;
            this.lbl_correct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_correct.Location = new System.Drawing.Point(31, 248);
            this.lbl_correct.Name = "lbl_correct";
            this.lbl_correct.Size = new System.Drawing.Size(134, 24);
            this.lbl_correct.TabIndex = 5;
            this.lbl_correct.Text = "correct answer";
            // 
            // lbl_answer3
            // 
            this.lbl_answer3.AutoSize = true;
            this.lbl_answer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_answer3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_answer3.Location = new System.Drawing.Point(22, 207);
            this.lbl_answer3.Name = "lbl_answer3";
            this.lbl_answer3.Size = new System.Drawing.Size(91, 24);
            this.lbl_answer3.TabIndex = 4;
            this.lbl_answer3.Text = "answer3 :";
            // 
            // lbl_answer2
            // 
            this.lbl_answer2.AutoSize = true;
            this.lbl_answer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_answer2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_answer2.Location = new System.Drawing.Point(22, 176);
            this.lbl_answer2.Name = "lbl_answer2";
            this.lbl_answer2.Size = new System.Drawing.Size(91, 24);
            this.lbl_answer2.TabIndex = 3;
            this.lbl_answer2.Text = "answer 2:";
            // 
            // lbl_answer1
            // 
            this.lbl_answer1.AutoSize = true;
            this.lbl_answer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_answer1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_answer1.Location = new System.Drawing.Point(22, 144);
            this.lbl_answer1.Name = "lbl_answer1";
            this.lbl_answer1.Size = new System.Drawing.Size(91, 24);
            this.lbl_answer1.TabIndex = 2;
            this.lbl_answer1.Text = "answer 1:";
            // 
            // lbl_text
            // 
            this.lbl_text.AutoSize = true;
            this.lbl_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_text.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_text.Location = new System.Drawing.Point(22, 54);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(52, 24);
            this.lbl_text.TabIndex = 1;
            this.lbl_text.Text = "Text:";
            // 
            // lbl_questionid
            // 
            this.lbl_questionid.AutoSize = true;
            this.lbl_questionid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_questionid.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_questionid.Location = new System.Drawing.Point(22, 16);
            this.lbl_questionid.Name = "lbl_questionid";
            this.lbl_questionid.Size = new System.Drawing.Size(111, 24);
            this.lbl_questionid.TabIndex = 0;
            this.lbl_questionid.Text = "Question id:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.groupBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 327);
            this.panel3.TabIndex = 0;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.textBoxQuestions);
            this.groupBox.Controls.Add(this.lbl_type);
            this.groupBox.Controls.Add(this.lbl_idlist);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox.Location = new System.Drawing.Point(9, 32);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(200, 271);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "All questions";
            // 
            // textBoxQuestions
            // 
            this.textBoxQuestions.Location = new System.Drawing.Point(7, 66);
            this.textBoxQuestions.Multiline = true;
            this.textBoxQuestions.Name = "textBoxQuestions";
            this.textBoxQuestions.ReadOnly = true;
            this.textBoxQuestions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxQuestions.Size = new System.Drawing.Size(187, 199);
            this.textBoxQuestions.TabIndex = 16;
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(124, 37);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(53, 25);
            this.lbl_type.TabIndex = 15;
            this.lbl_type.Text = "type";
            // 
            // lbl_idlist
            // 
            this.lbl_idlist.AutoSize = true;
            this.lbl_idlist.Location = new System.Drawing.Point(17, 37);
            this.lbl_idlist.Name = "lbl_idlist";
            this.lbl_idlist.Size = new System.Drawing.Size(29, 25);
            this.lbl_idlist.TabIndex = 14;
            this.lbl_idlist.Text = "id";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(197, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Type:";
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(261, 25);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(101, 20);
            this.textBoxType.TabIndex = 19;
            // 
            // numericUpDownCorrAns
            // 
            this.numericUpDownCorrAns.Location = new System.Drawing.Point(171, 254);
            this.numericUpDownCorrAns.Name = "numericUpDownCorrAns";
            this.numericUpDownCorrAns.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownCorrAns.TabIndex = 20;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 380);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCorrAns)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox textBoxA3;
        private System.Windows.Forms.TextBox textBoxA2;
        private System.Windows.Forms.TextBox textBoxA1;
        private System.Windows.Forms.Label lbl_correct;
        private System.Windows.Forms.Label lbl_answer3;
        private System.Windows.Forms.Label lbl_answer2;
        private System.Windows.Forms.Label lbl_answer1;
        private System.Windows.Forms.Label lbl_text;
        private System.Windows.Forms.Label lbl_questionid;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label lbl_idlist;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox textBoxQuestionId;
        private System.Windows.Forms.TextBox textBoxQuestionText;
        private System.Windows.Forms.TextBox textBoxQuestions;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownCorrAns;
    }
}