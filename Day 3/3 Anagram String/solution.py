def areAnagram(str1, str2):
# Get lengths of both strings

    n1 = len(str1)
    n2 = len(str2)

    # If length of both strings is not same,
    # then they cannot be anagram
    if n1 != n2:
        return False

    # Sort both strings
    str1 = sorted(str1)
    str2 = sorted(str2)

    # Compare sorted strings
    for i in range(n1):
        if str1[i] != str2[i]:
            return False

    return True