using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScore : MonoBehaviour
{
    public MoveScript p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18;
    public int fitCount;

    void Start()
    {
        fitCount = 1;
    }

    void Update()
    {
        fitCount = p1.collideCount + p2.collideCount + p3.collideCount + p4.collideCount + p5.collideCount + p6.collideCount +
            p7.collideCount + p8.collideCount + p9.collideCount + p10.collideCount + p11.collideCount + p12.collideCount +
            p13.collideCount + p14.collideCount + p15.collideCount + p16.collideCount + p17.collideCount + p18.collideCount;
        if (fitCount == 0)
        { 
            StartCoroutine(waiter());
        }
    }

    public IEnumerator waiter()
    {
        
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene("DoorScene");


    }

}
