using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToMove : MonoBehaviour
{
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 raycastposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(raycastposition, Vector2.zero);

            if(hit.collider != null)
            {
                if(hit.collider.gameObject.tag == "Ally")
                {
                    target = hit.collider.gameObject;
                }
            }
        }
    }
}
