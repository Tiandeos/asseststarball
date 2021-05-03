using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
   public GameObject DefaultstartMenu;
   public GameObject Startgamemenu;
   public GameObject Optionsmenu;
   public static string PlayerSide;   
   public void OnClickEnterStartANewGame() 
   {
      Application.LoadLevel(1);
   }
   public void OnClickEnterLoadGame() 
   {

   }
   public void OnClickEnterOptions() 
   {
      DefaultstartMenu.SetActive(false);
      Optionsmenu.SetActive(true);
   }
   public void OnClickEnterExit()
   {

   }
   public void Back() 
   {
      DefaultstartMenu.SetActive(true);
      Optionsmenu.SetActive(false);
      Startgamemenu.SetActive(false);
   }
}
