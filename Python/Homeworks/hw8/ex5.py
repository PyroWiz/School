def encode_letter(letter, key):
    alphabet = "אבגדהוזחטיכלמנסעפצקרשת"
    
    if letter in alphabet:
        current_index = alphabet.index(letter)
        
        new_index = (current_index + key) % len(alphabet)
        
        # Return the new letter
        encoded_letter = alphabet[new_index]
        return encoded_letter
    
    return letter