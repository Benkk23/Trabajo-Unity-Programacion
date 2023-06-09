using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    float horizontalInput;
    float verticalInput;
    public float playerSpeed; // Velocidad de mov del player
    public float rotationsSpeed; //Velocidad de rotacion del player
    public Animator anim; // animator
    public Rigidbody rb;
    public float jumpForce;
    public Animator jump;

    // Update is called once per frame
    void Update()
    {
        PlayerMove();

        playerjump();
      
        

       

    }

    void playerjump()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //SI presiono espacio
        {

            anim.SetBool("Jump", true);
        }
        else
        {
            anim.SetBool("Jump", false);
        }
    }
void PlayerMove()
    {
        horizontalInput = Input.GetAxis("Horizontal") * Time.deltaTime;
        verticalInput = Input.GetAxis("Vertical") * Time.deltaTime;


        transform.Rotate(0, horizontalInput * rotationsSpeed, 0);  //rotacion
        transform.Translate(0, 0, verticalInput * playerSpeed);  //movimiento

        if (Input.GetKeyDown(KeyCode.Space)) //SI presiono espacio
        {

            anim.SetBool("Jump", true);
        }
        else
        {
            anim.SetBool("Jump", false);
        }
            if (horizontalInput != 0) // Caminar Vertical
        {
            anim.SetBool("Walk", true);
        }
        else //si no
        {
            anim.SetBool("Walk", false);
        }

        if (verticalInput != 0)
        {
            anim.SetBool("Jump", false);
        }
        else
        {
            anim.SetBool("Jump", false);
        }
        
    }
    void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Gem"))
        {
            Destroy(collision.gameObject);

        }




    }




















}
