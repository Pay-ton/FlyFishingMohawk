using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CreateFish : MonoBehaviour
{
    public GameObject Fish;

    /*
     https://docs.unity3d.com/6000.3/Documentation/ScriptReference/Collider2D.html
     */
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
            fish.transform.position = new Vector3(joe, 7, transform.position.z);
            fish.name = "Fish";
        }


    }
}
