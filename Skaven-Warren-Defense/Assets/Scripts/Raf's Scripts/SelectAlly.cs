using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectAlly : MonoBehaviour
{
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0)) // 0 is left mouse button, 1 is right
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            
            if(Physics.Raycast(ray, out hitInfo))
            {
                if(hitInfo.collider.tag == "Ally")
                {
                    target = hitInfo.transform.gameObject;
                }
            }
         
        }
    }
}
