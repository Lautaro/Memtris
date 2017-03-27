using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using DG.Tweening;
using System.Linq;

public class CardSceneGui : MonoBehaviour
{

    #region
    public static CardSceneGui Me;
    #endregion

    public Text ScoreText;
    public Text SpeedText;
    public TextMesh EnergBallText;
    private int score;
    public MessageDisplay messageDisplay;

    public void Awake()
    {
        Me = this;
    }

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
            ScoreText.text = "Score: " + score;
        }
    }

    /// <summary>
    /// This is set from gravity property setter. Dont set manually.
    /// </summary>
    public void SetSpeedLabel(float speed)
    {
        SpeedText.text = "Speed: " + (speed * 100).ToString("N0");
    }

    public void DisplayEnergyBalls(int amount)
    {
        EnergBallText.text = "Energy Balls: " + amount;
    }

 
    
    public static void DisplayGuiMessage(string message, Color color)
    {
      Me.messageDisplay.DisplayGuiMessage(message, color);
    }

}
