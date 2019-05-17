### AnagramProject

Story time:
I was watching an episode of 8 out of 10 Cats Does Countdown. 
As I was sitting with my wife, I wondered whether the dictionary corner genuinely came up with their results or whether they used a program or script to do it.

I asked my wife if they did use a program, what would it look like? She said:

1) Find all combinations (anagrams) of the letters
2) Cross-reference it with the dictionary

And so this mini-project was born. 
- Get the permutation
- Query each character in the letter
  - Limit the query by length and first character
- Display results

### Summary

It was a fun project but isn't the most efficient, it only returns words of the same length and gets substancially slower once you enter longer words.
The time complexity of my solution is 0(n^2)  
 
