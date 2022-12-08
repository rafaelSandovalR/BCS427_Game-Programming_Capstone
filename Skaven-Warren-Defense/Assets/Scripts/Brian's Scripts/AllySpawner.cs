using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AllySpawner : MonoBehaviour
{
    //ally to spawn in
    [SerializeField] private GameObject allyPrefab;
    public TMP_Text allyCounter;

    //max amount of allies that can be spawned
    [SerializeField] private int allyMax = 10;

    public int allyCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        allyCounter = GameObject.FindGameObjectWithTag("AllyCount").GetComponent<TMP_Text>();
        allyCounter.SetText("Allies: " + allyCount);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T) && allyCount < allyMax)
        {
            GameObject newAlly = Instantiate(allyPrefab, new Vector3(-10, 1, 0), Quaternion.identity);
            allyCount++;
            allyCounter.SetText("Allies: " + allyCount);
        }
    }
}
