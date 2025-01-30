namespace _OOP_
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
            textBox1length = new TextBox();
            textBox2width = new TextBox();
            textBox3recentresult = new TextBox();
            button1 = new Button();
            listBox1results = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            label4 = new Label();
            textBox4radius = new TextBox();
            button3 = new Button();
            label5 = new Label();
            label6 = new Label();
            textBox5baselength = new TextBox();
            textBox6height = new TextBox();
            SuspendLayout();
            // 
            // textBox1length
            // 
            textBox1length.Location = new Point(29, 48);
            textBox1length.Name = "textBox1length";
            textBox1length.Size = new Size(125, 27);
            textBox1length.TabIndex = 0;
            // 
            // textBox2width
            // 
            textBox2width.Location = new Point(29, 102);
            textBox2width.Name = "textBox2width";
            textBox2width.Size = new Size(125, 27);
            textBox2width.TabIndex = 1;
            // 
            // textBox3recentresult
            // 
            textBox3recentresult.Location = new Point(106, 290);
            textBox3recentresult.Name = "textBox3recentresult";
            textBox3recentresult.Size = new Size(138, 27);
            textBox3recentresult.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(29, 147);
            button1.Name = "button1";
            button1.Size = new Size(114, 29);
            button1.TabIndex = 3;
            button1.Text = "rectangle area";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1results
            // 
            listBox1results.FormattingEnabled = true;
            listBox1results.Location = new Point(290, 267);
            listBox1results.Name = "listBox1results";
            listBox1results.Size = new Size(150, 144);
            listBox1results.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 25);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 5;
            label1.Text = "length";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 79);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 6;
            label2.Text = "width";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(129, 267);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 6;
            label3.Text = " recent result";
            label3.Click += label3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(213, 81);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "circle area";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(213, 25);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 6;
            label4.Text = "radius";
            label4.Click += label3_Click;
            // 
            // textBox4radius
            // 
            textBox4radius.Location = new Point(213, 48);
            textBox4radius.Name = "textBox4radius";
            textBox4radius.Size = new Size(125, 27);
            textBox4radius.TabIndex = 8;
            // 
            // button3
            // 
            button3.Location = new Point(397, 147);
            button3.Name = "button3";
            button3.Size = new Size(102, 29);
            button3.TabIndex = 9;
            button3.Text = "triangle area";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(389, 25);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 6;
            label5.Text = "base length";
            label5.Click += label3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(389, 79);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 6;
            label6.Text = "height";
            label6.Click += label3_Click;
            // 
            // textBox5baselength
            // 
            textBox5baselength.Location = new Point(389, 49);
            textBox5baselength.Name = "textBox5baselength";
            textBox5baselength.Size = new Size(125, 27);
            textBox5baselength.TabIndex = 10;
            // 
            // textBox6height
            // 
            textBox6height.Location = new Point(389, 102);
            textBox6height.Name = "textBox6height";
            textBox6height.Size = new Size(125, 27);
            textBox6height.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 450);
            Controls.Add(textBox6height);
            Controls.Add(textBox5baselength);
            Controls.Add(button3);
            Controls.Add(textBox4radius);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1results);
            Controls.Add(button1);
            Controls.Add(textBox3recentresult);
            Controls.Add(textBox2width);
            Controls.Add(textBox1length);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1length;
        private TextBox textBox2width;
        private TextBox textBox3recentresult;
        private Button button1;
        private ListBox listBox1results;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Label label4;
        private TextBox textBox4radius;
        private Button button3;
        private Label label5;
        private Label label6;
        private TextBox textBox5baselength;
        private TextBox textBox6height;
    }
}
