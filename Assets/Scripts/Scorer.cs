﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision collision) {
        Debug.Log("You've bumped into a thing this many times: " + hits);
        if(collision.gameObject.tag != "Hit") {
            hits += 1;
        }
        
    }
}
