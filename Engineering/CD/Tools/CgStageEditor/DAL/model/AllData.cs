using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
using Maticsoft.DBUtility;//Please add references

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

        public DataTable catalogTable;
        public DataTable comicsTypeTable;
        public DataTable stageTable;
        public DataTable stageTypeTable;
        public DataTable subjectTable;
        public DataTable subjectTypeTable;

        public static int FLAG_TABLE_catalog = 0x1;
        public static int FLAG_TABLE_comicsType = 0x2;
        public static int FLAG_TABLE_stage = 0x4;
        public static int FLAG_TABLE_stageType = 0x8;
        public static int FLAG_TABLE_subject = 0x10;
        public static int FLAG_TABLE_subjectType = 0x20;

        public AllData(int tableFlag)
        {
            init(tableFlag);
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
                comicsTypeTable = dataSet.Tables["comicsType"];
            }
            if ((tableFlag & FLAG_TABLE_stageType) == FLAG_TABLE_stageType)
            {
                stageTypeAdapter = new SQLiteDataAdapter("select * from stageType", connection);
                //stageTypeAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                stageTypeAdapter.Fill(dataSet, "stageType");
                stageTypeTable = dataSet.Tables["stageType"];
            }
            if ((tableFlag & FLAG_TABLE_subjectType) == FLAG_TABLE_subjectType)
            {
                subjectTypeAdapter = new SQLiteDataAdapter("select * from subjectType", connection);
                //subjectTypeAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                subjectTypeAdapter.Fill(dataSet, "subjectType");
                subjectTypeTable = dataSet.Tables["subjectType"];
            }
            if ((tableFlag & FLAG_TABLE_catalog) == FLAG_TABLE_catalog)
            {
                catalogAdapter = new SQLiteDataAdapter("select * from catalog", connection);
                //catalogAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                catalogAdapter.Fill(dataSet, "catalog");
                catalogTable = dataSet.Tables["catalog"];
            }
            if ((tableFlag & FLAG_TABLE_stage) == FLAG_TABLE_stage)
            {
                stageAdapter = new SQLiteDataAdapter("select * from stage", connection);
                //stageAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                stageAdapter.Fill(dataSet, "stage");
                stageTable = dataSet.Tables["stage"];
                if ((tableFlag & FLAG_TABLE_catalog) == FLAG_TABLE_catalog)
                {
                    DataRelation dr1 = new DataRelation("catalog_stage", catalogTable.Columns["id"], stageTable.Columns["catalog"]);
                    dataSet.Relations.Add(dr1);
                }
            }
            if ((tableFlag & FLAG_TABLE_subject) == FLAG_TABLE_subject)
            {
                subjectAdapter = new SQLiteDataAdapter("select * from subject", connection);
                //subjectAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                subjectAdapter.Fill(dataSet, "subject");
                subjectTable = dataSet.Tables["subject"];
                //ShowSchema(subjectTable);
                if ((tableFlag & FLAG_TABLE_stage) == FLAG_TABLE_stage){
                    DataRelation dr2 = new DataRelation("stage_subject", stageTable.Columns["id"], subjectTable.Columns["stage"]);
                    dataSet.Relations.Add(dr2);
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
            if (null != catalogTable)
                catalogTable.Dispose();
            if (null != comicsTypeTable)
                comicsTypeTable.Dispose();
            if (null != stageTable)
                stageTable.Dispose();
            if (null != stageTypeTable)
                stageTypeTable.Dispose();
            if (null != subjectTable)
                subjectTable.Dispose();
            if (null != subjectTypeTable)
                subjectTypeTable.Dispose();

            if (null != dataSet)
                dataSet.Dispose();
        }
    }
}
