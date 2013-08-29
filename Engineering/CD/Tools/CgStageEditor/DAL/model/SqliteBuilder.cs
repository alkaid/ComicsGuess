using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using Maticsoft.DBUtility;//Please add references
namespace coodroid.DAL.model
{
	/// <summary>
	/// SqliteCommand及SqliteAdapter构建帮助类
	/// </summary>
	public abstract class SqliteBuilder
	{
        protected SQLiteConnection connection;
        public System.Data.SQLite.SQLiteConnection Connection
        {
            get { return connection; }
            set { connection = value; }
        }
        public SqliteBuilder(SQLiteConnection connection)
        {
            this.connection = connection;
        }
        protected string defaultSeletSql = null;
        public string DefaultSeletSql
        {
            get { return defaultSeletSql; }
            set { defaultSeletSql = value; }
        }

		#region  BasicMeth

        protected SQLiteCommand createCmd(StringBuilder strSql, SQLiteParameter[] parameters)
        {
            SQLiteCommand cmd = new SQLiteCommand(strSql.ToString(), connection);
            foreach (SQLiteParameter parm in parameters)
                cmd.Parameters.Add(parm);
            return cmd;
        }
		/// <summary>
		/// 增加一条数据
		/// </summary>
        public abstract SQLiteCommand createInsertCmd();
		/// <summary>
		/// 更新一条数据
		/// </summary>
        public abstract SQLiteCommand createUpdateCmd();

		/// <summary>
		/// 删除一条数据
		/// </summary>
        public abstract SQLiteCommand createDeleteCmd();

        public SQLiteDataAdapter createAdapter()
        {
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(defaultSeletSql, connection);
            SQLiteCommandBuilder builder = new SQLiteCommandBuilder(adapter);
            //adapter.InsertCommand = createInsertCmd();
            adapter.UpdateCommand = createUpdateCmd();
            adapter.DeleteCommand = createDeleteCmd();
            return adapter;
        }

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

