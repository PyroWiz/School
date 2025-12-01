sum = 0
avgpointer = 0

ina = ""
while input != 0:
    ina = float(input("enter num"))
    if ina == 0 : break
    sum += ina
    avgpointer += 1

print(float((sum / avgpointer)))
