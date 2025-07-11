using UnityEngine;
using TMPro;
public class Dice : MonoBehaviour
{
    public TMP_Text score;
    public TMP_Text highScore;

    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
    public void RollDice()
    {
        int number = Random.Range(1, 7);
        score.text = number.ToString();

        if (number > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", number);
            highScore.text = number.ToString();
        }

    }
    public void Reset()
    {
        PlayerPrefs.DeleteAll();
        highScore.text = "0";
    }

        
    
}
