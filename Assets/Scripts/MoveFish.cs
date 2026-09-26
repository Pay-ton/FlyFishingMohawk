using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;

public class MoveFish : MonoBehaviour
{
    int xPos;
    public BoxCollider2D spearHit;
    public CapsuleCollider2D fishCollider;
    public static int score = 0;
    public static TMP_Text scoreObject;
    GameObject scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fishCollider = GetComponent<CapsuleCollider2D>();
        xPos = Random.Range(-10, 10);
        /* Used to figure out random int generator
         https://discussions.unity.com/t/how-do-you-generate-multiple-unique-random-numbers-within-a-range-based-on-a-seed/813803
         */

         scoreText = GameObject.FindGameObjectWithTag("Score");
        scoreObject = scoreText.GetComponent<TMP_Text>();
        

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > -6)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.01f, transform.position.z);
        } 
        else if (transform.position.y <= -6)
        {
            Destroy(gameObject);
        }

        GameObject spear = GameObject.FindGameObjectWithTag("Spear");

        if (spear != null)
        {
            spearHit = spear.GetComponent<BoxCollider2D>();

            if (fishCollider.IsTouching(spearHit))
            {
                score++;

                scoreObject.text = "Score: " + score;
                Destroy(gameObject);
            }
        }
    }
}
