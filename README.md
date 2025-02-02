# Patikaflix Series Platform

## Description
This project involves creating a list of TV series and performing various LINQ queries on them. The goal is to filter and sort the series based on different criteria, such as genre, release year, and directors.

## Features
- Store TV series information in a list.
- Filter series based on genre (Comedy).
- Create a new list containing only the series name, genre, and director.
- Sort the new list based on director names.
- Display all elements of the filtered list in a structured format.

## Data Structure
Each series is represented as an object with the following properties:
- **Title**: Name of the TV series.
- **Year**: The production year of the series.
- **ReleaseYear**: The year the series was first aired.
- **Genre**: The genre of the series.
- **Director**: The director(s) of the series.
- **Platform**: The first platform where the series aired.

## Example Data
```csharp
List<Series> seriesList = new List<Series>
{
    new Series("Avrupa Yakası", 2004, "Comedy", "Yüksel Aksu", "Kanal D"),
    new Series("Yalan Dünya", 2012, "Comedy", "Gülseren Buda Başkaya", "Fox TV"),
    new Series("Jet Sosyete", 2018, "Comedy", "Gülseren Buda Başkaya", "TV8"),
    new Series("Dadı", 2006, "Comedy", "Yusuf Pirhasan", "Kanal D"),
    new Series("Belalı Baldız", 2007, "Comedy", "Yüksel Aksu", "Kanal D")
};
```

## LINQ Queries
### 1. Filter Comedy Series
```csharp
var comedySeries = seriesList.Where(s => s.Genre.Contains("Comedy")).ToList();
```

### 2. Create a New List with Only Name, Genre, and Director
```csharp
var filteredList = comedySeries.Select(s => new { s.Title, s.Genre, s.Director }).ToList();
```

### 3. Sort the List by Director Name
```csharp
var sortedList = filteredList.OrderBy(s => s.Director).ToList();
```

### 4. Display the Filtered List
```csharp
foreach (var series in sortedList)
{
    Console.WriteLine($"{series.Title} - {series.Genre} - {series.Director}");
}
```

## Requirements
- .NET Core / .NET 5+
- Visual Studio or any C# compatible IDE

## How to Run
1. Clone the repository.
2. Open the solution in Visual Studio.
3. Run the program and observe the filtered and sorted list output in the console.
