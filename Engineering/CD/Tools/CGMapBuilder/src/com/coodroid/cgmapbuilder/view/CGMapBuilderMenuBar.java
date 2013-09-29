package com.coodroid.cgmapbuilder.view;

import javax.swing.JMenu;
import javax.swing.JMenuBar;
import javax.swing.JMenuItem;

/**
 * 地图编辑器的菜单栏
 * @author Administrator
 *
 */
public class CGMapBuilderMenuBar extends JMenuBar{
	
	private JMenuItem openFileMenuItem;//打开文件选项，里面打开的文件包含数据库文件和图片文件，用于进行编辑

	public CGMapBuilderMenuBar() {
		openFileMenuItem = new JMenuItem("打开");
		JMenu fileMenu = new JMenu("文件");//文件选项
		fileMenu.add(openFileMenuItem);
		this.add(fileMenu);
	}
}
