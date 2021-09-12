using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharecterController : MonoBehaviour
{
    public CharacterController controller;
    Vector3 direction;
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hInput = Input.GetAxis("Horizontal");
        direction.x = hInput * speed;

        controller.Move(direction * Time.deltaTime);
    }
}
