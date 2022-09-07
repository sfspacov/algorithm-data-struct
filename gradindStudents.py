def gradingStudents(grades):
    for i, x in enumerate(grades):
        if x >= 38:
            if x%5==4:
                x=x+1
            elif x%5==3:
                grades[i] =x+2

gradingStudents([73,67,38,33])