package com.coodroid.comicsguess.data;

import android.content.Context;

/**
 * 欢迎界面的DAO,主要功能，初始化DB，以及排列好数据库
 * @author JiangYinzhi
 *
 */
public class WelcomeDAO {

	private Context mContext;
	
	public WelcomeDAO(Context mContext) {
		this.mContext = mContext;
		initDB();
	}
	
	//初始化DB数据
	private void initDB(){
		DBSql dbSQL = new DBSql(mContext);
		dbSQL.init();
	}
	
	//随机排列题目的数据
	public void randomDBData(){
		
	}
}
