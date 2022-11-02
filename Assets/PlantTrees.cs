using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantTrees : MonoBehaviour
{  
    public GameObject tree;
    public GameObject sphere;
    public GameObject effect;

    void OnCollisionEnter(Collision col) 
    {   
        if (col.collider.name == "Ground")
        {
            Vector3 position = col.contacts[0].point;
            GameObject plantedTree = (GameObject)Instantiate(tree, position, Quaternion.identity);
            GameObject plantedffect = (GameObject)Instantiate(effect, position, Quaternion.identity);
            
            GameObject newSphere = (GameObject)Instantiate(tree, sphere.transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(plantedffect, 0f);
        }
    }
}
