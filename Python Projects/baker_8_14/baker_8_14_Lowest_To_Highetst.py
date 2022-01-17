#Christopher Baker
#6/23/2021
#In the student sample program files for this chapter, you will find a
#text file named GasPrices.txt. The file contains the weekly average prices
#for a gallon of gas in the United States, beginning on April 5th 1993, and ending
#on August 26th 2013. Each line in the file contains the average price for a gallon
#of gas on a specific date. Each line is formatted in the following way:
# MM-DD-YYYY:Price


#Write one or more programs that read the contents of a the file and perform the
#following Calculations:

#List of Prices, Lowest to Highest: Generate a text file that lists the dates and prices,
#sorted from the lowest to highest.




#I do not know how to fix that part to split the list and make it sorted from
#highest to lowest by PRICES. I do not understand. So here is the tasks for
#outputing to a file and sorting by the first character in the list.


def main():

        # open the file for reading
        gasFile = open('GasPrices.txt', 'r')


        outputFile = gasFile.readlines()


        outputFile.sort()


        outfileList = open('lowtohigh.txt', 'w')

        outfileList.writelines(outputFile)


        print(outputFile)




main()