class DLLNode:

    def __init__(self, data):
        self.data = data
        self.next = None
        self.prev = None

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

    def get_prev(self):
        """Return the self.prev attribute"""
        return self.prev

    def set_prev(self, new_prev):
        """Replace the existing value of the self.prev attribute with new_prev"""
        self.prev = new_prev


class DLL:

    def __init__(self):
        self.head = None

    def __repr__(self):
        return "DLL object: head => ".format(self.head)

    def is_empty(self):
        return self.head == None

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

    def add_front(self, new_data):
        """Add a Node on the begging of the list"""
        node = DLLNode(new_data)
        node.set_next(self.head)
        
        if self.head != None:
            self.head.set_prev(node)
        
        self.head = node

    def remove(self, data):
        """Remove the first occurence of the Node"""
        if self.head is None:
            return "Linked list is empty, nothing to remove"
        
        current = self.head
        found = False

        while not found:
            if current.get_data() == data:
                found = True
            else:
                if current.get_next() == None:
                    return "This item is not on the list"
                else:
                    current = current.get_next()

        if current.prev is None:
            self.head = current.get_next()
        else:
            #eu, current, estou me excluindo
            current.prev.set_next(current.get_next())
            current.next.set_prev(current.get_prev())

# if __name__ == "__main__":
#     dll=DLL()
#     print(dll.size())
#     dll.add_front(1)
#     print(dll.head)