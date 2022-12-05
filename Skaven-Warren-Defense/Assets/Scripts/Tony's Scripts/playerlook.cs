using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerlook : MonoBehaviour
{
    public float mouseSens = 100f;

    public Transform playerModel;

    public Camera FristP;
    public Camera ThrdP;

float XRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        FristP.enabled = true;
        ThrdP.enabled = false;

        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // player comera control
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime ;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        // rotate player in with camera
        playerModel.Rotate(Vector3.up * mouseX);
        XRotation -= mouseY;

        //player camera restrictions
        XRotation = Mathf.Clamp(XRotation, -85f, 90f);
        transform.localRotation = Quaternion.Euler(XRotation, 0F, 0F);

        //camera change
        if (Input.GetKeyDown("v"))
        {
            FristP.enabled = !FristP.enabled;
            ThrdP.enabled = !ThrdP.enabled;
        }
    }
}
