package com.coodroid.cgmapbuilder.view;

import java.awt.BorderLayout;
import java.awt.Color;

import javax.swing.JFrame;
import javax.swing.JMenu;
import javax.swing.JMenuBar;
import javax.swing.JMenuItem;
import javax.swing.JPanel;

/**
 * 地图生成器的主界面
 * @author JiangYinZhi
 *
 */
public class CGMapBuilderFrame {
	
	private JFrame jFrame;//窗体对象
	
	public CGMapBuilderFrame() {
		createFrame();
		createMenu();
		createMapPannel();
	}
	
	/**
	 * 创建窗体，并对窗体属性进行设置
	 */
	private void createFrame(){
		if(jFrame!=null){
			return;
		}
		jFrame = new JFrame("天天猜动漫地图生成器");
		jFrame.setBounds(350, 0, 800, 1100);
		jFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		jFrame.setVisible(true);
		jFrame.setResizable(false);//设置固定大小
		jFrame.setLayout(null);//设置为border布局
	}
	
	/**
	 * 菜单栏并加入到窗体内
	 */
	private void createMenu(){
		JMenuItem openFileMenuItem = new JMenuItem("打开");//打开文件选项，里面打开的文件包含数据库文件和图片文件，用于进行编辑
		JMenu fileMenu = new JMenu("文件");//文件选项
		fileMenu.add(openFileMenuItem);
		JMenuBar jMenuBar = new JMenuBar();//菜单
		jMenuBar.add(fileMenu);
		jMenuBar.setBounds(0, 0, 800, 20);
		if(jFrame!=null){
			jFrame.add(jMenuBar);
		}
	}
	
	/**
	 * 创建地图显示区域
	 */
	private void createMapPannel(){
		JPanel mapPannel = new JPanel();//地图显示块
//		mapPannel.setSize(480, 800);
		mapPannel.setBounds(5, 25, 480, 800);
		mapPannel.setBackground(Color.WHITE);
		if(jFrame!=null){
			jFrame.add(mapPannel);
		}
	}
}
