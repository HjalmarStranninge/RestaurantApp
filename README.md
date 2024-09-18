# Restaurant management API

This API provides endpoints to manage bookings, customers, menu items, and tables for a restaurant system. Below is a list of available endpoints and their descriptions.

## Table of Contents
- [Bookings](#bookings)
- [Menu Items](#menu-items)
- [Customers](#customers)
- [Tables](#tables)

---

## Bookings

### Create a New Booking
- **Method**: `POST`
- **Route**: `/makenewbooking`
- **Description**: Creates a new booking.
- **Request Body**: `BookingRequestDTO`
- **Response**: Success message or error.

### Delete a Booking
- **Method**: `DELETE`
- **Route**: `/deletebooking`
- **Description**: Deletes an existing booking by ID.
- **Request Query**: `int id`
- **Response**: Success message or error.

### Update a Booking
- **Method**: `POST`
- **Route**: `/updatebooking`
- **Description**: Updates a booking.
- **Request Body**: `BookingUpdateDTO`
- **Response**: Success message or error.

### Get All Bookings
- **Method**: `GET`
- **Route**: `/getallbookings`
- **Description**: Retrieves all bookings.
- **Response**: List of bookings.

### Get a Specific Booking
- **Method**: `GET`
- **Route**: `/getbooking`
- **Description**: Retrieves details of a specific booking by ID.
- **Request Query**: `int id`
- **Response**: Booking details or "Booking not found" error.

---

## Menu Items

### Create a New Menu Item
- **Method**: `POST`
- **Route**: `/createmenuitem`
- **Description**: Creates a new menu item.
- **Request Body**: `MenuItemCreateDTO`
- **Response**: Success message or error.

### Delete a Menu Item
- **Method**: `DELETE`
- **Route**: `/deletemenuitem`
- **Description**: Deletes an existing menu item by ID.
- **Request Query**: `int id`
- **Response**: Success message or error.

### Update a Menu Item
- **Method**: `POST`
- **Route**: `/updatemenuitem`
- **Description**: Updates a menu item.
- **Request Body**: `MenuItemDTO`
- **Response**: Success message or error.

### Get All Menu Items
- **Method**: `GET`
- **Route**: `/getallmenuitems`
- **Description**: Retrieves all menu items.
- **Response**: List of menu items.

### Get a Specific Menu Item
- **Method**: `GET`
- **Route**: `/getmenuitem`
- **Description**: Retrieves details of a specific menu item by ID.
- **Request Query**: `int id`
- **Response**: Menu item details or "Menu item not found" error.

---

## Customers

### Create a New Customer
- **Method**: `POST`
- **Route**: `/createcustomer`
- **Description**: Creates a new customer.
- **Request Body**: `CustomerCreateDTO`
- **Response**: Success message or error.

### Delete a Customer
- **Method**: `DELETE`
- **Route**: `/deletecustomer`
- **Description**: Deletes an existing customer by ID.
- **Request Query**: `int id`
- **Response**: Success message or error.

### Update Customer Info
- **Method**: `POST`
- **Route**: `/updatecustomer`
- **Description**: Updates customer information.
- **Request Body**: `CustomerDTO`
- **Response**: Success message or error.

### Get All Customers
- **Method**: `GET`
- **Route**: `/getallcustomers`
- **Description**: Retrieves all customers.
- **Response**: List of customers.

### Get Customer by Phone Number
- **Method**: `GET`
- **Route**: `/getcustomerbyphone`
- **Description**: Retrieves customer details by phone number.
- **Request Query**: `string phoneNumber`
- **Response**: Customer details or "Customer not found" error.

### Get Customer by ID
- **Method**: `GET`
- **Route**: `/getcustomerbyid`
- **Description**: Retrieves customer details by ID.
- **Request Query**: `int id`
- **Response**: Customer details or "Customer not found" error.

---

## Tables

### Create a New Table
- **Method**: `POST`
- **Route**: `/createtable`
- **Description**: Creates a new table.
- **Request Body**: `TableCreateDTO`
- **Response**: Success message or error.

### Delete a Table
- **Method**: `DELETE`
- **Route**: `/deletetable`
- **Description**: Deletes an existing table by ID.
- **Request Query**: `int id`
- **Response**: Success message or error.

### Update a Table
- **Method**: `POST`
- **Route**: `/updatetable`
- **Description**: Updates table information.
- **Request Body**: `TableDTO`
- **Response**: Success message or error.

### Get All Tables
- **Method**: `GET`
- **Route**: `/getalltables`
- **Description**: Retrieves all tables.
- **Response**: List of tables.

### Get a Specific Table
- **Method**: `GET`
- **Route**: `/gettable`
- **Description**: Retrieves details of a specific table by ID.
- **Request Query**: `int id`
- **Response**: Table details or "Table not found" error.

