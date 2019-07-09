using System;
using System.Collections.Generic;

namespace list_of_dictionaries_about_words
{
  class Program
  {
    static void Main(string[] args)
    {
      // Make a new list
      List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

      /*
          You want to track the following about each word:
              word, definition, part of speech, example sentence

          Example of one dictionary in the list:
          {
              "word": "excited",
              "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
              "part of speech": "adjective",
              "example sentence": "I am excited to learn C#!"
          }
      */

      // Create dictionary to represent a few words
      Dictionary<string, string> firstWord = new Dictionary<string, string>() {
              {"word", "excited"},
              {"definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness"},
              {"part of speech", "adjective"},
              {"example sentence", "I am excited to learn C#!"}
      };

      dictionaryOfWords.Add(firstWord);

      Console.WriteLine();
      Console.WriteLine("After first word added:");
      dictionaryOfWords.ForEach(dictionary =>
      {
        foreach (KeyValuePair<string, string> word in dictionary)
        {
          Console.WriteLine(word);
        }
      });

      // Add each of the 4 bits of data about the word to the Dictionary
      // excitedWord.Add();

      // Add Dictionary to your `dictionaryOfWords` list

      // create another Dictionary and add that to the list

      Dictionary<string, string> secondWord = new Dictionary<string, string>();
      secondWord.Add("word", "word");
      secondWord.Add("definition", "a string of characters that may or may not make sense");
      secondWord.Add("part of speech", "noun?");
      secondWord.Add("example sentence", "here is a word");

      dictionaryOfWords.Add(secondWord);

      Console.WriteLine();
      Console.WriteLine("After second word added:");
      dictionaryOfWords.ForEach(dictionary =>
      {
        foreach (KeyValuePair<string, string> word in dictionary)
        {
          Console.WriteLine(word);
        }
      });


      /*
          Iterate your list of dictionaries and output the data, You can use the two foreach() loops below to help you start your iteration.

          Example output for one word in the list of dictionaries:
              word: excited
              definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
              part of speech: adjective
              example sentence: I am excited to learn C#!
      */

      Console.WriteLine();
      Console.WriteLine("how the exercise would like me to iterate: ");
      // Iterate the List of Dictionaries
      dictionaryOfWords.ForEach(dictionary =>
      {

        // Iterate the KeyValuePairs of the Dictionary
        foreach (KeyValuePair<string, string> wordData in dictionary)
        {
          Console.WriteLine($"{wordData.Key}: {wordData.Value}");
        }
      });
    }
  }
}
