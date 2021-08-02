using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Quizz : Form
    {

        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int qNum = 0;
        int i;
        int score;

        public Quizz()
        {
            InitializeComponent();
            startGame();
            nextQuestion();
        }

        private void checkAnswer(object sender, EventArgs e)
        {
            Button senderButton = sender as Button;

            if (senderButton.Tag.ToString() == "1")
            {
                score++;
                nextQuestion();
            }
            else
            {
                MessageBox.Show("Pergjigje jo e sakte!");
                restartGame();

            }

            if (score == 10)
            {
                MessageBox.Show("Urime keni fituar!");
                restartGame();
            }


            if (qNum < 0)
            {
                qNum = 0;
            }
            else
            {
                qNum++;
            }

            lblScoreText.Text = "Answered correctly " + score + "/" + questionNumbers.Count;

        }

        private void restartGame()
        {
            score = 0;
            qNum = -1;
            i = 0;
            startGame();
        }

        private void nextQuestion()
        {
            if (qNum < questionNumbers.Count)
            {
                i = questionNumbers[qNum];
            }
            else
            {
                restartGame();
            }


            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    control.Tag = "0";
                }
            }

            switch (i)
            {
                case 1:
                    lblQuestion.Text = "How many countries possess nuclear arms?";


                    btnAns1.Text = "5";
                    btnAns2.Text = "9";
                    btnAns3.Text = "3";
                    btnAns4.Text = "12";

                    btnAns2.Tag = "1";
                    break;

                case 2:
                    lblQuestion.Text = "Who wrote 'The Notebook' ?";

                    btnAns1.Text = "Nicholas Sparks";
                    btnAns2.Text = "Alice Walker";
                    btnAns3.Text = "George Saunders";
                    btnAns4.Text = "Peter Jackson";

                    btnAns1.Tag = "1";
                    break;

                case 3:
                    lblQuestion.Text = "In which decade was Diet Coke first introduced?";
                    btnAns1.Text = "1990s";
                    btnAns2.Text = "1970s";
                    btnAns3.Text = "1980s";
                    btnAns4.Text = "1960s";

                    btnAns3.Tag = "1";
                    break;

                case 4:
                    lblQuestion.Text = "Where is Bratislava?";

                    btnAns1.Text = "Czech Republic";
                    btnAns2.Text = "Kosovo";
                    btnAns3.Text = "Slovakia";
                    btnAns4.Text = "Armenia";

                    btnAns3.Tag = "1";
                    break;

                case 5:
                    lblQuestion.Text = "How many planets are in our solar system?";

                    btnAns1.Text = "4";
                    btnAns2.Text = "8";
                    btnAns3.Text = "10";
                    btnAns4.Text = "12";

                    btnAns2.Tag = "1";
                    break;

                case 6:
                    lblQuestion.Text = "'Friends', 'The Office', and 'Parks and Recreation' were all on which channel?";

                    btnAns1.Text = "NBC";
                    btnAns2.Text = "ABC";
                    btnAns3.Text = "CBS";
                    btnAns4.Text = "FOX";

                    btnAns1.Tag = "1";
                    break;

                case 7:
                    lblQuestion.Text = "'The Scream' was famously painted by which artist?";
                    btnAns1.Text = "Rene Magritte";
                    btnAns2.Text = "Edvard Munch";
                    btnAns3.Text = "Grant Wood";
                    btnAns4.Text = "Edward Hopper";

                    btnAns2.Tag = "1";
                    break;

                case 8:
                    lblQuestion.Text = "What fills balloons to make them float?";

                    btnAns1.Text = "Hydrogen";
                    btnAns2.Text = "Argon";
                    btnAns3.Text = "Potassium";
                    btnAns4.Text = "Helium";

                    btnAns4.Tag = "1";
                    break;

                case 9:
                    lblQuestion.Text = "Where is Stonehenge located?";

                    btnAns1.Text = "Ireland";
                    btnAns2.Text = "Scotland";
                    btnAns3.Text = "Germany";
                    btnAns4.Text = "England";

                    btnAns4.Tag = "1";
                    break;

                case 10:
                    lblQuestion.Text = "Which street does Sherlock Holmes live on?";

                    btnAns1.Text = "Baker Street";
                    btnAns2.Text = "Bleeker Street";
                    btnAns3.Text = "Basil Street";
                    btnAns4.Text = "Banter Street";

                    btnAns1.Tag = "1";
                    break;


            }



        }

        private void startGame()
        {


            var randomList = questionNumbers.OrderBy(a => Guid.NewGuid()).ToList();

            questionNumbers = randomList;

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Hide();
        }

        private void Quizz_Load(object sender, EventArgs e)
        {

        }
    }
}
