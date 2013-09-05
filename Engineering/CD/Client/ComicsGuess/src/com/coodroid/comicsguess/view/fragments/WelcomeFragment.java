package com.coodroid.comicsguess.view.fragments;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import com.alkaid.base.extern.baseView.BaseFragment;
import com.coodroid.comicsguess.R;

/**
 * 欢迎界面fragment
 * @author Jiangyinzhi
 *
 */
public class WelcomeFragment extends BaseFragment{
	
	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		
		
	}

	@Override
	public View onCreateView(LayoutInflater inflater, ViewGroup container,
			Bundle savedInstanceState) {
		inflater.inflate(R.layout.welcome_layout, null);
		return super.onCreateView(inflater, container, savedInstanceState);
	}
	
	@Override
	public void onPause() {
		super.onPause();
	}

}
