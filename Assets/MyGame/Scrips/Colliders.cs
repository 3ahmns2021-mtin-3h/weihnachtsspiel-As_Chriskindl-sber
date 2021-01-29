using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Colliders : MonoBehaviour
{
    public Text scoreText;
    private int scoreNumber;

    // Start is called before the first frame update
    void Start()
    {
        scoreNumber = 0;
        scoreText.text = "" + scoreNumber;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Schneeball"))
        {
            Debug.Log("trigger");
            Destroy(collision.gameObject);
            Time.timeScale = 0;
        }

        if (collision.CompareTag("Kamin"))
        {
            Debug.Log("+1");
            scoreNumber += 1;
            scoreText.text = "" + scoreNumber;
        }
    }
}
