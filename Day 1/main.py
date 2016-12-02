directions = enumerate(["North", "East", "South", "West"])

class locationAndOrientation:
    def __init__(self):
        self.x = 0
        self.y = 0
        self.direction = 0
        self.visited = [(0, 0)]

    def turnLeft(self):
        if self.direction == 0:
            self.direction = 3
        else:
            self.direction -= 1

    def turnRight(self):
        if self.direction == 3:
            self.direction = 0
        else:
            self.direction += 1

    def go(self, amount):
        if self.direction == 0:
            while amount > 0:
                self.y += 1
                if (self.x, self.y) in self.visited:
                    return 1
                else:
                    self.visited.append((self.x, self.y))
                amount -= 1
        elif self.direction == 1:
            while amount > 0:
                self.x += 1
                if (self.x, self.y) in self.visited:
                    return 1
                else:
                    self.visited.append((self.x, self.y))
                amount -= 1
        elif self.direction == 2:
            while amount > 0:
                self.y -= 1
                if (self.x, self.y) in self.visited:
                    return 1
                else:
                    self.visited.append((self.x, self.y))
                amount -= 1
        elif self.direction == 3:
            while amount > 0:
                self.x -= 1
                if (self.x, self.y) in self.visited:
                    return 1
                else:
                    self.visited.append((self.x, self.y))
                amount -= 1

file = open("input.txt", mode='r')
data = file.read()
instructions = data.split(', ')
player = locationAndOrientation()
for instruction in instructions:
    if instruction[0] == 'R':
        player.turnRight()
    else:
        player.turnLeft()
    result = player.go(int(instruction[1:]))
    if result == 1:
        break
if player.x < 0:
    player.x *= -1
if player.y < 0:
    player.y *= -1
print(player.x + player.y)