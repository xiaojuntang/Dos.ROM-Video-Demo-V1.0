using Dos.ORM;

namespace Zxxk.Gkbb.DataAccess
{
    public class Db
    {
        public static readonly DbSession Context = new DbSession("SqlServerConn");
    }
}