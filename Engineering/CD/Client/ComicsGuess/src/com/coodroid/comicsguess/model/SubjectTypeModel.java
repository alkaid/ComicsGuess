package com.coodroid.comicsguess.model;

/**
 * 题目类型实体类
 * @author JiangYinZhi
 *
 */
public class SubjectTypeModel extends BaseModel{

	public int id;//题目类型id
	public String name;//题目类型名称
	
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
