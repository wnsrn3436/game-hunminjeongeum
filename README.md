# Hunminjeongeum

[한국어](README.ko.md)

A Korean initial consonant game where you score by typing real words that match the chosen initial consonants before time runs out. Once you set two or three initial consonants and start, the game checks each letter of a typed word for the right initial consonant and parses the search page of the National Institute of Korean Language's Standard Korean Language Dictionary to decide whether the word is in the dictionary. Every accepted word raises the score and refills the remaining time. It was made as a school assignment.

<p>
  <img src="docs/screenshots/screenshot-1.png" width="480" alt="Game screen">
</p>


## How to play

Download it from Releases and run it. It needs .NET Framework 4.5 and uses an internet connection to check words.

In the three lists at the bottom, pick the initial consonants for the first, second, and third letters, then press "게임 시작" (start game). "랜덤 선택 시작" (random start) picks the consonants at random and starts right away. The lists hold the 14 consonants from ㄱ to ㅎ, leaving out the tense ones, and the third list has one extra blank entry at the top.

Type a word in the input box and press Enter or "입력" (enter). A two-letter word with the right initial consonants in its first and second letters is always accepted, and if you chose a third consonant, a three-letter word that matches all three is accepted too.

| Result | Effect |
|---|---|
| Word in the dictionary | Added to the list, score +1, remaining time reset to 15 seconds |
| Word already entered | "중복된 단어입니다." (duplicate word) |
| Wrong initial consonants or length | "문자 구성을 확인하세요." (check the letters) |
| Word not in the dictionary | "잘못된 단어입니다." (invalid word) |

The remaining time goes down every second and stops while the dictionary is being checked. When it reaches 0, the game ends and shows the final score.


## How it works

**The initial consonant is computed from the Unicode position.** Hangul syllables start at `0xAC00` and are ordered as combinations of 19 initial consonants, 21 vowels, and 28 final consonants, so subtracting `0xAC00` from the code and dividing by 28 and then by 21 gives the initial consonant number. The lists leave out the tense consonants, so converting a list index to an initial consonant number skips the positions of ㄲ, ㄸ, ㅃ, ㅆ, and ㅉ.

```vb
Public Function WordCheck(ByVal word As Char, ByVal index As Integer) As Boolean
    If (index >= 1) Then index += 1
    If (index >= 4) Then index += 1
    If (index >= 8) Then index += 1
    If (index >= 10) Then index += 1
    If (index >= 13) Then index += 1
    If ((((AscW(word) - &HAC00) \ 28) \ 21) = index) Then Return True
    Return False
End Function
```

**Words are checked by reading the dictionary search result page.** When the initial consonants match, a hidden `WebBrowser` opens the search page of the National Institute of Korean Language's Standard Korean Language Dictionary (`stdweb2.korean.go.kr`). In `DocumentCompleted`, the code finds the `td` whose `class` is `sword`, and if its text differs from the message shown for zero search results, the word counts as being in the dictionary. The input box and the timer stay off while the game waits for the response.


## Files

| Path | Content |
|---|---|
| `source/HunMinJeongEum.sln` | Visual Studio 2013 solution |
| `source/HunMinJeongEum/Form1.vb` | Game flow, initial consonant check, dictionary lookup |
| `source/HunMinJeongEum/Form1.Designer.vb` | Form design |
| `source/HunMinJeongEum/Resources/` | Clock and target pictures |
| `docs/screenshots/` | Screenshots |
| Releases | Executable |


## License

CC BY-NC-ND 4.0. Unmodified copies may be shared for noncommercial purposes with attribution. Distributing modified versions and commercial use are not allowed. Bundled libraries, graphics, sounds, and maps made by other people keep their own rights. See [LICENSE](LICENSE).
