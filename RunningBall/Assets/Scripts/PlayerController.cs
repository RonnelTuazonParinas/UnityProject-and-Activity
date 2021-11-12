using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public float speed;
    private int count;
    public Text countText;
    private Rigidbody rb;
    public GameObject FinishLine;
    

	void Start () {
        rb = GetComponent<Rigidbody>();
        countText.text = "Score : 0";
    }
	
	// Update is called once per frame
	void Update () {
        float movementHorizontal = Input.GetAxis("Horizontal");
        float movementVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(movementHorizontal, 0.0f, movementVertical);

        rb.AddForce(movement * speed);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
        }
    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "EndLine")
        {
            FindObjectOfType<gameManager>().CompleteLevel();
        }
    }

    void SetCountText()
    {
        countText.text = "Score : " + count.ToString();

    }
}
