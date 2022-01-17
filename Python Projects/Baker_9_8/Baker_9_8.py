# Christopher Baker
# 9-8 Name and Email Addresses
# 7/21/2021
# Write a program that keeps name and email addresses in a dictionary as key-value
# pairs. the program should display a menu that lets the user look up a person's
# email address, add  a new name and email address, change an existing email address, and
# delete an existing name and email address. the program should pickle the dictionary
# and save it to a file when the user exits the program. Each time the program starts,
# it should retrieve the dictionary from the file and  unpickle it.
import pickle

#Define Constants for menu.
MENU_OPTION_LOOKUP = 1
MENU_OPTION_ADD    = 2
MENU_OPTION_CHANGE = 3
MENU_OPTION_DELETE = 4
MENU_OPTION_PRINT  = 5
MENU_OPTION_QUIT   = 6

#I HAVE NO IDEA HOW TO COMPLETE THIS STEP SO I USED THIS INSTEAD....
#THESE LINES CREATE THE FILE WITH ONE EMPTY SPACE TO MAKE SURE FILE IS NOT
#EMPTY. I COULD NOT FIGURE OUT HOW TO CREATE THE FILE WITH AN EMPTY DICTIONARY
#SO I CAN READ THE FILE. THIS WAS DEFINATELY THE TRICKY PART.

inFile = open('Name_Email.dat', 'wb')
userDictionary = {}
userDictionary[''] = ''
pickle.dump(userDictionary, inFile)
inFile.close()

#method to create menu:
def getMenuSelection():

    #draw a menu and get users selection:
    print()
    print("*" * 50)
    print("Name and Email Addresses")
    print("*" * 50)
    print("1. Look up Name & Email Address")
    print("2. Add New Name & Email Address")
    print("3. Change Email Address")
    print("4. Delete Name & Email Address")
    print("5. Print User Name and Email list")
    print("6. Exit the program")


    print()
    selectedOption = int(input("Please enter a menu selection:\t"))

    # while validation loops
    while selectedOption < MENU_OPTION_LOOKUP or selectedOption > MENU_OPTION_QUIT:
        selectedOption = int(input("Please enter a valid menu option:\t"))

    #user entered a valid menu option, return it to calling program
    return selectedOption


def userNameLookup(userDictionary):
    #get user name to lookup
    userName = input("Please enter user Name to lookup:\t")
    # use get method to locate the key or assing a default value.
    userEmail = userDictionary.get(userName, '0-Not Found!')
    #print user name and email address.
    print("\n",userName,"Email Address is", userEmail)

def userAdd(userDictionary):
    #get username to add
    userName = input("Add New User Name:\t")
    #get users email to add
    userEmail = input("Add New Email Address:\t")
    #validate username:
    if userName not in userDictionary:
        #add username to dictionary.
        userDictionary[userName] = userEmail
    #else statement if user already exists.
    else:
        print(userName,"is already in the dictionary")



def userChange(userDictionary):

    #get username email to change

    userName = input("Please Enter User Name:\t")

    # find/validate users email address
    if userName in userDictionary:
        #Change the email address
        print("User Name: ", userName,"has the Email Address:",userDictionary[userName])

        newEmail = input("Please enter New Email Address:")

        #assign new Email Address to the record in the dictionary.
        userDictionary[userName] = newEmail

    #else statement if not found in dictionary
    else:
        print(userName,"not found in user dictionary!")


def userDelete(userDictionary):
    #get user name from user
    userName = input("Please enter user name:\t")
    #find and validate user name:
    if userName in userDictionary:
        #delete function to delete user by using userName key.
        del userDictionary[userName]
    #else statement if username not found in dictionary.
    else:
        print(userName,"not found in user dictionary!")

def printUserList(userDictionary):
        #prints list of usernames and their email addresses.
        #print header
        print(format("Username", "40"), format("Email Address","12"))
        for name in userDictionary:
            print(format(name, "40"), format(userDictionary[name],"12"))



#define a function main as the top level of our program.
def main():

        inFile = open('Name_Email.dat', 'rb')

        userDictionary = pickle.load(inFile)


        # initialize a varlected = 0
        menuOptionSelected = 0

        # loop until user quits:
        while menuOptionSelected != MENU_OPTION_QUIT:
            # Call the display menu funtion to get users choice
            menuOptionSelected = getMenuSelection()
            #process menu choice
            if menuOptionSelected == MENU_OPTION_LOOKUP:
                userNameLookup(userDictionary)
            elif menuOptionSelected == MENU_OPTION_ADD:
                userAdd(userDictionary)
            elif menuOptionSelected == MENU_OPTION_CHANGE:
                userChange(userDictionary)
            elif menuOptionSelected == MENU_OPTION_DELETE:
                userDelete(userDictionary)
            elif menuOptionSelected == MENU_OPTION_PRINT:
                printUserList(userDictionary)


        outFile = open('Name_Email.dat', 'wb')

        pickle.dump(userDictionary, outFile)
        #exit the program.
        print("Thank you for using User Name & Email Addresses program!")


main()