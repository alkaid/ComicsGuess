package com.coodroid.comicsguess.view;

import android.app.Activity;
import android.support.v4.app.FragmentActivity;
import android.support.v4.app.FragmentManager;
import android.support.v4.app.FragmentTransaction;

import com.alkaid.base.common.LogUtil;
import com.coodroid.comicsguess.R;
import com.coodroid.comicsguess.view.fragments.GameFragment;
import com.coodroid.comicsguess.view.fragments.LevelSelectFragment;
import com.coodroid.comicsguess.view.fragments.MainMenuFragment;
import com.coodroid.comicsguess.view.fragments.WelcomeFragment;


/**
 * 
 * @author JiangYinZhi
 *
 */
public class FragmentSwitchHelper {
	
	private final String TAG = FragmentSwitchHelper.class.getName();
	private static FragmentSwitchHelper mInstance = null;
	private FragmentActivity mAct = null;
	private FragmentManager fm = null;
	
	/**欢迎界面fragment*/
	public final static String WELCOME_FRAGMENT = "WELCOME";
	/**主菜单fragment*/
	public final static String MAIN_MENU_FRAGMENT = "MAIN_MENU";
	/**关卡选择界面*/
	public final static String LEVEL_SELECT_FRAGMENT = "LEVEL_SELECT";
	/**游戏界面fragment*/
	public final static String GAME_FRAGMENT = "GAME";
	
	
	
	//将构造函数私有
	private FragmentSwitchHelper() {
		super();
	}

	public static FragmentSwitchHelper getInstance(){
		if(mInstance == null){
			mInstance = new FragmentSwitchHelper();
		}
		return mInstance;
	}
	
	public void init(FragmentActivity fAct){
		mAct = fAct;
		fm = fAct.getSupportFragmentManager();
	}
	
	/**
	 * 跳转到相对应的Fragment
	 * @param tag 标记相应的Fragment
	 */
	public boolean skipFragment(String tag){
		if(mAct==null||fm ==null){
			LogUtil.e(TAG, "尚未初始化activity");
			return false;
		}
		final FragmentTransaction ft = fm.beginTransaction();
		if(tag.equals(WELCOME_FRAGMENT)){
			if(fm.findFragmentByTag(WELCOME_FRAGMENT)==null){
				WelcomeFragment welcomeFragment = new WelcomeFragment();
				ft.replace(R.id.welcome_fragment, welcomeFragment, WELCOME_FRAGMENT);
				ft.setTransition(FragmentTransaction.TRANSIT_FRAGMENT_OPEN);
				ft.commit();
			}
		}else if(tag.equals(MAIN_MENU_FRAGMENT)){
			if(fm.findFragmentByTag(MAIN_MENU_FRAGMENT)==null){
				MainMenuFragment mainMenuFragment = new MainMenuFragment();
				ft.replace(R.id.main_menu_fragment, mainMenuFragment, MAIN_MENU_FRAGMENT);
				ft.setTransition(FragmentTransaction.TRANSIT_FRAGMENT_OPEN);
				ft.commit();
			}
		}else if(tag.equals(LEVEL_SELECT_FRAGMENT)){
			if(fm.findFragmentByTag(LEVEL_SELECT_FRAGMENT)==null){
				LevelSelectFragment levelSelectFragment = new LevelSelectFragment();
				ft.replace(R.id.level_select_fragment, levelSelectFragment, LEVEL_SELECT_FRAGMENT);
				ft.setTransition(FragmentTransaction.TRANSIT_FRAGMENT_OPEN);
				ft.commit();
			}
		}else if(tag.equals(GAME_FRAGMENT)){
			if(fm.findFragmentByTag(GAME_FRAGMENT)==null){
				GameFragment gameFragment = new GameFragment();
				ft.replace(R.id.game_guess_fragment, gameFragment, GAME_FRAGMENT);
				ft.setTransition(FragmentTransaction.TRANSIT_FRAGMENT_OPEN);
				ft.commit();
			}
		}
		return true;
	}
}
