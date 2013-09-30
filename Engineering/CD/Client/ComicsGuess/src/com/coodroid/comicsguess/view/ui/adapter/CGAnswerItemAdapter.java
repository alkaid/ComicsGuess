package com.coodroid.comicsguess.view.ui.adapter;

import java.util.ArrayList;


import android.content.Context;
import android.view.LayoutInflater;
import android.view.MotionEvent;
import android.view.View;
import android.view.ViewGroup;
import android.view.animation.Animation;
import android.view.animation.LinearInterpolator;
import android.view.animation.ScaleAnimation;
import android.widget.BaseAdapter;
import android.widget.TextView;

import com.coodroid.comicsguess.R;
import com.coodroid.comicsguess.view.ui.CGAnswerButton;

public class CGAnswerItemAdapter extends BaseAdapter
{
  private static int ITEM_COUNT = 20;
  private ArrayList<View> buttonList;
  private Context mCtx;
 
  private ArrayList<String> mKeyList;

  public CGAnswerItemAdapter(Context paramContext, String paramString)
  {
    this.mCtx = paramContext;
    this.mKeyList = new ArrayList(ITEM_COUNT);
    String[] arrayOfString = paramString.split("");
    for (int i = 0; ; i++)
    {
      if (i >= paramString.length())
      {
        this.buttonList = new ArrayList(ITEM_COUNT);
        return;
      }
      this.mKeyList.add(arrayOfString[i]);
    }
  }

  public CGAnswerItemAdapter(Context paramContext, ArrayList<String> paramArrayList)
  {
    this.mCtx = paramContext;
    this.mKeyList = paramArrayList;
    this.buttonList = new ArrayList(ITEM_COUNT);
  }

  public int getCount()
  {
    return this.mKeyList.size();
  }

  public Object getItem(int paramInt)
  {
    if (this.buttonList.size() > paramInt)
      return this.buttonList.get(paramInt);
    return null;
  }

  public long getItemId(int paramInt)
  {
    return paramInt;
  }

  public ArrayList<String> getKeyList()
  {
    return this.mKeyList;
  }

  public View getView(int paramInt, View paramView, ViewGroup paramViewGroup)
  {
    View localView = null;
    if (paramInt >= this.mKeyList.size())
    {
      new View(this.mCtx).setVisibility(View.INVISIBLE);
      localView = new View(this.mCtx);
      return localView;
    }
    if (paramView == null)
    {
      localView = ((LayoutInflater)this.mCtx.getSystemService("layout_inflater")).inflate(R.layout.button_text, null);
      localView.setOnTouchListener(new onKeyTouchListener());
    }else {
		localView = paramView;
	}
    while (true)
    {
      TextView localTextView = (TextView)localView.findViewById(R.id.text);
      localTextView.setText((CharSequence)this.mKeyList.get(paramInt));
      CGAnswerButton localCGAnswerButton = new CGAnswerButton(localTextView);
      localCGAnswerButton.setTitle((String)this.mKeyList.get(paramInt));
      localCGAnswerButton.setPos(paramInt);
      localView.setTag(localCGAnswerButton);
      if ((this.buttonList.contains(localView)) || (this.buttonList.size() > paramInt))
        break;
      this.buttonList.add(paramInt, localView);
      return localView;

    }
	return localView;
  }

  public void reloadList(String paramString)
  {
    this.mKeyList = new ArrayList(ITEM_COUNT);
    String[] arrayOfString = paramString.split("");
    for (int i = 0; ; i++)
    {
      if (i >= paramString.length())
      {
        this.buttonList = new ArrayList(ITEM_COUNT);
        notifyDataSetChanged();
        return;
      }
      this.mKeyList.add(arrayOfString[i]);
    }
  }

  public void reloadList(ArrayList<String> paramArrayList)
  {
    this.mKeyList = paramArrayList;
    this.buttonList = new ArrayList(ITEM_COUNT);
    notifyDataSetChanged();
  }



  private class keyAnimListener
    implements Animation.AnimationListener
  {
    private View mView;

    public keyAnimListener(View arg2)
    {
      Object localObject;
//      this.mView = localObject;
    }

    public void onAnimationEnd(Animation paramAnimation)
    {
//      this.mView.clearAnimation();
//      if (CGAnswerItemAdapter.this.mItemClickListener != null)
//      {
//        CGAnswerButton localCGAnswerButton = (CGAnswerButton)this.mView.getTag();
//        CGAnswerItemAdapter.this.mItemClickListener.keyClicked(this.mView, localCGAnswerButton.getPos());
//      }
    }

    public void onAnimationRepeat(Animation paramAnimation)
    {
    }

    public void onAnimationStart(Animation paramAnimation)
    {
    }
  }

  private class onKeyTouchListener implements View.OnTouchListener
  {
    public onKeyTouchListener()
    {
    }

    public boolean onTouch(View paramView, MotionEvent paramMotionEvent)
    {
      if (!((CGAnswerButton)paramView.getTag()).isVisible().booleanValue())
        return true;
      if (paramMotionEvent.getAction() == 0)
      {
        ScaleAnimation localScaleAnimation1 = new ScaleAnimation(1.0F, 1.4F, 1.0F, 1.4F, 1, 0.5F, 1, 0.5F);
        localScaleAnimation1.setDuration(50L);
        localScaleAnimation1.setFillAfter(true);
        localScaleAnimation1.setInterpolator(new LinearInterpolator());
        paramView.startAnimation(localScaleAnimation1);
      }
  

        if ((paramMotionEvent.getAction() == MotionEvent.ACTION_UP ) || (paramMotionEvent.getAction() == MotionEvent.ACTION_CANCEL))
        {
         
        ScaleAnimation localScaleAnimation2 = new ScaleAnimation(1.4F, 1.0F, 1.4F, 1.0F, 1, 0.5F, 1, 0.5F);
        localScaleAnimation2.setDuration(50L);
        localScaleAnimation2.setFillAfter(true);
        localScaleAnimation2.setInterpolator(new LinearInterpolator());
//        localScaleAnimation2.setAnimationListener(new MainGuessActivity.keyAnimListener(CGAnswerItemAdapter.this, paramView));
        paramView.startAnimation(localScaleAnimation2);
        }
      
	return true;
    }
  }
}

