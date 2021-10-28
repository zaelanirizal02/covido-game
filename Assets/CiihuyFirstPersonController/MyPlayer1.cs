using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MyPlayer1 : MonoBehaviour {
	public float speed;
	private Rigidbody rb;
	public MyJoystick joystick;
	public GameObject myCharacter;
	Animator  charAnimator;
	public Transform playerPutaran;


	void Start () {
		rb = GetComponent<Rigidbody> ();
		charAnimator = myCharacter.GetComponent<Animator>();
	}

	void FixedUpdate () {
		//Vector3 movement = new Vector3 (joystick.Horizontal () * Time.deltaTime, 0.0f, joystick.Vertical() * Time.deltaTime);
		//rb.AddForce (movement * speed);
        this.gameObject.transform.position += this.gameObject.transform.forward * Time.deltaTime * (speed * joystick.Vertical());
        this.gameObject.transform.position += this.gameObject.transform.right * Time.deltaTime * (speed * joystick.Horizontal());
				// float gerak = Input.GetAxis("Horizontal");
				// playerPutaran.localEulerAngles = new Vector3(0, gerak * 90, 0);

        if(joystick.Vertical() !=0 || joystick.Horizontal() !=0){
            //jalankan animasi
            charAnimator.SetBool("isRunning", true);
        }else{
			//stop animasi
			charAnimator.SetBool("isRunning", false);
		}
    }
}
