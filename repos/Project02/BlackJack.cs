
using System.Net.NetworkInformation;
/**
* @author Mikey Dowsett
* Class BlackJack simulates a simple game of two-card Blackjack. */
class BlackJack {
    private static Random deck; // Generates random cards
    private const int MAX_WINS = 5;

    // You may declare other private CONSTANT fields here if they are needed
    // in two or more methods. (Variables are to be declared in the methods)

    /** Parameterless constructor ALREADY COMPLETED*/
    public BlackJack() {
        deck = new Random();
    }

    /** Run the BlackJack game */
    public void Run() {
        // Display the directions. (Call the appropriate method)
        IntroduceGame();

        // Deal cards while the player or house has not reached
        // the maximum number of wins. Remember to use the MAX_WINS
        // named constant instead of 5.
        int totalPlayerWins = 0,
            totalHouseWins = 0;

        while (totalPlayerWins != MAX_WINS && totalHouseWins != MAX_WINS) {
            // Clear the window and announce a new game. ALREADY COMPLETED
            Console.Write("Press any key to deal cards . . .");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("=========================================");
            Console.WriteLine("New game...");
            Console.WriteLine("=========================================");

            // Call DealCards to "deal" the first card to the player and the
            // house. You will need to declare 2 descriptive variables to
            // send to DealCards. Do not initialize when declaring as these  
            // will be out parameters in the call to DealCards
            int playerCardOne,
                houseCardOne;
            DealCards(out playerCardOne, out houseCardOne);

            // Call DealCards to "deal" the second card to the player and the
            // house. This is just like what was just done for the first card.
            int playerCardTwo,
                houseCardTwo;
            DealCards(out playerCardTwo, out houseCardTwo);

            // Display the result for the player in the format: 
            //   Player: card1, card2 (score)
            //   Example --> Player: A, 2 (13)
            //  
            //   Requirement: 
            //      Player: is displayed here. Then call DisplayCards 
            //      which displays card1, card2 e.g. A, 2
            //      Then, call and store the returned result from GetScore 
            //      and display that score between two parentheses.
            //      Note: Unlike DisplayCards, there is no write statement
            //      in GetScore as the value is only returned. 
            int playerScore;
            DisplayCards(playerCardOne, playerCardTwo, "Player", out playerScore);

            // Similar to the player, do display results for the house
            int houseScore;
            DisplayCards(houseCardOne, houseCardTwo, "House", out houseScore);

            // Display who won or if it was a tie. If not a tie, add 
            // one to the winner's win total (Nothing is added to win totals
            // for a tie.) You will need to have previously declared variables 
            // to hold the win totals.
            if (playerScore > houseScore) {
                Console.WriteLine("Player Wins!\n");
                totalPlayerWins++;
            } else if(houseScore > playerScore) {
                Console.WriteLine("House Wins!\n");
                totalHouseWins++;
            } else {
                Console.WriteLine("Tie!\n");
            }
            

            // Display the total wins so far for the house and player
            // in the form:
            // Total Player Wins: number of player wins
            // Total House Wins: number of house wins
            Console.WriteLine($"Total Player Wins: {totalPlayerWins}");
            Console.WriteLine($"Total House Wins: {totalHouseWins}");


        } // End while

        // Announce who reached MAX_WINS wins first
        if (totalPlayerWins == MAX_WINS) {
            Console.WriteLine($"Player reaches {MAX_WINS} wins first!");
        } else if (totalHouseWins == MAX_WINS) {
            Console.WriteLine($"House reaches {MAX_WINS} wins first!");
        }
    }

    /**
	* DealCards assigns a random integer between 2 and 14 inclusively
	* to the player card and the house card.
	* Numeric card representation:
	*   2 - 10: represents the numeric face value of the card
	*   11: represents an Ace
	*   12 - 14: represents Jack, Queen, and King respectively 
	* @param playerCard Will hold the generated number for the player
	* @param houseCard Will hold the generated number for the house 
	* Hint: The method does not return a value, so use out or ref
	* parameters for playerCard and houseCard. */
    public void DealCards(out int playerCard, out int houseCard) {
        Random rand = new Random();
        playerCard = deck.Next(2, 15);
        houseCard = deck.Next(2, 15);
    } // end DealCards

    /**
	* DisplayCards displays the two cards for a given hand in the form
	*      card,<space>card<space>   (No new line)
	*  e.g    K, 8 
	* Card display:
	*   2 - 10: The number is displayed
	*   11: A is displayed
	*   12 - 14: J, Q, or K respectively is displayed
	* @param card1 Number representing the person's first card
	* @param card2 Number representing the person's second card 
	* @precondition Each card parameter contains a number in the
	*               range 2 - 14 */
    public void DisplayCards(int card1, int card2, string player, out int score) {
        string card1Alt,
               card2Alt;

        // 11 = Ace | 12 = Jack | 13 = Queen | 14 = King
        switch(card1){
            case 11:
                card1Alt = "A";
                break;
            case 12: 
                card1Alt = "J";
                break;
            case 13:
                card1Alt = "Q";
                break;
            case 14:
                card1Alt = "K";
                break;
            default:
                card1Alt = card1.ToString();
                break;
        }
        // 11 = Ace | 12 = Jack | 13 = Queen | 14 = King
        switch (card2) {
            case 11:
                card2Alt = "A";
                break;
            case 12:
                card2Alt = "J";
                break;
            case 13:
                card2Alt = "Q";
                break;
            case 14:
                card2Alt = "K";
                break;
            default:
                card2Alt = card2.ToString();
                break;
        }

        //Gets the score of the two cards and displays it.
        score = GetScore(card1, card2);
        Console.WriteLine($"{player}: {card1Alt}, {card2Alt} " +
            $"({score})");
    } // end DisplayCards;

    /**
	* GetScore computes the total score for a given hand by adding
	* the values of the two cards. To compute a card value
	*   2 - 11: The value of the card is the number
	*   12 - 14: The value of the card is 10
	*   Note: If a person has 2 Aces, the value of one of them is
	*         treated as a 1. (Total score would be 12)
	* @param card1 Number representing the person's first card
	* @param card2 Number representing the person's second card 
	* @precondition Each card parameter contains a number in the range
	*               2 - 14
	* @return The total score */
    public int GetScore(int card1, int card2) {
        //Checks if the cards are a Jack, Queen or King
        if (card1 >= 12)
            card1 = 10;
        if (card2 >= 12)
            card2 = 10;
        //Checks if both cards are an Ace
        if (card1 == 11 && card2 == 11)
            card2 = 1;

        return card1 + card2;
    } // end GetScore

    /** IntroduceGame introduces the game ALREADY COMPLETED */
    public void IntroduceGame() {
        Console.WriteLine(
                "**************************************************\n" +
                "Welcome to Two Card Black Jack!\n" +
                "The house and the player are each dealt two cards.\n" +
                "The value of each hand is computed and the winner\n" +
                "is announced. The game ends when either the player\n" +
                $"or the house wins {MAX_WINS} games.\n" +
                "**************************************************");
    } // end IntroduceGame
} // end class