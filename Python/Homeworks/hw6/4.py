num = 0
oldone = 0
oldtwo = 1
while num < 50:
    print(num)
    num = oldone + oldtwo
    oldone = oldtwo
    oldtwo = num

