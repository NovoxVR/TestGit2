using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Girl : MonoBehaviour
{
    public float velocity;
    private Vector3 vec;
    public Transform[] lootPosition;
    public GameObject[] chests;
    public GameObject playerToFollow;







    void Start()
    {
        






    }

    
    void Update()
    {

        vec.y = Input.GetAxis("Horizontal") * Time.deltaTime * velocity;




    }
}
