class SLLNode:

    def __init__(self, data):
        self.data = data
        self.next = None

    def __repr__(self):
        return "SSLNode object: data = {}".format(self.data)

    def get_data(self):
        """Return the self.data attribute"""
        return self.data

    def set_data(self, new_data):
        """Replace the existing value of the self.data attribute with new_data"""
        self.data = new_data

    def get_next(self):
        """Return the self.next attribute"""
        return self.next

    def set_next(self, new_next):
        """Replace the existing value of the self.next attribute with new_next"""
        self.next = new_next


class SLL:

    def __init__(self):
        self.head = None

    def __repr__(self):
        return "SLL object head = {}".format(self.head)

    def is_empty(self):
        return self.head == None

    def add_front(self, new_data):
        """Add a Node on the begging of the list"""
        node = SLLNode(new_data)
        node.set_next(self.head)
        self.head = node

    def size(self):
        counter = 0
        current = self.head
        while current != None:
            counter += 1
            current = current.get_next()
        return counter

    def search(self, data):
        current = self.head
        while current != None:
            if current.get_data() == data:
                return True
            current = current.get_next()
        return False

    def remove(self, data):
        """Removes the 1st occurence of a Node that contains the data argument self.data"""
        if self.head == None:
            return "It's an empty list"

        current = self.head
        prev = None
        found = False

        while not found:
            if current.data == data:
                found = True
            else:
                if current.get_next() == None:
                    return "Item not found"
                else:
                    prev = current
                    current = current.get_next()
        
        if prev == None:
            self.head = current.get_next()
        else:
            prev.set_next(current.get_next())


if __name__ == "__main__":
    sll = SLL()
    print(sll.remove(15))
    sll.add_front(27)
    print(sll.remove(15))
    print(sll.remove(27))
    print(sll.head)
    sll.add_front('apple')
    sll.add_front('berry')
    sll.add_front('cherry')
    print(sll.remove('berry'))
    print(sll.head)
    print(sll.head.get_next())
    print(sll.head.get_next().get_next())