using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bull_Eye.Logics;

namespace Bull_Eye.WindowUI
{
    public partial class FormSettings : Form
    {
        private static int m_NumberOfChances;

        public FormSettings()
        {
            m_NumberOfChances = 0;
            InitializeComponent();
            buttonNumberOfChances.Text = string.Format("Number of chances: {0}", (m_NumberOfChances + GameLogics.k_MaxNumberCount).ToString());
        }

        private void buttonNumberOfChances_Click(object sender, EventArgs e)
        {
            m_NumberOfChances = (++m_NumberOfChances) % GameLogics.k_MaxRange;
            buttonNumberOfChances.Text = string.Format("Number of chances: {0}", (m_NumberOfChances + GameLogics.k_MaxNumberCount).ToString());
        }

        public static int NumberOfChances
        {
            get { return m_NumberOfChances + GameLogics.k_LowestGuess; }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            FormGame formGame = new FormGame();

            this.Visible = false;
            formGame.ShowDialog();
            this.Close();
        }   
    }
}
