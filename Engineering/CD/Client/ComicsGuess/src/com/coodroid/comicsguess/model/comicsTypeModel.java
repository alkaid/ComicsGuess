package com.coodroid.comicsguess.model;

/**
 * 动漫类型实体类
 * @author JiangYinzhi
 *
 */
public class comicsTypeModel extends BaseModel{

	private int id;//动漫类型id
	private String name;//动漫类型名称
	
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
