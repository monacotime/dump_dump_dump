
def sieve():
    primeList = (n + 1) * [True]

    for candidate in range(2, (n+1)):
        if primeList[candidate]:
            print(candidate)
            for witness in range(candidate**2, n+1, candidate):
                primeList[witness] = False

def inputVal(something):
    while True:
        inVal = input(something)
        try:
            inVal = int(inVal)
        except ValueError:
            print('Please input an integer!')
        if inVal <= 0:
            print("please input a value more than 0")
        else:
            break
    return inVal
def start():
    global n
    n = inputVal("input: ")
    sieve()
while True:
    start()