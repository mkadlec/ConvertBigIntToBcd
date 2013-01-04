ConvertBigIntToBcd
==================

Convert a BigInt to a Binary Coded Decimal with padding

For example:

var bcdInBytes = ConvertBigIntToBcd(12345, 7);

Would return:

bcdInBytes = [18, 52, 95, 255, 255, 255, 255]
