package com.coodroid.comicsguess.data;

import java.io.IOException;
import java.io.InputStream;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import com.alkaid.base.common.LogUtil;
import com.alkaid.base.data.BaseSQL;

public class DBSql extends BaseSQL {
	public final static String DBNAME="comics.db";
	public final static int VERSION=1;
	
	/** 表明、字段名、别名的集合,用于构建sql语句*/
	public static class Table{
	
		public static class subject{
			/**表名*/
			public static String tName="subject";
			public static String tAlias="sb";
			//各字段名 前缀f代表field
			public static String fid="id";
			public static String ftitle="title";
			public static String fsubjectType="subjectType";
			public static String fcomicsType="comicsType";
			public static String fstage="stage";
			public static String flevel="level";
			public static String fremark="remark";
			public static String fresImg="resImg";
			public static String fresText="resText";
			public static String fresAudio="resAudio";
			public static String fcreatdate="creatdate";
			public static String ftip="tip";
			public static String fselectors="selectors";
			public static String fanswer="answer";
			public static String fsorter="sorter";
			public static String fresolved="resolved";
			//各字段别名  前缀a代表alias
			public static String aid=tAlias+fid;
			public static String atitle=tAlias+ftitle;
			public static String asubjectType=tAlias+fsubjectType;
			public static String acomicsType=tAlias+fcomicsType;
			public static String astage=tAlias+fstage;
			public static String alevel=tAlias+flevel;
			public static String aremark=tAlias+fremark;
			public static String aresImg=tAlias+fresImg;
			public static String aresText=tAlias+fresText;
			public static String aresAudio=tAlias+fresAudio;
			public static String acreatdate=tAlias+fcreatdate;
			public static String atip=tAlias+ftip;
			public static String aselectors=tAlias+fselectors;
			public static String aanswer=tAlias+fanswer;
			public static String asorter=tAlias+fsorter;
			public static String aresolved=tAlias+fresolved;
		}
		public static class comicsType{
			/**表名*/
			public static String tName="comicsType";
			public static String tAlias="ct";
			//各字段名
			public static String fid="id";
			public static String fname="name";
			//各字段别名
			public static String aid=tAlias+fid;
			public static String aname=tAlias+fname;
		}
		public static class catalog{
			/**表名*/
			public static String tName="catalog";
			public static String tAlias="cl";
			//各字段名
			public static String fid="id";
			public static String fname="name";
			//各字段别名
			public static String aid=tAlias+fid;
			public static String aname=tAlias+fname;
		}
		public static class stage{
			/**表名*/
			public static String tName="stage";
			public static String tAlias="st";
			//各字段名
			public static String fid="id";
			public static String fname="name";
			public static String fcatalog="catalog";
			public static String fstageType="stageType";
			public static String funlocked="unlocked";
			public static String fnearSubject="nearSubject";
			//各字段别名
			public static String aid=tAlias+fid;
			public static String aname=tAlias+fname;
			public static String acatalog=tAlias+fcatalog;
			public static String astageType=tAlias+fstageType;
			public static String aunlocked=tAlias+funlocked;
			public static String anearSubject=tAlias+fnearSubject;
		}
		public static class subjectType{
			/**表名*/
			public static String tName="subjectType";
			public static String tAlias="sbt";
			//各字段名
			public static String fid="id";
			public static String fname="name";
			//各字段别名
			public static String aid=tAlias+fid;
			public static String aname=tAlias+fname;
		}
		public static class stageType{
			/**表名*/
			public static String tName="subject";
			public static String tAlias="sb";
			//各字段名
			public static String fid="id";
			public static String fname="name";
			//各字段别名
			public static String aid=tAlias+fid;
			public static String aname=tAlias+fname;
		}
	}
	
	
	public DBSql(Context context) {
		super(context);
	}
	
	@Override
	protected SQLiteOpenHelper createDBHelper() {
		return new DBHelper(context);
	}

	public class DBHelper extends SQLiteOpenHelper{
		private Context context;
		public DBHelper(Context context) {
			super(context, DBNAME, null, VERSION);
			this.context=context;
		}
		
		@Override
		public void onCreate(SQLiteDatabase db) {
			InputStream is;
			try {
				is = context.getAssets().open("sql/ComicsGuessTestDB.sql");
				execCreateTableSQLScript(is);
			} catch (IOException e) {
				LogUtil.e(e);
			}
		}

		@Override
		public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
			// TODO Auto-generated method stub
			LogUtil.i("Database onUpgrade");
		}
	}
	
}
