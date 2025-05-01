namespace _11_practice_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Createobject = new Button();
            Exit = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Courseinput = new TextBox();
            Instrctorinput = new TextBox();
            Officeinput = new TextBox();
            Textbookinput = new TextBox();
            Authorinput = new TextBox();
            publisherinput = new TextBox();
            CourseObjectData = new GroupBox();
            publisheroutput = new TextBox();
            authoroutput = new TextBox();
            textbookoutput = new TextBox();
            Officeoutput = new TextBox();
            Intuctoroutput = new TextBox();
            Courseoutput = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            groupBox1.SuspendLayout();
            CourseObjectData.SuspendLayout();
            SuspendLayout();
            // 
            // Createobject
            // 
            Createobject.Location = new Point(278, 521);
            Createobject.Name = "Createobject";
            Createobject.Size = new Size(94, 48);
            Createobject.TabIndex = 0;
            Createobject.Text = "Create object";
            Createobject.UseVisualStyleBackColor = true;
            Createobject.Click += Createobject_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(435, 521);
            Exit.Name = "Exit";
            Exit.Size = new Size(94, 48);
            Exit.TabIndex = 1;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(publisherinput);
            groupBox1.Controls.Add(Authorinput);
            groupBox1.Controls.Add(Textbookinput);
            groupBox1.Controls.Add(Officeinput);
            groupBox1.Controls.Add(Instrctorinput);
            groupBox1.Controls.Add(Courseinput);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(49, 151);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(340, 282);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter course info";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 37);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "Course name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 83);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 1;
            label2.Text = "Intructor name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 119);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 2;
            label3.Text = "Office number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 155);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 3;
            label4.Text = "textbook title";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 201);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 4;
            label5.Text = "Author";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 238);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 5;
            label6.Text = "Publisher";
            // 
            // Courseinput
            // 
            Courseinput.Location = new Point(125, 37);
            Courseinput.Name = "Courseinput";
            Courseinput.Size = new Size(175, 27);
            Courseinput.TabIndex = 6;
            // 
            // Instrctorinput
            // 
            Instrctorinput.Location = new Point(125, 83);
            Instrctorinput.Name = "Instrctorinput";
            Instrctorinput.Size = new Size(175, 27);
            Instrctorinput.TabIndex = 7;
            // 
            // Officeinput
            // 
            Officeinput.Location = new Point(125, 119);
            Officeinput.Name = "Officeinput";
            Officeinput.Size = new Size(175, 27);
            Officeinput.TabIndex = 8;
            // 
            // Textbookinput
            // 
            Textbookinput.Location = new Point(125, 155);
            Textbookinput.Name = "Textbookinput";
            Textbookinput.Size = new Size(175, 27);
            Textbookinput.TabIndex = 9;
            // 
            // Authorinput
            // 
            Authorinput.Location = new Point(125, 194);
            Authorinput.Name = "Authorinput";
            Authorinput.Size = new Size(175, 27);
            Authorinput.TabIndex = 10;
            // 
            // publisherinput
            // 
            publisherinput.Location = new Point(125, 235);
            publisherinput.Name = "publisherinput";
            publisherinput.Size = new Size(175, 27);
            publisherinput.TabIndex = 11;
            // 
            // CourseObjectData
            // 
            CourseObjectData.Controls.Add(publisheroutput);
            CourseObjectData.Controls.Add(authoroutput);
            CourseObjectData.Controls.Add(textbookoutput);
            CourseObjectData.Controls.Add(Officeoutput);
            CourseObjectData.Controls.Add(Intuctoroutput);
            CourseObjectData.Controls.Add(Courseoutput);
            CourseObjectData.Controls.Add(label7);
            CourseObjectData.Controls.Add(label8);
            CourseObjectData.Controls.Add(label9);
            CourseObjectData.Controls.Add(label10);
            CourseObjectData.Controls.Add(label11);
            CourseObjectData.Controls.Add(label12);
            CourseObjectData.Location = new Point(426, 151);
            CourseObjectData.Name = "CourseObjectData";
            CourseObjectData.Size = new Size(340, 282);
            CourseObjectData.TabIndex = 3;
            CourseObjectData.TabStop = false;
            CourseObjectData.Text = "Course Object Data";
            // 
            // publisheroutput
            // 
            publisheroutput.Location = new Point(125, 235);
            publisheroutput.Name = "publisheroutput";
            publisheroutput.Size = new Size(175, 27);
            publisheroutput.TabIndex = 11;
            // 
            // authoroutput
            // 
            authoroutput.Location = new Point(125, 194);
            authoroutput.Name = "authoroutput";
            authoroutput.Size = new Size(175, 27);
            authoroutput.TabIndex = 10;
            // 
            // textbookoutput
            // 
            textbookoutput.Location = new Point(125, 155);
            textbookoutput.Name = "textbookoutput";
            textbookoutput.Size = new Size(175, 27);
            textbookoutput.TabIndex = 9;
            // 
            // Officeoutput
            // 
            Officeoutput.Location = new Point(125, 119);
            Officeoutput.Name = "Officeoutput";
            Officeoutput.Size = new Size(175, 27);
            Officeoutput.TabIndex = 8;
            // 
            // Intuctoroutput
            // 
            Intuctoroutput.Location = new Point(125, 83);
            Intuctoroutput.Name = "Intuctoroutput";
            Intuctoroutput.Size = new Size(175, 27);
            Intuctoroutput.TabIndex = 7;
            // 
            // Courseoutput
            // 
            Courseoutput.Location = new Point(125, 37);
            Courseoutput.Name = "Courseoutput";
            Courseoutput.Size = new Size(175, 27);
            Courseoutput.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 238);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 5;
            label7.Text = "Publisher";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(47, 201);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 4;
            label8.Text = "Author";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 155);
            label9.Name = "label9";
            label9.Size = new Size(98, 20);
            label9.TabIndex = 3;
            label9.Text = "textbook title";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(0, 119);
            label10.Name = "label10";
            label10.Size = new Size(104, 20);
            label10.TabIndex = 2;
            label10.Text = "Office number";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 83);
            label11.Name = "label11";
            label11.Size = new Size(106, 20);
            label11.TabIndex = 1;
            label11.Text = "Intructor name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(9, 37);
            label12.Name = "label12";
            label12.Size = new Size(95, 20);
            label12.TabIndex = 0;
            label12.Text = "Course name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 602);
            Controls.Add(CourseObjectData);
            Controls.Add(groupBox1);
            Controls.Add(Exit);
            Controls.Add(Createobject);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            CourseObjectData.ResumeLayout(false);
            CourseObjectData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Createobject;
        private Button Exit;
        private GroupBox groupBox1;
        private TextBox Authorinput;
        private TextBox Textbookinput;
        private TextBox Officeinput;
        private TextBox Instrctorinput;
        private TextBox Courseinput;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox publisherinput;
        private GroupBox CourseObjectData;
        private TextBox publisheroutput;
        private TextBox authoroutput;
        private TextBox textbookoutput;
        private TextBox Officeoutput;
        private TextBox Intuctoroutput;
        private TextBox Courseoutput;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}
