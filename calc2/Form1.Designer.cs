namespace calc2
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            resultLabel = new Label();
            addb = new Button();
            subtb = new Button();
            mb = new Button();
            db = new Button();
            panel1 = new Panel();
            closebutton = new Button();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(42, 42, 42);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Variable Small", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(3, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 36);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(42, 42, 42);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI Variable Small", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(3, 97);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(179, 36);
            textBox2.TabIndex = 1;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.BackColor = Color.Transparent;
            resultLabel.Font = new Font("Segoe UI Variable Small", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultLabel.ForeColor = Color.White;
            resultLabel.Location = new Point(12, 152);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(37, 43);
            resultLabel.TabIndex = 2;
            resultLabel.Text = "0";
            // 
            // addb
            // 
            addb.BackColor = Color.FromArgb(255, 169, 10);
            addb.BackgroundImageLayout = ImageLayout.None;
            addb.FlatAppearance.BorderSize = 0;
            addb.FlatStyle = FlatStyle.Flat;
            addb.Font = new Font("Segoe UI Variable Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addb.ForeColor = Color.Black;
            addb.Location = new Point(287, 97);
            addb.Name = "addb";
            addb.Size = new Size(112, 52);
            addb.TabIndex = 3;
            addb.Text = "+";
            addb.UseVisualStyleBackColor = false;
            // 
            // subtb
            // 
            subtb.BackColor = Color.FromArgb(255, 169, 10);
            subtb.FlatAppearance.BorderSize = 0;
            subtb.FlatStyle = FlatStyle.Flat;
            subtb.Font = new Font("Segoe UI Variable Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subtb.Location = new Point(405, 97);
            subtb.Name = "subtb";
            subtb.Size = new Size(115, 52);
            subtb.TabIndex = 4;
            subtb.Text = "-";
            subtb.UseVisualStyleBackColor = false;
            // 
            // mb
            // 
            mb.BackColor = Color.FromArgb(255, 169, 10);
            mb.FlatAppearance.BorderSize = 0;
            mb.FlatStyle = FlatStyle.Flat;
            mb.Font = new Font("Segoe UI Variable Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mb.Location = new Point(287, 39);
            mb.Name = "mb";
            mb.Size = new Size(112, 52);
            mb.TabIndex = 5;
            mb.Text = "X";
            mb.UseVisualStyleBackColor = false;
            // 
            // db
            // 
            db.BackColor = Color.FromArgb(255, 169, 10);
            db.FlatAppearance.BorderSize = 0;
            db.FlatStyle = FlatStyle.Flat;
            db.Font = new Font("Segoe UI Variable Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            db.Location = new Point(405, 39);
            db.Name = "db";
            db.Size = new Size(115, 52);
            db.TabIndex = 6;
            db.Text = "÷";
            db.UseVisualStyleBackColor = false;
            db.Click += db_Click_1;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(closebutton);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-24, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(569, 36);
            panel1.TabIndex = 7;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // closebutton
            // 
            closebutton.BackColor = Color.Black;
            closebutton.FlatAppearance.BorderColor = Color.Red;
            closebutton.FlatAppearance.BorderSize = 0;
            closebutton.FlatAppearance.MouseDownBackColor = Color.Red;
            closebutton.FlatAppearance.MouseOverBackColor = Color.Red;
            closebutton.FlatStyle = FlatStyle.Flat;
            closebutton.ForeColor = Color.White;
            closebutton.Location = new Point(509, 2);
            closebutton.Name = "closebutton";
            closebutton.Size = new Size(46, 23);
            closebutton.TabIndex = 8;
            closebutton.Text = "X";
            closebutton.UseVisualStyleBackColor = false;
            closebutton.Click += closebutton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(26, 2);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 0;
            label1.Text = "Calculator";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Location = new Point(-15, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(278, 10);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DimGray;
            panel3.Location = new Point(3, 139);
            panel3.Name = "panel3";
            panel3.Size = new Size(260, 10);
            panel3.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DimGray;
            panel4.Location = new Point(247, 39);
            panel4.Name = "panel4";
            panel4.Size = new Size(16, 110);
            panel4.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(532, 205);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(panel1);
            Controls.Add(db);
            Controls.Add(mb);
            Controls.Add(subtb);
            Controls.Add(addb);
            Controls.Add(resultLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label resultLabel;
        private Button addb;
        private Button subtb;
        private Button mb;
        private Button db;
        private Panel panel1;
        private Button closebutton;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}
