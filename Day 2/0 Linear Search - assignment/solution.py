def find_numbers_in_range(arr, low, high):
    result = []
    for num in arr:
        if low <= num <= high:
            result.append(num)
    return result
