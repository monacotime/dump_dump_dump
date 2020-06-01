import os

def openFile():
        os.startfile("C:\PSO2 Tweaker\PSO2 Tweaker.exe")
def humm():
        ext = "anything else"
        ext = input("Please input e to exit: ")
        if (ext == "e"):
         exit()
        else:
         humm()

openFile()
humm()
