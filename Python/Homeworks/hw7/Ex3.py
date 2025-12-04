def highlow():

    lowest = 0
    highest = 0
    num = int(input("enter num"))
    lowest = num
    while num != 999:

        if num > highest:
            highest = num
        if num < lowest:
            lowest = num
        num = int(input("enter num"))

    return (highest, lowest)


high, low = highlow()

print(high,low)
