
#Christopher Baker
#6/23/2021
#Chapter 8 Question 7: Character Analyisis
#Write a program that reads the file's (text.txt) contents and determines the following:
# -the number of uppercase letters in the file
# -the number of lowercase letters in the file
# -the number of digits in the file
# -the number of whitespace characters in the file


#countString function to calculate string features.
def countString(functionString):

    #variables to hold count of each feature.
    upperCase = 0
    lowerCase = 0
    totalDigits = 0
    totalSpace = 0

    #for loop for range of ch in functionString variable.
    for ch in functionString:


        if ch.isdigit(): # if statement to check if digits are present
            totalDigits += 1
        elif ch.isspace(): #elif statement to check for spaces
            totalSpace += 1
        elif ch.isupper():# elif statement to check for uppercase characters.
            upperCase += 1
        else:             #else statement to pass everything else as a lowercase character.
            lowerCase +=1


    #print statement to seperate output text.
    print("________________________________")
    #print statement for output of character counts.
    print("Total Didgets: \t\t", totalDigits)
    print("Total Spaces: \t\t", totalSpace)
    print("Total Upper Case: \t\t", upperCase)
    print("Total Lower Case: \t\t", lowerCase)
    print("")
    print("ヽ(`Д´)ﾉ")




#main function to call file data and read data as a whole string
def main():


    #try catch statement for errors.
    try:
        # open the file for reading
        inputFile = open('text.txt', 'r')

        # Read file as a whole string
        myText = inputFile.read()

        #call countString function and send myText variable to the function.
        countString(myText)


    # except responses if file is unable to be read or found.
    except IOError:
        print("cannot find the file")

    except:
        print("An error occured")




#Call main
main()