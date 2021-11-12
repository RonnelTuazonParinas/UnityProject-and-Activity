using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public GameObject target;
    UnityEngine.AI.NavMeshAgent agent;


    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        if(target == null)
        {
            target = GameObject.FindGameObjectWithTag("Player");
        }
    }

    // Update is called once per frame
    void Update()
    { 
        agent.destination = target.transform.position;

    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
            SceneManager.LoadScene("gameOver");
    }
}
