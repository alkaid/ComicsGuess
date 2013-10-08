package com.coodroid.cgmapbuilder.view;

import javax.swing.JFrame;



/**
 * 地图生成器的主界面
 * @author JiangYinZhi
 *
 */
public class CGMapBuilderFrame extends JFrame{
	
	
	public CGMapBuilderFrame() {
		setFramePro();
		//加入菜单栏
		CGMapBuilderMenuBar cgMenuBar = new CGMapBuilderMenuBar();
		cgMenuBar.setBounds(0, 0, 650, 20);
		this.add(cgMenuBar);
		//加入地图显示区域
		CGMapBuilderLeftPanel cgLeftPannel = new CGMapBuilderLeftPanel();
		cgLeftPannel.setBounds(10, 35, 240, 400);
		this.add(cgLeftPannel);
		//加入中间数据列表区域
		CGMapBuilderCenterPanel cgCenterPannel = new CGMapBuilderCenterPanel();
		cgCenterPannel.setBounds(260, 35, 240, 400);
		this.add(cgCenterPannel);
		//加入右边操作区域
		CGMapBuilderRightPanel cgRightPannel = new CGMapBuilderRightPanel();
		cgRightPannel.setBounds(510, 35, 120, 400);
		this.add(cgRightPannel);
	}
	
	/**
	 * 设置窗体属性
	 */
	private void setFramePro(){
		this.setTitle("天天猜动漫地图生成器");
		this.setBounds(400, 100, 650, 500);
		this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		this.setVisible(true);
		this.setResizable(false);//设置固定大小
		this.setLayout(null);//设置为border布局
	}
	
}
