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


#create class Patient:
class Patient:
    # create constructor: with variables.
    def __init__(self, firstName, middleName, lastName, patAddress, patCity, patState,
                 patZip, patPhone, emContact, emPhone):
        #create Items for variables in constructor:
        self.__firstName = firstName
        self.__middleName = middleName
        self.__lastName = lastName
        self.__patAddress = patAddress
        self.__patCity = patCity
        self.__patState = patState
        self.__patZip = patZip
        self.__patPhone = patPhone
        self.__emContact = emContact
        self.__emPhone = emPhone

    #create Mutators and Accessors: setters and getters:

    #Mutators/Setters:
    #Setter for firstName:
    def setFirst(self, firstName):
        self.__firstName = firstName

    # Setter for middleName:
    def setMiddle(self, middleName):
        self.__middleName = middleName

    # Setter for lastName:
    def setLast(self, lastName):
        self.__lastName = lastName

    # Setter for patAddress:
    def setAddress(self, patAddress):
        self.__patAddress = patAddress

    # Setter for patCity:
    def setCity(self, patCity):
        self.__patCity = patCity

    # Setter for patState:
    def setState(self, patState):
        self.__patState = patState

    # Setter for patZip:
    def setZip(self, patZip):
        self.__patZip = patZip

    # Setter for patPhone:
    def setPhone(self, patPhone):
        self.__patPhone = patPhone

    # Setter for emContact:
    def setEmContact(self, emContact):
        self.__emContact = emContact

    # Setter for emPhone:
    def setEmPhone(self, emPhone):
        self.__emPhone = emPhone

    #Accessors/Getters.
    #Getter for firstName:
    def getFirst(self):
        return self.__firstName

    # Getter for middleName:
    def getMiddle(self):
        return self.__middleName

    # Getter for lastName:
    def getLast(self):
        return self.__lastName

    # Getter for patAddress:
    def getAddress(self):
        return self.__patAddress

    # Getter for patCity:
    def getCity(self):
        return self.__patCity

    # Getter for patState:
    def getState(self):
        return self.__patState

    # Getter for patZip:
    def getZip(self):
        return self.__patZip

    # Getter for patPhone:
    def getPhone(self):
        return self.__patPhone

    # Getter for emContact:
    def getEmContact(self):
        return self.__emContact

    # Getter for emPhone:
    def getEmPhone(self):
        return self.__emPhone


    #output of info: with str method.

    def __str__(self):
        #Output return for Baker_10_6.py
        return "First Name:  " + self.getFirst() + \
               "\nMiddle name: " + self.getMiddle() + \
               "\nLast Name:   " + self.getLast() + \
               "\nAddress:     " + self.getAddress() + \
               "\nCity:        " + self.getCity() + \
               "\nState:       " + self.getState() + \
               "\nZip:         " + self.getZip() + \
               "\nPhone:       " + self.getPhone() + \
               "\nEm Contact:  " + self.getEmContact() + \
               "\nEm Phone:    " + self.getEmPhone()
