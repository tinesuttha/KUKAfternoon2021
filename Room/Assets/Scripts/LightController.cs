using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
  public Light light1;
    public float intensity = 1f;

  private void OnMouseDown()
  {
        print("MouseDown");
        
        light1.enabled = !light1.enabled;
        light1.intensity = intensity;
        //light1.enabled = false;

       /* if(light1.enabled == true)
        {
             light1.enabled = false; 
        }
        else 
        {
            light1.enabled = true;
        }  */
       
  }
  
}
