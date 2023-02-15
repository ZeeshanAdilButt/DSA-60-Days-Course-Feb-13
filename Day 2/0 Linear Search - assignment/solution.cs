int[] FindNumbersInRange(int[] arr, int low, int high, int targetNum) {

    //edge cases
    if(low < 0)
        low = 0;

    //edge cases
    if(high > arr.Length - 1)
        high = arr.Length -1;    
    
    List<int> result = new List<int>();

    for(int i = low; i<= high ; i++ ){

        if(arr[i] ==targetNum )
        {
            result.Add(num);
        }        
    }

    // foreach (int num in arr) {

    //     if (num >= low && num <= high) {
           
    //     }
    // }
    return result.ToArray();
}
