def last_early(my_str):
  last = my_str[-1]
  before = my_str[:-1]
  if last in before:
    return True
  else:
    return False
  
print(f"{last_early("hahc")}")
  