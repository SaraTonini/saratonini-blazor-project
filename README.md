# EventEase App

## Overview

EventEase is a web application designed for managing corporate and social events seamlessly. This app allows users to explore events with details such as event name, date, and location, navigate smoothly between pages, and register for events efficiently.

## Features

- **Event Card Component**: Displays essential event details with two-way data binding.
- **Event List with Pagination**: Optimizes performance by efficiently rendering large datasets.
- **Routing Functionality**: Includes error handling for invalid paths.
- **Registration Form**: Validates user input for registration.
- **State Management**: Tracks user sessions using local storage.
- **Attendance Tracker**: Monitors event participation.

## How Copilot Assisted

### Activity 1: Generating Blazor Code
Copilot generated the foundational Event Card component, providing:
- Fields for event name, date, and location.
- Two-way data binding for dynamic updates.

### Activity 2: Debugging and Optimization
Copilot assisted in:
- Identifying and fixing data binding issues.
- Resolving routing errors and handling invalid paths.
- Improving performance for large event datasets.

### Activity 3: Adding Advanced Features
Copilot helped implement:
- A Registration Form with data validation.
- State management for user sessions.
- An Attendance Tracker to monitor event participation.

## Getting Started

### Prerequisites
- .NET 6.0 SDK or higher
- Visual Studio Code or any C# compatible IDE
- Blazored.LocalStorage package

### Installation

1. **Clone the Repository**:
    ```sh
    git clone https://github.com/SaraTonini/saratonini-blazor-project.git
    cd EventEaseApp
    ```

2. **Restore NuGet Packages**:
    ```sh
    dotnet restore
    ```

3. **Build the Project**:
    ```sh
    dotnet build
    ```

4. **Run the Application**:
    ```sh
    dotnet run
    ```

### Usage
1. Open your web browser and navigate to `http://localhost:5000`.
2. Explore the event list, view event details, and register for events.

## Contributing
Contributions are welcome! Please follow these steps:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature-branch`).
3. Commit your changes (`git commit -m 'Add some feature'`).
4. Push to the branch (`git push origin feature-branch`).
5. Open a pull request.

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Acknowledgements
- Special thanks to Microsoft Copilot for assisting in the development process.
- Inspired by the needs of event management professionals.

