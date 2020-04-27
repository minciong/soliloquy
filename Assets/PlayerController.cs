using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	protected GameObject actor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Camera camera = GetComponent<Camera>();
        var mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        char letterIn;
        Vector3 pos;
        this.transform.position = new Vector3(mouse.x, mouse.y, 0);
        foreach(KeyCode vKey in System.Enum.GetValues(typeof(KeyCode))){
             if(Input.GetKeyDown(vKey)&& char.IsLetter(vKey.ToString()[0]) && vKey.ToString().Length == 1){
             //your code here
                letterIn = char.ToLower(vKey.ToString()[0]);
                pos = transform.position;
                GameObject[] letters = GameObject.FindGameObjectsWithTag("Letter");
		        LetterController letterscript;
		        Vector3 letterpos;
		        char letterval;
		        foreach(GameObject letter in letters){
		        	letterscript = letter.GetComponent<LetterController>();
		        	letterpos = letterscript.transform.position;
		        	letterval = letterscript.letterValue;
		        	if(letterval==letterIn){
		        		Vector3 diff = (letterpos - pos);
        				float curDistance = diff.sqrMagnitude;
        				// Debug.Log(curDistance);
        				if(curDistance<2){
        					int scorevalue = (int)((2-curDistance)*100);
        					// Debug.Log(scorevalue);
        					GameObject.Find("GameController").GetComponent<GameController>().UpdateScore(scorevalue);
        				}
        				Object.Destroy(letter);
		        	}
		        	else{
		        		Object.Destroy(letter);
		        	}
		        }
             }
         }

		// Event e = Event.current;
     
     //Check the type of the current event, making sure to take in only the KeyDown of the keystroke.
     //char.IsLetter to filter out all other KeyCodes besides alphabetical.
         
    }
}
