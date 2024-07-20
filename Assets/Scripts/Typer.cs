using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Typer : MonoBehaviour
{
    public Text wordOutput = null;
    private string remainingWord = string.Empty;
    private string currentWord = "I want to buy the muffins. The muffins tasted good. " +
    "They tasted like blueberries. My mom killed herself after the divorce.";

    int removedCount = 0;
    int initialLength = 0;

    // Start is called before the first frame update
    private void Start()
    {
        SetCurrentWord();
    }

    private void SetCurrentWord(){
        //Get bank word
        SetRemainingWord(currentWord);
        initialLength = currentWord.Length;
        removedCount = 0;
    }

    private void SetRemainingWord(string newString){
        remainingWord = newString;
        wordOutput.text = remainingWord;
    }

    // Update is called once per frame
    private void Update()
    {
        CheckInput();
    }

    private void CheckInput(){
        if(Input.anyKeyDown){
            string keysPressed = Input.inputString;
            if (keysPressed.Length == 1){
                EnterLetter(keysPressed); 
            }
        }
    }

    private void EnterLetter(string typedLetter){
        if(IsCorrectLetter(typedLetter)){
            RemoveLetter();
            if(IsWordComplete()){
                SetCurrentWord(); 
            }
        }
    }

    private bool IsCorrectLetter(string letter){
        return remainingWord.IndexOf(letter, removedCount) == 0+removedCount;
    }

    private void RemoveLetter(){
        string newString = remainingWord.Remove(0+removedCount,1); 
        SetRemainingWord(" " + newString);
        removedCount++;
    }

    private bool IsWordComplete(){
        return removedCount == initialLength;
    }
}
