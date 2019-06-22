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
    public partial class Form2 : Form
    {
        private int size;
        private Button[,] buttons;
        private bool inSetUp;

        public Form2(int size)
        {
            InitializeComponent();
            this.size = size;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            inSetUp = true;
            // Create an array of button which will be used to identify which button was pressed
            buttons = new Button[size, size];
            for(int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    // Give each button their necessery info like location size color and a callback function when they are pressed
                    buttons[i,j] = new Button();
                    buttons[i, j].Location = new Point(i * ((Size.Width-15) / size), j * (Size.Height-65) / size);
                    buttons[i, j].Text = "I'm a Light";
                    buttons[i, j].Size = new Size((Size.Width-15) / size, (Size.Height-65) / size);
                    buttons[i, j].BackColor = Color.Black;
                    buttons[i, j].Click += new EventHandler(this.ButtonClicked);

                    // add the button to the controll to ensure it display on the form
                    Controls.Add(buttons[i, j]);
                }
            }

            // Generate 2 random numbers to select a tile to be activate (this acts as a shuffle to the program)
            Random r = new Random();
            // this loop prevents a miniscule chance of the game shuffling to an already won game
            do
            {
                for (int i = 0; i < 100; i++)
                {
                    buttons[r.Next(0, size), r.Next(0, size)].PerformClick();
                }
            } while (checkForWin());
            inSetUp = false;
            Show();
            MessageBox.Show("Hi welcome to my Lights out game.\n\nThis is the game view where you will get to play the game. The game is quite simple,\nall you have to do is press on any tile to switch it's lights this will also affect the 4 adjecent light too.\n\nThe goal of the game is to turn off all the lights. if you feel like you want to quit the feel free to turn this window off. you will be take back to the previous window.\n\nGood Luck!\n\nPsst! there is a button down below that gives you a free win if you ever want to give up.");
        }

        /// <summary>
        /// This method checks every light is out
        /// </summary>
        /// <returns>Wether the game is won yet</returns>
        private bool checkForWin()
        {
            bool check = true;
            foreach(Button b in buttons)
            {
                if(b.BackColor == Color.Black)
                {
                    continue;
                }
                else
                {
                    check = false;
                    break;
                }
            }
            return check;
        }

        /// <summary>
        /// Handels the click of any of the buttons. It finds the button that pressed it and then trys to turn off the buttons around it. If such a button dosn't exist it handles the error and proceeds to function
        /// </summary>
        /// <param name="sender">The caller of the function</param>
        /// <param name="e">Arguments passed by the event</param>
        private void ButtonClicked(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    if (b.Equals(buttons[i, j]))
                    {
                        try
                        {
                            FlipButtonImage(buttons[i+1, j]);
                        }
                        catch { }
                        try
                        {
                            FlipButtonImage(buttons[i, j+1]);
                        }
                        catch { }
                        try
                        {
                            FlipButtonImage(buttons[i-1, j]);
                        }
                        catch { }
                        try
                        {
                            FlipButtonImage(buttons[i, j-1]);
                        }
                        catch { }
                        try
                        {
                            FlipButtonImage(buttons[i, j]);
                        }
                        catch { }
                    }
                }
            }
            // checks if the game is won and if so displays the winning text also ensure that the winning text does not show during the shuffeling process
            if(!inSetUp && checkForWin())
            {
                MessageBox.Show("Congratulations you Won!");
                Close();
            }
        }

        /// <summary>
        /// handles the Flipping of an individual light;
        /// </summary>
        /// <param name="b">the button to have it's light flipped</param>
        private void FlipButtonImage(Button b)
        {
            if(b.BackColor == Color.Yellow)
            {
                b.BackColor = Color.Black;
            }
            else
            {
                b.BackColor = Color.Yellow;
            }
        }

        /// <summary>
        /// .Handles the Cheat button that allows you to win the game
        /// </summary>
        /// <param name="sender">The caller of the function</param>
        /// <param name="e">Arguments passed by the event</param>
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Button b in buttons)
            {
                b.BackColor = Color.Black;
            }
            MessageBox.Show("Congratulations you Won!");
            Close();
        }
    }
}
