using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuAllies : MonoBehaviour
{
    public GameObject gameObjectPrefab;
    public string scenename;
    // Update is called once per frame
    void Update()
    {
        Instantiate(gameObjectPrefab, new Vector3(-25, 1, Random.Range(-20.0f, 20.0f)), Quaternion.identity);   

        if(Input.GetKeyDown(KeyCode.A))
        {
            SceneManager.LoadScene(scenename);
        }
    }
}
