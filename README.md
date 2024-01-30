Database Diagram:

![image](https://github.com/tolgaozkann/OttooPhase5/assets/96147862/9746b5c6-bf41-445c-a335-7e6940ca99cb)

System Tables Overview
The system comprises three primary tables, each serving a distinct purpose:

1. Users Table
This table stores essential information about users, including their unique user ID and name.

Fields:
id: The unique identifier for the user.
UserName: The name of the user.
2. Categories Table
The Categories table contains information related to book categories, such as category ID and name.

Fields:
id: The unique identifier for the category.
CategoryName: The name of the category.
3. Books Table
This table is responsible for storing details about individual books, encompassing book ID, title, and price.

Fields:
Booksid: The unique identifier for the book.
Title: The title of the book.
Price: The price of the book.
Table Relationships
The tables are intricately linked through both many-to-many and one-to-many relationships:

Users and Books Relationship
Users and Books are connected through the BookUser table, which features two foreign keys:

One references a user ID in the Users table.
The other references a book ID in the Books table.
This setup allows for a dynamic relationship where a user can borrow multiple books, and a book can be borrowed by multiple users.

Books and Categories Relationship
The Books and Categories tables are linked via a foreign key in the Books table known as CategoryID. This key references the ID column in the Categories table.

This relationship signifies that a book can belong to one category, and a category can encompass multiple books.
Detailed Table Structure
Users Table:
id: The unique identifier for the user.
UserName: The name of the user.
Categories Table:
id: The unique identifier for the category.
CategoryName: The name of the category.
Books Table:
Booksid: The unique identifier for the book.
Title: The title of the book.
Price: The price of the book.
BookUser Table:
Booksid: The foreign key referencing the Books table.
Usersid: The foreign key referencing the Users table.
