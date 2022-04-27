using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    // Start is called before the first frame update    public Transform firePoint;

    // Þetta er script fyrir byssuna (skjota)
    public GameObject bulletPrefab; 
    public int bullet_speed = 10;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject instBullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity); 
            Rigidbody instBullet_rb = instBullet.GetComponent<Rigidbody>();
            instBullet_rb.AddForce(transform.forward * bullet_speed);
            Destroy(instBullet, 1f);

        }

    }


}
