//Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. The order of the elements may be changed. Then return the number of elements in nums which are not equal to val.

var removeElement = function (nums, val) {
  let k = 0; // Initialize the count of non-equal elements.

  for (let i = 0; i < nums.length; i++) {
    if (nums[i] !== val) {
      // If the current element is not equal to val, replace the element at index k with it.
      nums[k] = nums[i];
      k++; // Increment k for each non-equal element.
    }
  }

  return k; // k is the number of elements not equal to val.
};

// Examples
const nums1 = [3, 2, 2, 3];
const val1 = 3;
const k1 = removeElement(nums1, val1);
console.log(k1);
console.log(nums1);

const nums2 = [0, 1, 2, 2, 3, 0, 4, 2];
const val2 = 2;
const k2 = removeElement(nums2, val2);
console.log(k2);
console.log(nums2);
