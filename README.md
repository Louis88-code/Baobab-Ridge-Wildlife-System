# Baobab Ridge Wildlife Rehabilitation Records System

## Project
PRG2782 - Programming Project

## project overview
The Baobab Ridge Wildlife Rehabilitation Records System is a C# Windows Forms desktop application designed to help a fictional wildlife rehabilitation centre maintain records of animals receiving care. The system records animal details, calculates recovery status and housing unit from the recovery score, and generates a summary report for the centre manager.

## Technologies
- C#
- Windows Forms
- .NET 8.0 or newer
- Git and GitHub
- Text-file storage

## Group Member
Louis Glaeser Coetzee - 603309
Masego Boikanyo Moima - 604834
Marinus du Randt - 604045
Gosiame Gonqga - 603062
Thakgatso Seroka - 601855

## Features
- Add animals: The user can enter the animal's ID, name, species, age, and recovery score. This is validated by the system and the status of the animal and its housing unit is determined
  
- View animals: Valid records are loaded from animals.txt and displayed using a read-only DataGridView control.
  
- Update animals: Enables users to select records by clicking on them from the grid or searching for their IDs. The users can change the permissible data, and the system will recompute status and accommodation.
  
- Delete animals: Enables the user to choose an animal and delete it after verification of the process.

- Generate summary reports: Calculates total number of animals, the average age of animals, the average score for recovery, and the number of animals in each status. These are displayed in the application interface and stored in summary.txt.

## Data file formats 
animals.txt:
- File contains single-line records for each animal.
- There are seven fields in a line separated by the pipe symbol (|) and in the following order:
  Animal ID | Name | Species | Age | Recovery Score | Status | Holding Unit
- Text file is encoded in the UTF-8 format and does not contain any header line.
- There should be no less than eight valid entries as starters with at least four different statuses.
- This file should be copied into the output directory alongside the executable program.

summary.txt:
- Generated upon the generation of the summary report.
- Includes the report header, the timestamp of generation, total number of animals, average age, average recovery score, and the total counts of all five categories.
- This file gets overwritten every time a summary report is generated.
- Averages should be accurate to two decimal points using a full stop as the decimal point character.
- In cases where there are no animals, the total and counts are zeroes, and the averages show N/A.

## Validation rules 
- Animal ID is mandatory, should be in the format WR- followed by exactly 4 digits, and should be unique. Animal ID is converted to upper case for validation and saving.
- Animal ID cannot be changed once the record is saved.
- Name and Species are mandatory and should have at least one but no more than 30 characters.
- Name and Species cannot contain the pipe | symbol.
- Age should be an integer between 0 and 100 inclusive.
- Recovery Score should be an integer between 0 and 100 inclusive.
- The input text is trimmed of leading and trailing whitespaces for validation.

## Build and Run
1. Download Visual Studio using the .NET desktop development workload and a suitable .NET 8.0+ SDK.
2. Checkout the team’s GitHub repository onto a brand new, empty folder.
3. Load up the solution (.sln) or project (.csproj) on Visual Studio.
4. Restore/build the project.
5. Make sure that the animals.txt file is part of the project and it will be copied to the output directory (Copy if newer).
6. Execute the project using Visual Studio.
7. Verify that animals.txt file exists beside the application, which is currently executing. The application is expected to create an empty one if there is no animals.txt present.

## Error handling
Errors in file handling, such as non-existent files and folders, files in use by other applications and problems related to permissions have to be handled. There should be no stack trace but only friendly messages and the application has to keep working. Malformed lines in animal records during file loading have to be ignored. The user must be informed about that number of lines.

## Git and Github workflow
Initialize Git before writing the application.
- Keep main as the stable branch and make sure that it compiles.
- Write Add, View, Update, Delete, and Summary functionalities using feature branches.
- Merge feature branches into main using GitHub pull requests.
- Make at least 15 commits altogether.
- Every team member should make at least three commits using their own Git identity on at least three different days.
- Every team member should have at least one merged pull request.
- Commit your work regularly and make sure that the GitHub main branch matches the submitted version.
- Do not commit bin/, obj/, .vs/ and other automatically generated files such as summary.txt.
- Make sure that the repository is public or that the lecturer is a collaborator.

## Project integrity 
The code and documentation must be done by the group itself. Each one must know the system well enough to explain his/her part of the work.
