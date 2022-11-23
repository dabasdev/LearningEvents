using Bl;

namespace LearningEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessagesCenter.HandelMessage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyService.CallSuccessMessage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyService.CallErrorMessage();
        }
    }
}