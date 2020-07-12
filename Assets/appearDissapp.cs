using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appearDissapp : MonoBehaviour
{
    public int clicks=1;
    public GameObject gameObject;
    public void play(){
        if(clicks%2!=0)
        {
            gameObject.SetActive(true);
            clicks++;
        }
        else{
            gameObject.SetActive(false);
            clicks++;
        } 
    }
    
}
