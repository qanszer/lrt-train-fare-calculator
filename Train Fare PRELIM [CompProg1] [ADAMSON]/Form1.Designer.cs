namespace Train_Fare_PRELIM__CompProg1___ADAMSON_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label3 = new Label();
            from = new ComboBox();
            to = new ComboBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            enter = new Label();
            answer = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 26);
            label3.Name = "label3";
            label3.Size = new Size(0, 26);
            label3.TabIndex = 2;
            // 
            // from
            // 
            from.FlatStyle = FlatStyle.Popup;
            from.Font = new Font("SuperFrench", 18F, FontStyle.Regular, GraphicsUnit.Point, 2);
            from.ForeColor = SystemColors.InactiveCaptionText;
            from.FormattingEnabled = true;
            from.Items.AddRange(new object[] { "Baclaran", "EDSA", "Libertad", "Gil Puyat", "Vito Cruz", "Quirino", "Pedro Gil", "United Nations", "Central Terminal", "Carriedo", "Doroteo Jose", "Bambang", "Tayuman", "Blumentritt", "Abad Santos", "R Papa", "5th Avenue", "Monumento", "Balintawak", "Roosevelt" });
            from.Location = new Point(684, 158);
            from.Name = "from";
            from.Size = new Size(456, 38);
            from.TabIndex = 3;
            from.Text = " From";
            from.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // to
            // 
            to.FlatStyle = FlatStyle.Popup;
            to.Font = new Font("SuperFrench", 18F, FontStyle.Regular, GraphicsUnit.Point, 2);
            to.ForeColor = SystemColors.InactiveCaptionText;
            to.FormattingEnabled = true;
            to.Items.AddRange(new object[] { "Baclaran", "EDSA", "Libertad", "Gil Puyat", "Vito Cruz", "Quirino", "Pedro Gil", "United Nations", "Central Terminal", "Carriedo", "Doroteo Jose", "Bambang", "Tayuman", "Blumentritt", "Abad Santos", "R Papa", "5th Avenue", "Monumento", "Balintawak", "Roosevelt" });
            to.Location = new Point(684, 213);
            to.Name = "to";
            to.Size = new Size(456, 38);
            to.TabIndex = 4;
            to.Text = " To";
            to.SelectedIndexChanged += to_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(783, 311);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.WaitOnLoad = true;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(956, 311);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(154, 154);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.WaitOnLoad = true;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // enter
            // 
            enter.BackColor = Color.Transparent;
            enter.ForeColor = SystemColors.ActiveCaptionText;
            enter.Location = new Point(1026, 510);
            enter.Name = "enter";
            enter.Size = new Size(132, 85);
            enter.TabIndex = 7;
            enter.Text = " ";
            enter.Click += label1_Click;
            // 
            // answer
            // 
            answer.BackColor = Color.Transparent;
            answer.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            answer.ForeColor = SystemColors.ActiveCaptionText;
            answer.Location = new Point(676, 526);
            answer.Name = "answer";
            answer.Size = new Size(324, 52);
            answer.TabIndex = 8;
            answer.Click += answer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(464, 26);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 9;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(192, 0, 0);
            label2.ForeColor = Color.FromArgb(192, 0, 0);
            label2.Location = new Point(775, 302);
            label2.Name = "label2";
            label2.Size = new Size(175, 170);
            label2.TabIndex = 10;
            label2.Text = " ";
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(192, 0, 0);
            label4.ForeColor = Color.FromArgb(192, 0, 0);
            label4.Location = new Point(943, 302);
            label4.Name = "label4";
            label4.Size = new Size(175, 170);
            label4.TabIndex = 11;
            label4.Text = " ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1188, 666);
            Controls.Add(label1);
            Controls.Add(answer);
            Controls.Add(enter);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(to);
            Controls.Add(from);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            MinimizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private ComboBox from;
        private ComboBox to;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label enter;
        private Label answer;
        private Label label1;
        private Label label2;
        private Label label4;
    }
}
