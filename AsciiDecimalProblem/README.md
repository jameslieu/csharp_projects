### Ascii Decimal challenge

Given any string, write a function which calculates a numeric value assigned to that string using
the following rules:

- Each character has a decimal value equal to its ASCII code
- Where the same character repeats in a row, its value is only counted once
- If a character appears more than once non-consecutively, its calculated value is its
[decimal value] * [appearance count]
- The numeric value assigned to the string is the sum of the calculated values of the
characters in the string.

Example:
'AaaaaaaBbbccaaaaaaaaaaaAAAAAAAa' is calculated as shown below
65 + 97 + 66 + 98 + 99 + (97 * 2) + (65 * 2) + (97 * 3) = 1040
