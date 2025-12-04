def distance(num1, num2, num3):

    case1 = (abs(num1 - num2) == 1) and (
        abs(num1 - num3) >= 2 and abs(num2 - num3) >= 2
    )

    case2 = (abs(num1 - num3) == 1) and (
        abs(num1 - num2) >= 2 and abs(num3 - num2) >= 2
    )

    return case1 or case2




print(distance(1, 2, 2))
