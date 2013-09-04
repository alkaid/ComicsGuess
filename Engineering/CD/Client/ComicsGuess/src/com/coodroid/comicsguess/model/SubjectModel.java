package com.coodroid.comicsguess.model;

/**
 * 题目的实体类
 * @author Jiangyinzhi
 *
 */
public class SubjectModel extends BaseModel{

	private  int id;	//题目id
	private  String title;//题目标题
	private  SubjectTypeModel subjectType;//题目所属类型 ,"动漫人物"、"宠物"、"场景
	private  comicsTypeModel comicsType;//题目所属动漫类型,腹黑、傲娇
	private  StageModel stage;//题目所属关卡
	private  int level;//题目难度
	private  String remark;//题目描述
	private  String resImg;//题目图片资源地址
	private  String resText;//题目文字资源
	private  String resAudio;//题目声效资源
	private  String creatdate;//题目创建时间
	private  String tip="tip";//题目提示
	private  String selectors;//题目答案文字集合
	private  String answer;//题目答案
	private  int sorter;//题目排序
	private  boolean resolved;//题目是否解决了
	
	public int getId() {
		return id;
	}
	public void setId(int id) {
		this.id = id;
	}
	public String getTitle() {
		return title;
	}
	public void setTitle(String title) {
		this.title = title;
	}
	public SubjectTypeModel getSubjectType() {
		return subjectType;
	}
	public void setSubjectType(SubjectTypeModel subjectType) {
		this.subjectType = subjectType;
	}
	public comicsTypeModel getComicsType() {
		return comicsType;
	}
	public void setComicsType(comicsTypeModel comicsType) {
		this.comicsType = comicsType;
	}
	public StageModel getStage() {
		return stage;
	}
	public void setStage(StageModel stage) {
		this.stage = stage;
	}
	public int getLevel() {
		return level;
	}
	public void setLevel(int level) {
		this.level = level;
	}
	public String getRemark() {
		return remark;
	}
	public void setRemark(String remark) {
		this.remark = remark;
	}
	public String getResImg() {
		return resImg;
	}
	public void setResImg(String resImg) {
		this.resImg = resImg;
	}
	public String getResText() {
		return resText;
	}
	public void setResText(String resText) {
		this.resText = resText;
	}
	public String getResAudio() {
		return resAudio;
	}
	public void setResAudio(String resAudio) {
		this.resAudio = resAudio;
	}
	public String getCreatdate() {
		return creatdate;
	}
	public void setCreatdate(String creatdate) {
		this.creatdate = creatdate;
	}
	public String getTip() {
		return tip;
	}
	public void setTip(String tip) {
		this.tip = tip;
	}
	public String getSelectors() {
		return selectors;
	}
	public void setSelectors(String selectors) {
		this.selectors = selectors;
	}
	public String getAnswer() {
		return answer;
	}
	public void setAnswer(String answer) {
		this.answer = answer;
	}
	public int getSorter() {
		return sorter;
	}
	public void setSorter(int sorter) {
		this.sorter = sorter;
	}
	public boolean isResolved() {
		return resolved;
	}
	public void setResolved(boolean resolved) {
		this.resolved = resolved;
	}
	
	
	
}
