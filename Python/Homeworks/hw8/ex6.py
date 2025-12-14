def decode_letter(letter, key):
    alphabet = "אבגדהוזחטיכלמנסעפצקרשת"
    
    if letter in alphabet:
        current_index = alphabet.index(letter)
        
        new_index = (current_index - key) % len(alphabet)
        
        decoded_letter = alphabet[new_index]
        return decoded_letter
        
    return letter