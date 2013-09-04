package com.coodroid.comicsguess.model;

/**
 * 关卡实体类
 * @author JiangYinzhi
 *
 */
public class StageModel extends BaseModel{
	
	private  int id;//关卡id
	private  String name;//关卡名称
	private  catalogModel catalog;//关卡目录
	private  StageTypeModel stageType;//关卡类型,"主线关卡"、"主题关卡"、"节日关卡"
	private  boolean unlocked;//是否解锁
	private  SubjectTypeModel subjectType;//接近的题目
	
	public StageModel(int id) {
		this.id = id;
	}
	
	public int getId() {
		return id;
	}
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}

	public boolean isUnlocked() {
		return unlocked;
	}
	public void setUnlocked(boolean unlocked) {
		this.unlocked = unlocked;
	}
	public catalogModel getCatalog() {
		return catalog;
	}
	public void setCatalog(catalogModel catalog) {
		this.catalog = catalog;
	}
	public StageTypeModel getStageType() {
		return stageType;
	}
	public void setStageType(StageTypeModel stageType) {
		this.stageType = stageType;
	}
	public SubjectTypeModel getSubjectType() {
		return subjectType;
	}
	public void setSubjectType(SubjectTypeModel subjectType) {
		this.subjectType = subjectType;
	}

	
	
}
