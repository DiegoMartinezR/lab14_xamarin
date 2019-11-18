using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;

namespace Lab14
{
    class ModelDatabase
    {
        readonly SQLiteAsyncConnection database;

        public ModelDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<modelo>().Wait();
        }

        public Task<List<modelo>> GetItemsAsync()
        {
            return database.Table<modelo>().ToListAsync();
        }

        public Task<List<modelo>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<modelo>("SELECT * FROM [modelo] ");
        }

        public Task<modelo> GetItemAsync(int id)
        {
            return database.Table<modelo>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(modelo item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(modelo item)
        {
            return database.DeleteAsync(item);
        }

    }
}
