/*Branden M. 
 * CST-150
 * Grand Canyon Univeristy
 */
namespace Activity_13__Tic_Tac_Toe_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            GenerateButtons();
        }

        Button[,] buttons = new Button[3, 3];

        private void GenerateButtons()
            // This function will begin creating the buttons needed for the tic-tac-toe game to work. 
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j] = new Button(); 
                    // This will make the new buttons needed for the game.

                    buttons[i, j].Size = new Size(135, 135);
                    // This will set the size of the buttons needed for the game.

                    buttons[i, j].Location = new Point(i * 140, j * 140);
                    // This will tell where to place the buttons on the board.

                    buttons[i, j].FlatStyle = FlatStyle.Flat;
                    // For this tic-tac-toe game we want flat squares to be shown on the tic-tac-toe board.

                    buttons[i, j].Font = new System.Drawing.Font(DefaultFont.FontFamily, 80, FontStyle.Bold);
                    // This will set the font style for the X's and O's on the board.

                    buttons[i, j].Click += new EventHandler(button_Click);
                    // This will tell the board that the button can be called to be clicked when the game begins.

                    panel1.Controls.Add(buttons[i, j]);
                    // This will setup the board with the buttons needed to play the game.
                }
            }

            MessageBox.Show("IT'S TIME TO PLAY THE GAME!");
        }

        void button_Click(object sender, EventArgs e)
        {
            // Load the clicked button into a local variable
            Button button = sender as Button;

            // Don't do anything if the block is already marked
            if (button.Text != "")
            {
                return;
            }

            // Mark the block with current players icon
            button.Text = button1.Text;

            TogglePlayer();
        }

        private void TogglePlayer()
        {
            CheckIfGameEnds();

            if (button1.Text == "X")
            {
                button1.Text = "O";
            }
            else
            {
                button1.Text = "X";
            }
        }

        private void CheckIfGameEnds()
            // This will check to meet the condtions that a player has 3 in a row, either diagonally, horizontally, or vertically
        {
            List<Button> victorButtons = new List<Button>();

            #region // vertical
            // This will start checking the board vertically to see if either player has won the game
            for (int i = 0; i < 3; i++)
            {
                victorButtons = new List<Button>();
                for (int j = 0; j < 3; j++)
                {
                    if (buttons[i, j].Text != button1.Text)
                    {
                        break;
                    }

                    victorButtons.Add(buttons[i, j]);
                    if (j == 2)
                    {
                        tictactoewinner(victorButtons);
                        return;
                    }
                }
            }
            #endregion 
            //This will end the checking the board vertically


            #region // horizontal 
            //This will check horizontally across the board horizontally and see if anyone has one the game with three X's or O's across
            for (int i = 0; i < 3; i++)
            {
                victorButtons = new List<Button>();
                for (int j = 0; j < 3; j++)
                {
                    if (buttons[j, i].Text != button1.Text)
                    {
                        break;
                    }

                    victorButtons.Add(buttons[j, i]);
                    if (j == 2)
                    {
                        tictactoewinner(victorButtons);
                        return;
                    }
                }
            }
            #endregion            
            #region// diagonally 1 (top-left to bottom-right)
            victorButtons = new List<Button>();
            for (int i = 0, j = 0; i < 3; i++, j++)
            {
                if (buttons[i, j].Text != button1.Text)
                {
                    break;
                }

                victorButtons.Add(buttons[i, j]);
                if (j == 2)
                {
                    tictactoewinner(victorButtons);
                    return;
                }
            }
            #endregion
            #region// diagonally 2 (will check from the bottom-left area of the board to top-right area of the board for a winner)
            victorButtons = new List<Button>();
            for (int i = 2, j = 0; j < 3; i--, j++)
            {
                if (buttons[i, j].Text != button1.Text)
                {
                    break;
                }

                victorButtons.Add(buttons[i, j]);
                if (j == 2)
                {
                    tictactoewinner(victorButtons);
                    return;
                }
            }
            #endregion

            // Checking if the game box has already been used
            foreach (var button in buttons)
            {
                if (button.Text == "")
                    return;
            }

            // If the game ends in a draw the player(s) will have the choice to keep playing or not
            DialogResult dialogResult = MessageBox.Show("THIS GAME ENDED IN A DRAW!" + "\n" + "\n" +  "Would you like to play again?", "Tic-Tac-Toe (Version 1.0)", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Restart(); // If the person chooses yes then the game will restart and they can play again.
            }
            else if (dialogResult == DialogResult.No)
            {
                Application.Exit(); // If the person chooses no then the game will stop.
            }
        }


        private void tictactoewinner(List<Button> victorButtons)
        {
            // color all the winner blocks
            foreach (var button in victorButtons)
            {
                button.BackColor = Color.Green;
                //Whoever wins the game will have their tiles highlighted in green.

                button.ForeColor = Color.Red;
                /// Whoever wins the game will have their letters highlighted in red. 
            }

            MessageBox.Show("Player: " + button1.Text + " is the winner!"); // This will display who won the current game

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"H:\PSEAFY2-arcade-win.wav");
            player.Play();
            // Wanted to add a winning sound to the game after someone wins

            DialogResult dialogResult = MessageBox.Show("Would you like to play again?", "Tic-Tac-Toe (Version 1.0)", MessageBoxButtons.YesNo);
            //Wanted to give the players the choice to play again or not

            if (dialogResult == DialogResult.Yes)
            {
                Application.Restart(); // If the person chooses yes then the game will restart and they can play again.
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Huge thank you to the support and guidance from the references and sites down below: " + "\n" + "\n" + "References: Multidimensional Arrays - C# Programming Guide. (2021, September 15). Microsoft Docs. Retrieved February 18, 2022, from https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/multidimensional-arrays" + "\n" + "\n" + "http://code-kings.blogspot.com/2014/06/tictactoe-csharp-tutorial.html"
                     + "\n" + "\n" + " How to Create Advanced Tic Tac Toe Game in C#. (2020, July 4). YouTube. Retrieved February 18, 2022, from https://www.youtube.com/watch?v=O2ia9AydiIM");
                Application.Exit(); // If the person chooses no then the game will stop.
            }

        }

        /* These will be the labels for the panel(holds the tic-tac-toe squares),
         * the label for the current players turn as well as the button that shows who's current turn it is
         */

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // This panel will hold all the tic-tac-toe squares.
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // This label will be on the far right of the board, and tell who's current turn it is.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // This button will show visually who's turn it is, it will display either X or O.
            MessageBox.Show("I'm just here to keep the players in line!");
        }
    }
}