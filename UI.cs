using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI : MonoBehaviour
{
    // Start is called before the first frame update

    // Þetta er script fyrir UI
    public TextMeshProUGUI healthText;
    public int health = 10;
    //public Text Score;
    void Start()
    {
        //healthText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: "+health;
        if(health < 0){
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision obj){
        if(obj.collider.tag == "Bullet"){
            Debug.Log("Test");
            health --;
        }
    }

}
