def find_sum_of_two(A, val):
    for index, x in enumerate(A):
        rest = val - x
        try:
            A[index+1:].index(rest)
            return True
        except:
            pos = -1
    return False

print(find_sum_of_two([5,7,1,2,8,4,3],10))