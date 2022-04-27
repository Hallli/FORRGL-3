using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   

public class OvinurShooting : MonoBehaviour
{
    // Start is called before the first frame update

    // Þertta er script fyrir ovininn til þess að skjota
    
    public GameObject bullet;
    public int bullet_speed;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        GameObject instBullet = Instantiate(bullet, transform.position, Quaternion.identity);
        Rigidbody instBullet_rb = instBullet.GetComponent<Rigidbody>();
        instBullet_rb.AddForce(transform.forward * bullet_speed);
        Destroy(instBullet, 10f);
    }

}
