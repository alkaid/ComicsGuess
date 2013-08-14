package com.coodroid.comicsguess.view.fragments;

import com.coodroid.comicsguess.R;

import android.app.Fragment;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

public class MainFragment extends Fragment{

	@Override
	public View onCreateView(LayoutInflater inflater, ViewGroup container,
			Bundle savedInstanceState) {
		inflater.inflate(R.layout.game_main_layout, null);
		return super.onCreateView(inflater, container, savedInstanceState);
	}
}
