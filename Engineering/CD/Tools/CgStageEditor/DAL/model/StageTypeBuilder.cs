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
	public class StageTypeBuilder:SqliteBuilder
	{
        public StageTypeBuilder(SQLiteConnection connection)
            : base(connection)
        {
            defaultSeletSql = "select * from stageType";
        }
        
		#region  BasicMeth

		/// <summary>
		/// 增加一条数据
		/// </summary>
        public override SQLiteCommand createInsertCmd()
		{
            return null;
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
        public override SQLiteCommand createUpdateCmd()
		{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update stageType set ");
            strSql.Append("name=@name");
            strSql.Append(" where id=@id");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@name", DbType.String,10,"name"),
					new SQLiteParameter("@id", DbType.Int32,8,"id")};
            return createCmd(strSql, parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
        public override SQLiteCommand createDeleteCmd()
		{

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from stageType ");
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

