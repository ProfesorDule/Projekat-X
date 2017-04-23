using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kretanje : MonoBehaviour {
    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;
    public GameObject Igrac;
    void Update()
    {
        
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;

        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);


        if (Igrac.transform.position.y < 15)
        {
            Debug.Log("Pali ste");
            Application.LoadLevel(0);
        }

        
    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Prepreka")
        {
            Debug.Log("Prepreka Udarena");
            Application.LoadLevel(0);
        }

        if (coll.gameObject.tag == "Cilj")
        {
            Debug.Log("Cilj dosegnut");
            Application.LoadLevel(0);
            
        }

    }
}
