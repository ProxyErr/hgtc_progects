#Christopher Baker
#5-13 Magic_8_Ball
#5/25/2021
#Write a program that simulates a Magic 8 Ball, which is a
#fortune-telling toy that displays a random response to a yes
#or no question. The program should read the responses from
#the file (8_ball_responses.txt) into a list. It should prompt
#the user to ask a question, then display one of the responses,
#randomly selected from the list. The program should repeat
#until the user is ready to quit.

#import random function
import random


def main():

    #Try statement in case there is an error
    try:

        #open the file for reading
        inputFile = open('8_ball_responses.txt','r')

        #Read all lines form file and place into a list
        responseList = inputFile.readlines()

        #strip \n from all elements of the list
        for i in range(len(responseList)):
            responseList[i] = responseList[i].rstrip('\n')


        #Gather user input:
        userQuestion = input("Ask the Magic 8 Ball a question: ")

        # random.choice(responseList) Get random response from txt file.
        while userQuestion != responseList:
            values = random.choice(responseList)

            # Display the random response.
            print(values)

            #This prompts the user to ask the 8 Ball another question to keep the loop going until the user
            #wants to quit.
            userQuestion = input("Ask the Magic 8 Ball a question: ")


    #except error if file cannot be found or read.
    except IOError:
        print("cannot find the file")

    except:
        print("An error occured")

#call main.
main()
