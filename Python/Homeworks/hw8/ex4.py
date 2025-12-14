def replace_final_letters(text):
    
    text = text.replace('ך', 'כ')
    text = text.replace('ם', 'מ')
    text = text.replace('ן', 'נ')
    text = text.replace('ף', 'פ')
    text = text.replace('ץ', 'צ')
    return text

def divide_text_into_words_of_specific_length(text, length):
   
    text = replace_final_letters(text)
    
   
    text = text.replace(" ", "")
    
    
    chunks = []
    for i in range(0, len(text), length):
        chunks.append(text[i : i + length])
    
    
    divided_text = " ".join(chunks)
    
    return divided_text


input_text = "שלום חברים אני מקווה שאתם מרגישים מצויין"
print(divide_text_into_words_of_specific_length(input_text, 5))