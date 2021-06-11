using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeColor : MonoBehaviour
{
    public GameScore g;
    public SpriteRenderer rend;
    public bool gameover = false;

    // Update is called once per frame
    void Update()
    {
        if (g.fitCount == 0 && gameover == false)
        {
            rend = this.GetComponent<SpriteRenderer>();
            rend.material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
            gameover = true;
        }
        else if (g.fitCount == 0 && gameover == true)
        {
        }
        else
        {
            rend = this.GetComponent<SpriteRenderer>();
            rend.material.color = Color.white;
        }
    }
}
