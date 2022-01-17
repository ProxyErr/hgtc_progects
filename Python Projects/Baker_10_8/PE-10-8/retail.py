#Christopher V Baker
#Chapter 10-8
# 7/30/2021

#Demonstrate the CashRegister class in a program that allows
# the user to select several items for purchase.
# When the user is ready to check out, the program should display
# a list of all the items he or she has selected for purchase,
# as well as the total price.

#create class RetailItem:
class RetailItem:
    #Create Constructor with items.
    def __init__(self, description, inventory, price):
        #items in constructor set to secure variables.
        self.__description = description
        self.__inventory = inventory
        self.__price = price
    #Setters/Mutators
    #setter for description:
    def set_description(self, description):
        self.__description = description
    #setter for inventory:
    def set_inventory(self, inventory):
        self.__inventory = inventory
    #setter for price:
    def set_price(self, price):
        self.__price = price

    #Getters/Accessors
    #getter for description:
    def get_description(self):
        return self.__description
    #getter for inventory:
    def get_inventory(self):
        return self.__inventory
    #getter for price
    def get_price(self):
        return self.__price

    #method for string output.
    def __str__(self):
        #outpute for each variable accessed  #output return for Exercise_10_8.py
        result = 'Description: ' + self.get_description() + '\n' + \
                 'Units in inventory: ' + str(self.get_inventory()) + \
                 '\nPrice: $' + str(self.get_price())
        #return results. for output.
        return result