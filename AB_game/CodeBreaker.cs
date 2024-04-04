using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace AB_game
{
    public partial class CodeBreaker : Form
    {
        public CodeBreaker()
        {
            InitializeComponent();
        }
        Random r = new Random();
        int firstGuess;
        int[] guess;
        List<int[]> permutations = new List<int[]>();


        /*
         Generates random 4 digit number, its used only for the first guess
        but might remove later if theres a mathematically best first guess
         */
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



        /*
        Generates every permutation under the sun for a 4 digit number 
        with a digit range of 1-9. This acts as "potential guesses" and starts
        off with every possible number being the possible solution. So about 504 possible
        */
        static List<int[]> GeneratePermutations()
        {
            List<int[]> permutations = new List<int[]>();

            var digits = Enumerable.Range(1, 9);
            var allPermutations = GetPermutations(digits, 4);

            foreach (var perm in allPermutations)
            {
                permutations.Add(perm.ToArray());
            }

            return permutations;
        }

        /*
         enumerate helper
         */
        static IEnumerable<IEnumerable<T>> GetPermutations<T>(IEnumerable<T> list, int length)
        {
            if (length == 1) return list.Select(t => new T[] { t });
            return GetPermutations(list, length - 1)
                .SelectMany(t => list.Where(e => !t.Contains(e)),
                    (t1, t2) => t1.Concat(new T[] { t2 }));
        }

        /*
        method to see if the guess feedback matches the feedback of a possible solution
        used to delete possible solutions
        posSolution = possible solution, guess = current guess, <A,B> equals current feedback
        counts array is used cause i hate nested ifs
        */
        static bool hintCheck(int[] posSolution, int[] guess, int A, int B)
        {
            int a = 0;
            int b = 0;
            int[] counts = new int[10]; 

            for (int i = 0; i < 4; i++)
            {
                if (posSolution[i] == guess[i])
                {
                    a++;
                }
                else
                {
                    int digit = int.Parse(posSolution[i].ToString());
                    counts[digit]++;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                if (posSolution[i] != guess[i])
                {
                    int digit = int.Parse(guess[i].ToString());
                    if (counts[digit] > 0)
                    {
                        b++;
                        counts[digit]--;
                    }
                }
            }

            return a == A && b == B;
        }




        private void txtHint_TextChanged(object sender, EventArgs e)
        {
            btnHint.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            btnBegin.Enabled = false;
            firstGuess = randomNumGen();

            //convert first guess to a int[], annoying way to do it
            guess = firstGuess.ToString().Select(digit => int.Parse(digit.ToString())).ToArray(); ;

            permutations = GeneratePermutations();
            lblFirstGuess.Text = string.Join("", firstGuess);

            txtHintA.Enabled = true;
            Debug.WriteLine("Test Debug Started");
            Debug.WriteLine("First Guess Made, starting # of perms: " + permutations.Count); ;

        }

        private void btnHint_Click(object sender, EventArgs e)
        {
     

            //idk it looks like str[0] would just take the ascii value, so i did this workaround to get the real number
            int A = int.Parse(txtHintA.Text.ToString());
            int B = int.Parse(txtHintB.Text.ToString());

            if (A == 4) {MessageBox.Show("Wow you won!"); return; };

            Debug.WriteLine("Guess Made, Beginning new Permutations");
            List<int[]> permTemp = new List<int[]>(permutations.Count);
            foreach (int[] perm in permutations)
            {
                if (hintCheck(perm, guess, A, B))
                    permTemp.Add(perm);
            }
            Debug.WriteLine("New Permutations done, new #:");
            permutations = permTemp;
            Debug.WriteLine(permutations.Count);
            guess = permutations[r.Next(permutations.Count)];
            lblGuess.Text = string.Join("", guess);
        }

        private void CodeBreaker_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("Test Debug Started");
        }
    }
}
