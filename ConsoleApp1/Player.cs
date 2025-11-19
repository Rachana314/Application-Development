public class Player
{
    // Instance fields with default values
    public string playerName = "";
    public int level = 0;
    public int health = 0;

    // Default constructor
    public Player()
    {
        Console.WriteLine("Default constructor has been called");
    }

    // Parameterized constructor
    public Player(string playerName, int level, int health)
    {
        this.playerName = playerName;
        this.level = level;
        this.health = health;
    }
}