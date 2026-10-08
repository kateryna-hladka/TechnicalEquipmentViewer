# Technical Equipment Viewer

WPF application for displaying technical equipment data received from an API as a hierarchical tree.

## Technologies

- C#
- .NET 8
- WPF
- System.Text.Json
- HttpClient

## Features

- Sends a POST request to the API.
- Deserializes the JSON response.
- Displays Technical Places, Equipments and Monitoring Tasks as a tree.
- Displays the number of direct child elements for each parent element.
- Uses separate classes for API communication, JSON deserialization and tree building.

## Requirements

- Windows 10 or later
- .NET 8

## Run

Clone the repository and open `TechnicalEquipmentViewer.slnx` in Visual Studio.

Build and run the project.
