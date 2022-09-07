def reverse_words(sentence):
    stack = sentence.split()
    sentence = ""
    while stack:
        sentence += stack.pop()
        if stack:
            sentence += " "
    return sentence

print(reverse_words("Hello World"))