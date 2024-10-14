namespace OSTask1V2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            namebox = new TextBox();
            agebox = new TextBox();
            malebutton = new RadioButton();
            femalebutton = new RadioButton();
            courses = new CheckedListBox();
            citybox = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(39, 47);
            label1.Name = "label1";
            label1.Size = new Size(67, 34);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 122);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 1;
            label2.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 295);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 2;
            label3.Text = "City";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 205);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 436);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 4;
            label5.Text = "Courses";
            label5.Click += label5_Click;
            // 
            // namebox
            // 
            namebox.Location = new Point(127, 44);
            namebox.Name = "namebox";
            namebox.Size = new Size(125, 27);
            namebox.TabIndex = 5;
            // 
            // agebox
            // 
            agebox.Location = new Point(127, 119);
            agebox.Name = "agebox";
            agebox.Size = new Size(125, 27);
            agebox.TabIndex = 6;
            // 
            // malebutton
            // 
            malebutton.AutoSize = true;
            malebutton.Location = new Point(135, 203);
            malebutton.Name = "malebutton";
            malebutton.Size = new Size(63, 24);
            malebutton.TabIndex = 7;
            malebutton.TabStop = true;
            malebutton.Text = "Male";
            malebutton.UseVisualStyleBackColor = true;
            // 
            // femalebutton
            // 
            femalebutton.AutoSize = true;
            femalebutton.Location = new Point(135, 242);
            femalebutton.Name = "femalebutton";
            femalebutton.Size = new Size(78, 24);
            femalebutton.TabIndex = 8;
            femalebutton.TabStop = true;
            femalebutton.Text = "Female";
            femalebutton.UseVisualStyleBackColor = true;
            // 
            // courses
            // 
            courses.FormattingEnabled = true;
            courses.Items.AddRange(new object[] { "OOP", "OS", "DSA", "ARCH" });
            courses.Location = new Point(135, 436);
            courses.Name = "courses";
            courses.Size = new Size(150, 114);
            courses.TabIndex = 9;
            // 
            // citybox
            // 
            citybox.FormattingEnabled = true;
            citybox.Items.AddRange(new object[] { "Mansoura", "Cairo", "Alexandria", "Aswan" });
            citybox.Location = new Point(127, 305);
            citybox.Name = "citybox";
            citybox.Size = new Size(151, 28);
            citybox.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(652, 611);
            button1.Name = "button1";
            button1.Size = new Size(132, 48);
            button1.TabIndex = 11;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 714);
            Controls.Add(button1);
            Controls.Add(citybox);
            Controls.Add(courses);
            Controls.Add(femalebutton);
            Controls.Add(malebutton);
            Controls.Add(agebox);
            Controls.Add(namebox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox namebox;
        private TextBox agebox;
        private RadioButton malebutton;
        private RadioButton femalebutton;
        private CheckedListBox courses;
        private ComboBox citybox;
        private Button button1;
    }
}