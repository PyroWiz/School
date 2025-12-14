def replace_final_letters(text):
    text_after_replacing = text
    
    text_after_replacing = text_after_replacing.replace('ך', 'כ')
    text_after_replacing = text_after_replacing.replace('ם', 'מ')
    text_after_replacing = text_after_replacing.replace('ן', 'נ')
    text_after_replacing = text_after_replacing.replace('ף', 'פ')
    text_after_replacing = text_after_replacing.replace('ץ', 'צ')
    
    return text_after_replacing

input_text = "שלום מה שלומך"
print(replace_final_letters(input_text)) 

