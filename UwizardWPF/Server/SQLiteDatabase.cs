using System;
using System.Threading.Tasks;
using SQLite.Net;

namespace UwizardWPF.Server
{
    public class SQLiteDatabase : ISQLiteDatabase
    {
        public Task Do(Action<SQLiteConnection> action)
        {
            throw new NotImplementedException();
        }

        public void DoSync(Action<SQLiteConnection> action)
        {
            throw new NotImplementedException();
        }

        public Task<TResult> Do<TResult>(Func<SQLiteConnection, TResult> func)
        {
            throw new NotImplementedException();
        }

        public TResult DoSync<TResult>(Func<SQLiteConnection, TResult> func)
        {
            throw new NotImplementedException();
        }
    }
}
