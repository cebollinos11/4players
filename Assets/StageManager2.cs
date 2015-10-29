using UnityEngine;
using System.Collections;

public class StageManager2 : MonoBehaviour {


    public string name;
    public string description;
    public Transform[] SpawnList;

    private GameManager GM;
    

	// Use this for initialization
	void Start () {

        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
        //Invoke("BuildStage", 0.01f);
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void BuildStage() {

        Debug.Log("Spawning chars");
        SpawnCharacters();
        
    }


    public void SpawnCharacters()
    {
        
        var i = 0;
        foreach (Transform SpawnPoint in SpawnList)
        {
            Debug.Log("Spawning char");
            if (GM.Players[i].Active)
            {
                //instantiate player
                GameObject p = (GameObject)Instantiate(GM.PlayerPrefab, SpawnPoint.position, SpawnPoint.rotation);
                // set color
                p.GetComponent<Renderer>().material.color = GM.Players[i].Color;
                p.name = GM.Players[i].name;
            }
            else { Debug.Log("not active"); }

            i++;


        }

    }
}
