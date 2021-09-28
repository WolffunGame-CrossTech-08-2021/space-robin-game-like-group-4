using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    public Transform CursorTransform;

    void Update()
    {


        Vector3 temp = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        CursorTransform.position = new Vector3(temp.x, temp.y, 0);
    }
}
