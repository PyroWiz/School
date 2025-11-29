max_width = 5

for i in range(1, max_width * 2):

    if i <= max_width:
        columns = i
    else:
        columns = max_width * 2 - i

    for j in range(columns):
        print("*", end=" ")
    print()
