using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RollingCircle : MonoBehaviour
{
    [SerializeField] private float speed;
    
    private int score;

    [SerializeField] Text ScoreText;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("SmallCircle"))
        {
            score++;
            ScoreText.text = score.ToString();
            
        }
    }

    void Update()
    {
        transform.Rotate(0, 0, speed * Time.fixedDeltaTime);
    }
}
