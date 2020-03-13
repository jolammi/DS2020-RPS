using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneChangerScript : MonoBehaviour
{
    [SerializeField]
    public static GameObject opening;
    public static GameObject gameRoom;

    public GameObject openingScene;
    public GameObject gameRoomScene;

    // Start is called before the first frame update
    void Start()
    {
        // Getting references for the gameobject of the scenes //
        opening = openingScene = GameObject.Find("Opening");
        gameRoom = gameRoomScene = GameObject.Find("GameRoom");
        // Hides other than opening scene //
        SceneChanger(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // Hndles the changing of the scenes //
    public static void SceneChanger(int sceneNumber)
    {
        switch (sceneNumber)
        {
            case 1:
                opening.SetActive(true);
                gameRoom.SetActive(false);
                break;
            case 2:
                opening.SetActive(false);
                gameRoom.SetActive(true);
                break;
        }
    }

    // Quit button Handling // 
    public void QuitGame()
    {
        Application.Quit();
    }
}
