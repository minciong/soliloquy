using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour
{
    

     public float nextSpawn = 1f;
     public float countdown = 1f;
     public int sIndex=0;
     public GameObject letterPrefab;
     public string soliloquy;
    void Start()
    {
        soliloquy = "tomorrowandtomorrowandtomorrowcreepsinthispettypacefromdaytodaytothelastsyllableofrecordedtimeandallouryesterdayshavelightedfoolsthewaytodustydeathoutoutbriefcandlelifesbutawalkingshadowapoorplayerthatstrutsandfretshishouruponthestageandthenisheardnomoreitisataletoldbyanidiotfullofsoundandfurysignifyingnothing";
    }

    // Update is called once per frame
    void Update()
    {
         countdown -= Time.deltaTime;
         if(countdown <= 0)
         {
             countdown = nextSpawn;
            if(sIndex<soliloquy.Length){
             SpawnLetter(soliloquy[sIndex]);
         		sIndex++;
         	}
         	else{
         		SceneManager.LoadScene("GameOverScene");
         	}
         }

    }
    void SpawnLetter(char c){
    	// Vector3 pos = new Vector3 (Random.Range (xMin, xMax), Random.Range (yMin, yMax),0);

    	GameObject letter = Instantiate(letterPrefab,transform.position,Quaternion.identity);
    	LetterController letterscript = letter.GetComponent<LetterController>();
    	letterscript.letterValue = c;
    	
    }
}
