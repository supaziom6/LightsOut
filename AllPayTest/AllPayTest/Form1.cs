using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllPayTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the Ready button is pressed it ensure that 1 and only one option is selected and launches an apropriate game mode
        /// </summary>
        /// <param name="sender">The caller of the function</param>
        /// <param name="e">Arguments passed by the event</param>
        private void ContinueButton_Click(object sender, EventArgs e)
        {
            int SelectedBoxes = 0;
            int SelectedBox = 5;
            if (Check4x4.Checked)
            {
                SelectedBoxes++;
                SelectedBox = 4;
            }
            if (Check5x5.Checked)
            {
                SelectedBoxes++;
                SelectedBox = 5;
            }
            if (Check6x6.Checked)
            {
                SelectedBoxes++;
                SelectedBox = 6;
            }

            if(SelectedBoxes != 1)
            {
                MessageBox.Show("You can only have one box selected");
            }
            else
            {
                // shows the second form that contains the game info
                Hide();
                Form2 f2 = new Form2(SelectedBox);
                f2.FormClosed += otherFormClosed;
                f2.ShowDialog();
            }

        }

        /// <summary>
        /// When the game form is close it informs the primary form to be displayed again
        /// </summary>
        /// <param name="sender">The caller of the function</param>
        /// <param name="e">Arguments passed by the event</param>
        private void otherFormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }
    }
}
