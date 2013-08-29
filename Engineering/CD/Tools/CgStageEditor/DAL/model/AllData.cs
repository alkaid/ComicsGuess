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

        private SQLiteConnection connection;
        public string DbPath
        {
            get { return DbHelperSQLite.DbPath; }
        }

        public AllData(string dbPath,int tableFlag)
        {
            DbHelperSQLite.DbPath = dbPath;
            connection = new SQLiteConnection(DbHelperSQLite.ConnectionString);
            initAdapter();
            createDataSet();
        }

        public AllData(string dbPath, DataSet dataSet) 
        {
            DbHelperSQLite.DbPath = dbPath;
            connection = new SQLiteConnection(DbHelperSQLite.ConnectionString);
            initAdapter();

            tableFlag=0;
            this.dataSet = dataSet;
            if(dataSet.Tables.Contains("comicsType"))
            {
                tableFlag |= FLAG_TABLE_comicsType;
                comicsTypeAdapter.Fill(dataSet, "comicsType");
            }
            if (dataSet.Tables.Contains("stageType"))
            {
                tableFlag |= FLAG_TABLE_stageType;
                stageTypeAdapter.Fill(dataSet, "stageType");
            }
            if (dataSet.Tables.Contains("subjectType"))
            {
                tableFlag |= FLAG_TABLE_subjectType;
                subjectTypeAdapter.Fill(dataSet, "subjectType");
            }
            if (dataSet.Tables.Contains("catalog"))
            {
                tableFlag |= FLAG_TABLE_catalog;
                catalogAdapter.Fill(dataSet, "catalog");
            }
            if (dataSet.Tables.Contains("stage"))
            {
                tableFlag |= FLAG_TABLE_stage;
                stageAdapter.Fill(dataSet, "stage");
            }
            if (dataSet.Tables.Contains("subject"))
            {
                tableFlag |= FLAG_TABLE_subject;
                subjectAdapter.Fill(dataSet, "subject");
            }
        }

        private void initAdapter()
        {
            catalogAdapter = new CatalogBuilder(connection).createAdapter();
            comicsTypeAdapter = new ComicsTypeBuilder(connection).createAdapter();
            stageAdapter = new StageBuilder(connection).createAdapter();
            stageTypeAdapter = new StageTypeBuilder(connection).createAdapter();
            subjectAdapter = new SubjectBuilder(connection).createAdapter();
            subjectTypeAdapter = new SubjectTypeBuilder(connection).createAdapter();
        }

        public void update()
        {
            if ((tableFlag & FLAG_TABLE_comicsType) == FLAG_TABLE_comicsType)
            {
                comicsTypeAdapter.Update(dataSet, "comicsType");
            }
            if ((tableFlag & FLAG_TABLE_stageType) == FLAG_TABLE_stageType)
            {
                stageTypeAdapter.Update(dataSet, "stageType");
            }
            if ((tableFlag & FLAG_TABLE_subjectType) == FLAG_TABLE_subjectType)
            {
                subjectTypeAdapter.Update(dataSet, "subjectType");
            }
            if ((tableFlag & FLAG_TABLE_catalog) == FLAG_TABLE_catalog)
            {
                catalogAdapter.Update(dataSet, "catalog");
            }
            if ((tableFlag & FLAG_TABLE_stage) == FLAG_TABLE_stage)
            {
                stageAdapter.Update(dataSet, "stage");
            }
            if ((tableFlag & FLAG_TABLE_subject) == FLAG_TABLE_subject)
            {
                subjectAdapter.Update(dataSet, "subject");
            }
        }


        private void createDataSet()
        {
            //dispose();
            //catalogAdapter = new SQLiteDataAdapter("select * from catalog", connection);
            //comicsTypeAdapter = new SQLiteDataAdapter("select * from comicsType", connection);
            //stageAdapter = new SQLiteDataAdapter("select * from stage", connection);
            //stageTypeAdapter = new SQLiteDataAdapter("select * from stageType", connection);
            //subjectAdapter = new SQLiteDataAdapter("select * from subject", connection);
            //subjectTypeAdapter = new SQLiteDataAdapter("select * from subjectType", connection);

            dataSet = new DataSet("comicsGuess");

            if ((tableFlag & FLAG_TABLE_comicsType) == FLAG_TABLE_comicsType)
            {
                //comicsTypeAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                comicsTypeAdapter.Fill(dataSet, "comicsType");
            }
            if ((tableFlag & FLAG_TABLE_stageType) == FLAG_TABLE_stageType)
            {
                //stageTypeAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                stageTypeAdapter.Fill(dataSet, "stageType");
            }
            if ((tableFlag & FLAG_TABLE_subjectType) == FLAG_TABLE_subjectType)
            {
                //subjectTypeAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                subjectTypeAdapter.Fill(dataSet, "subjectType");
            }
            if ((tableFlag & FLAG_TABLE_catalog) == FLAG_TABLE_catalog)
            {
                //catalogAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                catalogAdapter.Fill(dataSet, "catalog");
            }
            if ((tableFlag & FLAG_TABLE_stage) == FLAG_TABLE_stage)
            {
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
                dataSet.Clear();
                dataSet.Dispose();
        }
    }
}
