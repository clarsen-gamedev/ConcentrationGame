//  Name: Connor Larsen
//  Project: ConcentrationGame
//  Title: frm_MainGame.cs
//  Purpose: The main form for the concentration game, this is where the game is played

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcentrationGame
{
    public partial class frm_MainGame : Form
    {
        // Private Variables
        private Random rand = new Random();                 // Used for randomizing the placement of the cards
        private List<Point> points = new List<Point>();     // List containing the locations for the cards
        private PictureBox firstFlip;                       // Stores the first card that was flipped
        private PictureBox secondFlip;                      // Stores the second card that was flipped
        private int totalGuesses, correctGuesses, wins = 0; // Ints used to keep track of the game stats

        public frm_MainGame()
        {
            InitializeComponent();
            InitializeGame();   // Creates the first board on startup
        }

        // Set up a brand new game
        private void InitializeGame()
        {
            // Set the image of all cards on the board to the cardBack image
            foreach (PictureBox card in gb_GameBoard.Controls)
            {
                card.Image = Properties.Resources.cardBack; // Sets the image
                card.Cursor = Cursors.Hand;                 // When mousing over card, hand icon appears
                card.Enabled = true;                        // Enables the card
                points.Add(card.Location);                  // Adds the card's location to the points list
            }

            // "Shuffle" the deck of cards
            foreach (PictureBox card in gb_GameBoard.Controls)
            {
                int next = rand.Next(points.Count); // Picks a random spot on the board
                Point p = points[next];             // Stores the selected point
                card.Location = p;                  // Move the card to stored point
                points.Remove(p);                   // Removes the stored point from the list so it does not get selected again
            }

            // Set firstFlip and secondFlip to null
            firstFlip = null;
            secondFlip = null;

            // Initialize other variables for a new game
            totalGuesses = 0;
            correctGuesses = 0;
            lbl_CheatStatus.Text = "Cheats Disabled";

            // Store ints into corresponding text boxes
            SetTextBoxInt(tb_TotalGuesses, totalGuesses);
            SetTextBoxInt(tb_CorrectGuesses, correctGuesses);
        }

        #region Toolbar Options
        // When the "New option is clicked in the toolbar"
        private void toolbar_New_Click(object sender, EventArgs e)
        {
            InitializeGame();   // Starts a new game
        }

        // When the "Exit" option is clicked in the toolbar
        private void toolbar_Exit_Click(object sender, EventArgs e)
        {
            // Create a message box asking the player if they want to leave the game
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Please Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) // If the player chooses yes...
            {
                Application.Exit(); // Close the game
            }
        }

        // When the "Instructions" option is clicked in the toolbar
        private void toolbar_Instructions_Click(object sender, EventArgs e)
        {
            frm_Instructions instructions = new frm_Instructions(); // Initialize the Instructions form
            instructions.ShowDialog();                              // Display the Instructions form
        }

        // When the "Credits" option is clicked in the toolbar
        private void toolbar_Credits_Click(object sender, EventArgs e)
        {
            frm_Credits credits = new frm_Credits();    // Initialize the Credits form
            credits.ShowDialog();                       // Display the Credits form
        }
        #endregion

        #region Gameplay
        // When the player clicks on a card
        private void onCardClick(object sender, EventArgs e)
        {
            PictureBox cardClicked = (PictureBox)sender;    // Store the clicked card
            string tag = Convert.ToString(cardClicked.Tag); // Convert the card's tag into a string
            flipCard(cardClicked, tag);                     // Run the flipCard function
        }

        // Function which changes the image on a card, used for flipping
        private void flipCard(PictureBox card, string tag)
        {
            // Change the card's image
            ChangeCardImage(card, tag);

            // Perform a flip check once the image has changed
            flipCheck(card);
        }

        // When a card is clicked, this checks if it's the first or second card that is flipped, then compares the two if its the second
        private void flipCheck(PictureBox inCard)
        {
            // If this is the first card flipped...
            if (firstFlip == null)
            {
                firstFlip = inCard;         // Stores the clicked card into firstFlip
                firstFlip.Enabled = false;  // Disables the clicked card from being clicked again
            }

            // If this is the second card flipped...
            else if (firstFlip != null && secondFlip == null)
            {
                secondFlip = inCard;        // Stores the clicked card into secondFlip
                secondFlip.Enabled = false; // Disables the clicked card from being clicked again

                // Since two cards have now been clicked, its time to compare
                char[] firstTag = (firstFlip.Tag.ToString().ToCharArray()); // Convert the first tag into a char array
                char[] secondTag = (secondFlip.Tag.ToString().ToCharArray()); // Convert the second tag into a char array

                if (firstTag[1] == secondTag[1])    // If the cards are the same value...
                {
                    if (firstTag[0] == 'C' && secondTag[0] == 'S')
                    {
                        CardMatch();
                    }
                    else if (firstTag[0] == 'D' && secondTag[0] == 'H')
                    {
                        CardMatch();
                    }
                    else if (firstTag[0] == 'H' && secondTag[0] == 'D')
                    {
                        CardMatch();
                    }
                    else if (firstTag[0] == 'S' && secondTag[0] == 'C')
                    {
                        CardMatch();
                    }
                    else
                    {
                        NoMatch();
                    }
                }
                else    // The cards are not the same value
                {
                    NoMatch();
                }

                // Set firstFlip and secondFlip back to null
                firstFlip = null;
                secondFlip = null;
            }
        }

        private void ChangeCardImage(PictureBox card, string tag)
        {
            // Convert the tag into a char array
            char[] tagArray = tag.ToCharArray();

            // Detect the suit of the card, then detect the value of the card
            if (tagArray[0] == 'C') // If the card is a club...
            {
                if (tagArray[1] == 'A') { card.Image = Properties.Resources.clubs_ace; }
                else if (tagArray[1] == '2') { card.Image = Properties.Resources.clubs_2; }
                else if (tagArray[1] == '3') { card.Image = Properties.Resources.clubs_3; }
                else if (tagArray[1] == '4') { card.Image = Properties.Resources.clubs_4; }
                else if (tagArray[1] == '5') { card.Image = Properties.Resources.clubs_5; }
                else if (tagArray[1] == '6') { card.Image = Properties.Resources.clubs_6; }
                else if (tagArray[1] == '7') { card.Image = Properties.Resources.clubs_7; }
                else if (tagArray[1] == '8') { card.Image = Properties.Resources.clubs_8; }
                else if (tagArray[1] == '9') { card.Image = Properties.Resources.clubs_9; }
                else if (tagArray[1] == '0') { card.Image = Properties.Resources.clubs_10; }
                else if (tagArray[1] == 'J') { card.Image = Properties.Resources.clubs_jack; }
                else if (tagArray[1] == 'Q') { card.Image = Properties.Resources.clubs_queen; }
                else if (tagArray[1] == 'K') { card.Image = Properties.Resources.clubs_king; }
            }
            else if (tagArray[0] == 'D')    // If the card is a diamond
            {
                if (tagArray[1] == 'A') { card.Image = Properties.Resources.diamonds_ace; }
                else if (tagArray[1] == '2') { card.Image = Properties.Resources.diamonds_2; }
                else if (tagArray[1] == '3') { card.Image = Properties.Resources.diamonds_3; }
                else if (tagArray[1] == '4') { card.Image = Properties.Resources.diamonds_4; }
                else if (tagArray[1] == '5') { card.Image = Properties.Resources.diamonds_5; }
                else if (tagArray[1] == '6') { card.Image = Properties.Resources.diamonds_6; }
                else if (tagArray[1] == '7') { card.Image = Properties.Resources.diamonds_7; }
                else if (tagArray[1] == '8') { card.Image = Properties.Resources.diamonds_8; }
                else if (tagArray[1] == '9') { card.Image = Properties.Resources.diamonds_9; }
                else if (tagArray[1] == '0') { card.Image = Properties.Resources.diamonds_10; }
                else if (tagArray[1] == 'J') { card.Image = Properties.Resources.diamonds_jack; }
                else if (tagArray[1] == 'Q') { card.Image = Properties.Resources.diamonds_queen; }
                else if (tagArray[1] == 'K') { card.Image = Properties.Resources.diamonds_king; }
            }
            else if (tagArray[0] == 'H')    // If the card is a heart
            {
                if (tagArray[1] == 'A') { card.Image = Properties.Resources.hearts_ace; }
                else if (tagArray[1] == '2') { card.Image = Properties.Resources.hearts_2; }
                else if (tagArray[1] == '3') { card.Image = Properties.Resources.hearts_3; }
                else if (tagArray[1] == '4') { card.Image = Properties.Resources.hearts_4; }
                else if (tagArray[1] == '5') { card.Image = Properties.Resources.hearts_5; }
                else if (tagArray[1] == '6') { card.Image = Properties.Resources.hearts_6; }
                else if (tagArray[1] == '7') { card.Image = Properties.Resources.hearts_7; }
                else if (tagArray[1] == '8') { card.Image = Properties.Resources.hearts_8; }
                else if (tagArray[1] == '9') { card.Image = Properties.Resources.hearts_9; }
                else if (tagArray[1] == '0') { card.Image = Properties.Resources.hearts_10; }
                else if (tagArray[1] == 'J') { card.Image = Properties.Resources.hearts_jack; }
                else if (tagArray[1] == 'Q') { card.Image = Properties.Resources.hearts_queen; }
                else if (tagArray[1] == 'K') { card.Image = Properties.Resources.hearts_king; }
            }
            else if (tagArray[0] == 'S')    // If the card is a spade
            {
                if (tagArray[1] == 'A') { card.Image = Properties.Resources.spades_ace; }
                else if (tagArray[1] == '2') { card.Image = Properties.Resources.spades_2; }
                else if (tagArray[1] == '3') { card.Image = Properties.Resources.spades_3; }
                else if (tagArray[1] == '4') { card.Image = Properties.Resources.spades_4; }
                else if (tagArray[1] == '5') { card.Image = Properties.Resources.spades_5; }
                else if (tagArray[1] == '6') { card.Image = Properties.Resources.spades_6; }
                else if (tagArray[1] == '7') { card.Image = Properties.Resources.spades_7; }
                else if (tagArray[1] == '8') { card.Image = Properties.Resources.spades_8; }
                else if (tagArray[1] == '9') { card.Image = Properties.Resources.spades_9; }
                else if (tagArray[1] == '0') { card.Image = Properties.Resources.spades_10; }
                else if (tagArray[1] == 'J') { card.Image = Properties.Resources.spades_jack; }
                else if (tagArray[1] == 'Q') { card.Image = Properties.Resources.spades_queen; }
                else if (tagArray[1] == 'K') { card.Image = Properties.Resources.spades_king; }
            }
        }

        // Called when two cards match
        private void CardMatch()
        {
            // Show a message telling the player they didn't get a match
            DialogResult cardMatch = MessageBox.Show("Your cards match!", "Match!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            // Remove matched card's images
            firstFlip.Image = null;
            secondFlip.Image = null;

            // Increase both guess ints by 1
            correctGuesses++;
            totalGuesses++;

            // Display ints in their textboxes
            SetTextBoxInt(tb_CorrectGuesses, correctGuesses);
            SetTextBoxInt(tb_TotalGuesses, totalGuesses);

            // Check if the game has been won
            if (correctGuesses == 26)
            {
                // Display a message box telling the player they have won
                DialogResult winGame = MessageBox.Show("You have won!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                wins++; // Increase the number of wins by 1
                SetTextBoxInt(tb_Wins, wins);   // Display total wins in its textbox

                // Start a new game
                InitializeGame();
            }
        }

        private void NoMatch()
        {
            // Show a message telling the player they didn't get a match
            DialogResult noMatch = MessageBox.Show("Your cards didn't match...", "No Match", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Change the image on both cards back to cardBack
            firstFlip.Image = Properties.Resources.cardBack;
            secondFlip.Image = Properties.Resources.cardBack;

            // Re-enable both cards
            firstFlip.Enabled = true;
            secondFlip.Enabled = true;

            // Increase total guesses by 1 and display
            totalGuesses++;
            SetTextBoxInt(tb_TotalGuesses, totalGuesses);
        }

        private void btn_toggleCheats_Click(object sender, EventArgs e)
        {
            // Grab the current status of the cheat mode
            string status = Convert.ToString(lbl_CheatStatus.Text);

            // If cheats are disabled...
            if (status == "Cheats Disabled")
            {
                lbl_CheatStatus.Text = "Cheats Enabled";    // Change the label

                // Show each card value
                foreach (PictureBox card in gb_GameBoard.Controls)
                {
                    if (card.Enabled == true && card.Image != null) { ChangeCardImage(card, card.Tag.ToString()); }
                }
            }

            else if (status == "Cheats Enabled")
            {
                lbl_CheatStatus.Text = "Cheats Disabled";   // Change the label

                // Change all enabled card's images back to cardBack
                foreach (PictureBox card in gb_GameBoard.Controls)
                {
                    if (card.Enabled == true && card.Image != null) { card.Image = Properties.Resources.cardBack; }
                }
            }
        }

        #endregion

        // Function for putting an int into a text box
        private void SetTextBoxInt(TextBox inTextBox, int var)
        {
            string temp = Convert.ToString(var);    // Converts the int to a string
            inTextBox.Text = temp;                  // Places the converted string into a text box
        }
    }
}
