//Prompt
  //console app that takes a word and returns the scrabble score for that word.
  //A, E, I, O, U, L, N, R, S, T == 1
  //D, G                         == 2
  //B, C, M, P                   == 3
  //K                            == 5
  //J, X                         == 8
  //Q, Z                         == 10

//Requirements

//Further Exploration




using System;

namespace ScrabbleScorer
{
  public class Word
  {
    public string Input { get; set; }
    public char[] InputArray { get; set;}
    // properties, constructors, methods, etc. go here
    public Word(string input) {
      Input = input;
      char[] arrayed = new char[input.Length];
      InputArray = arrayed;

    }

    public bool IsWord()
    {
      if(this.Input != "") 
      {
        return true;
      }
      else 
      {
        return false;
      }
    }

    public void SetInputArray() 
    {
      for (int i = 0; i < this.Input.Length; i++)
      {
        this.InputArray[i] = this.Input[i];
      }
    }
  }
}