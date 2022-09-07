def elementsInString(elements, string):
    elements.sort()
    words = string.split()

    for i, word in enumerate(words):
        for element in reversed(elements):
            try:
                indice = word.index(element)
                if len(element) == 1 and word[indice - 1] == "|":
                    continue
                word = word.replace(element,"|" + element + "|")
            except:
                pos = -1
        words[i] = word
    return ' '.join(words)

print(elementsInString(["Cr", "K", "Br", "Au", "B"], "Breaking Bad"))