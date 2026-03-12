# AkademikADOApp – Form Description

This project contains a simple Windows Forms interface that demonstrates how to connect and disconnect from a SQL Server database using ADO.NET.

## Form Overview

The application uses a single Windows Form that allows the user to control the database connection and view the connection status.

## Form Components

The form contains the following user interface elements:

1. **Connect Database Button**
   - Name: `btnConnect`
   - Function: This button is used to establish a connection to the SQL Server database.
   - When the button is clicked, the application attempts to open the database connection.

2. **Disconnect Database Button**
   - Name: `btnDisconnect`
   - Function: This button is used to close the database connection.
   - When the button is clicked, the application disconnects from the database.

3. **Status Label**
   - Name: `lblStatus`
   - Function: This label displays the current status of the database connection.
   - It informs the user whether the database is connected or disconnected.

## User Interaction

The user interacts with the form by clicking the buttons provided:

- Clicking **Connect Database** will attempt to open the connection to the database.
- Clicking **Disconnect Database** will close the existing connection.
- The **status label** updates to reflect the current connection state.

**Output:**

**Form:**
<img width="647" height="350" alt="image" src="https://github.com/user-attachments/assets/5a4c8a69-c3cb-403f-87a7-c77f142e4602" />

**When press Connect Database Button:**
<img width="731" height="341" alt="image" src="https://github.com/user-attachments/assets/8b48f425-eaf3-4666-8f47-62c253473b1d" />

**When press Disconnect Database Button:**
<img width="767" height="343" alt="image" src="https://github.com/user-attachments/assets/8c034662-f062-4265-ac12-c5bb343166d0" />



## Purpose of the Form

The main purpose of this form is to provide a simple graphical interface for demonstrating database connection management using ADO.NET in a Windows Forms application.
