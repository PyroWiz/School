"""
num1 = int(input("enter course 1 grade"))
num2 = int(input("enter course 2 grade"))
num3 = int(input("enter course 3 grade"))

allcourses = (num1 + num2 + num3) / 3

if allcourses >= 95 and num1 > 90 and num2 > 90 and num3 > 90:
    print("you passed")
else:
    print("you failed")

variable = input("enter whatever to check for palindrom")

reversed = variable[::-1]

if variable == reversed:
    print("palindrom")
else:
    print("not palindrom")
"""

temps = input("enter temperature")

if temps.endswith("C"):
    print(temps)