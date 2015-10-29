using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class stageController : MonoBehaviour {

    public GameObject instructionsPanel;
    private StageManager2 SM;
    private string stageStatus = "";
	// Use this for initialization
	void Start () {
        SM = GetComponent<StageManager2>();
        Invoke("StartGeneration", 0.01f);

        
	}
    void StartGeneration() {

        SM.BuildStage();
        stageStatus = "showing_instructions";
        ShowInstructions();

    }
    void ShowInstructions() {

        instructionsPanel.transform.FindChild("StageName").GetComponent<Text>().text = SM.name;
        instructionsPanel.transform.FindChild("InstructionText").GetComponent<Text>().text = SM.description;
        //instructionsPanel.transform.FindChild("StartButton").GetComponent<Button>().onClick.AddListener(()=> PlayerClickedOnInstructionsButton());
        instructionsPanel.gameObject.SetActive(true);

    }

    void HideInstructions() {
        instructionsPanel.gameObject.SetActive(false);

    }
	// Update is called once per frame

  
	
    void Update () {

        if (Input.GetKeyDown(KeyCode.Space)) {
            GUIContinue();
        }
	
	}

    void GUIContinue() {
        Debug.Log("continue");
        switch (stageStatus) { 
        
            case "showing_instructions":
                HideInstructions();
                break;
        
        }
    }

}
