def upto(num: int):
    sum = 0

    for i in range(1, num + 1):
        if i % 2 == 0:
            sum -= i
        else:
            sum += i
    return sum

print(upto(5))
