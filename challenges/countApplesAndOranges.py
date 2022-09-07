def countApplesAndOranges(casa_ini, casa_fim, apple_tree, orange_tree, apples, oranges):

    result = 0
    for i, apple in enumerate(apples):
        apples[i] += apple_tree
        if apples[i] >= casa_ini and apples[i] <= casa_fim:
            result += 1

    for i, orange in enumerate(oranges):
        oranges[i] += orange_tree
        if oranges[i] >= casa_ini and oranges[i] <= casa_fim:
            result += 1
    
    return result
print(
countApplesAndOranges(8,9,4,12,[2,3,-4],[3,-2,-4])
)