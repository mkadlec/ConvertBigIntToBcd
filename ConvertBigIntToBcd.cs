        public static byte[] ConvertBigIntToBcd(long numberToConvert, int howManyBytes)
        {
            var convertedNumber = new byte[howManyBytes];
            var strNumber = numberToConvert.ToString();
            var currentNumber = string.Empty;

            for (var i = 0; i < howManyBytes; i++)
            {
                convertedNumber[i] = 0xff;
            }

            for (var i = 0; i < strNumber.Length; i++)
            {
                currentNumber += strNumber[i];

                if (i == strNumber.Length - 1 && i % 2 == 0)
                {
                    convertedNumber[i / 2] = 0xf;
                    convertedNumber[i / 2] |= (byte)((int.Parse(currentNumber) % 10) << 4);
                }

                if (i % 2 == 0) continue;
                var value = int.Parse(currentNumber);
                convertedNumber[(i - 1) / 2] = (byte) (value % 10);
                convertedNumber[(i - 1) / 2] |= (byte)((value / 10) << 4);
                currentNumber = string.Empty;
            }

            return convertedNumber;
        }
