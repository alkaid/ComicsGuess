package com.coodroid.comicsguess.view.fragments;

import java.util.Date;

import android.app.Activity;
import android.os.AsyncTask;
import android.os.Bundle;
import android.os.Handler;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import com.alkaid.base.common.LogUtil;
import com.alkaid.base.extern.baseView.BaseFragment;
import com.coodroid.comicsguess.R;
import com.coodroid.comicsguess.data.DBSql;
import com.coodroid.comicsguess.data.WelcomeDAO;
import com.coodroid.comicsguess.view.FragmentSwitchHelper;

/**
 * 欢迎界面fragment
 * @author Jiangyinzhi
 *
 */
public class WelcomeFragment extends BaseFragment{
	
	private final long SHOWTIME = 2000L;
	private Activity mAct;
	
	
	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		new InitTask().execute();
		mAct = getActivity();
	}

	@Override
	public View onCreateView(LayoutInflater inflater, ViewGroup container,
			Bundle savedInstanceState) {
		View view = inflater.inflate(R.layout.welcome_layout, null);
		return view;
	}
	
	@Override
	public void onPause() {
		super.onPause();
	}
	
	/**欢迎界面初始化数据*/
	private class InitTask extends AsyncTask<Void, Integer, Integer>{
		Date begin;Date end;
		@Override
		protected Integer doInBackground(Void... params) {
			//后台初始化全局
			begin=new Date();
			//初始化数据以及随机题目的数据
			WelcomeDAO dao = new WelcomeDAO(mAct);
			dao.randomDBData();
			return null;
		}
		@Override
		protected void onPostExecute(Integer result) {
			//初始化完成后计算用时，若用时未达到2秒钟，延迟至2秒更新ui，否则立即更新UI
			super.onPostExecute(result);
			end=new Date();
			long delgat=end.getTime()-begin.getTime();
			LogUtil.i("用时:"+delgat+"ms");
			if(delgat<SHOWTIME){
				new Handler().postDelayed(new Runnable() {
					@Override
					public void run() {
						FragmentSwitchHelper.getInstance().skipFragment(FragmentSwitchHelper.MAIN_MENU_FRAGMENT);
					}
				}, SHOWTIME-delgat);
			}else{
				FragmentSwitchHelper.getInstance().skipFragment(FragmentSwitchHelper.MAIN_MENU_FRAGMENT);
			}
		}
	}

}
