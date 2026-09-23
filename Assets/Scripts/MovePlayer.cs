using UnityEngine;
using UnityEngine.UIElements;

public class MovePlayer : MonoBehaviour
{
    //Variables

    int timeSincePress;
    bool turnleft;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            timeSincePress = 70;
            turnleft = true;
        }
        if (Input.GetKeyDown(KeyCode.D))
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
    }
}
