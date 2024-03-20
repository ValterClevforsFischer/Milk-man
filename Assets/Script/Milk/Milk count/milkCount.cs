using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class milkcounter : MonoBehaviour
{
    public milkManager mm;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Milk"))
        {
            mm.milkCount++;
        }
    }
}
