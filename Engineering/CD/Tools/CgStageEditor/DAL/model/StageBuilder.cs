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
    public class StageBuilder : SqliteBuilder
    {
        public StageBuilder(SQLiteConnection connection)
            : base(connection)
        {
            defaultSeletSql = "select * from stage";
        }
        
		#region  BasicMeth

		/// <summary>
		/// 增加一条数据
		/// </summary>
        public override SQLiteCommand createInsertCmd()
		{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into stage(");
            strSql.Append("name,catalog,stageType,unlocked,nearSubject)");
            strSql.Append(" values (");
            strSql.Append("@name,@catalog,@stageType,@unlocked,@nearSubject)");
            strSql.Append(";select LAST_INSERT_ROWID()");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@name", DbType.String,10,"name"),
					new SQLiteParameter("@catalog", DbType.Int32,8,"catalog"),
					new SQLiteParameter("@stageType", DbType.Int32,8,"stageType"),
					new SQLiteParameter("@unlocked", DbType.Boolean,"unlocked"),
					new SQLiteParameter("@nearSubject", DbType.Int32,8,"nearSubject")};
            return createCmd(strSql, parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
        public override SQLiteCommand createUpdateCmd()
		{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update stage set ");
            strSql.Append("name=@name,");
            strSql.Append("catalog=@catalog,");
            strSql.Append("stageType=@stageType,");
            strSql.Append("unlocked=@unlocked,");
            strSql.Append("nearSubject=@nearSubject");
            strSql.Append(" where id=@id");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@name", DbType.String,10,"name"),
					new SQLiteParameter("@catalog", DbType.Int32,8,"catalog"),
					new SQLiteParameter("@stageType", DbType.Int32,8,"stageType"),
					new SQLiteParameter("@unlocked", DbType.Boolean,"unlocked"),
					new SQLiteParameter("@nearSubject", DbType.Int32,8,"nearSubject"),
					new SQLiteParameter("@id", DbType.Int32,8,"id")};
            return createCmd(strSql, parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
        public override SQLiteCommand createDeleteCmd()
		{

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from stage ");
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

