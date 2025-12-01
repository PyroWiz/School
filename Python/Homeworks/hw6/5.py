num1 = int(input("Enter a number: "))
num2 = int(input("Enter another number: "))
num3 = int(input("Enter another number: "))

if num2 > num1 > num3 or num3 > num1 > num2:
    print(num1)
elif num2 > num3 > num1 or num1 > num3 > num2:
    print(num3)
elif num1 > num2 > num3 or num3 > num2 > num1:
    print(num2)