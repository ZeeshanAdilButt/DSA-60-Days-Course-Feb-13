function findIndexOfChar(s, c) {
    for (let i = 0; i < s.length; i++) {
        if (s[i] === c) return i;
    }
    return -1;
}
