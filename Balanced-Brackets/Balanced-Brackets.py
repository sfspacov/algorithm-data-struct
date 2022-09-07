def isBalanced(s):
    stack = []

    for c in s:
        if c in "([{":
            stack.append(c)
        else:
            #is empty: 1st character is right anything
            if not stack:
                print('NO')
                return
                
            popped = stack.pop()

            if c == "}" and  popped != "{":
                print('NO')
                return
            elif c == ")" and popped != "(":
                print('NO')
                return
            elif c == "]" and popped!= "[":
                print('NO')
                return
    
    #not empty
    if stack:
        print('NO')
    else:
        print('YES')

isBalanced('}][}}(}][))]')
isBalanced('[](){()}')
isBalanced('()')
isBalanced('({}([][]))[]()')
isBalanced('{)[](}]}]}))}(())(')
isBalanced('([[]')
