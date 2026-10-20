# Baobab Ridge Wildlife Rehabilitation Records System

> **Course:** PRG2782 – Programming Project  
> **Platform:** C# Windows Forms Desktop Application (.NET 10, Windows)

---

## Project Overview

The **Baobab Ridge Wildlife Rehabilitation Records System** is a C# Windows Forms desktop application designed for a wildlife rehabilitation centre to track and manage animals under care. The system logs animal details, automatically computes recovery status and housing assignments based on recovery scores, and generates a summary report for administration.

---

## Technologies

- **Language:** C#
- **UI Framework:** Windows Forms (WinForms)
- **Target Framework:** .NET 10 (`net10.0-windows`)
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

## How to Build and Run

The program only runs on **Windows** because it uses Windows Forms.

**Option 1 – Visual Studio**
1. Install Visual Studio with the ".NET desktop development" workload and the .NET 10 SDK.
2. Open `BaobabRidgeWildlifeSystem.slnx`.
3. Press **F5** (or click Start) to build and run.

**Option 2 – Command line**
1. Install the .NET 10 SDK.
2. Open a terminal in the solution folder and run:
   ```text
   dotnet build
   dotnet run --project BaobabRidgeWildlifeSystem
   ```

When the program starts, the **View Animals** screen opens and loads `animals.txt` automatically. The other screens (Add, Update, Summary Report) are opened with the buttons at the top of that screen.

---

## Features

- **View Animals:** Loads the records from `animals.txt` and shows them in a read-only grid with the columns Animal ID, Name, Species, Age, Recovery Score, Status and Housing Unit.
- **Add Animals:** Validates and saves a new animal (ID, name, species, age, recovery score). Status and housing unit are worked out automatically from the recovery score.
- **Update Animals:** Find an animal by typing its ID in the search box (not case sensitive) or by clicking a row in the grid. The ID cannot be changed while editing. Status and housing unit are recalculated when the recovery score changes.
- **Delete Animals:** Removes the selected animal after a confirmation message ("Delete WR-0007 (Naledi)? This cannot be undone.").
- **Summary Report:** Click **Generate Summary** to calculate the total number of animals, the average age, the average recovery score and the number of animals in each of the 5 statuses. The results are shown on screen and saved to `summary.txt`.
- **Error handling:** Unexpected errors are shown in a message box and written to `errors.log`.

### Status and housing rules

| Recovery Score | Status | Housing Unit |
| :--- | :--- | :--- |
| 0 – 19 | Critical | Intensive Care Unit |
| 20 – 39 | Serious | High-Dependency Ward |
| 40 – 59 | Stable | Recovery Ward |
| 60 – 79 | Recovering | Outdoor Enclosure |
| 80 – 100 | Release-Ready | Pre-Release Camp |

### Validation rules

- **Animal ID:** `WR-` followed by 4 digits (e.g. `WR-0001`). Saved in capital letters and must be unique.
- **Name and Species:** required, 1–30 characters, cannot contain `|`.
- **Age:** whole number from 0 to 100.
- **Recovery Score:** whole number from 0 to 100.

---

## Data Files

### `animals.txt`
One animal per line, with 7 values separated by the pipe character (`|`):

```text
Animal ID|Name|Species|Age|Recovery Score|Status|Housing Unit
WR-0001|Naledi|Vervet Monkey|5|70|Recovering|Outdoor Enclosure
```

- The file is kept in the project folder and a copy is placed next to the program when it is built.
- When the program loads the file, any line that is not valid (wrong number of values, bad ID, age not 0–100, score not 0–100) is **skipped**, and one message shows how many lines were skipped.
- If the file is missing, an empty one is created. An empty file simply shows an empty grid.
- Status and Housing Unit are always recalculated from the Recovery Score, so the program does not depend on what was typed in those two columns.

### `summary.txt`
A plain text report created by the **Generate Summary** button. It is saved in the same folder as `animals.txt` and is overwritten every time the button is clicked. It contains:

```text
BAOBAB RIDGE WILDLIFE REHABILITATION CENTRE
ANIMAL SUMMARY REPORT
Generated: 2026-10-20 18:30
----------------------------------------
Total animals:            10
Average age (years):      6.80
Average recovery score:   52.10
----------------------------------------
Animals per status:
  Critical:               2
  Serious:                2
  Stable:                 1
  Recovering:             3
  Release-Ready:          2
```

- Averages have 2 decimals and use a full stop.
- If there are no animals, both averages show `N/A`.
- All 5 statuses are always listed, even when the count is 0.

### `errors.log`
Created next to the program when an error happens. It is not part of the repository.

---

## Known Limitations

- Windows only (Windows Forms).
- Data is stored in a plain text file, so there is no protection if two people use the program at the same time.
- The **ID** of an animal cannot be changed. To fix a wrong ID, delete the animal and add it again.
- Invalid lines in `animals.txt` are skipped (not fixed) and are not shown, only counted. They stay in the file until someone corrects them by hand.
- Delete uses the animal selected in the View Animals grid; there is no undo.
- Name and Species are limited to 30 characters and cannot contain `|`.
- Row selection in the Update screen is loaded when a row is clicked with the mouse; using only the arrow keys needs the **Update Animal** button.
- There are no automated tests; the program was tested by hand.
