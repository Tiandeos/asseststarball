using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Bounce : MonoBehaviour
{
    Rigidbody2D rb;

    public static int ScoreRight = 0;
    public static int ScoreLeft = 0;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       

    }
    /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("KaleLeft"))
         {
            ScoreRight++;
            BallReady.clear = true;
            PlayerReady.clear = true;
         }
        else if (collision.transform.CompareTag("KaleRight"))
        {
            ScoreLeft++;
            BallReady.clear = true;
            PlayerReady.clear = true;
        }
    }
}
