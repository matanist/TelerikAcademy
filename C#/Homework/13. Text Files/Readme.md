## Text Files

**Task 01.** Write a program that reads a text file and prints on the console its odd lines.

**Task 02.** Write a program that concatenates two text files into another text file.

**Task 03.** Write a program that reads a text file and inserts line numbers in front of each of its lines. The result should be written to another text file.

**Task 04.** Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different. Assume the files have equal number of lines.

**Task 05.** Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area of size 2×2 with a maximal sum of its elements. The first line in the input file contains the size of matrix N. Each of the next N lines contain N numbers separated by space. The output should be a single number in a separate text file.
>Example: **N=4**
<table>
    <tr><td>2</td><td>3</td><td>3</td><td>4</td></tr>
    <tr><td>0</td><td>2</td><td>3</td><td>4</td></tr>
    <tr><td><b>3</b></td><td><b>7</b></td><td>1</td><td>2</td></tr>
    <tr><td><b>4</b></td><td><b>3</b></td><td>3</td><td>2</td></tr>
</table>

**Task 06.** Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
>Example:
<table>
    <tr><td>Ivan</td><td>George</td></tr>
    <tr><td>Peter</td><td>Ivan</td></tr>
    <tr><td>Maria</td><td>Maria</td></tr>
    <tr><td>George</td><td>Peter</td></tr>
</table>

**Task 07.** Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. Ensure it will work with large files (e.g. 100 MB).

**Task 08.** Modify the solution of the previous problem to replace only whole words (not substrings).

**Task 09.** Write a program that deletes from given text file all odd lines. The result should be in the same file.

**Task 10.** Write a program that extracts from given XML file all the text without the tags.
>Example:
```xml
    <?xml version="1.0"?>
    <student>
        <name>Pesho</name>
        <age>21</age>
        <interests count="3">
            <interest>Games</interest>
            <interest>C#</interest>
            <interest>Java</interest>
        </interests>
    </student>
```

**Task 11.** Write a program that deletes from a text file all words that start with the prefix "test". Words contain only the symbols 0...9, a...z, A...Z, _.

**Task 12.** Write a program that removes from a text file all words listed in given another text file. Handle all possible exceptions in your methods.

**Task 13.** Write a program that reads a list of words from a file words.txt and finds how many times each of the words is contained in another file test.txt. The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order. Handle all possible exceptions in your methods.
