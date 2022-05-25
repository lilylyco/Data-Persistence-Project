using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StateManager : MonoBehaviour
{
    public static StateManager Instance;
    public string PlayerName;

    public InputField input;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        if (StateManager.Instance != null)
        {
            PlayerName = StateManager.Instance.PlayerName;
        }
    }

    public void BeginGame()
    {
        Instance.PlayerName = input.text;
        SceneManager.LoadScene("main");
    }
}
