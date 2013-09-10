package com.coodroid.comicsguess.view.ui;

import android.content.Context;
import android.view.LayoutInflater;
import android.widget.LinearLayout;
import android.widget.TextView;

public class CGAnswerView extends LinearLayout
{
  private static int FONT_TISHI = -13857087;
  private Boolean isCorrect;
  private int mColor;
  private TextView mContentView;
  private int mPos;
  private Boolean mUsed;

  public CGAnswerView(Context paramContext)
  {
    super(paramContext);
    this.mContentView = ((TextView)((LayoutInflater)paramContext.getSystemService("layout_inflater")).inflate(2130903044, null));
    setLayoutParams(new LinearLayout.LayoutParams(-2, -2));
    addView(this.mContentView);
    this.mUsed = Boolean.valueOf(false);
    this.isCorrect = Boolean.valueOf(false);
    this.mColor = -1;
  }

  public String getKey()
  {
    if (this.mUsed.booleanValue())
      return this.mContentView.getText().toString();
    return "";
  }

  public int getPos()
  {
    return this.mPos;
  }

  public int getTextColor()
  {
    return this.mColor;
  }

  public Boolean isCorrect()
  {
    return this.isCorrect;
  }

  public Boolean isUsed()
  {
    return this.mUsed;
  }

  public void setDefaultWord(String paramString)
  {
    this.mUsed = Boolean.valueOf(true);
    this.isCorrect = Boolean.valueOf(true);
    this.mContentView.setTextColor(FONT_TISHI);
    this.mContentView.setBackgroundDrawable(null);
    this.mContentView.setText(paramString);
  }

  public void setPos(int paramInt)
  {
    this.mPos = paramInt;
  }

  public void setText(String paramString)
  {
    if (paramString.equals(""));
    for (this.mUsed = Boolean.valueOf(false); ; this.mUsed = Boolean.valueOf(true))
    {
      this.mContentView.setText(paramString);
      return;
    }
  }

  public void setTextColor(int paramInt)
  {
    this.mContentView.setTextColor(paramInt);
    this.mColor = paramInt;
  }
}

