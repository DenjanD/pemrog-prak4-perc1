namespace P4_1_1204039
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

        private void vbButton_MouseMove(object sender, MouseEventArgs e)
        {
            vbButton.Top -= e.Y;
            vbButton.Left += e.X;
            if (vbButton.Top < -16 || vbButton.Top > 160)
            {
                vbButton.Top = 73;
            }
            if (vbButton.Left < -64 || vbButton.Left > 384)
            {
                vbButton.Left = 160;
            }
        }

        private void csButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct!");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}