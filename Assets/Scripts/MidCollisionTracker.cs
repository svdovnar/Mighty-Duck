using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MidCollisionTracker : MonoBehaviour
{
    public ScoreTraker scoreTraker;

    private void Start()
    {
        scoreTraker = GameObject.FindGameObjectWithTag("Tracker").GetComponent<ScoreTraker>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        scoreTraker.AddScore(1);  // 1 is how much score we add
    }
}
