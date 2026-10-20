# Baobab Ridge Wildlife Rehabilitation Records System

> **Course:** PRG2782 – Programming Project  
> **Platform:** C# Windows Forms Desktop Application (.NET 8.0+)

---

## Project Overview

The **Baobab Ridge Wildlife Rehabilitation Records System** is a C# Windows Forms desktop application designed for a wildlife rehabilitation centre to track and manage animals under care. The system logs animal details, automatically computes recovery status and housing assignments based on recovery scores, and generates summary reports for administration.

---

## Technologies

- **Language:** C#
- **UI Framework:** Windows Forms (WinForms)
- **Target Framework:** .NET 8.0 or newer
- **Storage:** Text-file storage (`.txt`)
- **Version Control:** Git & GitHub

---

## Group Members

| Student Name | Student ID |
| :--- | :--- |
| Louis Glaeser Coetzee | 603309 |
| Masego Boikanyo Moima | 604834 |
| Marinus du Randt | 604045 |
| Gosiame Gonqga | 603062 |
| Thakgatso Seroka | 601855 |

---

## Features

- **Add Animals:** Validate and enter new animal records (ID, name, species, age, recovery score). Automatically calculates recovery status and housing unit allocation.
- **View Animals:** Load valid records from `animals.txt` and display them in a read-only `DataGridView`.
- **Update Animals:** Search records by ID or select directly from the grid to modify permissible data. Automatically recomputes recovery status and housing allocation upon update.
- **Delete Animals:** Remove animal records after explicit user confirmation.
- **Generate Summary Reports:** Calculate system-wide statistics (total count, average age, average recovery score, status breakdowns), display results in the UI, and write them to `summary.txt`.

---

## Data File Formats

### `animals.txt`
- Single-line records for each animal using pipe-delimited (`|`) values:
  ```text
  Animal ID | Name | Species | Age | Recovery Score | Status | Holding Unit
