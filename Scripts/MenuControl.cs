using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;
public class MenuControl : MonoBehaviourPunCallbacks
{
    [SerializeField] private GameObject UsernameMenu;
    [SerializeField] private GameObject ConnectPanel;
    [SerializeField] private InputField JoinGameInput;
    [SerializeField] private InputField CreateGameInput;
    [SerializeField] private InputField UsernameInput;
    [SerializeField] private Button StartButton;


   void Awake()
   {
       PhotonNetwork.ConnectUsingSettings();
   }
   void Start()
   {
        UsernameMenu.SetActive(true);      
   }
   private void OnConnectedToServer()
   {
       PhotonNetwork.JoinLobby(TypedLobby.Default);
       Debug.Log("Connected");
   }
   public void ChangeNickName() 
   {
       if(UsernameInput.text.Length >= 2) 
       {
           StartButton.interactable = true;
       }
       else 
       {
           StartButton.interactable = false;
       }
   }
   public void SetNickname() 
   {
       UsernameMenu.SetActive(false);
       PhotonNetwork.NickName = UsernameInput.text;
   }
   public void CreateAGame() 
   {
       PhotonNetwork.CreateRoom(CreateGameInput.text,new RoomOptions() {MaxPlayers = 12},null);
   }
   public void JoinGame()
   {
       RoomOptions roomOptions = new RoomOptions();
       roomOptions.MaxPlayers = 12;
       PhotonNetwork.JoinOrCreateRoom(JoinGameInput.text,roomOptions,TypedLobby.Default);
   }
   public override void OnJoinedRoom() 
   {
       PhotonNetwork.LoadLevel("Main");
   }
}
