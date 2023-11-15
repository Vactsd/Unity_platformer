using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed_Horizontal=10;
    public float Speed_Vertical=10;

    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        float Horizontal=Input.GetAxisRaw("Horizontal");
        float Vertical=Input.GetAxisRaw("Vertical");

        Vector2 position=transform.position;
        position.x=position.x+Horizontal*Speed_Horizontal*Time.deltaTime;
        position.y=position.y+Vertical*Speed_Vertical*Time.deltaTime;
        transform.position=position;
        
    }
}
