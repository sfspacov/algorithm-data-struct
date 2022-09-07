def find_missing(input):
    n = len(input)+1
    
    #Soma de todos os elementos de 1 a n
    sumAllElements = ((n)*(n+1))//2 
    
    #Essa soma menos a soma dos elementos do array dara o faltante
    return sumAllElements-sum(input) 

print(find_missing([3,7,1,2,8,4,5]))