package com.coodroid.comicsguess.model;

/**
 * 目录实体类
 * @author JiangYinZhi
 *
 */
public class catalogModel extends BaseModel{
	
	private int id;//目录id
	private String name;//目录名称
	
	public int getId() {
		return id;
	}
	public void setId(int id) {
		this.id = id;
	}
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	
	
}
