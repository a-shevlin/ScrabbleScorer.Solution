# Scrabble Scorer

#### By _**Alex Shevlin, Zac Waggoner**_  

#### _{Brief description of application}_  

---

## Table of Contents

**[Technologies Used](#technologies-used)  
[Description](#description)  
[Setup and Installation](#setupinstallation-requirements)  
[Known Bugs](#known-bugs)  
[License](#license)  
[Tests](#tests)**

---
## Technologies Used

* _C#_
* _.NET_

---
## Description

_{This is a detailed description of your application. Give as much detail as needed to explain what the application does as well as any other information you want users or other developers to have.}_

---
## Setup/Installation Requirements

* Install *`Microsoft .NET SDK`*
* Place files in a folder named `ProjectName.Solution`
    <pre>ScrabbleScorer.Solution
    ├── ScrabbleScorer
    └── ScrabbleScorer.Tests</pre>
<details>
<summary><strong>To Run</strong></summary>
Navigate to  
   <pre>ScrabbleScorer.Solution
   ├── <strong>ScrabbleScorer</strong>
   └── ScrabbleScorer.Tests</pre>

Run ```$ dotnet run``` in the console
</details>

<details>
<summary><strong>For Testing</strong></summary>
Navigate to  
    <pre>ScrabbleScorer.Solution
    ├── ScrabbleScorer
    └── <strong>ScrabbleScorer.Tests</strong></pre>

Run ```$ dotnet test``` in the console

</details>
<br>

This program was built using *[Microsoft .NET SDK 5.0.401](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)*, and may not be compatible with other versions. Your milage may vary.

---
## Known Bugs

* _Any known issues_
* _should go here_

## License

[MIT](/LICENSE)

Copyright (c) 2022 Alex Shevlin, Zac Waggoner

### **Tests**

<table>
  <tr>
    <th>Describe</th>
    <th>Code</th>
    <th>Expected Output</th>
  </tr>
  <tr>
    <td>return input word to string</td>
    <td>
    string test = "test";
    <br>
    Word newWord = new Word(test);
    </td>
    <td>newWord.IsWord() is true</td>
  </tr>
    <tr>
    <td>check for word in string</td>
    <td>
    string test = "";
    <br>
    Word newWord = new Word(test);
    </td>
    <td>newWord.IsWord() is false</td>
  </tr>
    <tr>
    <td>return input word to an array</td>
    <td>
    string test = "test"
    <br>
    Word newWord = new Word(test);
    <br>
    newWord.SetInputArray();
    </td>
    <td>newWord.InputArray === {'t', 'e', 's', 't'}</td>
  </tr>
    <tr>
    <td>return score based on letter</td>
    <td>
    string test = "test";
    <br>
    Word newWord = new Word(test);
    <br>
    newWord.SetInputArray();
    <br>
    newWord.AddScore();
    </td>
    <td>newWord.WordScore === 4</td>
  </tr>
</table>