package com.coodroid.cgmapbuilder.view;

import java.awt.Color;
import java.awt.Dimension;
import java.awt.Font;

import javax.swing.BorderFactory;
import javax.swing.JButton;
import javax.swing.JPanel;

public class CGMapBuilderRightPannel extends JPanel{

	private JPanel stageInfoPanel;//关卡信息区域，显示
	private JButton autoCreateMapBtn;//自动创建地图按钮
	private JButton saveMapBtn;//保存当前地图按钮
	private JButton resetMapBtn;//还原之前的地图
	
	public CGMapBuilderRightPannel() {
		this.setBorder(BorderFactory.createLineBorder(Color.BLACK));
		createStageInfoArea();
		autoCreateMapBtn = createBtn("生成地图");
		saveMapBtn = createBtn("保存地图");
		resetMapBtn = createBtn("还原地图");
		autoCreateMapBtn.setBounds(25, 220, 70, 30);
		saveMapBtn.setBounds(25, 270, 70, 30);
		resetMapBtn.setBounds(25, 320, 70, 30);
		this.add(autoCreateMapBtn);
		this.add(saveMapBtn);
		this.add(resetMapBtn);
		
	}
	
	//创建关卡信息区域，显示
	private void createStageInfoArea(){
		stageInfoPanel = new JPanel();
//		stageInfoPanel.setPreferredSize(new Dimension(100, 200));
		stageInfoPanel.setBounds(5, 5, 110, 200);
		stageInfoPanel.setBackground(Color.RED);
		this.setLayout(null);
		this.add(stageInfoPanel);
	}
	
	//创建按钮
	private JButton createBtn(String name){
		JButton jBtn = new JButton(name);
		jBtn.setFont(new Font("1号字体", 0, 9));
		jBtn.setText(name);
		return jBtn;
	}
	
}
