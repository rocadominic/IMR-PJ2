using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderListener : MonoBehaviour
{
    GameObject msg;
    // Start is called before the first frame update
    void Start()
    {
        msg = GameObject.Find("WinMsg");
        msg.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "cub de luat" || collision.collider.name == "minge")
        {
            msg.SetActive(true);
        }
    }

}
