using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float power = 10f;

	private Rigidbody2D ballBody;
    bool canShoot = false;
    void Start()
    {
        GameObject ball = GameObject.FindGameObjectsWithTag ("Ball") [0];
        ballBody = ball.GetComponent<Rigidbody2D> ();
    }
    void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.X) && canShoot)
            {
                //Debug.Log("b");
                Vector2 v = ballBody.gameObject.transform.position - transform.position;
			    v = v / v.magnitude;
			    v = v * power * 30;
			    ballBody.AddForce (v);
            }   
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Ball")
        {
            canShoot = true;
            //Debug.Log("a");
            
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ball")
        {
            canShoot = false;
        }
    }


}
