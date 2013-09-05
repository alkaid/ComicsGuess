using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using Maticsoft.DBUtility;//Please add references
namespace coodroid.DAL.model
{
	/// <summary>
	/// 数据访问类:stage
	/// </summary>
	public partial class stage
	{
		public stage()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("id", "stage"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from stage");
			strSql.Append(" where id=@id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@id", DbType.Int32,4)
			};
			parameters[0].Value = id;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(coodroid.Model.model.stage model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into stage(");
			strSql.Append("name,catalog,stageType,unlocked,nearSubject)");
			strSql.Append(" values (");
			strSql.Append("@name,@catalog,@stageType,@unlocked,@nearSubject)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@name", DbType.String,10),
					new SQLiteParameter("@catalog", DbType.Int32,8),
					new SQLiteParameter("@stageType", DbType.Int32,8),
					new SQLiteParameter("@unlocked", DbType.Boolean),
					new SQLiteParameter("@nearSubject", DbType.Int32,8)};
			parameters[0].Value = model.name;
			parameters[1].Value = model.catalog;
			parameters[2].Value = model.stageType;
			parameters[3].Value = model.unlocked;
			parameters[4].Value = model.nearSubject;

			object obj = DbHelperSQLite.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(coodroid.Model.model.stage model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update stage set ");
			strSql.Append("name=@name,");
			strSql.Append("catalog=@catalog,");
			strSql.Append("stageType=@stageType,");
			strSql.Append("unlocked=@unlocked,");
			strSql.Append("nearSubject=@nearSubject");
			strSql.Append(" where id=@id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@name", DbType.String,10),
					new SQLiteParameter("@catalog", DbType.Int32,8),
					new SQLiteParameter("@stageType", DbType.Int32,8),
					new SQLiteParameter("@unlocked", DbType.Boolean),
					new SQLiteParameter("@nearSubject", DbType.Int32,8),
					new SQLiteParameter("@id", DbType.Int32,8)};
			parameters[0].Value = model.name;
			parameters[1].Value = model.catalog;
			parameters[2].Value = model.stageType;
			parameters[3].Value = model.unlocked;
			parameters[4].Value = model.nearSubject;
			parameters[5].Value = model.id;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from stage ");
			strSql.Append(" where id=@id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@id", DbType.Int32,4)
			};
			parameters[0].Value = id;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from stage ");
			strSql.Append(" where id in ("+idlist + ")  ");
			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public coodroid.Model.model.stage GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,name,catalog,stageType,unlocked,nearSubject from stage ");
			strSql.Append(" where id=@id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@id", DbType.Int32,4)
			};
			parameters[0].Value = id;

			coodroid.Model.model.stage model=new coodroid.Model.model.stage();
			DataSet ds=DbHelperSQLite.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public coodroid.Model.model.stage DataRowToModel(DataRow row)
		{
			coodroid.Model.model.stage model=new coodroid.Model.model.stage();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["name"]!=null)
				{
					model.name=row["name"].ToString();
				}
				if(row["catalog"]!=null && row["catalog"].ToString()!="")
				{
					model.catalog=int.Parse(row["catalog"].ToString());
				}
				if(row["stageType"]!=null && row["stageType"].ToString()!="")
				{
					model.stageType=int.Parse(row["stageType"].ToString());
				}
				if(row["unlocked"]!=null && row["unlocked"].ToString()!="")
				{
					if((row["unlocked"].ToString()=="1")||(row["unlocked"].ToString().ToLower()=="true"))
					{
						model.unlocked=true;
					}
					else
					{
						model.unlocked=false;
					}
				}
				if(row["nearSubject"]!=null && row["nearSubject"].ToString()!="")
				{
					model.nearSubject=int.Parse(row["nearSubject"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,name,catalog,stageType,unlocked,nearSubject ");
			strSql.Append(" FROM stage ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQLite.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM stage ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from stage T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQLite.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@tblName", DbType.VarChar, 255),
					new SQLiteParameter("@fldName", DbType.VarChar, 255),
					new SQLiteParameter("@PageSize", DbType.Int32),
					new SQLiteParameter("@PageIndex", DbType.Int32),
					new SQLiteParameter("@IsReCount", DbType.bit),
					new SQLiteParameter("@OrderType", DbType.bit),
					new SQLiteParameter("@strWhere", DbType.VarChar,1000),
					};
			parameters[0].Value = "stage";
			parameters[1].Value = "id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQLite.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

