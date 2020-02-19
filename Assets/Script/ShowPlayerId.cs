using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPlayerId : MonoBehaviour
{
    // Cached references
    [SerializeField] public GameManager gameManager;
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        gameObject.GetComponent<Text>().text = gameManager.PlayerId;
    }
}
