using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bull_Eye.WindowUI
{
    public partial class FormGame : Form
    {
        private const int k_NumberOfValues = 4;
        List<List<Button>> m_Guesses = new List<List<Button>>();
        List<Button> m_GuessArrow = new List<Button>();
        List<List<Button>> m_Answers = new List<List<Button>>();
        public FormGame()
        {
            InitializeComponent();
            GuessesComponent();
        }

        private void GuessesComponent()
        {
            int topLocation = 70;
            const int k_additionToTopLocation = 30;
            const int k_additionToRightLocation = 49;

            for (int i = 0; i < FormSettings.NumberOfChances; i++)
            {
                List<Button> tempList = new List<Button>();
                int rightLocation = 20;
                for (int j = 0; j < k_NumberOfValues; j++)
                {
                    Button tempGuessButton = new Button();
                    tempGuessButton.Enabled = false;
                    tempGuessButton.Location = new System.Drawing.Point(rightLocation, topLocation);
                    rightLocation += k_additionToRightLocation;
                    tempGuessButton.Name = string.Format("buttonGuess{0}Place{1}", i, j);
                    tempGuessButton.Size = new System.Drawing.Size(43, 43);
                    tempGuessButton.UseVisualStyleBackColor = false;
                    this.Controls.Add(tempGuessButton);
                    tempList.Add(tempGuessButton);

                }
                m_Guesses.Add(tempList);

                {
                    Button tempArrowButton = new Button();
                    tempArrowButton.Enabled = false;
                    tempArrowButton.Location = new System.Drawing.Point(rightLocation, topLocation + (tempList[0].Bottom - tempList[0].Top) / 4);
                    rightLocation += k_additionToRightLocation;
                    tempArrowButton.Name = string.Format("buttonArrow{0}", i);
                    tempArrowButton.Text = "-->>";
                    tempArrowButton.Size = new System.Drawing.Size(43, 20);
                    tempArrowButton.UseVisualStyleBackColor = false;
                    this.Controls.Add(tempArrowButton);
                    m_GuessArrow.Add(tempArrowButton);
                }
                int additionToRightAnswerLocation = 25;

                tempList = new List<Button>();
                for (int j = 0; j < k_NumberOfValues / 2; j++)
                {
                    int rightAnswerLocation = m_GuessArrow[0].Right + 10;
                    for (int k = 0; k < k_NumberOfValues / 2; k++)
                    {
                        Button tempAnswerButton = new Button();
                        tempAnswerButton.Enabled = false;
                        tempAnswerButton.Location = new System.Drawing.Point(rightAnswerLocation, topLocation);
                        rightAnswerLocation += additionToRightAnswerLocation;
                        tempAnswerButton.Name = string.Format("buttonAnswer{0},Place{1},Line{2}", i, j, k);
                        tempAnswerButton.Size = new System.Drawing.Size(20, 20);
                        tempAnswerButton.UseVisualStyleBackColor = false;
                        this.Controls.Add(tempAnswerButton);
                        tempList.Add(tempAnswerButton);
                    }

                    topLocation += additionToTopLocation - 5;
                }

                m_Answers.Add(tempList);
                topLocation += 10;
            }

            this.Height = m_Guesses[FormSettings.NumberOfChances - 1][k_NumberOfValues - 1].Bottom + 50;

            for (int i = 0; i < k_NumberOfValues; i++)
            {
                m_Guesses[0][i].Enabled = true;

            }
        }
    }
}
