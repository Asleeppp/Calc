using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace calc2
{
    public partial class Form1 : Form
    {
        private bool dragging = false; 
        private Point dragCursorPoint; 
        private Point dragFormPoint;
        public Form1()
        {
            InitializeComponent();
            addb.Click += new EventHandler(Addb_Click);
            subtb.Click += new EventHandler(Subtb_Click);
            mb.Click += new EventHandler(Mb_Click);
            db.Click += new EventHandler(Db_Click);
            textBox1.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            textBox2.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            panel1.MouseDown += new MouseEventHandler(panel1_MouseDown);
            panel1.MouseMove += new MouseEventHandler(panel1_MouseMove);
            panel1.MouseUp += new MouseEventHandler(panel1_MouseUp);
        }
        private void Addb_Click(object sender, EventArgs e)
        {
            CalculateResult((a, b) => a + b);
        }
        private void Subtb_Click(object sender, EventArgs e)
        {
            CalculateResult((a, b) => a - b);
        }
        private void Mb_Click(object sender, EventArgs e)
        {
            CalculateResult((a, b) => a * b);
        }
        private void Db_Click(object sender, EventArgs e)
        {
            CalculateResult((a, b) => b != 0 ? a / b : double.NaN); // Handle division by zero
        }
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void CalculateResult(Func<double, double, double> operation)
        {
            double input1 = 0;
            double.TryParse(textBox2.Text, out double input2);
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                double.TryParse(textBox1.Text, out input1);
            }
            double result = operation(input1, input2);
            resultLabel.Text = "Result: " + result.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void closebutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void db_Click_1(object sender, EventArgs e)
        {
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
    }
}
