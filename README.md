# GameZone

## Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)
- [Acknowledgements](#acknowledgements)

## Overview

GameZone is a web application developed using .NET 8 that allows users to manage a collection of video games. It provides functionalities to create, read, update, and delete (CRUD) game entries, offering a seamless experience for game enthusiasts to organize their game libraries.

## Features

- **Game Management**: Add new games with details such as title, genre, release date, and platform.
- **CRUD Operations**: Perform create, read, update, and delete operations on game entries.
- **Responsive Design**: Accessible on various devices with a user-friendly interface.

## Technologies Used

- **Backend**: ASP.NET Core 8
- **Frontend**: HTML, CSS, JavaScript
- **Database**: Entity Framework Core

## Getting Started

### Prerequisites

- .NET 8 SDK installed on your machine.
- A code editor, preferably Visual Studio or Visual Studio Code.

### Installation

1. **Clone the Repository**:

   ```bash
   git clone https://github.com/MohamedElgeddawy/GameZone.git
   ```

2. **Navigate to the Project Directory**:

   ```bash
   cd GameZone/GameZone
   ```

3. **Restore Dependencies**:

   ```bash
   dotnet restore
   ```

4. **Apply Migrations and Update the Database**:

   ```bash
   dotnet ef database update
   ```

5. **Run the Application**:

   ```bash
   dotnet run
   ```


## Usage

- **Adding a New Game**: Navigate to the "Add Game" section and fill in the required details.
- **Viewing Games**: The homepage displays a list of all games in the collection.
- **Editing a Game**: Click on the "Edit" button next to a game to modify its details.
- **Deleting a Game**: Click on the "Delete" button to remove a game from the collection.



## Acknowledgements

- Thanks to the .NET community for their continuous support and contributions.
- Inspired by various open-source projects and tutorials.


