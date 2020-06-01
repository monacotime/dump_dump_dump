import random

#Hard Defined Values------------

mainList = []

currentChoice = 1

#Functions Defenations----------

def cRand():
    randChoice = random.choice(mainList)
    print(randChoice)

def exitQ():
    print("Are you sure you want to quit?"
          " [Y = Quit]"
          " [N = Re-assign choices]")
    while True:
        exitA = input("(Y/N): ")
        if exitA == "Y" or exitA == "y":
            exit()
        elif exitA == "N" or exitA == "n":
            mainList = []
            mainFlip()
            break
        else:
            print("please type only (Y/N)")

def validInputCheck(prompt):
    while True:
        try:
            value = int(input(prompt))
        except ValueError:
            print("Sorry, thats not an integer.")
            continue

        if value < 0:
            print("Sorry, you can't have a negative choice. =,=")
            continue
        else:
            break
    return value

def mainFlip():

    currentChoice = 1

    numChoice = validInputCheck("How many choices?: ")

    while currentChoice <= numChoice:
        addedChoice = input("Choice: ")
        mainList.append(addedChoice)
        currentChoice += 1


    while True :

        sq = input("Random? (Y,N): ")

        if sq == "Y" or sq == "y":
            cRand()

        elif sq == "N" or sq == "n":
            print("Ty for running our program :D")
            exitQ()
            break
        else:
            print("plz type only (Y/N)!")

#Actual execution---------------
mainFlip()
