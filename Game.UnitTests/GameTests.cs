namespace Game.UnitTests;

public class GameTests
{
    int sorok_szama = 3;

    [Fact]
    public void Jatek_Inditasa_Jatekos1_Nevet_Eltarolja()
    {
        var game = new BoardFootballGame("jatekos1", "", sorok_szama,3,1);
        Assert.Equal("jatekos1", game.Jatekos1);
    }

    [Fact]
    public void Jatek_Inditasa_Jatekos2_Nevet_Eltarolja()
    {
        var game = new BoardFootballGame("jatekos1", "jatekos2", sorok_szama,5,1);
        Assert.Equal("jatekos2", game.Jatekos2);
    }

    [Fact]
    public void Jatek_Inditasa_Sorok_Szamat_Eltarolja()
    {
        var game = new BoardFootballGame("jatekos1", "jatekos2", sorok_szama,5,1);
        Assert.Equal(3, game.Sorok_szama);
    }

    [Fact]
    public void Jatek_Inditasa_Paros_Sorok_Szama_Hibat_Dob()
    {
        Assert.Throws<Exception>(() => new BoardFootballGame("jatekos1", "jatekos2", sorok_szama, 5, 1));
    }

    [Fact]
    public void Oszlopok_száma_tárolása()
    {
        var game = new BoardFootballGame("","",sorok_szama,5,1);
        Assert.Equal(5, game.Oszlopok_szama);
    }
    [Fact]
    public void Oszlopok_száma_Paros()
    {
        Assert.Throws<Exception>(() => new BoardFootballGame("", "", sorok_szama, 4, 1));
    }
    [Fact]
    public void Focisták_száma_tárolás()
    {
        //Given
        var game = new BoardFootballGame("","",sorok_szama,5,10);
        Assert.Equal(10, game.Focistak);
    }

}

