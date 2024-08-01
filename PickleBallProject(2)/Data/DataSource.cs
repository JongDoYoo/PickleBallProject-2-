using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PickleBallProject_2_.Model;
using SQLite;

namespace PickleBallProject_2_.Data
{
    public class DataSource
    {
        private readonly SQLiteAsyncConnection _database;

        public DataSource(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<SystemInfo>().Wait();
            
        }

        public Task<int> RegisterUserAsync(SystemInfo user)
        {
            return _database.InsertAsync(user);
        }

        public Task<SystemInfo> LoginUserAsync(string email, string password)
        {
            return _database.Table<SystemInfo>().FirstOrDefaultAsync(u => u.Email == email && u.Password == password);
        }

        public Task<SystemInfo> GetUserByEmailAsync(string email)
        {
            return _database.Table<SystemInfo>().FirstOrDefaultAsync(u => u.Email == email);
        }
    }
}
