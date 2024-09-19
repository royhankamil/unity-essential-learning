using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    public float speed = 5.0f; // Kecepatan gerak player

    protected virtual void Update()
    {
        // Mengambil input dari tombol WASD atau panah
        float moveHorizontal = Input.GetAxis("Horizontal"); // A/D atau panah kiri/kanan untuk sumbu X
        float moveVertical = Input.GetAxis("Vertical");     // W/S atau panah atas/bawah untuk sumbu Y

        // Membuat vektor gerakan berdasarkan input
        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f);

        // Menggerakkan player berdasarkan input
        transform.position += movement * speed * Time.deltaTime;
    }
}
