def encode2(myString):
    if not myString:
        return ""

    counter = 1
    resposta = ""
    prev = myString[0]
    for item in myString[1:]:
        if item == prev:
            counter+=1
        else:
            resposta+=str(counter)+prev
            counter = 1
        prev = item
    resposta+=str(counter)+prev
    
    return resposta

def encode(myString):
    myarray = []
    if not myString:
        return ""
    
    for index, item in enumerate(myString):
        if index == 0:
            myarray.append([1, item])
        else:

            if myarray[len(myarray) -1][1] == item:
                myarray[len(myarray) -1][0] += 1

            else:
                myarray.append([1, item])

    resposta = ''

    for item in myarray:
        resposta+=str(item[0])+item[1]
    return resposta


print(encode2("aabcc"))
print(encode2(None))
print(encode2("None"))
print(encode2(""))