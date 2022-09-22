using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using UnityEngine.UI;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public CharachterDataBase charachterDB;
    public CharachterDataBase tempCharacterDB;
    public SpriteRenderer theSR;
    public sop_panel sopPanel;
    public Button playButton;
    public Animator canvasAnim;
    public GameObject[] sopBoxes;
    private int selectedOption;
    private Character tempChar;
    public bool doRandom;
    public int randomCharFrom = 0;

    private void Awake()
    {
        for(int i = 0; i < tempCharacterDB.character.Length; i++)
        {
            charachterDB.character[i] = tempCharacterDB.character[i];
        }
    }

    private void Start()
    {
        playButton.interactable = false;
        
        if (sopPanel.doneCalculate)
        {
            for (int i = 0; i < sopPanel.SopLists.Length; i++)
            {
                sopBoxes[i] = sopPanel.transform.GetChild(i+1).gameObject;
            }
        }
        shuffleCharacterOrder();
        UpdateCharacter(selectedOption);

    }



    private void UpdateCharacter(int selectedOption)
    {
        Character character = charachterDB.GetCharacter(selectedOption);
        theSR.sprite = character.characterSprite;
        sopBoxReset();
        sopCheck(character);

        if (character == charachterDB.GetCharacter(5))
        {
            playButton.interactable = true;
        }
        else if (character != charachterDB.GetCharacter(5))
        {
            playButton.interactable = false;
        }
    }
    public void NextOption()
    {

         selectedOption++;
        if (selectedOption >= charachterDB.CharacterCount)
        {
            selectedOption = 0;

        }
        UpdateCharacter(selectedOption);

    }

    public void BackOption()
    {
        selectedOption--;
        if (selectedOption < 0)
        {
            selectedOption = charachterDB.CharacterCount - 1;
        }
        UpdateCharacter(selectedOption);
    }

    void sopCheck(Character characterToCheck)
    {
        for(int x = 0; x < characterToCheck.sopTerpakai.Length; x++)
        {
            if(characterToCheck.sopTerpakai[x] == true)
            {
                sopBoxes[x].transform.GetChild(3).gameObject.SetActive(true);
            }
        }
    }


    void sopBoxReset()
    {
        for (int i = 0; i < sopBoxes.Length; i++)
        {
            sopBoxes[i].transform.GetChild(3).gameObject.SetActive(false);
        }
    }

    void shuffleCharacterOrder()
    {
        if (doRandom)
        {
              for (int i = randomCharFrom; i < charachterDB.character.Length; i++)
            {
                int rnd = Random.Range(randomCharFrom, charachterDB.character.Length);
                tempChar = charachterDB.character[rnd];
                charachterDB.character[rnd] = charachterDB.character[i];
                charachterDB.character[i] = tempChar;
            }
        
        
        }
          
    }

}
