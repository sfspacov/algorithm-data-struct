﻿Queue q = new Queue(4);

// print Queue elements
q.queueDisplay();

// inserting elements in the queue
q.queueEnqueue(20);
q.queueEnqueue(30);
q.queueEnqueue(40);
q.queueEnqueue(50);

// print Queue elements
q.queueDisplay();

// insert element in the queue
q.queueEnqueue(60);

// print Queue elements
q.queueDisplay();

q.queueDequeue();
q.queueDequeue();
Console.Write("\n\nafter two node deletion\n\n");

// print Queue elements
q.queueDisplay();

// print front of the queue
q.queueFront();