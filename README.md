# Mastermind
ZVI Technologies - Test for Applicants

I just wrote a function where if the guess code "guess" is equals to the code "code"
the function instantly returns a list of 4 black pegs meaning the guess code was 
perfect.

Then if it's not the case the function will create a list "result" of "ResultPeg" where the function
is gonna build the result. then in a "for" loop that will loop for each element of the list "result"
to find when the [color,position] of the guess code "guess" is equals to the code "code" in this case 
the function will add a "ResulPeg.Black" to the list "result". 

In the other case when only the color
that its in the guess code "guess" match with any of the code "code" colors it will add a "ResultPeg.White"
to the list "result". 

And once the whole list "guess" is looped the function will return it with the bunch of pegs inside of it.

