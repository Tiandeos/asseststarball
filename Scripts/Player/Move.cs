using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class Move : MonoBehaviour
{
    public PhotonView photonView;
    public GameObject cameraplayer;
    Rigidbody2D rb;
    public int speed = 5;
    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        if(photonView.IsMine) 
        {
            cameraplayer.SetActive(true);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 vector3 = new Vector3(x * speed, y * speed, 0f);

        rb.AddForce(vector3);

    }
}
