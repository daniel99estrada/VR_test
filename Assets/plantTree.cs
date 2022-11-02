using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantTree : MonoBehaviour
{   

    public GameObject tree;
    public GameObject sphere;
    public Vector3 sphereStartPosition;

    void Awake()
    {
        sphereStartPosition = sphere.transform.position;
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Ground")
        {   
            Instantiate(tree, col.contacts[0].point, Quaternion.identity);
            Instantiate(sphere, sphereStartPosition, Quaternion.identity);

            Destroy(this.gameObject, 3f);

        }

        
    }
}
