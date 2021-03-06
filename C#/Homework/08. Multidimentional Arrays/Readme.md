## Multidimensional Arrays

**Task 01.** Write a program that fills and prints a matrix of size N×N as shown below:
>**N=4**
<table>
    <tr><td>&nbsp;&nbsp;1</td><td>&nbsp;&nbsp;5</td><td>&nbsp;&nbsp;9</td><td>13</td></tr>
    <tr><td>&nbsp;&nbsp;2</td><td>&nbsp;&nbsp;6</td><td>10</td><td>14</td></tr>
    <tr><td>&nbsp;&nbsp;3</td><td>&nbsp;&nbsp;7</td><td>11</td><td>15</td></tr>
    <tr><td>&nbsp;&nbsp;4</td><td>&nbsp;&nbsp;8</td><td>12</td><td>16</td></tr>
</table>
<table>
    <tr><td>&nbsp;&nbsp;1</td><td>&nbsp;&nbsp;8</td><td>&nbsp;&nbsp;9</td><td>16</td></tr>
    <tr><td>&nbsp;&nbsp;2</td><td>&nbsp;&nbsp;7</td><td>10</td><td>15</td></tr>
    <tr><td>&nbsp;&nbsp;3</td><td>&nbsp;&nbsp;6</td><td>11</td><td>14</td></tr>
    <tr><td>&nbsp;&nbsp;4</td><td>&nbsp;&nbsp;5</td><td>12</td><td>13</td></tr>
</table>
<table>
    <tr><td>&nbsp;&nbsp;7</td><td>11</td><td>14</td><td>16</td></tr>
    <tr><td>&nbsp;&nbsp;4</td><td>&nbsp;&nbsp;8</td><td>12</td><td>15</td></tr>
    <tr><td>&nbsp;&nbsp;2</td><td>&nbsp;&nbsp;5</td><td>&nbsp;&nbsp;9</td><td>13</td></tr>
    <tr><td>&nbsp;&nbsp;1</td><td>&nbsp;&nbsp;3</td><td>&nbsp;&nbsp;6</td><td>10</td></tr>
</table>
<table>
    <tr><td>&nbsp;&nbsp;1</td><td>12</td><td>11</td><td>10</td></tr>
    <tr><td>&nbsp;&nbsp;2</td><td>13</td><td>16</td><td>&nbsp;&nbsp;9</td></tr>
    <tr><td>&nbsp;&nbsp;3</td><td>14</td><td>15</td><td>&nbsp;&nbsp;8</td></tr>
    <tr><td>&nbsp;&nbsp;4</td><td>&nbsp;&nbsp;5</td><td>&nbsp;&nbsp;6</td><td>&nbsp;&nbsp;7</td></tr>
</table>

**Task 02.** Write a program that reads a rectangular matrix of size N×M and finds in it the square 3×3 that has maximal sum of its elements.

**Task 03.** We are given a matrix of strings of size N×M. Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix.
>Examples:
<table>
    <tr><td><strong>ha</strong></td><td>fifi</td><td>ho</td><td>hi</td></tr>
    <tr><td>fo</td><td><strong>ha</strong></td><td>hi</td><td>xx</td></tr>
    <tr><td>xxx</td><td>ho</td><td><strong>ha</strong></td><td>xx</td></tr>
</table>
<table>
    <tr><td>s</td><td>qq</td><td><strong>s</strong></td></tr>
    <tr><td>pp</td><td>pp</td><td><strong>s</strong></td></tr>
    <tr><td>pp</td><td>qq</td><td><strong>s</strong></td></tr>
</table>

**Task 04.** Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method `Array.BinarySearch()` finds the largest number in the array which is <= K.

**Task 05.** You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

**Task 06\*.** Write a class Matrix to hold a matrix of integers. Overload the operators for adding, subtracting and multiplying of matrices, indexer for accessing the matrix content and `ToString()`.

**Task 07\*.** Write a program that finds the largest area of equal neighbor elements in a rectangular matrix and prints its size.
>Example:
<table>
    <tr><td>1</td><td><strong>3</strong></td><td>2</td><td>2</td><td>2</td><td>4</td></tr>
    <tr><td><strong>3</strong></td><td><strong>3</strong></td><td><strong>3</strong></td><td>2</td><td>4</td><td>4</td></tr>
    <tr><td>4</td><td><strong>3</strong></td><td>1</td><td>2</td><td><strong>3</strong></td><td><strong>3</strong></td></tr>
    <tr><td>4</td><td><strong>3</strong></td><td>1</td><td><strong>3</strong></td><td><strong>3</strong></td><td>1</td></tr>
    <tr><td>4</td><td><strong>3</strong></td><td><strong>3</strong></td><td><strong>3</strong></td><td>1</td><td>1</td></tr>
</table>

Hint: you can use the algorithm "Depth-first search" or "Breadth-first search".
