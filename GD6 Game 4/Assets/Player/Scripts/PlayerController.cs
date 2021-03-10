using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 4;


    public GameObject RainBullet;

    public Transform RainPosition;

    public Rigidbody2D rb;

    
    
    

    // Start is called before the first frame update
    void Start()
    {

        

    }

    // Update is called once per frame
    void Update()
    {

        var movement = Input.GetAxis("Horizontal");

        transform.position += new Vector3 (movement, 0, 0) * Time.deltaTime * speed;


        if (Input.GetButton("Fire1"))
        {

            Rain();




        }



    }


    void Rain()
    {




        Instantiate(RainBullet,RainPosition.position, RainPosition.rotation);





    }





}
