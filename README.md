# BlueBook
! Database string path is currently hard-coded and needs to remain in the database folder.

Bluebook is a phonentic ambiguity searcher which enables the user to input a word or a phrase, and will return results containing the same phonetic sounds as those being input. 

For example: If I input the word "captain", one of the results returned will be "uncapped intuition". The ending of "uncapped" and the beginning of "intuition" have the same phonetics as "captain".

Bluebook achieves this by searching the input words in the database and finding their pairs which are strings consisting of characters from the international phonetic alphabet (examples of the IPA can be found at the beginning of wikipedia pages where it is used to inform readers of the pronounciation of a particular word or name). Bluebook will then add the IPA characters into a single string and proceed to make a list with of all other words with matching characters. After that, Bluebook uses an algorithm to sort those matching words into results where each result is made up from the matching words and does not contain any non-matching characters in the middle of the input word or phrase.

Two options to add "phonetic ambiguity" are available. An example of this are the sounds of both "T" and "D" being quite similar. Enabling the "all consonants" option will widen the scope of results. Similarly, the "all vowels" option will enable ambiguity among vowel phonetics.

For inputs over 2 words long, Bluebook can take quite some time to process a list of results, as the possibilities can be quite large. Asynchronous processing has not yet been implemented in Bluebook, so at the moment the user can expect the user interface to remain unresponsive whilst Bluebook processes results.



