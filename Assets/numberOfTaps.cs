using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numberOfTaps : MonoBehaviour
{
    public int noOfTaps=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void ButtonClick()
    {
        noOfTaps++;
        Debug.Log(noOfTaps);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
