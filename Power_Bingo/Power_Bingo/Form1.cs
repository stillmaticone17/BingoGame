using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Power_Bingo
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        // Declaring variables for the dimensions of the board and its numbers
        private const int bingoCardSize = 5;
        private const int numbers = 5;
        private const int maxBingoNumber = 75;

        // Creates an array of references to buttons with the dimensions of the variables above
        private Button[,] newButton = new Button[bingoCardSize, bingoCardSize];
        int countOfCalledNumbers;
        char nextCalledLetter;
        int nextCalledNumber;

        String bingoLetters = "BINGO";



        private InternalCardClass internalCardRepWO2DArray = new InternalCardClass();
        private RNGType RNGObj = new RNGType();

        //width and height of a card cell
        int cardCellWidth = 75;
        int cardCellHeight = 75;
        int barWidth = 6; // Thickness of horizontal and vertical bars
        int xCardUpperLeft = 45;
        int yCardUpperLeft = 45;
        int padding = 20;

        private void createCard()
        {
            // Creates 25 buttons and adds them to the board

            Size size = new Size(75, 75);
            Point loc = new Point(0, 0);
            int topMargin = 60;

            int x, y;

            // Draws Column indices by calling separate method 'drawColumnLabels'
            y = 0;
            DrawColumnLabels();

            x = xCardUpperLeft;
            y = yCardUpperLeft;

            // Draws top line for the bingo card
            drawHorizBar(x, y, bingoCardSize);
            y = y + barWidth;

            // Draws left most line for the bingo card
            drawVertBar(x, y);
            for (int row = 0; row < bingoCardSize; row++)
            {
                loc.Y = topMargin + row * (size.Height + padding);
                int extraLeftPadding = 50;
                for (int column = 0; column < bingoCardSize; column++)
                {
                    newButton[row, column] = new Button();
                    newButton[row, column].Location = new Point(extraLeftPadding + column *
                        (size.Width + padding) + barWidth, loc.Y);
                    newButton[row, column].Font = new Font("Microsoft JhengHei", 24, FontStyle.Bold);

                    if (row == bingoCardSize / 2 && column == bingoCardSize / 2)
                    {
                        newButton[row, column].Font = new Font("Microsoft JhengHei", 10, FontStyle.Bold);
                        newButton[row, column].Text = "Free \n Space";
                        newButton[row, column].BackColor = System.Drawing.Color.Orange;
                    }
                    else
                    {
                        newButton[row, column].Font = new Font("Microsoft JhengHei", 24, FontStyle.Bold);
                        newButton[row, column].Text = RNGObj.getRandomValue(bingoLetters[column]).ToString();
                    }
                    //end if-else statement

                    // Enables buttons and names them based on their location
                    newButton[row, column].Enabled = true;
                    newButton[row, column].Name = "btn" + row.ToString() + column.ToString();

                    // Applies one event handler to each of the buttons

                    newButton[row, column].Click += new EventHandler(Button_Click);

                    // Adds button to the form
                    Controls.Add(newButton[row, column]);

                    // Draws vertical delimiter
                    x += cardCellWidth + padding;
                    if (row == 0) drawVertBar(x - 5, y);
                } // end column for loop

                // One row now complete

                // Draw bottom square delimiter if square complete
                x = xCardUpperLeft - 20;
                y = y + cardCellHeight + padding;
                drawHorizBar(x + 25, y - 10, bingoCardSize - 10);

            } // end row for loop

            // Draw column indices at bottom of the card
            y += barWidth - 1;
            DrawColumnLabels();
            Globals.selectedNumbersListObj.reset();
        } // end of CreateBoard


        //Draws column indices at top and bottom of the card
        private void DrawColumnLabels()
        {
            Label lblColID = new Label();
            lblColID.Font = new Font("Microsoft JhengHei", (float)24.0, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColID.ForeColor = Color.Green;  //color of column label font
            lblColID.Location = new Point(cardCellWidth, 0);
            lblColID.Name = "lblColIDBINGO";
            lblColID.Size = new Size(488, 32);
            lblColID.TabIndex = 0;
            lblColID.Text = "B      I       N       G       O";
            Controls.Add(lblColID);
            lblColID.Visible = true;
            lblColID.CreateControl();
            lblColID.Show();
        } //end drawColumnLabels

        //Draw the dark horizontal bar
        private void drawHorizBar(int x, int y, int cardSize)
        {
            int currentX;
            currentX = x;

            Label lblHorizBar = new Label();
            lblHorizBar.BackColor = SystemColors.ControlText;
            lblHorizBar.Location = new Point(currentX, y);
            lblHorizBar.Name = "lblHorizBar";
            lblHorizBar.Size = new Size((cardCellWidth + padding - 1) *
                bingoCardSize, barWidth);
            lblHorizBar.TabIndex = 20;
            Controls.Add(lblHorizBar);
            lblHorizBar.Visible = true;
            lblHorizBar.CreateControl();
            lblHorizBar.Show();
            currentX = currentX + cardCellWidth;
        } //end drawHorizBar

        void playTheGame()
        {
            if (countOfCalledNumbers < maxBingoNumber)
            {
                countOfCalledNumbers++;
                nextCalledNumber = RNGObj.getNextUniqueRandomValue(1, maxBingoNumber);
                nextCalledLetter = bingoLetters[(nextCalledNumber - 1) / numbers];
                txtCalledNumber.Text = nextCalledLetter + " " + nextCalledNumber.ToString();
            }
            else
            {
                MessageBox.Show("All bingo numbers called. \nYou must have missed one or more. \nGame over.");


            }
        }
        //Draw dark vertical bar
        private void drawVertBar(int x, int y)
        {
            Label lblVertBar = new Label();
            lblVertBar.BackColor = SystemColors.ControlText;
            lblVertBar.Location = new Point(x, y);
            lblVertBar.Name = "lblVertBar" + x.ToString();
            lblVertBar.Size = new Size(barWidth, (cardCellHeight + padding - 1) * bingoCardSize);
            lblVertBar.TabIndex = 19;
            Controls.Add(lblVertBar);
            lblVertBar.Visible = true;
            lblVertBar.CreateControl();
            lblVertBar.Show();
        }  // end drawVertBar


        // This is the handler for all Bingo Card Buttons
        //  It uses sender argument to determine which button was selected
        //  The argument is of type object and must be converted to type Button in order to change 
        //      its properties.
        private void Button_Click(object sender, EventArgs e)
        {
            int bingoCountWO2D;
            int selectedNumber;

            int rowID = Convert.ToInt32(((Button)sender).Name[3]);
            int colID = Convert.ToInt32(((Button)sender).Name[4]);
            MessageBox.Show("Cell[" + rowID + "," + colID + "] has been selected!");

            int cellID = rowID * 3 + colID;

            // Double check that the value of the button clicked matches the value called
            selectedNumber = Convert.ToInt32(newButton[rowID, colID].Text);
            if (selectedNumber == nextCalledNumber) //nextCalledNumber is a variable from the InternalBoard class
            {
                newButton[rowID, colID].BackColor = Color.Orange;
                //internalCardRep2DArray.recordCalledNumber(rowID, colID);
                internalCardRepWO2DArray.recordCalledNumber(rowID, colID);
                Globals.selectedNumbersListObj.recordCalledNumber(selectedNumber);

                // Check for winner by calling Internal Card Class
                // Go here if player found the number called in their card
                // Check for winner for either internal representation
                bingoCountWO2D = internalCardRepWO2DArray.isWinner(rowID, colID);
                // bingoCountWO2D = internalCardRepWO2DArray.isWinner(rowID, colID);
                if (bingoCountWO2D > 0)
                {
                    MessageBox.Show("BINGO!! You are the winner!!", "Winner Found! \n"
                        + "Bingo count = " + (bingoCountWO2D)
                        + "Game Over!");
                    Close();
                } //end inner if statement
                playTheGame();
            }
            else
            {
                MessageBox.Show("Called number does not match the selected number!"
                    + "Try again!", "Numbers Do Not Match");
            } //end of outer if else statement
        } // end button_click handler
    }
    public class Globals
    {
        public static SelectedNumbersList selectedNumbersListObj = new SelectedNumbersList();
    }



}
