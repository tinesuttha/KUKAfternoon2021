using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WarpController : MonoBehaviour
{
    public string sceneName;
    public AudioSource warpSound;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Invoke("LoadNextScene", 0.6f);
            //�ѹ�֡ Scene
            PlayerPrefs.SetString("PrevScene", sceneName);
            /*����­���ѹ�֡���*/
            var player = other.GetComponent<PlayerContorllerRigbody>();

            PlayerPrefs.SetInt("CoinCount", player.coinCount);

            /*����­���ѹ�֡���*/
            // var player = other.gameObject.GetComponent<PlayerContorllerRigbody>();
            // PlayerPrefs.SetInt("CoinCount", player.coinCount);
            warpSound?.Play();
            /*if(warpSound != null)
            {
              warpSound.Play();
            }*/

        }
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
