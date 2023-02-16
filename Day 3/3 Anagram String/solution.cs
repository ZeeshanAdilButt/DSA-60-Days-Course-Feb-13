static bool AreAnagram(string str1, string str2)
{
// Get lengths of both strings
int n1 = str1.Length;
int n2 = str2.Length;

// If length of both strings is not same,
// then they cannot be anagram
if (n1 != n2)
    return false;

// Sort both strings
char[] arr1 = str1.ToCharArray();
char[] arr2 = str2.ToCharArray();

Array.Sort(arr1);
Array.Sort(arr2);

// Compare sorted strings
for (int i = 0; i < n1; i++)
    if (arr1[i] != arr2[i])
        return false;

    //TODO: bonus points use an array to update character count

return true;
}