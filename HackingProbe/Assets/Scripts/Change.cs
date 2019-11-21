using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Change : MonoBehaviour
{
	public Sprite OffSprite;
	public Sprite OnSprite;

	public Sprite goldSprite;
	public Sprite purpleSprite;
	public Sprite blueSprite;

	public Button but;

	private bool isGold;
	private bool isPurple;
	private bool isBlue;

	public void ChangeImage()
	{
		if(isGold == false && isPurple == false && isBlue == false) // For when no variables are active - neutral state
		{
			if (but.image.sprite == OnSprite)
			{
				but.image.sprite = OffSprite;
			}
			else
			{
				but.image.sprite = OnSprite;
			}
		}
		else if (isGold == true && isPurple == false && isBlue == false) // check if the gold variable is active
		{
			if (but.image.sprite == OnSprite)
			{
				but.image.sprite = goldSprite;
				isGold = false;
			}
			else
			{
				but.image.sprite = OnSprite;
			}
		}
		if (isGold == false && isPurple == true && isBlue == false) // check if the purple variable is active
		{
			if (but.image.sprite == OnSprite)
			{
				but.image.sprite = purpleSprite;
				isPurple = false;
			}
			else
			{
				but.image.sprite = OnSprite;
			}
		}
		if (isGold == false && isPurple == false && isBlue == true) // check if the blue variable is active
		{
			if (but.image.sprite == OnSprite)
			{
				but.image.sprite = blueSprite;
				isBlue = false;
			}
			else
			{
				but.image.sprite = OnSprite;
			}
		}
	}

	public void SelectGold()
	{
		isGold = true;
	}

	public void SelectPurple()
	{
		isPurple = true;
	}

	public void SelectBlue()
	{
		isBlue = true;
	}

}
