function findLargestBySumOfDigits(nums) {
    var sum=0;
    var maxSum=0;
    var number;
    var index;

    //Loop in nums
    for (var i = 0; i < nums.length; i++) {
        //Check for floating point
        if (nums[i]%1!=0) {
            console.log("undefined");
            return;
        }
        //Remove monus
        number = Math.abs(nums[i]);
        number = number.toString();
        
        //Loop to sum digits
        for (var j = 0; j < number.length; j++) {
            sum += Number(number[j]);
        }
        //Check for max sum
        if (Number(sum) > Number(maxSum)) {
            maxSum = sum;
            index = i;
        }
        sum = 0;
        
    }
    console.log(nums[index]);
}

findLargestBySumOfDigits([5, 10, 15, 111])
findLargestBySumOfDigits([33, 44, -99, 0, 20])
findLargestBySumOfDigits(['hello'])
findLargestBySumOfDigits([5, 3.3])
