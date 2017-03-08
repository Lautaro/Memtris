using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuScene : MonoBehaviour {

	public enum MainMenuSceneState {
		Main, Options, Instructions

	}

	private MainMenuSceneState state;
	public GameObject OptionsPanel;
	public GameObject InstructionsPanel;
	public Slider SfxVolumeSlider;
	public Slider MusicVolumeSlider;
	public MainMenuSceneState State  { get { return state; }  }




	void Awake() {
		state = MainMenuSceneState.Main;
	}

	void Start () {
		
	}
	
	void Update () {
		
	}


    void PlayGameButtonPressed()
    { 
		
    
    }

    public void InstructionsButtonPressed()
    {
		state = MainMenuSceneState.Instructions;
		OptionsPanel.SetActive (false);
		InstructionsPanel.SetActive (true);
    }

	public void OptionsButtonPressed()
    {
		state = MainMenuSceneState.Options;
		OptionsPanel.SetActive (true);
		InstructionsPanel.SetActive (false);
    }

	public void SfxVolumeSliderChanged()
	{
		SFXMan.SfxVolume = SfxVolumeSlider.value;	
		Debug.Log ("SFX: " + SFXMan.SfxVolume);
	}

	public void MusicVolumeSliderChanged()
	{
		SFXMan.MusicVolume = MusicVolumeSlider.value;		
		Debug.Log ("Music: " + SFXMan.MusicVolume);
	}
}
