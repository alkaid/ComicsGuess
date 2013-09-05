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
    public class SubjectBuilder : SqliteBuilder
    {
        public SubjectBuilder(SQLiteConnection connection)
            : base(connection)
        {
            defaultSeletSql = "select * from subject";
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
            strSql.Append("update subject set ");
            strSql.Append("title=@title,");
            strSql.Append("subjectType=@subjectType,");
            strSql.Append("comicsType=@comicsType,");
            strSql.Append("stage=@stage,");
            strSql.Append("level=@level,");
            strSql.Append("remark=@remark,");
            strSql.Append("resImg=@resImg,");
            strSql.Append("resText=@resText,");
            strSql.Append("resAudio=@resAudio,");
            strSql.Append("creatdate=@creatdate,");
            strSql.Append("tip=@tip,");
            strSql.Append("selectors=@selectors,");
            strSql.Append("answer=@answer,");
            strSql.Append("sorter=@sorter,");
            strSql.Append("resolved=@resolved");
            strSql.Append(" where id=@id");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@title", DbType.String,20,"title"),
					new SQLiteParameter("@subjectType", DbType.Int32,8,"subjectType"),
					new SQLiteParameter("@comicsType", DbType.Int32,8,"comicsType"),
					new SQLiteParameter("@stage", DbType.Int32,8,"stage"),
					new SQLiteParameter("@level", DbType.Int32,8,"level"),
					new SQLiteParameter("@remark", DbType.String,100,"remark"),
					new SQLiteParameter("@resImg", DbType.String,100,"resImg"),
					new SQLiteParameter("@resText", DbType.String,300,"resText"),
					new SQLiteParameter("@resAudio", DbType.String,100,"resAudio"),
					new SQLiteParameter("@creatdate", DbType.Date,"creatdate"),
					new SQLiteParameter("@tip", DbType.String,100,"tip"),
					new SQLiteParameter("@selectors", DbType.String,100,"selectors"),
					new SQLiteParameter("@answer", DbType.String,20,"answer"),
					new SQLiteParameter("@sorter", DbType.Int32,8,"sorter"),
					new SQLiteParameter("@resolved", DbType.Boolean,"resolved"),
					new SQLiteParameter("@id", DbType.Int32,8,"id")};
            return createCmd(strSql, parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
        public override SQLiteCommand createDeleteCmd()
		{

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from subject ");
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

