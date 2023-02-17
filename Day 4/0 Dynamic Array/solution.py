class DynamicArray:
    def __init__(self):
        self.data = [None] * 1
        self.size = 0

    def __len__(self):
        return self.size

    def __getitem__(self, index):
        return self.data[index]

    def append(self, item):
        if self.size == len(self.data):
            self._resize(2 * len(self.data))
        self.data[self.size] = item
        self.size += 1

    def _resize(self, capacity):
        new_data = [None] * capacity
        for i in range(self.size):
            new_data[i] = self.data[i]
        self.data = new_data
