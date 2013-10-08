package com.coodroid.cgmapbuilder.data;

import java.io.File;
import java.io.IOException;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.Statement;

/**
 * 处理数据库文件一些方法
 * @author JiangYinZhi
 *
 */
public class DBHelper {
	
	private Statement state;

	public DBHelper() {
		
	}
	
	//SQLiteDB连接
	private void SQLiteDBConn(String url){
			try {
				Class.forName("org.sqlite.jdbc");
				Connection connection = DriverManager.getConnection("jdbc:sqlite:"+url);
				Statement stat = connection.createStatement();
			} catch (ClassNotFoundException e) {
				e.printStackTrace();
				System.out.println("驱动文件未找到");
			} catch (SQLException e) {
				e.printStackTrace();
				System.out.println("数据库连接出错");
			}
	}
	
	
	//加载SQL文件
	private void readSQLFile(String SQLFileUrl) throws IOException{
		File SQLFile = new File(SQLFileUrl);
		if(SQLFileUrl==null||SQLFileUrl.equals("")){
			throw new NullPointerException("无效的文件路径");
		}
		long len = SQLFile.length();
		byte[] bytes = new byte[(int)len];
	}
}
