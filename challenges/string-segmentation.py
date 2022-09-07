def can_segment_string(s, dictionary):
    for word in dictionary:
        if word in s:
            s = s.replace(word, "")
        if not s:
            return True

    return False

print(can_segment_string("applepeer", {"apple","apple","pear","pie"}))