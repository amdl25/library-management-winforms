# Library Management System (C# Windows Forms)

Desktop application for managing a library: books, readers and loans, stored in a SQL Server LocalDB database. It was built to practice object-oriented programming in C# together with Windows Forms and ADO.NET.

## Features
- Add and update loans with loan and return dates, with the readers and books shown in data grids
- Input validation on the form fields
- View loan details and save them to a file
- Import and export data as TXT and XML files
- Drag and drop and printing support
- Charts drawn from the loan data
- Keyboard shortcuts on the forms

## OOP concepts demonstrated
- Abstract class (`Library`) and inheritance (`Book : Library`)
- `ICloneable` (`Book`, `Reader`) and `IComparable` (`Reader`)
- Operator overloading: `reader + loan` and `reader - loan`
- Delegates and events: `RestituireImprumutEventHandler` fires when a loan is returned
- Interface (`IAddable`) and a custom `UserControl` (`NameUserControl`)
- Typed DataSets and table adapters for database access

## Tech stack
C#, .NET Framework 4.7.2, Windows Forms, ADO.NET, SQL Server LocalDB.

## Project structure

```
LibraryManager.sln
LibraryManager/
  Library.cs, Book.cs, Reader.cs, Loan.cs   domain model
  MainForm.cs                               main window and menu
  LoanForm.cs                               add and update loans
  ViewForm.cs                               view loans
  FilesForm.cs                              TXT and XML import/export, printing, drag and drop
  ChartsForm.cs                             charts
  NameUserControl.cs                        custom control
  CititoriDataSet*.xsd                      typed DataSets
  Database/Cititori.dacpac                  database schema
  Database/readers_table.png                table diagram
```

## Getting started

### Prerequisites
- Windows
- Visual Studio 2022 with the ".NET desktop development" workload (includes SQL Server LocalDB)

### Database
1. In Visual Studio open **SQL Server Object Explorer** and connect to `(localdb)\MSSQLLocalDB`.
2. Right-click **Databases**, choose **Publish Data-tier Application** and select `LibraryManager/Database/Cititori.dacpac`. Name the database `Cititori`.

The connection string is in `LibraryManager/App.config`:

```
Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Cititori;Integrated Security=True
```

### Run
Open `LibraryManager.sln`, set `LibraryManager` as the startup project and press F5.

## Notes
- The database and its DataSets use the Romanian name `Cititori` (readers). The UI is in Romanian.
