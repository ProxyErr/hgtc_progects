# Christopher Baker
# 9-3 File Encryption and Decryption
# 7/21/2021
# Write a program that uses a dictionary to assign "codes" to each letter
# of the alphabet. The program should open a specified text file, read its contents,
# then use the dictionary to write an encrypted version of the file's contents to a
# second file. Each character in the second file should contain the code for the
# corresponding character in the first file. Write a second program that opens an
# encrypted file and displays its decrypted contents on the screen.


#encryption code:
CODE = {'A':')','a':'0','B':'(','b':'9','C':'*','c':'8',\
        'D':'&','d':'7','E':'^','e':'6','F':'%','f':'5',\
        'G':'$','g':'4','H':'#','h':'3','I':'@','i':'2',\
        'J':'!','j':'1','K':'Z','k':'z','L':'Y','l':'y',\
        'M':'X','m':'x','N':'W','n':'w','O':'V','o':'v',\
        'P':'U','p':'u','Q':'T','q':'t','R':'S','r':'s',\
        'S':'R','s':'r','T':'Q','t':'q','U':'P','u':'p',\
        'V':'O','v':'o','W':'N','w':'n','X':'M','x':'m',\
        'Y':'L','y':'l','Z':'K','z':'k','!':'J','1':'j',\
        '@':'I','2':'i','#':'H','3':'h','$':'G','4':'g',\
        '%':'F','5':'f','^':'E','6':'e','&':'D','7':'d',\
        '*':'C','8':'c','(':'B','9':'b',')':'A','0':'a',\
        ':':',',',':':','?':'.','.':'?','<':'>','>':'<',\
        "'":'"','"':"'",'+':'-','-':'+','=':';',';':'=',\
        '{':'[','[':'{','}':']',']':'}'}
#main function:
def main():
        #Value from convertText(): method.
        resultText = convertText()


        #Uncheck (#) on NEXT LINE to check print function of encrypted code.
        print(resultText)


        #open outputFile to write dencrypted text to text file.
        #outputFile = open('Ancient_Marinar_Decryption.txt', 'w')

        #write encrypted text to file function.
        #outputFile.write(resultText)

        #Close file.
        #outputFile.close()


# method to covert text:
def convertText():

        #open the file:
        inputFile = open('Ancient_Marinar_Encryption.txt', 'r')
        #Read the information from the file:
        fileText = inputFile.read()

        #Set as string variable
        resultText = ''

        #for loop to find every character in the Ancient_Marinar.txt
        for ch in fileText:

                # if statement for space check in text file.
                # CODE dictionary does not account for spaces.
                if ch.isspace():
                        resultText = resultText + ch

                #resultText = variable to hold the function.
                #function is to use the ch key to use every key and = its value.
                else:
                        resultText = resultText + CODE[ch]

        #return value to convertText(): method storage.
        return resultText



#Call Main:
main()