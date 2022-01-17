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
#Average Price Per Year:
#Average Price Per Month:
#Highest and Lowest Prices Per Year:
#List of Prices, Lowest to Highest:
#List of Prices, Highest to lowest:



STARTING_DATE = 1993
ENDING_DATE = 2013

STARTING_MONTH = 1
ENDING_MONTH = 12



def main():

    # trycatch because we are working with files.
    try:
        # open the file for reading
        gasFile = open('GasPrices.txt', 'r')

        # Read all lines form
        gasList = gasFile.readlines()

        # Create the file with the elements sorted
        # by price from highest to lowest.
        create_low_to_high_file(gasList)

        #Display to seperate lists in output to user.
        print("")
        print("_Yearly_Average___________________________________________________")
        print("")
        #for loop to use constants as range to print in list.
        for i in range (STARTING_DATE, ENDING_DATE + 1):
            tempAverage = getYearlyAverage(gasList, i)
            print("The average gas price in", i, "was", tempAverage)


        print("")
        print("_Monthly_Average___________________________________________________")
        print("")


        for i in range(STARTING_MONTH, ENDING_MONTH + 1):
            tempAverage = getMonthlyAverage(gasList, i)
            print("The average gas price in Month", i, "was", tempAverage)

        print("")
        print("_Highest_Prices_Per_Year_________________________________________")
        print("")


        for i in range(STARTING_DATE, ENDING_DATE + 1):
            tempHigh = getHighYear(gasList, i)
            print("the highest prices in", i, "was", tempHigh)

        print("")
        print("_Lowest_Prices_Per_Year_________________________________________")
        print("")

        for i in range(STARTING_DATE, ENDING_DATE + 1):
            tempLow = getLowYear(gasList, i)
            print("the Lowest prices in", i, "was", tempLow)


        #OUT FILE AREA: All outfile functions as needed.

        #HIGH TO LOW FUNCTION TO WRITE OUT.
        outputfile = open('high_to_low.txt', 'w')

        #while loop to create a loop to iterate through all the numbers in the gasList
        while (len(gasList) > 0):
            # Get the index of the element with the highest price.
            highest_index = highest_element_position(gasList)

            # Get that element.
            highest_line = gasList[highest_index]

            # Write that element to the file.
            outputfile.write(highest_line)

            # Delete that element from the list.
            del gasList[highest_index]

        # Close the file.
        outputfile.close()


    # except responses if file is unable to be read or found.
    except IOError:
        print("cannot find the file")

    except:
        print("An error occured")

#LOW TO HIGH FUNCTION TO WRITE OUTFILE
def create_low_to_high_file(gasList):

    #trycatch because we are working with files.
    try:
    # Make a copy of gas_list.
        temp_list = []
        for e in gasList:
            temp_list.append(e)

        # Open a file for writing.
        outputfile = open('low_to_high.txt', 'w')

        while (len(temp_list) > 0):
            # Get the index of the element with the lowest price.
            lowest_index = lowest_element_position(temp_list)

            # Get that element.
            lowest_line = temp_list[lowest_index]

            # Write that element to the file.
            outputfile.write(lowest_line)

            # Delete that element from the list.
            del temp_list[lowest_index]

        # Close the file.
        outputfile.close()

    # except responses if file is unable to be read or found.
    except IOError:
        print("cannot find the file")

    except:
        print("An error occured")


def getYearlyAverage(methodList, year):
    gasTotal = 0
    itemCount = 0
    for i in methodList:
        if getYear(i) == year:
            gasTotal += getPrice(i)
            itemCount += 1
    yearlyAverage = gasTotal / itemCount
    return yearlyAverage


def getMonthlyAverage(methodList, month):
    gasTotal = 0
    itemCount = 0
    for i in methodList:
        if getMonth(i) == month:
            gasTotal += getPrice(i)
            itemCount += 1
    monthlyAverage = gasTotal / itemCount
    return monthlyAverage

def getHighYear(methodList, year):
    gasTotal = 0
    itemCount = 0
    for i in methodList:
        if getYear(i) == year:
            if getPrice(i) > gasTotal:
                gasTotal = getPrice(i)
            itemCount += 1
    return gasTotal


def getLowYear(methodList, year):
    gasTotal = 5
    itemCount = 0
    for i in methodList:
        if getYear(i) == year:
            if getPrice(i) < gasTotal:
                gasTotal = getPrice(i)
            itemCount += 1
    return gasTotal


# The lowest_element_position function returns the position of the
# element in g_list with the lowest value.
def lowest_element_position(g_list):
    lowest = getPrice(g_list[0])
    position = 0
    for i in range(1, len(g_list)):
        if getPrice(g_list[i]) < lowest:
            lowest = getPrice(g_list[i])
            position = i

    # Return the position of the lowest value.
    return position


# The highest_element_position function returns the position of the
# element in g_list with the highest value.
def highest_element_position(g_list):
    highest = getPrice(g_list[0])
    position = 0
    for i in range(1, len(g_list)):
        if getPrice(g_list[i]) > highest:
            highest = getPrice(g_list[i])
            position = i

    # Return the position of the highest value.
    return position


#SPLIT FUNCTION LIST: Add more if needed.


def getYear(str):
    # Split the string at the dash.
    gasItems = str.split('-')
    # Split the string at the colon.
    dateGasItems=gasItems[2].split(':')
    # Return the Year, as a string.
    return int(dateGasItems[0])


def getDay(str):
    # Split the string at the dash.
    gasItems = str.split('-')
    # Return the day, as a string.
    return int(gasItems[1])


def getMonth(str):
    # Split the string at the dash.
    gasItems = str.split('-')
    # Return the Month, as a string.
    return int(gasItems[0])


def getPrice(str):
    # Split the string at the colon.
    gasItems = str.split(':')
    # Return the price, as a string.
    return float(gasItems[1])


def getDate(str):
    # Split the string at the colon.
    items = str.split(':')
    # Return the date, as a string.
    return str(items[0])

#call main
main()

