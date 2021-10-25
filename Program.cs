using System;

namespace pendu
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomWord word = RandomWord.constructor();

            string wordToGuess = word.getWordToGuess();

            Play play = Play.constructor(wordToGuess, 5);
            Console.Write("Tapez une lettre : ");
            while(true){
                string letter = Console.ReadLine();
                if(letter.Length != 1){
                    Console.Write("Une seul lettre à la fois ne peut etre rentré");
                    continue;
                }
                int flag = play.addUserLetter(letter[0]);
                switch(flag){
                    case Errors._success :
                        Console.Write("La lettre existe dans le mot");
                    break;
                    case  Errors._endGame : 
                        Console.Write("vous avez gagné");
                    return;
                    case Errors._letterAlreadyExists : 
                        Console.Write("Vous avez deja tapez cette lettre");
                    break;
                    case Errors._letterNotInWord : 
                        Console.Write("la lettre n'est pas dans le mot");
                    break;
                    case Errors._youDie : 
                        Console.Write("vous avez perdu");
                    return;
                }
                Console.WriteLine("");
                Console.WriteLine(play.getWordToDisplay());
                string letterUser = play.getUserLetter();
                
                Console.Write("Les lettres que vous avez tapez : " );
                for(int i = 0; i < letterUser.Length; i++ ){
                    Console.Write(letterUser[i] + " ");
                }
                
                Console.Write("\n");
                Console.WriteLine("votre nombre d'essai restant : " + play.getNumberTry());

            }

        }
    }
}
