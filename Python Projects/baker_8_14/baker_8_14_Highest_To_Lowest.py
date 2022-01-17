#Christopher Baker
#6/23/2021
#just like the Lowest to Highest file this will be in reverse.





def main():

        # open the file for reading
        gasFile = open('GasPrices.txt', 'r')


        outputFile = gasFile.readlines()


        outputFile.sort()


        outputFile.reverse()



        outfileList = open('hightolow.txt', 'w')

        outfileList.writelines(outputFile)


        print(outputFile)




main()