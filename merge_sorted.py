class Node:
   def __init__(self, data=None):
      self.data = data
      self.next = None

class LinkedList:
   def __init__(self):
      self.head = None


def merge_sorted(head1, head2):
  # if both lists are empty then merged list is also empty
  # if one of the lists is empty then other is the merged list
  if head1 == None:
    return head2
  elif head2 == None:
    return head1

  mergedHead = None;
  if head1.data <= head2.data:
    mergedHead = head1
    head1 = head1.next
  else:
    mergedHead = head2
    head2 = head2.next

  mergedTail = mergedHead
  
  while head1 != None and head2 != None:
    temp = None
    if head1.data <= head2.data:
      temp = head1
      head1 = head1.next
    else:
      temp = head2
      head2 = head2.next

    mergedTail.next = temp
    mergedTail = temp

  if head1 != None:
    mergedTail.next = head1
  elif head2 != None:
    mergedTail.next = head2

  return mergedHead

l = LinkedList()
l.head = Node(1)
n2 = Node(3)
n3 = Node(7)

l.head.next = n2
n2.next = n3

l2 = LinkedList()
l2.head = Node(1)
nb = Node(2)

l.head.next = nb
merged = merge_sorted(l.head, l2.head)
for i in merged:
  print(i + "->")