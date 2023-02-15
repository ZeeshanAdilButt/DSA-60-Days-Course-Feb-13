
vector<int> FindNumbersInRange(vector<int>& arr, int low, int high, int targetNum) {
    
    vector<int> result;

    for(int i = low; i<= high ; i++ ){

        if(arr[i] ==targetNum )
        {
            result.push_back(num);
        }        
    }

    // for (int num : arr) {
    //     if (num >= low && num <= high) {
    //         result.push_back(num);
    //     }
    // }
    return result;
}
