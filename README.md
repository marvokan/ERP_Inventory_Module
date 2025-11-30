# Inventory Management System

A comprehensive enterprise-class inventory management system built with C# and .NET 8.0, featuring a Windows Forms UI and multi-database support.

## Overview

This project is an ERP (Enterprise Resource Planning) inventory module designed to manage inventory operations including item tracking, inventory audits, package/barcode management, and store location management. The system implements a layered architecture with clear separation of concerns using established design patterns.

## Features

- **Item Management** - Complete CRUD operations for product/item records
- **Inventory Audits** - Track inventory counts with header/line item structure
- **Package Management** - Barcode and serial number tracking for items
- **Store & POS Management** - Multi-location inventory tracking
- **Master-Detail Forms** - Rich UI for managing parent-child data relationships
- **Multi-Database Support** - MS SQL Server (local and remote) and SQLite
- **Data Validation** - Automatic state tracking for records (New, Updated, Deleted)

## Technology Stack

- **Language:** C# (.NET 8.0)
- **UI Framework:** Windows Forms (WinForms)
- **Database:** MS SQL Server, MS SQL LocalDB, SQLite
- **ORM:** Dapper
- **Architecture:** Layered/N-Tier with MVVM-like patterns

## Project Structure

The solution consists of 7 projects organized in a layered architecture:

### Core Libraries

#### **Lib**
Generic, reusable business logic components providing:
- Database abstraction layer (`CDBMSSQL`, `CDBMSSQLLocal`, `CDBSQLite`)
- Common interfaces (`IDBTable`, `IDatabase`, `IDataModule`)
- Base record class with state tracking (`CDBRecord`)
- MSSQL LocalDB instance launcher

#### **Lib.UX**
Generic, reusable Windows Forms UI components:
- Form templates for master/detail CRUD operations
- Data grid decorators (Browser, Detail, Editable)
- Builder pattern for form construction
- Form state management
- Control extension methods

### Application-Specific Projects

#### **Inventory.Common**
Application-specific configuration:
- Settings management (Singleton pattern)
- JSON-based configuration
- Database connection string management

#### **Inventory.Data** (Project.Data)
Data access layer:
- **Data Records:** `ITEM`, `ITEM_INV`, `ITEM_INV_LINE`, `ITEM_PKG`, `STORE`, `STORE_POS`
- **Views:** `V_INVENTORIES`
- **Factory:** `CDataTableFactory` for creating table objects with lazy initialization
- Dapper-based SQL query execution

#### **Inventory.Logic** (Project.Logic)
Business logic layer:
- **Entities:** Business objects (`CItem`, `CItem_Inv`, `CItem_Inv_Line`, `CItem_Pkg`)
- **Models:** UI data models with lookup capabilities
- **Modules:** Data modules implementing master-detail operations (`DMItem_Inv`)
- **Builders:** Data module builders for assembling complex components

#### **Inventory.UX**
Application-specific UI implementation:
- Form templates for inventory operations
- Browser views for listing records
- Entity detail views for editing
- Table-specific forms for items, packages, stores, and POS

#### **WindowsApp**
Main application entry point and executable.

## Architecture

The system implements a layered architecture with clear data flow:

```
WindowsApp (Entry Point)
    ↓
Inventory.UX (UI Forms)
    ↓
Lib.UX (Generic Form Templates)
    ↓
Inventory.Logic (Business Logic)
    ├── Entities
    ├── Models
    └── Modules (Master/Detail)
        ↓
    Inventory.Data (Data Access)
        ├── Records
        └── CDataTableFactory
            ↓
        Lib (Database Abstraction)
            ↓
        Database (SQL Server / SQLite)
```

## Design Patterns

The project implements several enterprise design patterns:

- **Factory Pattern** - Creating table objects and database instances
- **Builder Pattern** - Constructing complex forms and data modules
- **Singleton Pattern** - Application settings and data factory
- **State Pattern** - Form state management (Initial, BrowserLoaded, EditingEntity, etc.)
- **Visitor Pattern** - Data transformation between entities, models, and tables
- **Template Method Pattern** - Base form classes and data modules
- **Repository Pattern** - Data access abstraction
- **Proxy Pattern** - Form delegates to data module

## Database Schema

The system manages a comprehensive ERP schema including:

- **Core Tables:** STORE, ITEM, ITEM_PKG, ITEM_INV, ITEM_INV_LINE
- **Reference Tables:** MEASUREMENT_UNIT, ITEM_CATEGORY, PACKAGE_TYPE, STORE_POS
- **Extended Schema:** CUSTOMER, SUPPLIER, INVOICE, PAYMENT, PRODUCTION (defined for future expansion)

Database scripts are provided:
- `Schema.Full.SQL` - Complete schema definition
- `Data_Input.sql` - Initial data setup
- `Test_Inventory.sql` - Test data

## Getting Started

### Prerequisites

- .NET 8.0 SDK or later
- MS SQL Server (or SQL Server Express/LocalDB)
- Visual Studio 2022 or later (recommended)

### Setup

1. Clone the repository
2. Open `Project.sln` in Visual Studio
3. Set up the database:
   - Execute `Schema.Full.SQL` to create the database schema
   - Run `Data_Input.sql` for initial reference data
   - (Optional) Run `Test_Inventory.sql` for test data
4. Update connection string in `settings.json`
5. Build the solution
6. Run the `WindowsApp` project

## Configuration

Application settings are stored in `settings.json`. Update the database connection string as needed:

```json
{
  "ConnectionString": "your-connection-string-here"
}
```

## Development

The project follows SOLID principles with clear separation of concerns:

- **Generic components** are in `Lib` and `Lib.UX` for reusability
- **Application-specific logic** is in `Inventory.*` projects
- **Database operations** use Dapper for performance
- **UI forms** follow template patterns for consistency
- **State management** ensures data integrity

## License

[Specify your license here]

## Contributing

[Add contribution guidelines if applicable]
