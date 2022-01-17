#Christopher Baker
#5-7 Charge Account Validation
#5/25/2021
#Write a program that reads the contents of the file into a list.
#The program should then ask the user to enter a charge
#account number. The program should determine whether the number is valid
#by seawrching for it in the list. If the number is not in the list, the
#program should display a message indicating the number is invalid.




def main():

    #Declare Variables
    searchAccnt = ''

    #Try statement in case there is an error
    try:
        #open the file for reading
        inputFile = open('charge_accounts.txt','r')

        #Read all lines form file and place into a list

        accountList = inputFile.readlines()

        #strip \n from all elements of the list
        for i in range(len(accountList)):
            accountList[i] = accountList[i].rstrip('\n')


        #Gather user input
        searchAccnt = input("Enter account number to search for: ")

        #Search for entered item in list and give appropriate repsonse
        if searchAccnt in accountList:
            print("Account number", searchAccnt, "is Valid!")
        else:
            print("Account number", searchAccnt, "is not Valid!")


    #except responses if file is unable to be read or found.
    except IOError:
        print("cannot find the file")

    except:
        print("An error occured")

#call main:
main()