using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SockController : MonoBehaviour
{
    public float kickAngle = 45f; // Sudut maksimum tendangan dari posisi awal
    public float kickSpeed = 5f;  // Kecepatan tendangan
    private float initialAngle;   // Sudut awal kaki
    private bool isHeld = false;  // Status tombol ditekan

    void Start()
    {
        // Menyimpan sudut awal kaki
        initialAngle = transform.localEulerAngles.z;
    }

    void Update()
    {
        // Deteksi input untuk menendang
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            isHeld = true; // Mulai menendang
        }

        // Deteksi saat tombol dilepas
        if (Input.GetKeyUp(KeyCode.Space) || Input.GetMouseButtonUp(0))
        {
            isHeld = false; // Kembali ke posisi awal
        }
    }

    void FixedUpdate()
    {
        if (isHeld)
        {
            // Rotasi ke sudut maksimum (menendang)
            float targetAngle = initialAngle + kickAngle; // Sudut maksimum relatif terhadap posisi awal
            float currentAngle = Mathf.LerpAngle(transform.localEulerAngles.z, targetAngle, kickSpeed * Time.deltaTime);
            transform.localEulerAngles = new Vector3(0, 0, currentAngle);
        }
        else
        {
            // Kembali ke sudut awal (posisi istirahat)
            float currentAngle = Mathf.LerpAngle(transform.localEulerAngles.z, initialAngle, kickSpeed * Time.deltaTime);
            transform.localEulerAngles = new Vector3(0, 0, currentAngle);
        }
    }
}