using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelection : MonoBehaviour
{
    [SerializeField] GameObject[] characters;
    private int activeCharacter = 0;

    void Start()
    {
        for (int i=1; i < characters.Length; i++)
        {
            characters[i].SetActive(false);
        }
    }

    public void Change()
    {
        activeCharacter++;

        if (activeCharacter > characters.Length - 1)
        {
            activeCharacter = 0;
        }

        for (int i=0; i < characters.Length; i++)
        {
            characters[i].SetActive(false);
        }
        characters[activeCharacter].SetActive(true);
    }
}
