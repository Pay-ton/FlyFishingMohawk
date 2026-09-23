using UnityEngine;

public class CreateFish : MonoBehaviour
{
    public GameObject Fish;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {       
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Fish") == null)
        {
            int joe = Random.Range(-10, 10);
            GameObject fish = Instantiate(Fish);
            fish.transform.position = new Vector3(joe, transform.position.y, transform.position.z);
            fish.name = "Fish";
        }
    }
}
