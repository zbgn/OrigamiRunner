using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetShotScript : MonoBehaviour {
void OnTriggerEnter2D(Collider2D theCollision)
    {
        if (theCollision.tag == "shot")
        {
            GameController.instance.RunnerDied();
        }
    }
}