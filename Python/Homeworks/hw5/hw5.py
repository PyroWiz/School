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

temps = (input("enter temperature "))

if temps.endswith("C") or temps.endswith("c"):
    temps = float(temps[:-1])
    temps = float((5 * temps - 160) / (9))
    print(str(temps) + "F")
elif temps.endswith("F") or temps.endswith("f"):
    temps = float(temps[:-1])
    temps = float((9 * temps + (32 * 5)) / (5))
    print(str(temps) + "C")
else:
    print("bad input")
