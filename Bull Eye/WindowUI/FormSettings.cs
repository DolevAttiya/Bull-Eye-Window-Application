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
    public partial class FormSettings : Form
    {
        private const int k_MinimumNumberOfChances = 4;
        private const int k_RoundParameter = 7;
        private int m_NumberOfChances;
        public FormSettings()
        {
            m_NumberOfChances = 0;
            InitializeComponent();
            buttonNumberOfChances.Text = string.Format("Number of chances: {0}", (m_NumberOfChances + k_MinimumNumberOfChances).ToString());
        }

        private void buttonNumberOfChances_Click(object sender, EventArgs e)
        {
            m_NumberOfChances = (++m_NumberOfChances) % k_RoundParameter;
            buttonNumberOfChances.Text = string.Format("Number of chances: {0}", (m_NumberOfChances + k_MinimumNumberOfChances).ToString());
        }
        public int NumberOfChances
        {
            get { return m_NumberOfChances; }
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
