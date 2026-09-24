using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    //Variables
    float speed = 5f;
    public GameObject Spear;
    GameObject currentSpear;
    int timeSincePress;

    bool spearThrown = false;

    // Update is called once per frame
    void Update()
    {
        // Horizontal Movement
        float movementX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        
        Vector3 position = transform.position;
        position.x += movementX;
        transform.position = position;

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

    public void ThrowSpear()
    {
        if (spearThrown == false)
        {
            spearThrown = true;
            currentSpear = Instantiate(Spear);
            currentSpear.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            currentSpear.name = "Spear";
        }
    }
}
