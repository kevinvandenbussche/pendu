using System;
using System.Text;
class RandomWord{   
    private string _wordToGuess;
    public string setWordToGuess(string value){
        return this._wordToGuess = value;
    }

    public string getWordToGuess(){
        return this._wordToGuess;
    }

    public static RandomWord constructor(){
        RandomWord theRandomWord = new RandomWord();

        string[] word = {"coucou", "demain", "microsoft" };

        Random number = new Random();

        int index = number.Next(word.Length);

        theRandomWord.setWordToGuess(word[index]);

        return theRandomWord;
        
    }

}
   

