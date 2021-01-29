using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float currentTime = 0;
    public float startingTime = 10;

    public Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        timerText.text = currentTime.ToString ("0") + "sec";

        if (currentTime <= 0)
        {
            currentTime = 0;
            Time.timeScale = 0;
        }
    }
}
