# Importing the necessary functions from modules.
from random import choice

try:

    # Getting the necessary values from the user and setting the required variables.
    rounds = int(input("Enter the number of rounds: "))
    points, botPoints, Rounds = 0,0, rounds

    if rounds % 2 == 1:

        while Rounds != 0:

            move = input("Enter your move ('rock' / 'paper' / 'scissors'): ").lower()
            botMove = choice(["rock","paper","scissors"])

            if move == "rock" and botMove == "paper":

                print("The bot chose paper while you chose rock. The bot got a point!")
                botPoints += 1

            if move == "rock" and botMove == "rock":

                print("You both chose rock. Noone got a point!")

            if move == "rock" and botMove == "scissors":

                print("The bot chose scissors while you chose rock. You got a point!")
                points += 1

            if move == "paper" and botMove == "scissors":

                print("The bot chose scissors while you chose paper. You got a point!")
                botPoints += 1

            if move == "paper" and botMove == "paper":

                print("You both chose paper. Noone got a point!")

            if move == "paper" and botMove == "rock":

                print("The bot chose rock while you chose paper. The bot got a point!")
                points += 1

            if move == "scissors" and botMove == "rock":

                print("The bot chose rock while you chose scissors. The bot got a point!")
                botPoints += 1

            if move == "scissors" and botMove == "scissors":

                print("Both of you chose scissors. Noone got a point!")

            if move == "scissors" and botMove == "paper":

                print("The bot chose paper while you chose scissors. You got a point!")
                points += 1

            Rounds -= 1

            if move not in ["rock", "paper", "scissors"]:

                Rounds += 1
                print("Please enter a valid move.")

        if botPoints > points:

            print(f"The bot won!\n\nYour points:\t\tBot points:\n\n{points}\t\t\t{botPoints}")

        elif points > botPoints:

            print(f"You won!\n\nYour points:\t\tBot points:\n\n{points}\t\t\t{botPoints}")

        else:

            print(f"It is a draw!\n\nYour points:\t\tBot points:\n\n{points}\t\t\t{botPoints}")

    else:

        print("The number of rounds must be odd.")

except ValueError:

    print("Please enter a valid value.")