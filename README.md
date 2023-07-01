# Book Management System
This application enables the management of books, authors, publishers, and categories. It utilizes a architectural structure utilizing Generic Repository and Dependency Injection to perform these operations. This structure can help prevent code repetition, enhance testability, and provide a more flexible application development.

For example, Generic Repository allows you to manage database operations (such as adding, updating, deleting, and querying) through a generic interface. You can create classes like BookRepository, AuthorRepository, PublisherRepository, and CategoryRepository that implement this generic repository interface and perform operations related to the respective tables.

Dependency Injection allows you to inject the necessary objects into other classes that will use these repository classes (e.g., BookController). As a result, you can utilize the Generic Repository interface in the BookController class to perform book-related operations. Similarly, you can perform relevant operations in other controller classes. Therefore, this application enables the management of books, authors, publishers, and categories. Below is an example of an application that can be built using these tables:

# Book Management

You can add, update, and delete books.
Each book can be associated with an author, a publisher, and a category.
You can store information such as page count and publication date for books.

# Author Management

You can add, update, and delete authors.
Each author can have information such as birth date and (optionally) death date.
Authors can be associated with the books they have written.

# Publisher Management

You can add, update, and delete publishers.
Each publisher can have information such as address, phone number, and establishment date.
Publishers can be associated with the books they have published.

# Category Management

You can add, update, and delete categories.
Each category can have a description.
Categories can be associated with the books belonging to them.
In this example, each model class (Publisher, Category, Book, Author) corresponds to tables in the database. Each class is used in conjunction with the related classes.

For instance, in the BookController class, you can perform CRUD (create, read, update, delete) operations on books. Similarly, you can manage the relevant data using AuthorController, PublisherController, and CategoryController classes.

There are numerous customizations and functionalities that can be added based on these tables. For example, you can incorporate operations such as search, filtering, sorting, navigate between related data, and more. This is a general example of a basic library management application that can be customized to suit your needs.
