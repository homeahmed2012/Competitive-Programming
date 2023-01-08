import sys

def calc(x, y, z):
    if(y == 0):
        return 1
    res = calc(x, y//2, z)%z
    res = (res**2)%z
    if(y%2 != 0):
        res *= x
    return res%z

all = []
for line in sys.stdin:
    all.append(line)

for i in range(0, len(all)-2, 4):
    print(calc(int(all[i]), int(all[i+1]), int(all[i+2])))
