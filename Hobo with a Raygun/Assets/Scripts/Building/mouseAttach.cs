using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseAttach : MonoBehaviour
{
    float depth = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        var mousePos = Input.mousePosition;
        var wantedPos = Camera.main.ScreenToWorldPoint (new Vector3 (mousePos.x, mousePos.y, depth));
        transform.position = wantedPos;
    }
}
