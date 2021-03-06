using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MoveCount : MonoBehaviour{
    public int turnCount = 0;
    public int turnsStart = 100;
    public Text movesUsed;

    void Start(){ movesUsed = GetComponent<Text>(); }

    // If player uses all moves in a level, game is over.
    public void CountMove(){
        turnCount++;
        movesUsed.text = "" + turnCount;
        if(turnsStart == turnCount){ FindObjectOfType<Movement>().Die(); }
    }

    /*
        MOVE COUNT RESET POWER-UP
    */

    public void Update(){
        if(Input.GetButtonDown("Jump")){ CountMove(); }
        if(Input.GetKeyDown(KeyCode.DownArrow)){ CountMove(); }
        if(Input.GetButtonDown("Horizontal")){ CountMove(); }
    }
}