namespace Proiect_IP_Quizzes.Forms
{
    partial class QuizForm
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
            System.Windows.Forms.Button btn_nextquestion;
            this.lbl_q = new System.Windows.Forms.Label();
            this.lbl_questionText = new System.Windows.Forms.Label();
            this.radiobtn_first = new System.Windows.Forms.RadioButton();
            this.radiobtn_second = new System.Windows.Forms.RadioButton();
            this.radiobtn_third = new System.Windows.Forms.RadioButton();
            this.lbl_questionNumber = new System.Windows.Forms.Label();
            btn_nextquestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_q
            // 
            this.lbl_q.AutoSize = true;
            this.lbl_q.Font = new System.Drawing.Font("David Libre", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_q.Location = new System.Drawing.Point(299, 20);
            this.lbl_q.Name = "lbl_q";
            this.lbl_q.Size = new System.Drawing.Size(77, 19);
            this.lbl_q.TabIndex = 0;
            this.lbl_q.Text = "question";
            // 
            // lbl_questionText
            // 
            this.lbl_questionText.AutoSize = true;
            this.lbl_questionText.Font = new System.Drawing.Font("DejaVu Math TeX Gyre", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_questionText.Location = new System.Drawing.Point(138, 75);
            this.lbl_questionText.Name = "lbl_questionText";
            this.lbl_questionText.Size = new System.Drawing.Size(133, 69);
            this.lbl_questionText.TabIndex = 1;
            this.lbl_questionText.Text = "question text";
            // 
            // radiobtn_first
            // 
            this.radiobtn_first.AutoSize = true;
            this.radiobtn_first.Font = new System.Drawing.Font("DejaVu Math TeX Gyre", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtn_first.Location = new System.Drawing.Point(150, 209);
            this.radiobtn_first.Name = "radiobtn_first";
            this.radiobtn_first.Size = new System.Drawing.Size(140, 59);
            this.radiobtn_first.TabIndex = 2;
            this.radiobtn_first.TabStop = true;
            this.radiobtn_first.Text = "primul raspuns";
            this.radiobtn_first.UseVisualStyleBackColor = true;
            // 
            // radiobtn_second
            // 
            this.radiobtn_second.AutoSize = true;
            this.radiobtn_second.Font = new System.Drawing.Font("DejaVu Math TeX Gyre", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtn_second.Location = new System.Drawing.Point(150, 255);
            this.radiobtn_second.Name = "radiobtn_second";
            this.radiobtn_second.Size = new System.Drawing.Size(154, 59);
            this.radiobtn_second.TabIndex = 3;
            this.radiobtn_second.TabStop = true;
            this.radiobtn_second.Text = "al doilea raspuns";
            this.radiobtn_second.UseVisualStyleBackColor = true;
            // 
            // radiobtn_third
            // 
            this.radiobtn_third.AutoSize = true;
            this.radiobtn_third.Font = new System.Drawing.Font("DejaVu Math TeX Gyre", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtn_third.Location = new System.Drawing.Point(150, 298);
            this.radiobtn_third.Name = "radiobtn_third";
            this.radiobtn_third.Size = new System.Drawing.Size(157, 59);
            this.radiobtn_third.TabIndex = 4;
            this.radiobtn_third.TabStop = true;
            this.radiobtn_third.Text = "al treilea raspuns";
            this.radiobtn_third.UseVisualStyleBackColor = true;
            // 
            // btn_nextquestion
            // 
            btn_nextquestion.BackColor = System.Drawing.Color.Teal;
            btn_nextquestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_nextquestion.Font = new System.Drawing.Font("DejaVu Math TeX Gyre", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_nextquestion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btn_nextquestion.Location = new System.Drawing.Point(303, 369);
            btn_nextquestion.Name = "btn_nextquestion";
            btn_nextquestion.Size = new System.Drawing.Size(169, 69);
            btn_nextquestion.TabIndex = 5;
            btn_nextquestion.Text = "next question ->";
            btn_nextquestion.UseVisualStyleBackColor = false;
            btn_nextquestion.Click += new System.EventHandler(this.OnNextQuestionClick);
            // 
            // lbl_questionNumber
            // 
            this.lbl_questionNumber.AutoSize = true;
            this.lbl_questionNumber.Font = new System.Drawing.Font("David Libre", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_questionNumber.Location = new System.Drawing.Point(382, 20);
            this.lbl_questionNumber.Name = "lbl_questionNumber";
            this.lbl_questionNumber.Size = new System.Drawing.Size(43, 19);
            this.lbl_questionNumber.TabIndex = 6;
            this.lbl_questionNumber.Text = "1/10";
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_questionNumber);
            this.Controls.Add(btn_nextquestion);
            this.Controls.Add(this.radiobtn_third);
            this.Controls.Add(this.radiobtn_second);
            this.Controls.Add(this.radiobtn_first);
            this.Controls.Add(this.lbl_questionText);
            this.Controls.Add(this.lbl_q);
            this.Name = "QuizForm";
            this.Text = "QuizForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_q;
        private System.Windows.Forms.Label lbl_questionText;
        private System.Windows.Forms.RadioButton radiobtn_first;
        private System.Windows.Forms.RadioButton radiobtn_second;
        private System.Windows.Forms.RadioButton radiobtn_third;
        private System.Windows.Forms.Label lbl_questionNumber;
    }
}