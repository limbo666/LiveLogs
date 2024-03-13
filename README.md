# LiveLogs
![image](https://github.com/limbo666/LiveLogs/assets/331155/df2efe86-229a-49c1-99ce-32d22ab8ecda)

## Live Log Viewer and Search Tool for Windows
This tool inspired from Linux "tail" command 

## Overview
This application provides a simple yet powerful tool for viewing and searching log files. It allows users to load log files, monitor them in real-time, and search for specific text within the logs.

## GUI preview
Main window

![image](https://github.com/limbo666/LiveLogs/assets/331155/b46027ad-840d-4aa8-a65f-c75e8040b915)

Conditional options

![image](https://github.com/limbo666/LiveLogs/assets/331155/d82d7a31-db53-40c4-b094-81e3426ea2ce)




## Features
- **Real-time Log Monitoring:** The application continuously reads log files, displaying new entries as they are added.
- **Search Functionality:** Users can search for specific text within the log file and navigate between search results.
- **User-Friendly Interface:** The interface is intuitive and easy to use, with options to customize log viewing preferences.
- **Conditional Color:** The program displayes lines in different colors. Keywords can be defined under Conditional options.
- **Conditional Actions:** Sound, Popup window, Extrernal program (script) running. Keywords can be defined under Conditional options.

## Usage
1. **Select Log File:** Choose a log file using the "Select Log File" option from the menu or by entering the file path directly.
2. **Start Log Monitoring:** Click the "Start Reading" button to begin monitoring the log file in real-time.
3. **Search for Text:** Use the search bar to enter the text you want to search for within the log file. Press Enter or click the search button to start the search.
4. **Navigate Search Results:** If search results are found, use the navigation buttons to move between occurrences.
5. **Stop Log Monitoring:** Click the "Stop Reading" button to pause log monitoring.

## Testing
A tool that creates random log lines is available on the following repository: https://github.com/limbo666/RandomLogWriter
Use this to create/update a log file and check the LiveLogs fucntioanlity.

## Requirements
- **Operating System:** Windows
- **.NET Framework:** .NET Framework 4.8 or later

## Getting Started
**Select A or B** <br>
A.
1. Get the program from [releases](https://github.com/limbo666/LiveLogs/releases).
2. Unzip to a folder.
3. Run the executable file (`LiveLogs.exe`) to launch the application.

B.
1. Clone the repository to your local machine.
2. Open the solution file (`LiveLogs.sln`) in Visual Studio.
3. Build the solution to generate the executable file.
4. Run the executable file (`LiveLogs.exe`) to launch the application.

## License
This project is licensed under the MIT License
