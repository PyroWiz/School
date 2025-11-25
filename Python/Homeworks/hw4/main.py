msg = "Python Course"

print(msg)

print(msg[0])

print(msg[len(msg) - 1])

print(msg[0], msg[1])

print(f"{msg[len(msg) - 1]} {msg[len(msg) - 2]}")

words = msg.split()

print(words[0], words[1])

reverse = msg[::-1]

print(reverse)

cutted = msg[::1]

index = 0

while index < len(cutted):  # to do reverse just change index to start from the end and thats it for both
    if index % 2 != 0:
        print(cutted[index], end="")
    index += 1

index = 0
print()

while index < len(cutted):
    if index % 2 == 0:
        print(cutted[index], end="")
    index += 1

print()
cutted = msg[1:len(cutted)-1:]

print(cutted)

if cutted == cutted[::-1]:
    print("YES")
else:
    print("NO")


