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
    public partial class PhotoQuizz : Form
    {
        //photoquizz game variables 
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;

        public PhotoQuizz()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 5;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CheckAnswersEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if(buttonTag==correctAnswer)
            {
                score++;
            }
            if(questionNumber==totalQuestions)
            {
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

               
                MessageBox.Show(
                "Quiz Ended!" + Environment.NewLine +
                "You have answered " + score + " Questions correctly" + Environment.NewLine +
                "your total percentage is " + percentage + "%" + Environment.NewLine +
                "Click OK to play again");
                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }
            questionNumber++;
            askQuestion(questionNumber);


        }

        
       

        private void askQuestion(int qnum)
        {
            switch(qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.eiffelt;
                    lblQuestion.Text = "Ne cilin qytet ndodhet 'Eiffel Tower'";
                    button1.Text = "Paris";
                    button2.Text = "Berlin";
                    button3.Text = "Budapest";
                    button4.Text = "Oslo";

                    correctAnswer=1;

                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.pisat;
                    lblQuestion.Text = "Ne cilin qytet ndodhet 'Pisa'";
                    button1.Text = "Pisa";
                    button2.Text = "Berlin";
                    button3.Text = "Budapest";
                    button4.Text = "Oslo";

                    correctAnswer = 1;

                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.bigben;
                    lblQuestion.Text = "Ne cilin qytet ndodhet 'BigBen'";
                    button1.Text = "Pisa";
                    button2.Text = "Berlin";
                    button3.Text = "Londer";
                    button4.Text = "Liverpool";

                    correctAnswer = 3;

                    break;


                case 4:
                    pictureBox1.Image = Properties.Resources.bigben;
                    lblQuestion.Text = "Ne cilin qytet ndodhet 'BigBen'";
                    button1.Text = "Pisa";
                    button2.Text = "Berlin";
                    button3.Text = "Londer";
                    button4.Text = "Liverpool";

                    correctAnswer = 3;

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.miladt;
                    lblQuestion.Text = "Ne cilin qytet ndodhet 'Milad Tower'";
                    button1.Text = "Tehran";
                    button2.Text = "Berlin";
                    button3.Text = "Isfahan";
                    button4.Text = "Liverpool";

                    correctAnswer = 1;

                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Hide();
        }

        private void PhotoQuizz_Load(object sender, EventArgs e)
        {

        }
    }
}
