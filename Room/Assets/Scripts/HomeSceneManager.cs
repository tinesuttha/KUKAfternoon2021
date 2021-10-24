using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HomeSceneManager : MonoBehaviour
{
    
        public void GoToPlayground()
        {
        //ลบค่าก่อนเริ่มเกม
        //PlayerPrefs.SetInt("CoinCount", 0);
        PlayerPrefs.DeleteKey("CoinCount");
        PlayerPrefs.DeleteKey("BulletCount");
        SceneManager.LoadScene("Playground");
        }
   
      public void ContinuePlay()
      {
        if(PlayerPrefs.HasKey("PrevScene"))
        {
            string prevSceneName = PlayerPrefs.GetString("PrevScene");
            SceneManager.LoadScene(prevSceneName);
        }
        
       }

    public void MyCredit()
    {
        SceneManager.LoadScene("MyCredit");

    }

    public void GotoHome()
    {
        SceneManager.LoadScene("Home");

    }


    public void ExitGame()
        {
        Application.Quit();
        }

    
}
