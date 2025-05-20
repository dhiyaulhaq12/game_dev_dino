using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFlow : MonoBehaviour
{
    public Transform player;      // Drag Player ke sini via Inspector
    public Vector3 offset;        // Jarak antara kamera dan player

    void LateUpdate()
    {
        if (player != null)
        {
            // Ikuti posisi player dengan offset (bisa disesuaikan di Inspector)
            transform.position = new Vector3(player.position.x + offset.x,
                                             player.position.y + offset.y,
                                             transform.position.z);  // Z tetap agar tidak berubah
        }
    }
}
