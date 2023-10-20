using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Start is called before the first frame update




    public Transform bulletSpawnPointl;
    public GameObject bulletPrefabs;
    public float bulletSpeed;

    void Update()
    {
        RotateGun();
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }

    }
    void RotateGun()
    {
        Vector3 mousPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 lookDir = mousPos - transform.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x)*Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.Euler(0, 0, angle);
        transform.rotation = rotation;
        if (transform.eulerAngles.z >90 && transform.eulerAngles.z<270)
        {
            transform.localScale = new Vector3(0.3f, -0.3f, 0);
        }
        else
        {
            transform.localScale = new Vector3(0.3f, 0.3f, 0);

        }
    }
    void Fire()
    {
        // Lấy hướng từ vũ khí đến vị trí chuột
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = (mousePosition - transform.position).normalized;

        // Tạo thể hiện đạn và đặt vận tốc
        var bullet = Instantiate(bulletPrefabs, bulletSpawnPointl.position, bulletSpawnPointl.rotation);
        bullet.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;

     
    }


}
