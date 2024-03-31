# Tic Tac Toe

Get three in a row of 'O' or 'X' to win. There are two players for this game and they both get to use a unique token 'O' or 'X'.

## Report

I chose to do 'Project - Simple Game' that being Tic Tac Toe.

I made a board game and token entities. The board game is a single entity, so I made a script in direct use of it while the tokens have a shared script, so I made a token prefab that each token will inherit to have the same actions and behavior. I used images for the two different tokens and the game board and use the token hitbox for the player to click to display either 'X' or 'O'. Once a token is set, it cannot be changed. The gameboard keeps track of the count index and would check if it's even or odd to change token for each click. The token script has an array tokens that has the two images of the tokens that was used to change it for each click. I built a tokens array in the board script so that I can do a win condition and also to get the coordinates, I made a TokenData script onto each token that has its own row and col data. The project took in a total of 6 hours since I was in the process of learning of Unity.

It took me some time to publish this game onto GitHub pages as it doesn't work with compression, so I had it disabled.
