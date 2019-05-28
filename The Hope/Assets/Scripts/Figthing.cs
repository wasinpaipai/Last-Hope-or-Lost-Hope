using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Figthing : MonoBehaviour
{

    public Player player;

    private void run()
    {
        if (player.atk)
        {
            print("a");
        }
    }
}
