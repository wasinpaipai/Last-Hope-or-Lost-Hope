using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//xxxxxxxxx;
public class DeviceTrigger : MonoBehaviour
{
    [SerializeField] private GameObject[] targets;

    void OnTriggerEnter(Collider other)
    {
        foreach (GameObject target in targets)
        {
            target.SendMessage("Active");
        }
        print("Ac");
    }
    void OnTriggerExit(Collider other)
    {
        foreach (GameObject target in targets)
        {
            target.SendMessage("Deactive");
        }
        print("De");
    }
}
