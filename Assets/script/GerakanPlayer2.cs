using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GerakanPlayer2 : MonoBehaviour
{
    public MyJoystick joystick;
    public GameObject myCharacter;
    [Header("Kecepatan")]
    public float kecepatan;
    // Rigidbody rb;
    // Animator anim;
     [Header ("Rotasi Player")]
    public Animator animator;

    public void Awake()
        {
            // rb = GetComponent<Rigidbody>();
            // anim = GetComponent<Animator>();
        }
    public CharacterController characterController;
    
    // Start is called before the first frame update
    void Start()
    {  
        animator = myCharacter.GetComponent<Animator>();
        // Rotation();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
        // Rotation();
    }

    void Movement()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        float moveAnim = new Vector2(moveX, moveZ).magnitude;
        animator.SetFloat("Movement", moveAnim, 0.1f, Time.deltaTime);
        // rb.velocity = Vector3.right * moveX * kecepatan;
        // anim.SetFloat("Kecepatan", Mathf.Abs(moveX), 0.1f, Time.deltaTime);
        // rb.velocity = Vector3.right * moveZ * kecepatan;
        // anim.SetFloat("Kecepatan", Mathf.Abs(moveZ), 0.1f, Time.deltaTime);
     
        
        Vector3 movement = new Vector3(moveX,  -1, moveZ);
        movement = transform.TransformDirection(movement);

       
        characterController.Move(movement * kecepatan * Time.deltaTime) ;
        

        this.gameObject.transform.position += this.gameObject.transform.forward * Time.deltaTime * (kecepatan * joystick.Vertical());
        this.gameObject.transform.position += this.gameObject.transform.right * Time.deltaTime * (kecepatan * joystick.Horizontal());
       
        if(joystick.Vertical() !=0 || joystick.Horizontal() !=0){
            //jalankan animasi
            animator.SetBool("isRunning", true);
        }
        //  movement = transform.TransformDirection(movement);
        // anim.SetFloat("Kecepatan", Mathf.Abs(moveZ), 0.1f, Time.deltaTime);
        // anim.SetFloat("Kecepatan",  z(moveX), 0.1f, Time.deltaTime);
        // playerPutaran.localEulerAngles = new Vector3(0, moveZ * 90, 0);
        //         playerPutaran.localEulerAngles = new Vector3(0, moveX * 90, 0);


        //  transform.Translate(new Vector3(gerakHorizontal, 0, gerakVertical) * (kecepatan * Time.deltaTime));
        //  rb.velocity =  Vector3.right * gerakHorizontal * kecepatan;
      

        //  playerPutaran.localEulerAngles = new Vector3(0, gerakHorizontal * 90, 0);
        //  rb.velocity = Vector3.forward * gerakVertical * kecepatan;
         

    }
    // void Rotation()
    // {
    //     rotation.x += Input.GetAxis("Mouse X") * rotationSpeed;
    //     rotation.y += Input.GetAxis("Mouse Y") * rotationSpeed;

    //     rotation.y = Mathf.Clamp(rotation.y, -10, 10);

    //     transform.localRotation = Quaternion.Euler(rotation.y, rotation.x, 0);
    // }
}
