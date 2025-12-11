def opposite(num):
    num = int(num)
    if num == 0:
        return
    print(int(num % 10))
    return opposite(num / 10)


opposite(123)
