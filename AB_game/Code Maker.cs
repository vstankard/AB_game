using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AB_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int code;
        int a = 0;
        int b = 0;

        private void Form1_Load(object sender, EventArgs e)
        { }

        public int[] generateNumberArray(int num)
        {
            int[] genArray = new int[4];

            for (int i = 3; i >= 0; i--)
            {
                genArray[i] = num % 10;
                num /= 10;
            }
            return genArray;
        }

        public int randomNumGen()
        {

            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Random random = new Random();

            int i = nums.Length - 1;

            while (i > 0)
            {
                int j = random.Next(0, i + 1);
                int temp = nums[i];

                nums[i] = nums[j];
                nums[j] = temp;

                i--;
            }

            return nums[0] * 1000 + nums[1] * 100 + nums[2] * 10 + nums[3];
        }

        public void winCheck()
        {
            if (a == 4) MessageBox.Show("Oh No! Your Code's Been Cracked!", "ERROR: Loser Alert");
            a = 0;
            b = 0;
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            lblNum.Text = randomNumGen().ToString();
            code = int.Parse(lblNum.Text);
        }

        private void txtGuess_TextChanged(object sender, EventArgs e)
        {
            btnGuess.Enabled = true;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            int guess = int.Parse(txtGuess.Text);

            int[] codeDigits = new int[4];
            int[] guessDigits = new int[4];

            //generate code and guess arrays
            codeDigits = generateNumberArray(code);
            guessDigits = generateNumberArray(guess);


            //generate hint

            for (int i = 0; i < 4; i++)
            {
                if (codeDigits[i] == guessDigits[i])
                {
                    a++;
                }
                else if (codeDigits.Contains(guessDigits[i]))
                {
                    b++;
                }
            }

            lblHint.Text = a + "A" + b + "B";

            winCheck();

        }

        private void chkBox_CheckedChanged(object sender, EventArgs e)
        {
            lblCensor.Visible = chkBox.Checked;
        }
    }
}
