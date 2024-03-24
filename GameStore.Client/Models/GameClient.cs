namespace GameStore.Client.Models;

public static class GameClient
{
    private static readonly List<Game> games = new()
    {
        new Game()
        {
            Id = 1,
            Name = "Minecraft",
            Genre = "Sandbox",
            Price = 9.99M,
            ReleaseDate = new DateTime(2011, 11, 18),
        },
        new Game()
        {
            Id = 2,
            Name = "Terraria",
            Genre = "Adventure",
            Price = 9.99M,
            ReleaseDate = new DateTime(2011, 05, 16),
        },
        new Game()
        {
            Id = 3,
            Name = "Hollow Knight",
            Genre = "Adventure",
            Price = 14.99M,
            ReleaseDate = new DateTime(2017, 02, 24),
        },
    };

    public static Game[] GetGames()
    {
        return games.ToArray();
    }

    public static void AddGame(Game game)
    {
        game.Id = games.Max(x => x.Id) + 1;
        games.Add(game);
    }

    public static Game GetGame(int id)
    {
        return games.Find(x => x.Id == id) ?? throw new Exception("Could not find a game");
    }

    public static void UpdateGame(Game updatedGame)
    {
        Game existingGame = GetGame(updatedGame.Id);
        existingGame.Name = updatedGame.Name;
        existingGame.Genre = updatedGame.Genre;
        existingGame.Price = updatedGame.Price;
        existingGame.ReleaseDate = updatedGame.ReleaseDate;
    }

    public static void DeleteGame(int id)
    {
        Game game = GetGame(id);
        games.Remove(game);
    }
}