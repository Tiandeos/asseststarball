using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class GameManager : MonoBehaviour
{
    public GameObject PlayerPrefab;
    public GameObject GameCanvas;
    public GameObject SceneCamera;
   /// <summary>
   /// Awake is called when the script instance is being loaded.
   /// </summary>
   void Awake()
   {
       GameCanvas.SetActive(true);
   }
   public void SpawnPlayer() 
   {
       PhotonNetwork.Instantiate(PlayerPrefab.name,new Vector2(this.transform.position.x * 3,this.transform.position.y),Quaternion.identity,0);
       GameCanvas.SetActive(false);
       SceneCamera.SetActive(false);
   }
}
