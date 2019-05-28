using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyHit : MonoBehaviour
{
    [SerializeField] private GameObject[] targets;

    void OnTriggerEnter(Collider other)
    {
        foreach (GameObject target in targets)
        {
            target.SendMessage("AtkActive");
        }
        print("Ac");
    }
    void OnTriggerExit(Collider other)
    {
        foreach (GameObject target in targets)
        {
            target.SendMessage("AtkDeactive");
        }
        print("De");
    }
}
