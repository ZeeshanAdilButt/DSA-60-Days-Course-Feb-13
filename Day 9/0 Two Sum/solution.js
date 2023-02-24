var twoSum = function(nums, target) {
    var map = new Map();
    for (var i = 0; i < nums.length; i++) {
        var requiredNum = target - nums[i];
        if (map.has(requiredNum)) {
            return [map.get(requiredNum), i];
        }
        if (!map.has(nums[i])) {
            map.set(nums[i], i);
        }
    }
    return [];
};
