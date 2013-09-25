package com.coodroid.comicsguess.view.fragments;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.View.OnClickListener;
import android.view.ViewGroup;
import android.widget.Button;

import com.alkaid.base.extern.baseView.BaseFragment;
import com.coodroid.comicsguess.R;
import com.coodroid.comicsguess.view.FragmentSwitchHelper;

/**
 * 主菜单fragment
 * @author Jiangyinzhi
 *
 */
public class MainMenuFragment extends BaseFragment{
	
	private Button mainLevelBtn;
	private Button mainChallengeBtn;
	private Button mainShareBtn;
	
	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
	}

	@Override
	public View onCreateView(LayoutInflater inflater, ViewGroup container,
			Bundle savedInstanceState) {
		View view = inflater.inflate(R.layout.main_menu_layout, null);
		mainLevelBtn = (Button) view.findViewById(R.id.main_level_btn);
		mainChallengeBtn = (Button) view.findViewById(R.id.main_challenge_btn);
		mainShareBtn = (Button) view.findViewById(R.id.main_share_btn);
		setOnBtnListener();
		return view;
	}
	
	@Override
	public void onPause() {
		super.onPause();
	}
	
	//各个按键的监听
	private void setOnBtnListener(){
		if(mainLevelBtn!=null){
			mainLevelBtn.setOnClickListener(new OnClickListener() {
				@Override
				public void onClick(View v) {
					FragmentSwitchHelper.getInstance().skipFragment(FragmentSwitchHelper.LEVEL_SELECT_FRAGMENT);
				}
			});
		}
		if(mainChallengeBtn!=null){
			mainChallengeBtn.setOnClickListener(new OnClickListener() {
				@Override
				public void onClick(View v) {
					
				}
			});
		}
		if(mainShareBtn!=null){
			mainShareBtn.setOnClickListener(new OnClickListener() {
				@Override
				public void onClick(View v) {
					
				}
			});
		}
	}

}
