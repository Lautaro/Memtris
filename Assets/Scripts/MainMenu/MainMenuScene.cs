using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class MainMenuScene : MonoBehaviour {

	public enum MainMenuSceneState {
		Main, Options, Instructions

	}

	private MainMenuSceneState state;
	public GameObject OptionsPanel;
	public GameObject InstructionsPanel;
	public Slider SfxVolumeSlider;
	public Slider MusicVolumeSlider;
	public GameObject Logotype;
	public MainMenuSceneState State  { get { return state; }  }




	void Awake() {
		state = MainMenuSceneState.Main;

		// yoyo bounce x scale
		Logotype.transform.DOScale (new Vector3 (1.3f, 1, 1), 12f)
			.SetEase (Ease.InOutBounce)
			.SetLoops(-1, LoopType.Yoyo);

		// yoyo bounce y scale
		Logotype.transform.DOScale (new Vector3 (1, 1.8f, 1), 5f)
			.SetEase (Ease.InOutBounce)
			.SetLoops(-1, LoopType.Yoyo);
//
//		// yoyo bounce x rotatio
//		Logotype.transform.DORotate (new Vector3 (1, 1.2f, 1), 7f)
//			.SetEase (Ease.InOutExpo)
//			.SetLoops(-1, LoopType.Yoyo);

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
