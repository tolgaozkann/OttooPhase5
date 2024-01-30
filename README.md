Database Diagram:

![image](https://github.com/tolgaozkann/OttooPhase5/assets/96147862/9746b5c6-bf41-445c-a335-7e6940ca99cb)

The System has three tables:
• Users table: This table stores information about users, such as their user ID and name.
• Categories table: This table stores information about book categories, such as the 
category ID and name.
• Books table: This table stores information about books, such as the book ID, title, and 
price.
The tables are related to each other through many-to-many and one-to-many relationships:
• Users and Books are related through the BookUser table. This table has two foreign keys: 
one that references a user ID in the Users table and another that references a book ID in 
the Books table. This means that a user can borrow many books, and a book can be 
borrowed by many users.
• Books and Categories are related through a foreign key in the Books table 
called CategoryID. This references the ID column in the Categories table. This means 
that a book can belong to one category, and a category can have many books.
• Users table:
o id: The unique identifier for the user.
o UserName: The name of the user.
• Categories table:
o id: The unique identifier for the category.
o CategoryName: The name of the category.
• Books table:
o Booksid: The unique identifier for the book.
o Title: The title of the book.
o Price: The price of the book.
• BookUser table:
o Booksid: The foreign key that references the Books table.
o Usersid: The foreign key that references the Users table
