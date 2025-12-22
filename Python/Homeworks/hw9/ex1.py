def main():
    def encrypt(text, key):
        encrypted_text = []
        key_index = 0
        key = key.upper()  # Normalize key to uppercase

        for char in text:
            if char.isalpha():
                # Determine ASCII offset (65 for 'A', 97 for 'a')
                base = ord("A") if char.isupper() else ord("a")

                # Calculate shift from the current key character
                shift = ord(key[key_index % len(key)]) - ord("A")

                # Perform shift and wrap around alphabet
                new_char_code = (ord(char) - base + shift) % 26 + base
                encrypted_text.append(chr(new_char_code))

                key_index += 1  # Move to next key letter
            else:
                # Keep non-alphabetic characters as is
                encrypted_text.append(char)

        return "".join(encrypted_text)

    def decrypt(encrypted_text, key):
        decrypted_text = []
        key_index = 0
        key = key.upper()

        for char in encrypted_text:
            if char.isalpha():
                # Determine ASCII offset
                base = ord("A") if char.isupper() else ord("a")

                # Calculate the shift value of the key
                shift = ord(key[key_index % len(key)]) - ord("A")

                # SUBTRACT the shift to decrypt
                # Python's % operator handles negative numbers correctly automatically
                new_char_code = (ord(char) - base - shift) % 26 + base
                decrypted_text.append(chr(new_char_code))

                key_index += 1
            else:
                decrypted_text.append(char)

        return "".join(decrypted_text)

    while True:

        def display_menu():
            print("press 1 to encode\npress 2 to decode\npress 3 to exit")

        def encode():
            print("enter the text and key")
            text = input()
            key = input()
            print(encrypt(text, key))

        def decode():
            print("enter text to decode with key")
            text = input()
            key = input()
            print(decrypt(text, key))

        display_menu()
        choice = input()
        match choice:
            case "1":
                encode()
            case "2":
                decode()
            case "3":
                print("closing")
                return
            case _:
                print("wrong input")


main()
