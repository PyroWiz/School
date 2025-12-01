switch = 0
evencounter = 0
oddcounter = 0

while switch != "done":
    switch = (input("Enter a number: "))

    if switch == "done": break

    switch = int(switch)

    if switch % 2 == 0:
        evencounter += 1
    elif switch % 2 == 1:
        oddcounter += 1

print(f"odd : {oddcounter} , even : {evencounter}")
