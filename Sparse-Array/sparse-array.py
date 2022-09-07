def matchingStrings(strings, queries):
    result = []
    for item in queries:
        result.append(strings.count(item))
    return result