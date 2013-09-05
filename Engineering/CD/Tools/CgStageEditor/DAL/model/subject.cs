using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using Maticsoft.DBUtility;//Please add references
namespace coodroid.DAL.model
{
	/// <summary>
	/// 数据访问类:subject
	/// </summary>
	public partial class subject
	{
		public subject()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("id", "subject"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from subject");
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
		public int Add(coodroid.Model.model.subject model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into subject(");
			strSql.Append("title,subjectType,comicsType,stage,level,remark,resImg,resText,resAudio,creatdate,tip,selectors,answer,sorter,resolved)");
			strSql.Append(" values (");
			strSql.Append("@title,@subjectType,@comicsType,@stage,@level,@remark,@resImg,@resText,@resAudio,@creatdate,@tip,@selectors,@answer,@sorter,@resolved)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@title", DbType.String,20),
					new SQLiteParameter("@subjectType", DbType.Int32,8),
					new SQLiteParameter("@comicsType", DbType.Int32,8),
					new SQLiteParameter("@stage", DbType.Int32,8),
					new SQLiteParameter("@level", DbType.Int32,8),
					new SQLiteParameter("@remark", DbType.String,100),
					new SQLiteParameter("@resImg", DbType.String,100),
					new SQLiteParameter("@resText", DbType.String,300),
					new SQLiteParameter("@resAudio", DbType.String,100),
					new SQLiteParameter("@creatdate", DbType.Date),
					new SQLiteParameter("@tip", DbType.String,100),
					new SQLiteParameter("@selectors", DbType.String,100),
					new SQLiteParameter("@answer", DbType.String,20),
					new SQLiteParameter("@sorter", DbType.Int32,8),
					new SQLiteParameter("@resolved", DbType.Boolean)};
			parameters[0].Value = model.title;
			parameters[1].Value = model.subjectType;
			parameters[2].Value = model.comicsType;
			parameters[3].Value = model.stage;
			parameters[4].Value = model.level;
			parameters[5].Value = model.remark;
			parameters[6].Value = model.resImg;
			parameters[7].Value = model.resText;
			parameters[8].Value = model.resAudio;
			parameters[9].Value = model.creatdate;
			parameters[10].Value = model.tip;
			parameters[11].Value = model.selectors;
			parameters[12].Value = model.answer;
			parameters[13].Value = model.sorter;
			parameters[14].Value = model.resolved;

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
		public bool Update(coodroid.Model.model.subject model)
		{
			StringBuilder strSql=new StringBuilder();
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
					new SQLiteParameter("@title", DbType.String,20),
					new SQLiteParameter("@subjectType", DbType.Int32,8),
					new SQLiteParameter("@comicsType", DbType.Int32,8),
					new SQLiteParameter("@stage", DbType.Int32,8),
					new SQLiteParameter("@level", DbType.Int32,8),
					new SQLiteParameter("@remark", DbType.String,100),
					new SQLiteParameter("@resImg", DbType.String,100),
					new SQLiteParameter("@resText", DbType.String,300),
					new SQLiteParameter("@resAudio", DbType.String,100),
					new SQLiteParameter("@creatdate", DbType.Date),
					new SQLiteParameter("@tip", DbType.String,100),
					new SQLiteParameter("@selectors", DbType.String,100),
					new SQLiteParameter("@answer", DbType.String,20),
					new SQLiteParameter("@sorter", DbType.Int32,8),
					new SQLiteParameter("@resolved", DbType.Boolean),
					new SQLiteParameter("@id", DbType.Int32,8)};
			parameters[0].Value = model.title;
			parameters[1].Value = model.subjectType;
			parameters[2].Value = model.comicsType;
			parameters[3].Value = model.stage;
			parameters[4].Value = model.level;
			parameters[5].Value = model.remark;
			parameters[6].Value = model.resImg;
			parameters[7].Value = model.resText;
			parameters[8].Value = model.resAudio;
			parameters[9].Value = model.creatdate;
			parameters[10].Value = model.tip;
			parameters[11].Value = model.selectors;
			parameters[12].Value = model.answer;
			parameters[13].Value = model.sorter;
			parameters[14].Value = model.resolved;
			parameters[15].Value = model.id;

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
			strSql.Append("delete from subject ");
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
			strSql.Append("delete from subject ");
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
		public coodroid.Model.model.subject GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,title,subjectType,comicsType,stage,level,remark,resImg,resText,resAudio,creatdate,tip,selectors,answer,sorter,resolved from subject ");
			strSql.Append(" where id=@id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@id", DbType.Int32,4)
			};
			parameters[0].Value = id;

			coodroid.Model.model.subject model=new coodroid.Model.model.subject();
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
		public coodroid.Model.model.subject DataRowToModel(DataRow row)
		{
			coodroid.Model.model.subject model=new coodroid.Model.model.subject();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["title"]!=null)
				{
					model.title=row["title"].ToString();
				}
				if(row["subjectType"]!=null && row["subjectType"].ToString()!="")
				{
					model.subjectType=int.Parse(row["subjectType"].ToString());
				}
				if(row["comicsType"]!=null && row["comicsType"].ToString()!="")
				{
					model.comicsType=int.Parse(row["comicsType"].ToString());
				}
				if(row["stage"]!=null && row["stage"].ToString()!="")
				{
					model.stage=int.Parse(row["stage"].ToString());
				}
				if(row["level"]!=null && row["level"].ToString()!="")
				{
					model.level=int.Parse(row["level"].ToString());
				}
				if(row["remark"]!=null)
				{
					model.remark=row["remark"].ToString();
				}
				if(row["resImg"]!=null)
				{
					model.resImg=row["resImg"].ToString();
				}
				if(row["resText"]!=null)
				{
					model.resText=row["resText"].ToString();
				}
				if(row["resAudio"]!=null)
				{
					model.resAudio=row["resAudio"].ToString();
				}
				if(row["creatdate"]!=null && row["creatdate"].ToString()!="")
				{
					model.creatdate=DateTime.Parse(row["creatdate"].ToString());
				}
				if(row["tip"]!=null)
				{
					model.tip=row["tip"].ToString();
				}
				if(row["selectors"]!=null)
				{
					model.selectors=row["selectors"].ToString();
				}
				if(row["answer"]!=null)
				{
					model.answer=row["answer"].ToString();
				}
				if(row["sorter"]!=null && row["sorter"].ToString()!="")
				{
					model.sorter=int.Parse(row["sorter"].ToString());
				}
				if(row["resolved"]!=null && row["resolved"].ToString()!="")
				{
					if((row["resolved"].ToString()=="1")||(row["resolved"].ToString().ToLower()=="true"))
					{
						model.resolved=true;
					}
					else
					{
						model.resolved=false;
					}
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
			strSql.Append("select id,title,subjectType,comicsType,stage,level,remark,resImg,resText,resAudio,creatdate,tip,selectors,answer,sorter,resolved ");
			strSql.Append(" FROM subject ");
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
			strSql.Append("select count(1) FROM subject ");
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
			strSql.Append(")AS Row, T.*  from subject T ");
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
			parameters[0].Value = "subject";
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

