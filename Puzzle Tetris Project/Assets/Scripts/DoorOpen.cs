using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public Transform door;
    public float t;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        Vector3 a = transform.position;
        Vector3 b = door.position;

        transform.position = Vector3.MoveTowards(a, b, speed);
    }
}
