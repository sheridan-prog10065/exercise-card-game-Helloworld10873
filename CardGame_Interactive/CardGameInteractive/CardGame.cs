namespace CardGameInteractive;

/// <summary>
///Defines the card game that implements the game logic and holds the card deck 
/// </summary>
public class CardGame
{
    /// <summary>
    /// represents the deck of cards the game is using
    /// </summary>
    private CardDeck _cardDeck;
    
    /// <summary>
    /// the score of the game
    /// </summary>
    private Score _score;
    
    /// <summary>
    /// the last card played by the user
    /// </summary>
    private Card _playerCard;

    /// <summary>
    /// the last card played by the house
    /// </summary>
    private Card _houseCard;
    
}