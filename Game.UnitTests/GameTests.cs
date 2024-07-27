namespace Game.UnitTests;

public class GameTests
{
    [Fact]
    public void Jatek_Inditasa_Jatekos1_Nevet_Eltarolja()
    {
        var sorok_szama = 3;
        var game = new BoardFootballGame("jatekos1", "", sorok_szama,3,1);
        Assert.Equal("jatekos1", game.Jatekos1);
    }

    [Fact]
    public void Jatek_Inditasa_Jatekos2_Nevet_Eltarolja()
    {
        var game = new BoardFootballGame("jatekos1", "jatekos2", 1,5,1);
        Assert.Equal("jatekos2", game.Jatekos2);
    }

    [Fact]
    public void Jatek_Inditasa_Sorok_Szamat_Eltarolja()
    {
        var game = new BoardFootballGame("jatekos1", "jatekos2", 3,5,1);
        Assert.Equal(3, game.Sorok_szama);
    }

    [Fact]
    public void Jatek_Inditasa_Paros_Sorok_Szama_Hibat_Dob()
    {
        Assert.Throws<Exception>(() => new BoardFootballGame("jatekos1", "jatekos2", 4, 5, 1));
    }

    [Fact]
    public void Oszlopok_száma_tárolása()
    {
        var game = new BoardFootballGame("","",3,5,1);
        Assert.Equal(5, game.Oszlopok_szama);
    }
    [Fact]
    public void Oszlopok_száma_Paros()
    {
        Assert.Throws<Exception>(() => new BoardFootballGame("", "", 3, 4, 1));
    }
    [Fact]
    public void Focisták_száma_tárolás()
    {
        //Given
        var game = new BoardFootballGame("","",3,5,10);
        Assert.Equal(10, game.Focistak);
    }

}

