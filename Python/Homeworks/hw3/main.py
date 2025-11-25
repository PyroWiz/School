from operator import indexOf

msg = "the python language is a good language"

print(msg.upper())
print(msg.lower())
print(msg.title())
print(msg.find("o"))
print(msg.find("language"))
print(msg.rfind("o"))
print(msg.rfind("language"))
print(msg.strip())
print(msg.replace("language", "course"))
print(msg.count("a"))

if msg.find("the") == 0:
    print("true")
else:
    print("false")

lg = len("language")
if msg.rfind("language") == len(msg) - lg:
    print("true")
else:
    print("false")

if "good" in msg:
    print("true")

s1 = "Hi All"
s2 = "hi all"

if s1.lower() == s2.lower():
    print("true")
else:
    print("false")

template = "My name is {name} and I am {age} years old."

template = template.replace("{name}", "ido")
template = template.replace("{age}", "25")
print(template)

id_str = "12345"

print(id_str.isdigit())

length = int(len(id_str))

add = 9 - length

while add > 0:
    id_str = "0" + id_str
    add -= 1

print (id_str)
