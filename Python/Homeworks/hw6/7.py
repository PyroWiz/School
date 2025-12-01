user = int(input("enter number"))

for i in range(1,user+1):
    for j in range(i):
        print(f"{i}", end="")
    print()