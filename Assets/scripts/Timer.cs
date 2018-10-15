using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    private bool Finished = false;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        if (Finished)
            return;

        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;
    }
    public void Finish()
    {
        Finished = true;
        timerText.color = Color.yellow;
    
    }
}