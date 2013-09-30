package com.coodroid.comicsguess.view.ui;


import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

import android.app.Activity;
import android.graphics.drawable.ColorDrawable;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.animation.AnimationSet;
import android.view.animation.LayoutAnimationController;
import android.view.animation.LinearInterpolator;
import android.widget.GridView;
import android.widget.LinearLayout;

import com.alkaid.base.extern.baseView.BaseFragmentActivity;
import com.coodroid.comicsguess.R;
import com.coodroid.comicsguess.view.ui.adapter.CGAnswerItemAdapter;

public class MainGuessActivity extends Activity  {
	
	private CGAnswerItemAdapter mAdapter;
	private KeyClick mItemClickListener;
	private ArrayList<CGAnswerView> mAnsKeyViewsList;
	private GridView keyGrid;
	private LayoutInflater mInflate;
	private LinearLayout mGridContainer;
	




	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_play);
        this.mInflate = ((LayoutInflater)getSystemService("layout_inflater"));
        
        
        mGridContainer= (LinearLayout)findViewById(R.id.gridview_container);
        ArrayList<String> test = new ArrayList<String>();
        test.add("毛");
        test.add("虾");
        test.add("傻");
        test.add("逼");
        test.add("虾");
        test.add("虾"); 
        test.add("虾");
        test.add("虾");
        test.add("虾");
        test.add("虾");
        test.add("虾");
        test.add("虾");
        test.add("虾");
        test.add("虾");
        test.add("虾");
        test.add("虾");
        test.add("虾");
        test.add("虾");
        test.add("虾");
        test.add("虾");
        test.add("虾");
        test.add("虾");
        test.add("虾");
        test.add("虾");
  
        initKeysGrid(test);
		
	}
	
	
	
	
	  private void initKeysGrid(ArrayList<String> paramArrayList)
	  {
	    keyGrid = ((GridView)this.mInflate.inflate(R.layout.key_grid, null));
	   
	
	    mGridContainer.addView(this.keyGrid);
	    mAdapter = new CGAnswerItemAdapter(getBaseContext(), paramArrayList);
//	    this.mItemClickListener = new KeyClick(null);
//	    this.mAdapter.setItemListener(this.mItemClickListener);
	    this.keyGrid.setAdapter(this.mAdapter);
	    this.keyGrid.setSelector(new ColorDrawable(0));
	    LayoutAnimationController localLayoutAnimationController = this.keyGrid.getLayoutAnimation();
	    Iterator localIterator;
	    if (localLayoutAnimationController != null)
	    {
	      AnimationSet localAnimationSet = (AnimationSet)localLayoutAnimationController.getAnimation();
	      List localList = localAnimationSet.getAnimations();
	      localAnimationSet.setInterpolator(new LinearInterpolator());
	      localLayoutAnimationController.setInterpolator(new LinearInterpolator());
	      localIterator = localList.iterator();
	    }
//	    while (true)
//	    {
//	      if (!localIterator.hasNext())
//	        return;
//	      ((Animation)localIterator.next()).setInterpolator(new LinearInterpolator());
//	    }
	  }
	
	
	
	  private class KeyClick
	    implements MainGuessActivity.onKeyClickListener
	  {
	    private int mPos;
	    private View mView;

	    private KeyClick()
	    {
	    }

	    public void keyClicked(View paramView, int paramInt)
	    {
	      this.mView = paramView;
	      this.mPos = paramInt;
	      CGAnswerButton localCGAnswerButton = (CGAnswerButton)this.mView.getTag();
	
	      if (localCGAnswerButton.isVisible().booleanValue())
	    	  MainGuessActivity.this.setAnsBoard(localCGAnswerButton.title(), this.mPos);
	      localCGAnswerButton.clickHandler();
	    }
	  }
	  
	  
	  private void setAnsBoard(String paramString, int paramInt)
	  {
	    Iterator localIterator = this.mAnsKeyViewsList.iterator();
	    StringBuilder localStringBuilder = new StringBuilder();
	    Boolean localBoolean = Boolean.valueOf(false);
	    while (true)
	    {
	      if (!localIterator.hasNext())
	      {
//	        checkSucc(localStringBuilder.toString());
	        return;
	      }
	      CGAnswerView localCGAnswerView = (CGAnswerView)localIterator.next();
	      if (localCGAnswerView.isUsed().booleanValue())
	      {
	        localStringBuilder.append(localCGAnswerView.getKey());
	        continue;
	      }
	      if ((localBoolean.booleanValue()) || (paramString.equals("")) || (localCGAnswerView.isUsed().booleanValue()) || (localCGAnswerView.getVisibility() == 4))
	        continue;
	      localBoolean = Boolean.valueOf(true);
	      localCGAnswerView.setText(paramString);
	      localCGAnswerView.setPos(paramInt);
	      localStringBuilder.append(paramString);
	    }
	  }
	  
	  
	
	public abstract interface onKeyClickListener
	{
	  public abstract void keyClicked(View paramView, int paramInt);
	}

}

