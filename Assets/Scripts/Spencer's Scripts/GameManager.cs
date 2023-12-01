using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject battleButton;
    public bool isPressed = false;

    // Start is called before the first frame update
    void Start()
    {
        //Makes sure only one instance is active
        if (instance == null){
            instance = this;
        }   
        battleButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //When a player ship collides with an enemy ship, sets the battle button to be active
    void OnCollisionEnter (Collision collision) {
        Debug.Log("Collided With Something");
        if (collision.gameObject.tag == "Enemy" ) {
            Debug.Log("Collided With Enemy");
            battleButton.SetActive(true);
        }
    }
}
