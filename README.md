# BlueBook
# BlueBook
! Database string path is currently hard-coded and needs to remain in the database folder.

Bluebook is a phonentic ambiguity searcher which enables the user to input a word or a phrase, and will return results containing the same phonetic sounds as those being input. 

For example: If I input the word "captain", one of the results returned will be "uncapped intuition". The ending of "uncapped" and the beginning of "intuition" have the same phonetics as "captain".

Bluebook achieves this by searching the input words in the database and finding their pairs which are strings consisting of characters from the international phonetic alphabet (examples of the IPA can be found at the beginning of wikipedia pages where it is used to inform readers of the pronounciation of a particular word or name). Bluebook will then add the IPA characters into a single string and proceed to make a list with of all other words with matching characters. After that, Bluebook uses an algorithm to sort those matching words into results where each result is made up from the matching words and does not contain any non-matching characters in the middle of the input word or phrase.

Two options to add "phonetic ambiguity" are available. An example of this are the sounds of both "T" and "D" being quite similar. Enabling the "all consonants" option will widen the scope of results. Similarly, the "all vowels" option will enable ambiguity among vowel phonetics.

Ambiguity process uses a BackgroundWorker to push the processing onto a separate thread and allow the UI to remain responsive.



