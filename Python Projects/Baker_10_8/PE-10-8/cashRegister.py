#Christopher V Baker
#Chapter 10-8
# 7/30/2021

#Demonstrate the CashRegister class in a program that allows
# the user to select several items for purchase.
# When the user is ready to check out, the program should display
# a list of all the items he or she has selected for purchase,
# as well as the total price.

#Create class CashRegister:
class CashRegister:

    #this is an empty constructor.
    def __init__(self):
        #empty variable to hold items selected by user:
        self.__items = []
    #method to clear items.
    def clear(self):

        self.__items = []
    #method to get items to cart:
    def purchase_item(self, retail_item):

        self.__items.append(retail_item)
        print('The item was added to the cash register.')
    #get and calculate total
    def get_total(self):
        #counter variable
        total = 0.0
        #for loop to validate item.
        for item in self.__items:
            total = total + item.get_price()
        #return total amount to get_total()
        return total
    #show items method.
    def show_items(self):
        #print for title to user for info
        print('The items in the cash register are:')
        print()
        #for loop to validate item in self._items variable. prints to display. ??
        for item in self.__items:
            print(item)
            print()