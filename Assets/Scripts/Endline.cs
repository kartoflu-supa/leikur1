﻿using UnityEngine;

public class Endline : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<gamemanager>().Levelcomplete();
        }
    }
}