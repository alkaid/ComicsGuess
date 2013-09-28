package com.coodroid.comicsguess;

import android.app.Activity;
import android.os.Bundle;
import android.support.v4.app.FragmentActivity;
import android.view.KeyEvent;

import com.coodroid.comicsguess.view.FragmentSwitchHelper;
import com.coodroid.comicsguess.view.base.BaseFragmentActivity;


/**
 * 主activity，用于切换各个模块的。包含欢迎界面，主界面，关卡选择界面，和游戏界面
 * @author Administrator
 *
 */
public class MainActivity extends BaseFragmentActivity{
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		FragmentSwitchHelper.getInstance().init(this);
		initView();
		
	}
	
	//初始化界面
	private void initView(){
		this.setContentView(R.layout.main_activity_layout);
		FragmentSwitchHelper.getInstance().skipFragment(FragmentSwitchHelper.WELCOME_FRAGMENT);
		
	}
	
	@Override
	public boolean onKeyDown(int keyCode, KeyEvent event) {
		String tag = FragmentSwitchHelper.getInstance().getFragmentTag();
		//对返回键进行处理
		switch (keyCode) {
		case KeyEvent.KEYCODE_BACK:
			if(tag.equals(FragmentSwitchHelper.MAIN_MENU_FRAGMENT)){
				//退出游戏
				
			}else if(tag.equals(FragmentSwitchHelper.LEVEL_SELECT_FRAGMENT)||
					tag.equals(FragmentSwitchHelper.GAME_FRAGMENT)){
				//其他物理返回键回到主菜单
				FragmentSwitchHelper.getInstance().skipFragment(FragmentSwitchHelper.MAIN_MENU_FRAGMENT);
			}
			break;

		default:
			break;
		}
		return true;
	}

}
