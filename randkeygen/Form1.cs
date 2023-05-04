using System.Text;

namespace randkeygen
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

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void minusButton_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void generatedKeyBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void generate_Click(object sender, EventArgs e)
        {
            int keyLength = Convert.ToInt32(charNumBox.Text);
            string chars = "";
            Random rand = new Random();

            if (chkLetters.Checked)
            {
                chars += "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }

            if (chkNumbers.Checked)
            {
                chars += "0123456789";
            }

            if (chkOthers.Checked)
            {
                chars += "!@#$%^&*()_+{}:\"<>?,./;'[]\\-=`~";
            }

            if (chars.Length == 0)
            {
                return;
            }



            StringBuilder result = new StringBuilder(keyLength);
            for (int i = 0; i < keyLength; i++)
            {
                result.Append(chars[rand.Next(chars.Length)]);
            }

            generatedKeyBox.Text = result.ToString();
        }

        private void copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(generatedKeyBox.Text);
        }
    }
}