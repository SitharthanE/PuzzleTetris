using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public GameObject CollisionTip;
    public GameObject CollisionTip1;
    public GameObject CollisionTip3;
    public GameObject CollisionTip4;
    private SpriteRenderer rend1, rend2, rend3, rend4;
    private Sprite greenGem, redGem;

    public int piececount;
	public bool moving;
    public int collideCount = 0;

    public float startPosX;
    public float startPosY;

    private Vector3 resetPos;

    void Start()
    {
        rend1 = CollisionTip.GetComponent<SpriteRenderer>();
        rend2 = CollisionTip1.GetComponent<SpriteRenderer>();
        rend3 = CollisionTip3.GetComponent<SpriteRenderer>();
        rend4 = CollisionTip4.GetComponent<SpriteRenderer>();
        greenGem = Resources.Load<Sprite>("gem_1");
        redGem = Resources.Load<Sprite>("gem_2");
        rend1.sprite = greenGem;
        rend2.sprite = greenGem;
        rend3.sprite = greenGem;
        rend4.sprite = greenGem;
        resetPos = this.transform.localPosition;
    }


    void Update()
    {
        if (moving)
        {
            changeSprite();
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, this.gameObject.transform.localPosition.z);

        }
    }

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;

            moving = true;
        }
    }

    void OnMouseUp()
    {
        moving = false;

        if (collideCount > 0)
        {
            this.transform.localPosition = new Vector3(resetPos.x, resetPos.y, resetPos.z);
            rend1.sprite = greenGem;
            rend2.sprite = greenGem;
            rend3.sprite = greenGem;
            rend4.sprite = greenGem;
        }
        else
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, this.gameObject.transform.localPosition.z);
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        collideCount++;
        //Debug.Log(collideCount);
    }

    void OnTriggerExit2D(Collider2D col)
    {
        collideCount--;
        //Debug.Log(collideCount);
    }

    void changeSprite()
    {
        if (collideCount != 0)
        {
            rend1.sprite = redGem;
            rend2.sprite = redGem;
            rend3.sprite = redGem;
            rend4.sprite = redGem;
        }
        else
        {
            rend1.sprite = greenGem;
            rend2.sprite = greenGem;
            rend3.sprite = greenGem;
            rend4.sprite = greenGem;
        }
    }
}