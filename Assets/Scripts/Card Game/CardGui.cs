using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CardGui : MonoBehaviour
{
    #region
    public static CardGui Me;
    #endregion

    Text scoreLabel;
    Text speedLabel;
    Text energyBallsLabel;
    static Text wavePresentation;
    static int score;

    public int Score
    {
        get
        {
            return score;
        }
        set
        {
            score += value;
            SFXMan.sfx_Score.Play();
            scoreLabel.text = "Score: " + score;
        }
    }

    /// <summary>
    /// This is set from gravity property setter. Dont set manually.
    /// </summary>
    /// <param name="speed">Speed.</param>
    public void SetSpeedLabel(float speed)
    {
        speedLabel.text = "Speed: " + (speed * 100).ToString("N0");
    }

    public void SetEnergyBalls(int amount)
    {
        energyBallsLabel.text = "Energy Balls: " + amount;
    }

    void Awake()
    {
        Me = this;
        scoreLabel = transform.Find("ScoreLabel").GetComponent<Text>();
        speedLabel = transform.Find("SpeedLabel").GetComponent<Text>();
        wavePresentation = transform.Find("WavePresentation").GetComponent<Text>();
        energyBallsLabel = transform.Find("EnergyBallsLabel").GetComponent<Text>();
        wavePresentation.enabled = false;
    }



    public static void Message(string message, Color color)
    {
        wavePresentation.text = message;
        wavePresentation.color = color;
        wavePresentation.enabled = true;

        //var components = wavepresentation.getcomponents<uitweener>();

        //foreach (var tween in components)
        //{

        //    tween.reset();
        //    tween.playforward();
        //}
    }

    public void PresentationFinished()
    {

    }




}
