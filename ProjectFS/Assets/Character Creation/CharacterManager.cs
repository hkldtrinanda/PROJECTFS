using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public CharachterDataBase charachterDB;
    public SpriteRenderer theSR;
    public sop_panel sopPanel;
    public Button playButton;

    private int selectedOption;

    private void Start()
    {
        playButton.interactable = false;
        UpdateCharacter(selectedOption);
    }



    private void UpdateCharacter(int selectedOption)
    {
        Character character = charachterDB.GetCharacter(selectedOption);
        theSR.sprite = character.characterSprite;
        for (int i = 0; i < sopPanel.SopLists.Length; i++)
        {
            sopPanel.transform.GetChild(i).transform.GetChild(3).gameObject.SetActive(false);
        }

        for (int i = 0; i < character.sopDigunakan; i++)
        {
            sopPanel.transform.GetChild(i).transform.GetChild(3).gameObject.SetActive(true);
        }
        
        if(character == charachterDB.GetCharacter(5))
        {
            playButton.interactable = true;
        }



    }
    public void NextOption()
    {
        selectedOption++;
        if(selectedOption >= charachterDB.CharacterCount)
        {
            selectedOption = 0;
           
        }
        UpdateCharacter(selectedOption);

    }

   public void BackOption()
    {
        selectedOption--;
        if(selectedOption < 0)
        {
            selectedOption = charachterDB.CharacterCount - 1;
        }
        UpdateCharacter(selectedOption);
    }
}
