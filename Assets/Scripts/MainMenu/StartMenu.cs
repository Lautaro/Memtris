using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour {

	public enum MainMenuSceneState {
		Main, Options, Instructions

	}

	
	public GameObject OptionsPanel;
	public GameObject InstructionsPanel;
	public Slider SfxVolumeSlider;
	public Slider MusicVolumeSlider;
	public GameObject Logotype;

    private MainMenuSceneState state;
    public MainMenuSceneState State  { get { return state; }  }




	void Awake()
    {
        state = MainMenuSceneState.Main;

        AnimateLogotype();

    }

    private void AnimateLogotype()
    {
        var tweenSequencer = DOTween.Sequence();
        var logo = Logotype.transform;

        // yoyo bounce x scale
        tweenSequencer.Append(
            logo.DOScale(new Vector3(2.0f, 2.0f, 1), 3f)
          .SetEase(Ease.Linear)
            .SetLoops(100, LoopType.Yoyo));

        // yoyo bounce y scale
        //tweenSequencer.Join(
        //   logo.DOScale(new Vector3(1, 1.8f, 1), 4f)

        //    .SetLoops(100, LoopType.Yoyo));

        //// yoyo bounce y scale
        //tweenSequencer.Join(
        //   logo.DOScale(new Vector3(2, 1, 1), 8f)

        //    .SetLoops(100, LoopType.Yoyo));

        // yoyo bounce rotation
        tweenSequencer.Join(
      logo.DORotate(new Vector3(0, 200, 0), 5f)
        .SetEase(Ease.Linear)
          .SetLoops(100, LoopType.Yoyo));

        //tweenSequencer.Join(
        //logo.DORotate(new Vector3(0, 0, 40f), 4f)
     
        //    .SetLoops(100, LoopType.Yoyo));
    }

    void Start () {
		
	}
	
	void Update () {
		
	}


    public void PlayGameButtonPressed()
    {
        SceneManager.LoadScene("CardGame");
    
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
