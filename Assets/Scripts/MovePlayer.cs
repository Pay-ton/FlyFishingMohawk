using System;
using UnityEngine;
using UnityEngine.UIElements;

public class MovePlayer : MonoBehaviour
{
    //Variables

    int timeSincePress;
    bool turnleft;

    public GameObject Spear;
    GameObject currentSpear;

    bool spearThrown = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            timeSincePress = 70;
            turnleft = true;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            timeSincePress = 70;
            turnleft = false;
        }
        timeSincePress--;
        if ((timeSincePress == 0)&&(turnleft == true))
        {
            
            transform.position = new Vector3(transform.position.x - 0.7f, transform.position.y, transform.position.z);
        }
        else if ((timeSincePress == 0) && (turnleft == false))
        {
            
            transform.position = new Vector3(transform.position.x + 0.7f, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ThrowSpear();
        }
          if (spearThrown == true)
        {
            currentSpear.transform.position = new Vector3(currentSpear.transform.position.x, currentSpear.transform.position.y + 0.8f, currentSpear.transform.position.z);
            if (currentSpear.transform.position.y > 10) { spearThrown = false; Destroy(currentSpear); }

        }
    }

    public void ThrowSpear(){
        if (spearThrown == false)
        {
            spearThrown = true;
            currentSpear = Instantiate(Spear);
            currentSpear.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            currentSpear.name = "Spear";

        }

    }
}
