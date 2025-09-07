public class Solution {
    // Main method to find two indices whose values add up to the target
    public int[] TwoSum(int[] nums, int target) {
        // Create a dictionary to store numbers and their indices for quick lookup
        Dictionary<int, int> map = new Dictionary<int, int>();

        // Loop through each element in the array
        for (int i = 0; i < nums.Length; i++) {
            // Calculate the complement that would sum to the target
            int complement = target - nums[i];

            // Check if the complement already exists in the dictionary
            if (map.ContainsKey(complement)) {
                // If found, return the indices: index of complement and current index
                return new int[] { map[complement], i };
            }

            // If not found, store the current number and its index in the dictionary
            map[nums[i]] = i;
        }

        // If no solution is found (shouldn't happen as per problem constraints), throw an error
        throw new ArgumentException("No two sum solution");
    }
}
