int FindIndexOfChar(string s, char c) {
    for (int i = 0; i < s.length(); i++) {
        if (s[i] == c) return i;
    }
    return -1;
}
