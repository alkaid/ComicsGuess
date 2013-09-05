package com.coodroid.comicsguess.data;

import java.util.ArrayList;

import com.coodroid.comicsguess.data.DBSql.DBHelper;
import com.coodroid.comicsguess.model.StageModel;
import com.coodroid.comicsguess.model.StageTypeModel;
import com.coodroid.comicsguess.model.SubjectModel;

import android.content.Context;
import android.database.Cursor;

/**
 * 关卡DAO,
 * @author JiangYinzhi
 *
 */
public class StageDAO {

	private static StageDAO lDao = null;
	private static DBSql db = null;
	
	public static StageDAO getInstance(Context context){
		if(lDao == null){
			lDao = new StageDAO();
		}
		if(db == null){
			db = new DBSql(context);
		}
		
		return lDao;
	}
	
	//根据关卡类型查询所有关卡，目的1.查询所有主线关卡，2.查询所有主题关卡
	public ArrayList<StageModel> queryAllStages(StageTypeModel stageType){
		String[] fieldsNames = {DBSql.Table.stage.aid,DBSql.Table.stage.aname,
				DBSql.Table.stage.acatalog,DBSql.Table.stage.astageType,
				DBSql.Table.stage.aunlocked,DBSql.Table.stage.astageType};
		String[] selectArgs = {stageType.getId()+""};
		Cursor mCursor = db.select(DBSql.Table.stage.tName, fieldsNames, 
				DBSql.Table.stage.fstageType+"=?", selectArgs, null,null, DBSql.Table.stage.fid);
		ArrayList<StageModel> stages =new ArrayList<StageModel>();
//		if(mCursor.moveToFirst()){
//			do{
//				StageModel stage = new StageModel();
//				l.setMatchId(c.getInt(1));
//				l.setServetTime(c.getString(2));
//				l.setScore(c.getString(3));
//				l.setTextTime(c.getString(4));
//				l.setText(c.getString(5));
//				textLives.add(l);
//			}while(c.moveToNext());
//		}
		return null;
	}
	
	//根据关卡查询所有题目
	public SubjectModel queryAllSubjects(StageModel stage){
		return null;
	}
	
}
