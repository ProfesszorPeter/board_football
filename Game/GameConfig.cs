namespace Game;

public record GameConfig
{
    public GameConfig(string Player1, string Player2, int Columns, int Rows, int Footballers)
    {
        if (string.IsNullOrEmpty(Player1)) throw new ArgumentNullException("Player1 should not be empty");
        if (string.IsNullOrEmpty(Player2)) throw new ArgumentNullException("Player2 should not be empty");
        if (Columns % 2 == 0) throw new ArgumentException("Column should be odd");
        if (Columns < 5) throw new ArgumentException("Columns should be higher than 4");
        if (Rows % 2 == 0) throw new ArgumentException("Rows should be odd");
        if (Footballers % 2 == 1) throw new ArgumentException("Footballers should be even");
        this.Player1 = Player1;
        this.Player2 = Player2;
        this.Columns = Columns;
        this.Rows = Rows;
        this.Footballers = Footballers;
    }

    public string Player1 { get; }
    public string Player2 { get; }
    public int Columns { get; }
    public int Rows { get; }
    public int Footballers { get; }
}