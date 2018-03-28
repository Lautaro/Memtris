﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections.Generic;

public class MainGame : MonoBehaviour
{
    public static int Wave = 1;
    public static MainGameState state;
    Slider musicVolumeSlider;
    Slider sfxVolumeSlider;
    GameObject logo;


    #region Main Menu User Interface

    public GameObject InstructionsPanel;
    public GameObject OptionsPanel;
    #endregion

    // Use this for initialization
    void Start()
    {

        InstructionsPanel = transform.Find("Instructions").gameObject;
        OptionsPanel = transform.Find("Options").gameObject;


        state = MainGameState.StartMenu;
        Wave = 1;

        SFXMan.PlayAsSong(SFXMan.sng_StartMenuSong);

        logo = transform.Find("Logo").gameObject;
        musicVolumeSlider = transform.Find("Options/MusicVolume").GetComponent<Slider>();
        sfxVolumeSlider = transform.Find("Options/SfxVolume").GetComponent<Slider>();

    }

   

    public void StartGame()
    {
        StartCoroutine(InitiateGame());
    }

    IEnumerator InitiateGame()
    {
        Wave = 1;
        state = MainGameState.PlatformGame;

        SFXMan.sfx_StartGame.Play();
        AnimateLogo();
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("CardMemtris");
        //		Application.LoadLevel ("PlatformScene");
    }

    void AnimateLogo()
    {
        //var tween = logo.GetComponent<TweenScale>();
        //tween.style = UITweener.Style.Once;
        //tween.to = new Vector3(0.0f, 0.0f, 0.0f);
        //tween.duration = 3;
        //tween.PlayForward();

    }

    public void SetMusicVolume()
    {
        SFXMan.MusicVolume = musicVolumeSlider.value;
    }

    public void SetSfxVolume()
    {
        SFXMan.SfxVolume = sfxVolumeSlider.value;
    }

    public void ToggleOptionsPanel()
    {

        OptionsPanel.SetActive(true);
        InstructionsPanel.SetActive(false);

    }

    public void ToggleInstructionsPanel()
    {
        OptionsPanel.SetActive(false);
        InstructionsPanel.SetActive(true);

    }


}

public enum MainGameState
{
    StartMenu,
    PlatformGame,
    CardGame
}


