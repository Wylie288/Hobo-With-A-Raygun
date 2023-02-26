/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectColission : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    var smooth = 5.0;
    // Update is called once per frame
    void Update()
    {
        var ray : Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        var hit : RaycastHit;
        if(Physics.Raycast(ray,hit,50))
            {
                if(hit.transform.gameObject.tag == "cursorfollow")
                {
                    Drag(hit);
                }
            }
    }
    void Drag(_h : RaycastHit)
    {
        transform.position = Vector3.Lerp (
            transform.position, _h.point,
            Time.deltaTime * smooth);
        )
    }
}
*/