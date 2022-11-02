using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnTree : MonoBehaviour
{  
    public GameObject tree;
    public GameObject sphere;
    public GameObject effect;
    public Vector3 startingPosition;

    void Awake()
    {
        startingPosition = sphere.transform.position;
    }

    void OnCollisionEnter(Collision col) 
    {   
        if (col.collider.name == "Ground")
        {   
            Debug.Log("tree Planted");
            Vector3 position = col.contacts[0].point;
            GameObject plantedTree = (GameObject)Instantiate(tree, position, Quaternion.identity);
            GameObject plantedffect = (GameObject)Instantiate(effect, position, Quaternion.identity);
            
            GameObject newSphere = (GameObject)Instantiate(sphere, startingPosition, Quaternion.identity);
            Destroy(plantedffect, 4f);
            Destroy(gameObject);
        }
    }
}
