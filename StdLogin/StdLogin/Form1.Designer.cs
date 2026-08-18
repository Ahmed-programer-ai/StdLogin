namespace StdLogin
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            txtId = new TextBox();
            txtName = new TextBox();
            txtDegree = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtUDegree = new TextBox();
            txtUName = new TextBox();
            txtUId = new TextBox();
            label7 = new Label();
            txtDID = new TextBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(0, 64, 64);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(491, 6);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(507, 225);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 64, 64);
            button1.Location = new Point(880, 237);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(118, 33);
            button1.TabIndex = 1;
            button1.Text = "Show";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(0, 64, 64);
            txtId.ForeColor = Color.White;
            txtId.Location = new Point(782, 322);
            txtId.Margin = new Padding(4, 3, 4, 3);
            txtId.Name = "txtId";
            txtId.Size = new Size(214, 30);
            txtId.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(0, 64, 64);
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(782, 360);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(214, 30);
            txtName.TabIndex = 3;
            // 
            // txtDegree
            // 
            txtDegree.BackColor = Color.FromArgb(0, 64, 64);
            txtDegree.ForeColor = Color.White;
            txtDegree.Location = new Point(782, 401);
            txtDegree.Margin = new Padding(4, 3, 4, 3);
            txtDegree.Name = "txtDegree";
            txtDegree.Size = new Size(214, 30);
            txtDegree.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            label1.Location = new Point(630, 315);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 29);
            label1.TabIndex = 5;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            label2.Location = new Point(630, 359);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 29);
            label2.TabIndex = 6;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            label3.Location = new Point(630, 401);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 29);
            label3.TabIndex = 7;
            label3.Text = "Degree";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 64, 64);
            button2.Location = new Point(880, 453);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(118, 33);
            button2.TabIndex = 8;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 64, 64);
            button3.Location = new Point(505, 453);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(118, 33);
            button3.TabIndex = 15;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label4.Location = new Point(275, 391);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(90, 31);
            label4.TabIndex = 14;
            label4.Text = "Degree";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label5.Location = new Point(275, 354);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(77, 31);
            label5.TabIndex = 13;
            label5.Text = "Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label6.Location = new Point(275, 315);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(38, 31);
            label6.TabIndex = 12;
            label6.Text = "ID";
            // 
            // txtUDegree
            // 
            txtUDegree.BackColor = Color.FromArgb(0, 64, 64);
            txtUDegree.ForeColor = Color.White;
            txtUDegree.Location = new Point(408, 398);
            txtUDegree.Margin = new Padding(4, 3, 4, 3);
            txtUDegree.Name = "txtUDegree";
            txtUDegree.Size = new Size(214, 30);
            txtUDegree.TabIndex = 11;
            // 
            // txtUName
            // 
            txtUName.BackColor = Color.FromArgb(0, 64, 64);
            txtUName.ForeColor = Color.White;
            txtUName.Location = new Point(408, 359);
            txtUName.Margin = new Padding(4, 3, 4, 3);
            txtUName.Name = "txtUName";
            txtUName.Size = new Size(214, 30);
            txtUName.TabIndex = 10;
            // 
            // txtUId
            // 
            txtUId.BackColor = Color.FromArgb(0, 64, 64);
            txtUId.ForeColor = Color.White;
            txtUId.Location = new Point(408, 322);
            txtUId.Margin = new Padding(4, 3, 4, 3);
            txtUId.Name = "txtUId";
            txtUId.Size = new Size(214, 30);
            txtUId.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(-4, 322);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(38, 31);
            label7.TabIndex = 17;
            label7.Text = "ID";
            // 
            // txtDID
            // 
            txtDID.BackColor = Color.FromArgb(0, 64, 64);
            txtDID.ForeColor = Color.White;
            txtDID.Location = new Point(51, 322);
            txtDID.Margin = new Padding(4, 3, 4, 3);
            txtDID.Name = "txtDID";
            txtDID.Size = new Size(214, 30);
            txtDID.TabIndex = 16;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 64, 64);
            button4.Location = new Point(149, 453);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(118, 33);
            button4.TabIndex = 18;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1000, 518);
            Controls.Add(button4);
            Controls.Add(label7);
            Controls.Add(txtDID);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txtUDegree);
            Controls.Add(txtUName);
            Controls.Add(txtUId);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDegree);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "StdLogin";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtDegree;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Button button3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtUDegree;
        private TextBox txtUName;
        private TextBox txtUId;
        private Label label7;
        private TextBox txtDID;
        private Button button4;
    }
}
