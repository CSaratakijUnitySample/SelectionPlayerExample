using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UICharacterSelection : MonoBehaviour
{
    public void OnSelectCharacter(int index)
    {
        Global.SelectCharacterIndex = index;
    }

    public void OnClickPlay()
    {
        SceneManager.LoadScene(1);
    }
}

