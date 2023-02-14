let input = "Count the number of words in this string";
let wordCount = 0;
for (let i = 0; i < input.length; i++) {
    if (input[i] === ' ' || i === input.length - 1) {
        wordCount++;
    }
}
console.log("Word count: " + wordCount);
