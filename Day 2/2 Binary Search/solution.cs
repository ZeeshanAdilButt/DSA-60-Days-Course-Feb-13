static int BinarySearch(int[] arr, int left, int right, int target) {
    
    int left = 0, right = arr.Length - 1;

    while (left <= right) {
    
        int mid = (left + right) / 2;

        if (arr[mid] == target) {
            return mid;
        } else if (arr[mid] < target) {
            left = mid + 1;
        } else {
            right = mid - 1;
        }
    }
    return -1;
}
