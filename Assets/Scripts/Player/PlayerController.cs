using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    Sprite[] characterSprites;


    SpriteRenderer spriteRenderer;


    void Awake()
    {
        Initialize();
        LoadCharacterPreference();
    }

    void Update()
    {
        InputHandler();
    }

    void Initialize()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void LoadCharacterPreference()
    {
        spriteRenderer.sprite = characterSprites[Global.SelectCharacterIndex];
    }

    void InputHandler()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            SceneManager.LoadScene(0);
        }
    }
}

