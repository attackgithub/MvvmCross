using System.IO;
using SQLite.Net.Interop;
using SQLite.Net.Platform.WinRT;

namespace MvvmCross.Plugins.Sqlite.WindowsUWP
{
    public class WindowsSqliteConnectionFactory : MvxSqliteConnectionFactoryBase
    {
        public override ISQLitePlatform CurrentPlattform => new SQLitePlatformWinRT();
        public override string GetPlattformDatabasePath(string databaseName)
        {
            return Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, databaseName);
        }
    }
}