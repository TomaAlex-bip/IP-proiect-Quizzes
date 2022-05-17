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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.lbl_questionid = new System.Windows.Forms.Label();
            this.lbl_text = new System.Windows.Forms.Label();
            this.lbl_answer1 = new System.Windows.Forms.Label();
            this.lbl_answer2 = new System.Windows.Forms.Label();
            this.lbl_answer3 = new System.Windows.Forms.Label();
            this.lbl_correct = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_idlist = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox.SuspendLayout();
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.btn_update);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.lbl_id);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
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
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("David Libre", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_welcome.Location = new System.Drawing.Point(168, 9);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(216, 21);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "Welcome administrator";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.lbl_type);
            this.groupBox.Controls.Add(this.lbl_idlist);
            this.groupBox.Font = new System.Drawing.Font("David Libre", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox.Location = new System.Drawing.Point(9, 32);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(200, 271);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "All questions";
            // 
            // lbl_questionid
            // 
            this.lbl_questionid.AutoSize = true;
            this.lbl_questionid.Font = new System.Drawing.Font("David Libre", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_questionid.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_questionid.Location = new System.Drawing.Point(22, 16);
            this.lbl_questionid.Name = "lbl_questionid";
            this.lbl_questionid.Size = new System.Drawing.Size(104, 19);
            this.lbl_questionid.TabIndex = 0;
            this.lbl_questionid.Text = "Question id:";
            // 
            // lbl_text
            // 
            this.lbl_text.AutoSize = true;
            this.lbl_text.Font = new System.Drawing.Font("David Libre", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_text.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_text.Location = new System.Drawing.Point(22, 54);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(52, 19);
            this.lbl_text.TabIndex = 1;
            this.lbl_text.Text = "Text:";
            // 
            // lbl_answer1
            // 
            this.lbl_answer1.AutoSize = true;
            this.lbl_answer1.Font = new System.Drawing.Font("David Libre", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_answer1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_answer1.Location = new System.Drawing.Point(22, 144);
            this.lbl_answer1.Name = "lbl_answer1";
            this.lbl_answer1.Size = new System.Drawing.Size(85, 19);
            this.lbl_answer1.TabIndex = 2;
            this.lbl_answer1.Text = "answer 1:";
            // 
            // lbl_answer2
            // 
            this.lbl_answer2.AutoSize = true;
            this.lbl_answer2.Font = new System.Drawing.Font("David Libre", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_answer2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_answer2.Location = new System.Drawing.Point(22, 176);
            this.lbl_answer2.Name = "lbl_answer2";
            this.lbl_answer2.Size = new System.Drawing.Size(85, 19);
            this.lbl_answer2.TabIndex = 3;
            this.lbl_answer2.Text = "answer 2:";
            // 
            // lbl_answer3
            // 
            this.lbl_answer3.AutoSize = true;
            this.lbl_answer3.Font = new System.Drawing.Font("David Libre", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_answer3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_answer3.Location = new System.Drawing.Point(22, 207);
            this.lbl_answer3.Name = "lbl_answer3";
            this.lbl_answer3.Size = new System.Drawing.Size(85, 19);
            this.lbl_answer3.TabIndex = 4;
            this.lbl_answer3.Text = "answer3 :";
            // 
            // lbl_correct
            // 
            this.lbl_correct.AutoSize = true;
            this.lbl_correct.Font = new System.Drawing.Font("David Libre", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_correct.Location = new System.Drawing.Point(31, 248);
            this.lbl_correct.Name = "lbl_correct";
            this.lbl_correct.Size = new System.Drawing.Size(127, 19);
            this.lbl_correct.TabIndex = 5;
            this.lbl_correct.Text = "correct answer";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(113, 143);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(226, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(113, 176);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(226, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(113, 207);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(226, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(164, 249);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 10;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(80, 54);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(259, 75);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("David Libre", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_id.Location = new System.Drawing.Point(132, 16);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 19);
            this.lbl_id.TabIndex = 13;
            this.lbl_id.Text = "1";
            // 
            // lbl_idlist
            // 
            this.lbl_idlist.AutoSize = true;
            this.lbl_idlist.Location = new System.Drawing.Point(17, 37);
            this.lbl_idlist.Name = "lbl_idlist";
            this.lbl_idlist.Size = new System.Drawing.Size(27, 21);
            this.lbl_idlist.TabIndex = 14;
            this.lbl_idlist.Text = "id";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(124, 37);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(48, 21);
            this.lbl_type.TabIndex = 15;
            this.lbl_type.Text = "type";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
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
    }
}