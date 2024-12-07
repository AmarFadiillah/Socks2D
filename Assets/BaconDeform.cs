using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaconDeform : MonoBehaviour
{
    public float deformAmount = 0.5f; // Seberapa besar deformasi
    private Vector3 originalPosition;

    void Start()
    {
        originalPosition = transform.position;
    }

    void Update()
    {
        float wave = Mathf.Sin(Time.time * 10f) * deformAmount;
        transform.position = new Vector3(originalPosition.x, originalPosition.y + wave, originalPosition.z);
    }
}

