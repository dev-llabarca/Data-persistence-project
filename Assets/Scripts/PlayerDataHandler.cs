using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
    using UnityEditor;
#endif
using UnityEngine.SceneManagement;

public class PlayerDataHandler : MonoBehaviour
{
    //Static Class for save the current player data;
    //Singleton pattern
    public static PlayerDataHandler Instance;
    public string PlayerName;
    public int Score;
    private void Awake()
    {
        //we dont actually need this if statement because when we are in the Main Scene
        //we cant return to the Start Menu Scene where the Player Data Handle Object already exists.
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
