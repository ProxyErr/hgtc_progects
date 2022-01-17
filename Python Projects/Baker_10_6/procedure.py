# Christopher Baker
# 10 - 6 Patient Charges
# 7/31/2021
# Write a class named Patient that has attributes:
# The Patient class's __init__ method should accept an argument for each attribute.
# Next, write a class named Procedure that represents a medical procedure that has
# been performed on a patient. The procedure class should have attributes:
# The Procedure class's __init___ method should accept an argument for each attribute.
# The Procedure class should also have accessor and mutator methods for each attribute.
# Next, write a program that creates an instance of the Patient class, initialized with
# sample data. Then, create three instances of the Procedure class, initialized.


#Create Class Procedure:
class Procedure:
    #Create Constructor: with items.
    def __init__(self, procName, procDate, procPract, procCharge):
        self.__procName = procName
        self.__procDate = procDate
        self.__procPract = procPract
        self.__procCharge = procCharge

    #setter for procName:
    def setName(self, procName):
        self.__procName = procName
    #setter for procDate
    def setDate(self, procDate):
        self.__procDate = procDate
    #setter for procPract
    def setPract(self, procPract):
        self.__procPract = procPract
    #setter for procCharge
    def setCharge(self, procCharge):
        self.__procCharge = procCharge

    #getter for procName
    def getName(self):
        return self.__procName
    #getter for procDate
    def getDate(self):
        return self.__procDate
    #getter for procPract
    def getPract(self):
        return self.__procPract
    #getter for procCharge
    def getCharge(self):
        return self.__procCharge

    # output of info: with str method.
    def __str__(self):
        #output return for Baker_10_6.py
        return  "Procedure:    " + self.getName() + \
                "\nDate:         " + self.getDate() + \
                "\nPractitioner: " + self.getPract() + \
                "\nCharge:       " + self.getCharge()
