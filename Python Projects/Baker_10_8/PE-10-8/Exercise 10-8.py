#Christopher V Baker
#Chapter 10-8
# 7/30/2021

#Demonstrate the CashRegister class in a program that allows
# the user to select several items for purchase.
# When the user is ready to check out, the program should display
# a list of all the items he or she has selected for purchase,
# as well as the total price.




#import class files to main function program.
import cashRegister
import retail

#set global variables.
PANTS = 1
SHIRT = 2
DRESS = 3
SOCKS = 4
SWEATER = 5

#Main function.
def main():

    #variable information: input values for variables.
    pants = retail.RetailItem('Pants', 10, 19.99)
    shirt = retail.RetailItem('Shirt', 15, 12.50)
    dress = retail.RetailItem('Dress', 3, 79.00)
    socks = retail.RetailItem('Socks', 50, 1.00)
    sweater = retail.RetailItem('Sweater', 5, 49.99)
    #hold sale_items in list:
    sale_items = {PANTS:pants, SHIRT:shirt,
                  DRESS:dress, SOCKS:socks,
                  SWEATER:sweater}
    #call cashRegister Class file.
    register = cashRegister.CashRegister()
    #validation variable for prompt.
    checkout = 'N'
    #while loop for validation of N.
    while checkout == 'N':
        #funtion for choices of user choice when prompted.
        user_choice = get_user_choice()
        item = sale_items[user_choice]
        #if statement for different choice. 0
        if item.get_inventory() == 0:
            print('The item is out of stock.')
        #else statement for a valid choice by user.
        else:
            register.purchase_item(item)

            #this pulls info from retail class.
            new_item = retail.RetailItem(item.get_description(), \
                                         item.get_inventory()-1, \
                                         item.get_price())
            sale_items[user_choice] = new_item
            #prompts user if they are ready to check out.
            checkout = input('Are you ready to check out (Y/N)? ')
    #final output
    print()
    print('Your purchase total is: ', \
          format(register.get_total(), '.2f'))
    print()
    register.show_items()
    register.clear()
#Function for prompting user and get choice.
def get_user_choice():
    #display menu
    print('Menu')
    print('---------------------------------')
    print('1. Pants')
    print('2. Shirt')
    print('3. Dress')
    print('4. Socks')
    print('5. Sweater')
    print()
    #prompt user for choice.
    choice = int(input('Enter the menu number of the item ' + \
                       'you would like to purchase: '))
    print()
    #while loop to validate choice is within menu list.
    while choice > SWEATER or choice < PANTS:
        #re-prompt the user for a valid menu choice if chosen wrong.
        choice = int(input('Please enter a valid item number: '))
        print()
    #return choice for main function to call from get_user_choice():
    return choice
#call main()
main()