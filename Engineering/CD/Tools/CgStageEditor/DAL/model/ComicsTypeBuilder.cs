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
	public class ComicsTypeBuilder:SqliteBuilder
	{
        public ComicsTypeBuilder(SQLiteConnection connection)
            : base(connection)
        {
            defaultSeletSql = "select * from comicsType";
        }
        
		#region  BasicMeth

		/// <summary>
		/// 增加一条数据
		/// </summary>
        public override SQLiteCommand createInsertCmd()
		{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into comicsType(");
            strSql.Append("name)");
            strSql.Append(" values (");
            strSql.Append("@name)");
            strSql.Append(";select LAST_INSERT_ROWID()");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@name", DbType.String,20,"name")};
            return createCmd(strSql, parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
        public override SQLiteCommand createUpdateCmd()
		{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update comicsType set ");
            strSql.Append("name=@name");
            strSql.Append(" where id=@id");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@name", DbType.String,20,"name"),
					new SQLiteParameter("@id", DbType.Int32,8,"id")};
            return createCmd(strSql, parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
        public override SQLiteCommand createDeleteCmd()
		{

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from comicsType ");
            strSql.Append(" where id=@id");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@id", DbType.Int32,4,"id")
			};
            return createCmd(strSql, parameters);
		}

        

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

