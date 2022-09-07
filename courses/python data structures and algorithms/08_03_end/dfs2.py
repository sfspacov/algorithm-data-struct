offsets = {"up": (-1, 0), "right": (0, 1), "down": (1, 0), "left": (-1, 0)}


def get_path(predecessors, start, goal):
    current = goal
    path = []
    while current != start:
        path.append(current)
        # dictionary of tuple (sinistro!)
        current = predecessors[current]
    path.append(start)
    path.reverse()
    return path

def is_legal(maze, pos):
    i, j = pos
    num_rows = len(maze)
    num_cols = len(maze[0])
    return 0 <= i < num_rows and 0 <= j < num_cols and maze[i][j] != "*"


def dfs(start, goal, maze):
    stack = Stack()
    stack.push(start)
    predecessors = {Start: None}

    while not stack.is_empty():
        current_cell = stack.pop()
        if current_cell == goal:
            return get_path(predecessors, start, goal)
        for direction in ["up", "right", "down", "left"]:
            row_offset, col_offset = offsets[direction]
            current_row = current_cell[0]
            current_col = current_cell[1]
            # tuple row(i), column(j)
            neighbour = (current_row + row_offset, current_col + col_offset)
            if is_legal(maze, neighbour) and neighbour not in predecessors:
                stack.push(neighbour)
                predecessors[neighbour] = current_cell
    return None