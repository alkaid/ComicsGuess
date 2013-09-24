package com.coodroid.comicsguess;

import android.app.Activity;
import android.os.Bundle;
import android.support.v4.app.FragmentActivity;

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

}
