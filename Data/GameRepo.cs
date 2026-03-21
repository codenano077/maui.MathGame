
using Maui.MathGame.Models;
using SQLite;

namespace MathGame.Maui.Data
{
    public class GameRepo
    {
        string _dbPath;
        private SQLiteConnection conn;

        public GameRepo(string dbPath)
        {
            _dbPath = dbPath;
        }

        public void Init()
        {
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<Game>();
        }

        public List<Game> GetAllGames()
        {
            Init();
            return conn.Table<Game>().ToList();
        }

        public void Add(Game game)
        {
            Init();
            conn = new SQLiteConnection(_dbPath);
            conn.Insert(obj: game);
        }

        public void Delete(int id)
        {
            Init();
            conn = new SQLiteConnection(_dbPath);
            conn.Delete(new Game { Id = id });
        }
    }
}