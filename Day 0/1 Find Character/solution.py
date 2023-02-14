def find_index_of_char(s, c):
    for i in range(len(s)):
        if s[i] == c:
            return i
    return -1
