public class BoardFootballGame {
    public string Jatekos1 { get; set; }
    public string Jatekos2 { get; set; }
    public int Sorok_szama { get; set; }
    public int Oszlopok_szama { get; set; }
    public int Focistak { get; set; }

    public BoardFootballGame(string player1, string player2, int sorok_szama, int oszlopo_szama, int focistak)
    {
        Jatekos1 = player1;
        Jatekos2 = player2;
        if (sorok_szama % 2 == 0) throw new Exception("A sorok száma páratlan kell hogy legyen"); 
        Sorok_szama = sorok_szama;
        if (oszlopo_szama % 2 == 0) throw new Exception("Az oszlopok száma páratlan kell legyen");
        Oszlopok_szama = oszlopo_szama;
        Focistak = focistak;
    }
}