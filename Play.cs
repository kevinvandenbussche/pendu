using System;
class Play{
    private string _userLetters;
    private string _wordToDisplay;
    private string _wordToFind;
    
    private uint _numberTry;

    public static Play constructor(string wordToFind, uint numberTry){
        //remplace les caracteres du mot à deviner par des _
        if(wordToFind.Contains("_")){
            return null;
        }
        Play play = new  Play();
        //j'instancie mes variables
        play._userLetters = "";
        play._wordToFind = wordToFind;
        play._numberTry = numberTry;
        //je verifie le nombre de caractere du mot à deviner
        for(int value = 0; value < wordToFind.Length; value++){
            play._wordToDisplay += "_";
        }
        
        return play ;
    }

   public string getUserLetter(){
       return _userLetters;
   }
    public uint getNumberTry(){
        return _numberTry;
    }

    public string getWordToDisplay(){
        return _wordToDisplay;
    }

    void setNumberTry(uint live){
        this._numberTry = live;
    }

    public int addUserLetter(char letter){
        if(_numberTry == 0){
            return Errors._noMoreTry;
        }

        if(_userLetters.Contains(letter)){
            return Errors._letterAlreadyExists;
        }
        // me permet de concatener des les lettres tapez  par l'utilisateur dans l'attribut _userLetter
        _userLetters += letter;

        if(!_wordToFind.Contains(letter)){
            //enleve un essai a chauqe lettre tapez
            _numberTry --;
            if(_numberTry == 0){
                return Errors._youDie;
            }
            return Errors._letterNotInWord;
        }
        // pour remplacer les _ par les lettres tapez par l'utilisateur
        for(int i = 0; i < _wordToFind.Length;  i++){
            if(_wordToFind[i] == letter){
                _wordToDisplay = _wordToDisplay.Remove(i, 1);
                _wordToDisplay = _wordToDisplay.Insert(i, letter.ToString());
                
            }
        }

        if(!_wordToDisplay.Contains("_")){
            return Errors._endGame;
        }
        return Errors._success;
    }
}