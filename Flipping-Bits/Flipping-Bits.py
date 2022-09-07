def flippingBits(n):
    bitformat = '{:>032d}'.format(n).replace("0", "2").replace("1", "0").replace("2", "1")

    return int(bitformat, 2)
    #return 2**32+~n indian answer



print(
    flippingBits(1)
)
print(
    flippingBits(0)
)