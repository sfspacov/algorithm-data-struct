int CharacterReplacement(string s, int k){
    int[] count = new int[26];
    int start = 0, maxFreq = 0, maxLength = 0;
    for(int i = 0; i < s.Length; i++){
        maxFreq = Math.Max(maxFreq, ++count[s[i] - 'A']);
        while(i - start + 1 - maxFreq > k){
            count[s[start] - 'A']--;
            start++;
        }
        maxLength = Math.Max(maxLength, i - start + 1);
    }
    return maxLength;
}

var n1 = new Node(1);

n1.left = new Node(2);
n1.right = new Node(3);

//PrintTreeByLevel(n1);

ProductExceptSelf(new int[] { 1, 2, 3, 4 });

int[] ProductExceptSelf(int[] nums){
    var result = new int[nums.Length];
    var prefix = new int[nums.Length];
    var postfix = new int[nums.Length];
    prefix[0] = 1;
    postfix[nums.Length - 1] = 1;
    for (int i = 1; i < nums.Length; i++)
    {
        prefix[i] = prefix[i - 1] * nums[i - 1];
    }
    for (int i = nums.Length - 2; i >= 0; i--)
    {
        postfix[i] = postfix[i + 1] * nums[i + 1];
    }
    for (int i = 0; i < nums.Length; i++)
    {
        result[i] = prefix[i] * postfix[i];
    }
    return result;
}

void PrintInOrder(Node root)
{
    if (root == null)
    {
        return;
    }
    PrintInOrder(root.left);
    Console.WriteLine(root.data);
    PrintInOrder(root.right);
}

void PrintTreeByLevel(Node root)
{
    if (root == null)
    {
        return;
    }
    Queue<Node> queue = new Queue<Node>();
    queue.Enqueue(root);
    while (queue.Count > 0)
    {
        Node node = queue.Dequeue();
        Console.WriteLine(node.data);
        if (node.left != null)
        {
            queue.Enqueue(node.left);
        }
        if (node.right != null)
        {
            queue.Enqueue(node.right);
        }
    }
}

bool FloydCycleDetection(NodeLL node){
    NodeLL slow = node;
    NodeLL fast = node;
    while(fast != null && fast.next != null){
        slow = slow.next;
        fast = fast.next.next;
        if(slow == fast){
            return true;
        }
    }
    return false;
}

int MaxSubArray(int[] nums) {
    int max = int.MinValue;
    int sum = 0;
    for (int i = 0; i < nums.Length; i++) {
        sum += nums[i];
        max = Math.Max(max, sum);
        if (sum < 0) {
            sum = 0;
        }
    }
    return max;
}

//BestTimeToBuyAndSellStocks(new int[]{7,1,5,3,6,4});
int BestTimeToBuyAndSellStocks(int[] prices){
    int max = 0;
    int min = int.MaxValue;
    for (int i = 0; i < prices.Length; i++) {
        min = Math.Min(min, prices[i]);
        max = Math.Max(max, prices[i] - min);
    }
    return max;
}

// LengthOfLongestSubstring("abcabcbb");
// LengthOfLongestSubstring("bbbbb");

int LengthOfLongestSubstring(string s) {
    int max = 0;
    int start = 0;
    Dictionary<char, int> map = new Dictionary<char, int>();
    for (int i = 0; i < s.Length; i++) {
        if (map.ContainsKey(s[i])) {
            start = Math.Max(start, map[s[i]] + 1);
        }
        map[s[i]] = i;
        max = Math.Max(max, i - start + 1);
    }
    return max;
}

int[] DepthFirstSearch(int[][] graph, int start) {
    var visited = new bool[graph.Length];
    var stack = new Stack<int>();
    stack.Push(start);
    var result = new List<int>();
    while (stack.Count > 0) {
        var node = stack.Pop();
        if (visited[node]) {
            continue;
        }
        visited[node] = true;
        result.Add(node);
        foreach (var neighbor in graph[node]) {
            stack.Push(neighbor);
        }
    }
    return result.ToArray();
}

int[] BreadthFirstSearch(int[][] graph, int start) {
    var visited = new bool[graph.Length];
    var queue = new Queue<int>();
    queue.Enqueue(start);
    var result = new List<int>();
    while (queue.Count > 0) {
        var node = queue.Dequeue();
        if (visited[node]) {
            continue;
        }
        visited[node] = true;
        result.Add(node);
        foreach (var neighbor in graph[node]) {
            queue.Enqueue(neighbor);
        }
    }
    return result.ToArray();
}

int[] MergeSort(int[] array) {
    if (array.Length <= 1) {
        return array;
    }
    var mid = array.Length / 2;
    var left = MergeSort(array.Take(mid).ToArray());
    var right = MergeSort(array.Skip(mid).ToArray());
    return Merge(left, right);
}

int[] Merge(int[] left, int[] right) {
    var result = new int[left.Length + right.Length];
    int i = 0, j = 0, k = 0;
    while (i < left.Length && j < right.Length) {
        if (left[i] < right[j]) {
            result[k++] = left[i++];
        } else {
            result[k++] = right[j++];
        }
    }
    while (i < left.Length) {
        result[k++] = left[i++];
    }
    while (j < right.Length) {
        result[k++] = right[j++];
    }
    return result;
}

void QuickSort(int[] array, int start, int end) {
    if (start >= end) {
        return;
    }
    var pivot = array[start];
    var left = start;
    var right = end;
    while (left < right) {
        while (left < right && array[right] >= pivot) {
            right--;
        }
        array[left] = array[right];
        while (left < right && array[left] <= pivot) {
            left++;
        }
        array[right] = array[left];
    }
    array[left] = pivot;
    QuickSort(array, start, left - 1);
    QuickSort(array, left + 1, end);
}

class Node{
    public int data;
    public Node left;
    public Node right;
    public Node(int data){
        this.data = data;
    }
}
class NodeLL{
    public int data;
    public NodeLL next;
}
