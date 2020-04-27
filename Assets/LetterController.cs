using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterController : MonoBehaviour
{
    // Start is called before the first frame update
    public float xMin=-7.5f;
    public float xMax=7.5f;
    public float yMin=-3.5f;
    public float yMax=3.5f;
    public float lifetime = 1f;
    public char letterValue;
    public int spriteNumber;
    protected SpriteRenderer letterSpriteRenderer;
    public Sprite[] alphabetSprites;
    void Start()
    {
    	// Debug
        Destroy(gameObject, lifetime);
        alphabetSprites = Resources.LoadAll<Sprite>("Sprites/alphabet");
        spriteNumber = (int)char.ToLower(letterValue)-97; 
        GetComponent<SpriteRenderer>().sprite = alphabetSprites[spriteNumber];
        transform.position = new Vector3 (Random.Range (xMin, xMax), Random.Range (yMin, yMax),0);
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
