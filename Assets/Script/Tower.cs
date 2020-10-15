using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    private PlayerController playerController;

    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
       
    }
    void OnMouseDown()
    {
        //Change tower color back to green as indicator
        gameObject.GetComponent<SpriteRenderer>().color = Color.green;
        playerController.closestTower = gameObject;

    }
    
    void OnMouseUp()
    {
        //Change tower color back to normal as indicator
        gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        playerController.closestTower = null;
    }
}
