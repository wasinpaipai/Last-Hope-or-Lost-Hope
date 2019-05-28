using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventOrder : MonoBehaviour
{
    bool printUpdate = false;
    bool printFixedUpdate = false;
    bool printLateUpdate = false;
    GameObject gm;
    // Start is called before the first frame update
    void Start()
    {
        print("Start");
        gm.transform.position = new Vector3(1, 2, 3);
        //gm.transform.position.x = ssss
    }

    // Update is called once per frame
    void Update()
    {
        if (!printUpdate)
        {
            print("Update");
            printUpdate = true;
        }
    }

    private void FixedUpdate()
    {
        if (!printFixedUpdate)
        {
            print("FIXEDUpdate");
            printFixedUpdate = true;
        }
    }

    private void LateUpdate()
    {
        if (!printLateUpdate)
        {
            print("LateUpdate");
            printLateUpdate = true;
        }
    }

    private void OnEnable()
    {
        print("OnEnable");
    }

    private void Awake()
    {
        print("Awake");
    }

    private void Reset()
    {
        print("Reset");
    }

}
