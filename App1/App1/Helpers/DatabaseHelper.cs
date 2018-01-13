using App1.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Helpers
{
    public static class DatabaseHelper
    {
        public static SQLiteAsyncConnection Database { get; private set; }
        private static bool _initialized;

        public static async Task Initialize()
        {
            if(Database == null)
            {
                Database = new SQLiteAsyncConnection(Xamarin.Forms.DependencyService.Get<IFileHelper>().GetLocalFilePath("xamarin_db.db3"));
                await Database.CreateTableAsync<TaskDTO>();
            }
        }

        public static async Task<List<T>> GetTable<T>() where T : new()
        {
            if (Database == null)
                await Initialize();
            return await Database.Table<T>().ToListAsync();
        }

        public static async Task<T> GetSingle<T>(int id) where T : baseDTO, new()
        {
            if (Database == null)
                await Initialize();
            return await Database.Table<T>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public static async Task<int> InsertSingle<T>(T item) where T: baseDTO, new()
        {
            if (Database == null)
                await Initialize();
            return await Database.InsertAsync(item);
        }

        public static async Task<int> UpdateSingle<T>(T item) where T: baseDTO, new()
        {
            if (Database == null)
                await Initialize();
            return await Database.UpdateAsync(item);
        }
    }
}
