using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
using Maticsoft.DBUtility;
using System.Data.SqlClient;//Please add references

namespace coodroid.DAL.model
{
    public class AllData
    {
        public SQLiteDataAdapter catalogAdapter;
        public SQLiteDataAdapter comicsTypeAdapter;
        public SQLiteDataAdapter stageAdapter;
        public SQLiteDataAdapter stageTypeAdapter;
        public SQLiteDataAdapter subjectAdapter;
        public SQLiteDataAdapter subjectTypeAdapter;

        public DataSet dataSet;

        public static int FLAG_TABLE_catalog = 0x1;
        public static int FLAG_TABLE_comicsType = 0x2;
        public static int FLAG_TABLE_stage = 0x4;
        public static int FLAG_TABLE_stageType = 0x8;
        public static int FLAG_TABLE_subject = 0x10;
        public static int FLAG_TABLE_subjectType = 0x20;

        private int tableFlag;

        public AllData(int tableFlag)
        {
            this.tableFlag = tableFlag;
            init(tableFlag);
        }

        
        public AllData()
        {
            this.tableFlag = FLAG_TABLE_catalog | FLAG_TABLE_comicsType | FLAG_TABLE_stage | FLAG_TABLE_stageType | FLAG_TABLE_subject | FLAG_TABLE_subjectType;
            init(tableFlag);
        }

        public AllData(DataSet dataSet) 
        {
            tableFlag=0;
            this.dataSet = dataSet;
            if(dataSet.Tables.Contains("comicsType"))
            {
                tableFlag |= FLAG_TABLE_comicsType;
            }
            if (dataSet.Tables.Contains("stageType"))
            {
                tableFlag |= FLAG_TABLE_stageType;
            }
            if (dataSet.Tables.Contains("subjectType"))
            {
                tableFlag |= FLAG_TABLE_subjectType;
            }
            if (dataSet.Tables.Contains("catalog"))
            {
                tableFlag |= FLAG_TABLE_catalog;
            }
            if (dataSet.Tables.Contains("stage"))
            {
                tableFlag |= FLAG_TABLE_stage;
            }
            if (dataSet.Tables.Contains("subject"))
            {
                tableFlag |= FLAG_TABLE_subject;
            }
            fill(dataSet, tableFlag);
        }

        public void update()
        {
            SQLiteConnection connection = new SQLiteConnection(DbHelperSQLite.ConnectionString);
            if ((tableFlag & FLAG_TABLE_comicsType) == FLAG_TABLE_comicsType)
            {
                SQLiteCommandBuilder builder = new SQLiteCommandBuilder(comicsTypeAdapter);
                comicsTypeAdapter.Update(dataSet, "comicsType");
            }
            if ((tableFlag & FLAG_TABLE_stageType) == FLAG_TABLE_stageType)
            {
                SQLiteCommandBuilder builder = new SQLiteCommandBuilder(stageTypeAdapter);
                stageTypeAdapter.Update(dataSet, "stageType");
            }
            if ((tableFlag & FLAG_TABLE_subjectType) == FLAG_TABLE_subjectType)
            {
                SQLiteCommandBuilder builder = new SQLiteCommandBuilder(subjectTypeAdapter);
                subjectTypeAdapter.Update(dataSet, "subjectType");
            }
            if ((tableFlag & FLAG_TABLE_catalog) == FLAG_TABLE_catalog)
            {
                if (dataSet.Tables["catalog"].GetChanges() != null)
                {
                    SQLiteCommandBuilder builder = new SQLiteCommandBuilder(catalogAdapter);
                    catalogAdapter.Update(dataSet, "catalog");
                }
            }
            if ((tableFlag & FLAG_TABLE_stage) == FLAG_TABLE_stage)
            {
                if (dataSet.Tables["stage"].GetChanges() != null)
                {
                    SQLiteCommandBuilder builder = new SQLiteCommandBuilder(stageAdapter);

                    stageAdapter.UpdateCommand = getStageCmd(connection);
                    stageAdapter.Update(dataSet, "stage");
                }
            }
            if ((tableFlag & FLAG_TABLE_subject) == FLAG_TABLE_subject)
            {
                if (dataSet.Tables["subject"].GetChanges() != null)
                {
                    SQLiteCommandBuilder builder = new SQLiteCommandBuilder(subjectAdapter);
                    subjectAdapter.Update(dataSet, "subject");
                }
            }
        }

        private SQLiteCommand getStageCmd(SQLiteConnection connection)
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
					new SQLiteParameter("@name", DbType.String,10,"name"),
					new SQLiteParameter("@catalog", DbType.Int32,8,"catalog"),
					new SQLiteParameter("@stageType", DbType.Int32,8,"stageType"),
					new SQLiteParameter("@unlocked", DbType.Boolean,"unlocked"),
					new SQLiteParameter("@nearSubject", DbType.Int32,8,"nearSubject"),
					new SQLiteParameter("@id", DbType.Int32,8,"id")};
            SQLiteCommand cmd = new SQLiteCommand(strSql.ToString(),connection);
            foreach (SQLiteParameter parm in parameters)
                cmd.Parameters.Add(parm);
            return cmd;

        }

        public void fill(DataSet dataSet, int tableFlag)
        {
            SQLiteConnection connection = new SQLiteConnection(DbHelperSQLite.ConnectionString);
            if ((tableFlag & FLAG_TABLE_comicsType) == FLAG_TABLE_comicsType)
            {
                if(null==comicsTypeAdapter)
                    comicsTypeAdapter = new SQLiteDataAdapter("select * from comicsType", connection);
                comicsTypeAdapter.Fill(dataSet, "comicsType");
            }
            if ((tableFlag & FLAG_TABLE_stageType) == FLAG_TABLE_stageType)
            {
                if(null==stageTypeAdapter)
                    stageTypeAdapter = new SQLiteDataAdapter("select * from stageType", connection);
                stageTypeAdapter.Fill(dataSet, "stageType");
            }
            if ((tableFlag & FLAG_TABLE_subjectType) == FLAG_TABLE_subjectType)
            {
                if(null==subjectTypeAdapter)
                    subjectTypeAdapter = new SQLiteDataAdapter("select * from subjectType", connection);
                subjectTypeAdapter.Fill(dataSet, "subjectType");
            }
            if ((tableFlag & FLAG_TABLE_catalog) == FLAG_TABLE_catalog)
            {
                if(null==catalogAdapter)
                    catalogAdapter = new SQLiteDataAdapter("select * from catalog", connection);
                catalogAdapter.Fill(dataSet, "catalog");
            }
            if ((tableFlag & FLAG_TABLE_stage) == FLAG_TABLE_stage)
            {
                if(null==stageAdapter)
                    stageAdapter = new SQLiteDataAdapter("select * from stage", connection);
                stageAdapter.Fill(dataSet, "stage");
            }
            if ((tableFlag & FLAG_TABLE_subject) == FLAG_TABLE_subject)
            {
                if(null==subjectAdapter)
                    subjectAdapter = new SQLiteDataAdapter("select * from subject", connection);
                //subjectAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                subjectAdapter.Fill(dataSet, "subject");
            }
        }

        public void init(int tableFlag){
            dispose();
            SQLiteConnection connection = new SQLiteConnection(DbHelperSQLite.ConnectionString);
            //catalogAdapter = new SQLiteDataAdapter("select * from catalog", connection);
            //comicsTypeAdapter = new SQLiteDataAdapter("select * from comicsType", connection);
            //stageAdapter = new SQLiteDataAdapter("select * from stage", connection);
            //stageTypeAdapter = new SQLiteDataAdapter("select * from stageType", connection);
            //subjectAdapter = new SQLiteDataAdapter("select * from subject", connection);
            //subjectTypeAdapter = new SQLiteDataAdapter("select * from subjectType", connection);

            dataSet = new DataSet("comicsGuess");

            if ((tableFlag & FLAG_TABLE_comicsType) == FLAG_TABLE_comicsType)
            {
                comicsTypeAdapter = new SQLiteDataAdapter("select * from comicsType", connection);
                comicsTypeAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                comicsTypeAdapter.Fill(dataSet, "comicsType");
            }
            if ((tableFlag & FLAG_TABLE_stageType) == FLAG_TABLE_stageType)
            {
                stageTypeAdapter = new SQLiteDataAdapter("select * from stageType", connection);
                //stageTypeAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                stageTypeAdapter.Fill(dataSet, "stageType");
            }
            if ((tableFlag & FLAG_TABLE_subjectType) == FLAG_TABLE_subjectType)
            {
                subjectTypeAdapter = new SQLiteDataAdapter("select * from subjectType", connection);
                //subjectTypeAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                subjectTypeAdapter.Fill(dataSet, "subjectType");
            }
            if ((tableFlag & FLAG_TABLE_catalog) == FLAG_TABLE_catalog)
            {
                catalogAdapter = new SQLiteDataAdapter("select * from catalog", connection);
                //catalogAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                catalogAdapter.Fill(dataSet, "catalog");
            }
            if ((tableFlag & FLAG_TABLE_stage) == FLAG_TABLE_stage)
            {
                stageAdapter = new SQLiteDataAdapter("select * from stage", connection);
                //stageAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                stageAdapter.Fill(dataSet, "stage");
                if ((tableFlag & FLAG_TABLE_catalog) == FLAG_TABLE_catalog)
                {
                    DataRelation dr = new DataRelation("catalog_stage", dataSet.Tables["catalog"].Columns["id"], dataSet.Tables["stage"].Columns["catalog"]);
                    dataSet.Relations.Add(dr);
                }
                if ((tableFlag & FLAG_TABLE_stageType) == FLAG_TABLE_stageType)
                {
                    DataRelation dr = new DataRelation("stageType_stage", dataSet.Tables["stageType"].Columns["id"], dataSet.Tables["stage"].Columns["stageType"]);
                    dataSet.Relations.Add(dr);
                }
            }
            if ((tableFlag & FLAG_TABLE_subject) == FLAG_TABLE_subject)
            {
                subjectAdapter = new SQLiteDataAdapter("select * from subject", connection);
                //subjectAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                subjectAdapter.Fill(dataSet, "subject");
                //ShowSchema(subjectTable);
                if ((tableFlag & FLAG_TABLE_stage) == FLAG_TABLE_stage){
                    DataRelation dr = new DataRelation("stage_subject", dataSet.Tables["stage"].Columns["id"], dataSet.Tables["subject"].Columns["stage"]);
                    dataSet.Relations.Add(dr);
                    //DataRelation dr2 = new DataRelation("subject_stage", subjectTable.Columns["id"], stageTable.Columns["nearSubject"]);
                    //dataSet.Relations.Add(dr2);
                }
                if ((tableFlag & FLAG_TABLE_comicsType) == FLAG_TABLE_comicsType)
                {
                    DataRelation dr = new DataRelation("comicsType_subject", dataSet.Tables["comicsType"].Columns["id"], dataSet.Tables["subject"].Columns["comicsType"]);
                    dataSet.Relations.Add(dr);
                }
                if ((tableFlag & FLAG_TABLE_subjectType) == FLAG_TABLE_subjectType)
                {
                    DataRelation dr = new DataRelation("subjectType_subject", dataSet.Tables["subjectType"].Columns["id"], dataSet.Tables["subject"].Columns["subjectType"]);
                    dataSet.Relations.Add(dr);
                }
            }
        }

        /// <summary>
        /// 显示表结构
        /// </summary>
        /// <param name="data"></param>
        private void ShowSchema(DataTable data)
        {
            Console.WriteLine("Rows:" + data.Rows.Count);

            //主键
            Console.WriteLine("PrimaryKey:" + data.PrimaryKey.Length.ToString());
            foreach (DataColumn c in data.PrimaryKey)
                Console.WriteLine(c.ColumnName);

            //约束
            Console.WriteLine("Constraints:" + data.Constraints.Count.ToString());
            foreach (Constraint c in data.Constraints)
                Console.WriteLine(c.ConstraintName);

            //无法获取主外键主联定义
            Console.WriteLine("ParentRelations:" + data.ParentRelations.Count.ToString());
            Console.WriteLine("ChildRelations:" + data.ChildRelations.Count.ToString());

            Console.WriteLine("------------------------------------------------");
        }

        private void dispose()
        {
            
            if (null != dataSet)
                dataSet.Dispose();
        }
    }
}
