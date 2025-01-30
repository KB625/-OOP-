namespace _OOP_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private double CalculateAreaRAF(double length, double width)
        {
            return length * width; // Rectangle area formula
        }

        private double CalculateAreaCAF(double radius)
        {
            return Math.PI * radius * radius; // Circle area formula
        }
        private double CalculateAreaTAF(double baseLength, double height)
        {
            return 0.5 * baseLength * height; // Triangle area formula
        }

        // Event handler for Rectangle Area button click
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double length = Convert.ToDouble(textBox1length.Text);
                double width = Convert.ToDouble(textBox2width.Text);
                double area = CalculateAreaRAF(length, width);

                string result = $"Rectangle Area: {area}";
                listBox1results.Items.Add(result); // Add result to ListBox
                textBox3recentresult.Text = result; // Display in TextBox for recent result
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numerical values.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // Event handler for Circle Area button click
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double radius = Convert.ToDouble(textBox4radius.Text);
                double area = CalculateAreaCAF(radius);

                string result = $"Circle Area: {area}";
                listBox1results.Items.Add(result); // Add result to ListBox
                textBox3recentresult.Text = result; // Display in TextBox for recent result
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid radius.");
            }
        }

        // Event handler for Triangle Area button click
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double baseLength = Convert.ToDouble(textBox5baselength.Text);
                double height = Convert.ToDouble(textBox6height.Text);
                double area = CalculateAreaTAF(baseLength, height);

                string result = $"Triangle Area: {area}";
                listBox1results.Items.Add(result); // Add result to ListBox
                textBox3recentresult.Text = result; // Display in TextBox for recent result
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid base and height values.");
            }

        }
    }
}



