package com.coodroid.comicsguess.view.fragments;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import com.alkaid.base.extern.baseView.BaseFragment;
import com.coodroid.comicsguess.R;

/**
 * 主菜单fragment
 * @author Jiangyinzhi
 *
 */
public class MainMenuFragment extends BaseFragment{
	
	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
	}

	@Override
	public View onCreateView(LayoutInflater inflater, ViewGroup container,
			Bundle savedInstanceState) {
		View view = inflater.inflate(R.layout.main_menu_layout, null);
		return view;
	}
	
	@Override
	public void onPause() {
		super.onPause();
	}

}
