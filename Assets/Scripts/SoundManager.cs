using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public Sprite newSprite;
    public Sprite oldSprite;
    private Image img;

    public void ChangeSprite()
    {
        if (muted == true)
        {
            img.sprite = newSprite;
        }
        if (muted == false)
        {
            img.sprite = oldSprite;
        }
    }
    private bool muted = false;
    void Start()
    {
        img = GetComponent<Image>();
        if (!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
            Load();
        }
        else
        {
            Load();
        }
        AudioListener.pause = muted; 
    }

    public void OnButtonPress()
    {
        if (muted == false)
        {
            muted = true;
            AudioListener.pause = true;
        }
        else 
        {
        muted = false;
            AudioListener.pause = false;
        }
        Save();
    }
    private void Load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
    }
    private void Save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }
}

