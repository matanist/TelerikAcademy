## Strings and Text Processing

**Task 01.** Describe the strings in C#. What is typical for the string data type? Describe the most important methods of the String class.

**Task 02.** Write a program that reads a string, reverses it and prints the result at the console.
>Example: sample → **elpmas**

**Task 03.** Write a program to check if in a given expression the brackets are put correctly.
>Examples:
* Correct expression: **((a+b)/5-d)**
* Incorrect expression: **)(a+b))**

**Task 04.** Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
>Example:
The target substring is `in`. The text is as follows:
```
We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
```
The result is: **9**

**Task 05.** You are given a text. Write a program that changes the text in all regions surrounded by the tags `<upcase>` and `</upcase>` to uppercase. The tags cannot be nested.
>Example:
```html
We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
```
The expected result:
```
We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
```

**Task 06.** Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with `*`. Print the result string into the console.

**Task 07.** Write a program that encodes and decodes a string using given encryption key (cipher). The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.

**Task 08.** Write a program that extracts from a given text all sentences containing given word. Consider that the sentences are separated by `.` and the words – by non-letter symbols.
>Example: The word is `in`. The text is:
```
We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
```
The expected result is:
```
We are living in a yellow submarine. We will move out of it in 5 days.
```

**Task 09.** We are given a string containing a list of forbidden words and a text containing some of these words. Write a program that replaces the forbidden words with asterisks.
>Example:
```
Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4 and is implemented as a dynamic language in CLR.
```
The words are: `PHP`, `CLR` and `Microsoft`. The expected result:
```
********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.
```

**Task 10.** Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings.
>Example: Sample input: `Hi!`. Expected output: `\u0048\u0069\u0021`

**Task 11.** Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation. Format the output aligned right in 15 symbols.

**Task 12.** Write a program that parses an URL address given in the format: [protocol]://[server]/[resource].
>Example:
* URL = **http://www.devbg.org/forum/index.php**
* [protocol] = **http**
* [server] = **www.devbg.org**
* [resource] = **/forum/index.php**

**Task 13.** Write a program that reverses the words in given sentence.
>Example:
```
C# is not C++, not PHP and not Delphi!
```
The expected result:
```
Delphi not and PHP, not C++ not is C#!
```

**Task 14.** A dictionary is stored as a sequence of text lines containing words and their explanations. Write a program that enters a word and translates it by using the dictionary.
>Example for dictionary:
<table>
    <tr><td>.NET</td><td>platform for applications from Microsoft</td></tr>
    <tr><td>CLR</td><td>managed execution environment for .NET</td></tr>
    <tr><td>namespace</td><td>hierarchical organization of classes</td></tr>
</table>  

**Task 15.** Write a program that replaces in a HTML document given as string all the tags `<a href="...">...</a>` with corresponding tags `[URL=...]...[/URL]`.
>Example:
>* HTML fragment:
>
```html
<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
```
>* Output:
>
```html
<p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>
```

**Task 16.** Write a program that reads two dates in the format: `day.month.year` and calculates the number of days between them.
>Example:
* Enter the first date: **27.02.2006**
* Enter the second date: **3.03.2006**
* Distance: **4 days**

**Task 17.** Write a program that reads a date and time given in the format: `day.month.year hour:minute:second` and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

**Task 18.** Write a program for extracting all email addresses from given text. All substrings that match the format `<identifier>@<host>...<domain>` should be recognized as emails.

**Task 19.** Write a program that extracts from a given text all dates that match the format `DD.MM.YYYY`. Display them in the standard date format for Canada.

**Task 20.** Write a program that extracts from a given text all palindromes, e.g. `ABBA`, `lamal`, `exe`.

**Task 21.** Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.

**Task 22.** Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.

**Task 23.** Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
>Example: aaaaabbbbbcdddeeeedssaa → **abcdedsa**

**Task 24.** Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

**Task 25.** Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
>Example:
```html
   <html>
     <head><title>News</title></head>
     <body>
       <p><a href="http://academy.telerik.com">Telerik Academy</a> aims to provide free real-world practical
       training for young people who want to turn into skillful .NET software engineers.</p>
     </body>
   </html>
```
