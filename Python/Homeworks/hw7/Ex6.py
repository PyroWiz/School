def recura(num):
    num = int(num)
    if num == 0:
        return 0
    return num % 10 + recura(num / 10)


print(recura(111111))
