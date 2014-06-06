# Hunminjeongeum

A Korean initial consonant game where you score by typing real words that match the chosen initial consonants before time runs out. After two or three initial consonants are set, each typed word is checked letter by letter for the right initial consonant, and the search page of the Standard Korean Language Dictionary by the National Institute of Korean Language is parsed to decide whether the word is in the dictionary. Every accepted word raises the score and refills the remaining time. It was made as a school assignment.

<p>
  <img src="docs/screenshots/screenshot-1.png" width="480" alt="Game screen">
</p>


## How to play

Download from Releases and run it. .NET Framework 4.5 is required, and checking words uses an internet connection.

Pick the initial consonants of the first, second, and third letters in the three lists at the bottom and press "게임 시작" (start game). "랜덤 선택 시작" (random start) picks the consonants at random and starts right away. The lists hold the 14 consonants from ㄱ to ㅎ without the tense ones, and the third list has an extra blank entry at the top.

Type a word in the input box and press Enter or "입력" (enter). A two-letter word whose first and second letters match is always accepted, and when a third consonant is chosen, a three-letter word matching all three is accepted as well.

| Result | Effect |
|---|---|
| Word in the dictionary | Added to the list, score +1, remaining time reset to 15 seconds |
| Word already entered | "중복된 단어입니다." (duplicate word) |
| Wrong initial consonants or length | "문자 구성을 확인하세요." (check the letters) |
| Word not in the dictionary | "잘못된 단어입니다." (invalid word) |

The remaining time drops every second and pauses while the dictionary is being checked. When it reaches 0, the game ends and the final score is shown.


## How it works

**The initial consonant is computed from the Unicode position.** Hangul syllables are laid out from `0xAC00` in the order of 19 initial consonants, 21 vowels, and 28 final consonants, so subtracting `0xAC00` from the code and dividing by 28 and then by 21 gives the initial consonant number. The lists leave out the tense consonants, so converting a list index to an initial consonant number skips the positions of ㄲ, ㄸ, ㅃ, ㅆ, and ㅉ.

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

**Words are checked by reading the dictionary search result page.** When the initial consonants match, a `WebBrowser` that is never shown opens the search page of the Standard Korean Language Dictionary by the National Institute of Korean Language (`stdweb2.korean.go.kr`). In `DocumentCompleted`, the `td` whose `class` is `sword` is found, and if its text differs from the message for zero search results, the word counts as being in the dictionary. While waiting for the response, the input box and the timer are turned off.


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

CC BY-NC-ND 4.0. Unmodified copies may be shared for noncommercial purposes with attribution. Modified versions and commercial use are not allowed. Bundled libraries, graphics, sounds, and maps made by other people keep their own rights. See [LICENSE](LICENSE).
