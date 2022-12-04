using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject allyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            GameObject newAlly = Instantiate(allyPrefab, new Vector3(-10, 1, 0), Quaternion.identity);
        }
    }
}
