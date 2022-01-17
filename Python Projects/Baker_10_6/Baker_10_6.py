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


import patient
import procedure

#main function:
def main():

    print("." * 40)
    # New patient information:
    newPatient = patient.Patient("C", "V", "B", "0000", "Carpathia", "Romania",

                                 "999", "000-0000", "Simon", "Sevil Alicard")
    #Patient Output:
    print(newPatient)
    print("." * 40)
    #Procedure input:
    procedureOne = procedure.Procedure("Physical Exam", "7/31/2021", "Dr.Irvine", "$250.00")
    #Procedure Output:
    print(procedureOne)
    # Procedure input:
    procedureTwo = procedure.Procedure("X-ray", "7/31/2021", "Dr. Jamison", "$500.00")
    # Procedure Output:
    print(procedureTwo)
    # Procedure input:
    procedureThree = procedure.Procedure("Blood Test", "7/31/2021", "Dr. Smith", "$200.00")
    # Procedure Output:
    print(procedureThree)


#Call Main()
main()