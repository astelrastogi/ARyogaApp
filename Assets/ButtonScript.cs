using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class NextButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager gameManager;
    public int tap;
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    
    
    // public void OnPointerClick(PointerEventData eventData)
    // {
    //     tap = eventData.clickCount;
 
    //     if (tap == 1)
    //     {
    //         gameManager.yoga1.SetActive(true);
    //     }
    //     if (tap == 2)
    //     {
    //         gameManager.yoga2.SetActive(true);
    //     }
    //     if (tap == 3)
    //     {
    //         gameManager.yoga3.SetActive(true);
    //     }
    //     if (tap == 4)
    //     {
    //         gameManager.yoga4.SetActive(true);
    //     }
    //     if (tap == 5)
    //     {
    //         gameManager.yoga5.SetActive(true);
    //     }
    //     if (tap == 6)
    //     {
    //         gameManager.yoga6.SetActive(true);
    //     }
    //     if (tap == 7)
    //     {
    //         gameManager.yoga7.SetActive(true);
    //     }
    //     if (tap == 8)
    //     {
    //         gameManager.yoga8.SetActive(true);
    //     }
    //     if (tap == 9)
    //     {
    //         gameManager.yoga9.SetActive(true);
    //     }
    //     if (tap == 10)
    //     {
    //         gameManager.yoga10.SetActive(true);
    //     }
    // }
}
