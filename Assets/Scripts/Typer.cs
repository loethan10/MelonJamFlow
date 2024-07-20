using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Typer : MonoBehaviour
{
    public WordBank wordBank = null; 
    public Text wordOutput = null;
    private string remainingWord = string.Empty;
    private string currentWord = string.Empty;

    int removedCount = 0;
    int initialLength = 0;

    // Start is called before the first frame update
    private void Start()
    {
        SetCurrentWord();
    }

    private void SetCurrentWord(){
        //Get bank word
        currentWord = wordBank.GetWord();
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
                RectTransform rt = wordOutput.GetComponent<RectTransform>();
                rt.anchoredPosition = new Vector3(250f, 0f, 0f);
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
