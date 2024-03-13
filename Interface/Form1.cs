using Lab2_KO;
namespace Interface

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            listBox2.Items.Clear();
            int.TryParse(textBox1.Text, out int number);
            int.TryParse(textBox2.Text, out int seed);
            int.TryParse(textBox3.Text, out int capasity);


            Problem problem = new Problem(seed, number);
            Result result = problem.Solve(capasity);

            listBox1.Items.Add(string.Join(", ", result.items));

            listBox1.Items.Add($"Total value{problem._endvalue}");
            listBox1.Items.Add($"Total weight{problem._endweight}");

            foreach (var item in problem.getresults())
            {

                listBox2.Items.Add(item);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
