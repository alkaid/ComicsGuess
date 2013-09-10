package com.coodroid.comicsguess.view.ui;

import android.widget.TextView;

public class CGAnswerButton
{
  private TextView mButton;
  private int mPosition;
  private String mTitle;

  public CGAnswerButton(TextView paramTextView)
  {
    this.mButton = paramTextView;
  }

  public void Visible(Boolean paramBoolean)
  {
    if (paramBoolean.booleanValue())
    {
      this.mButton.setVisibility(0);
      return;
    }
    this.mButton.setVisibility(4);
  }

  public void clickHandler()
  {
    if (this.mButton.getVisibility() == 0)
      playSound();
    Visible(Boolean.valueOf(false));
  }

  public int getPos()
  {
    return this.mPosition;
  }

  public Boolean isVisible()
  {
    if (this.mButton.getVisibility() == 0);
    for (boolean bool = true; ; bool = false)
      return Boolean.valueOf(bool);
  }

  public void playSound()
  {
    
  }

  public void setPos(int paramInt)
  {
    this.mPosition = paramInt;
  }

  public void setTitle(String paramString)
  {
    this.mTitle = paramString;
    this.mButton.setText(paramString);
  }

  public String title()
  {
    return this.mTitle;
  }
}

