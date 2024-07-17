   # CarRentalSystem
Design the Backend for a Simplified Car Rental System
Scenario:
Design the backend for a car rental system where users can view, search, and rent cars.

Acceptance Criteria:
View All Cars: Users can see a list of all available cars.

Each car consists of a model, make, year, location, description, and rental price per day.
Search Cars: Users can search for cars using keywords that match either the car model or description.

Leave a Review: Users can leave a review for any car and provide a rating from 1 to 5 along with the review.

Fetch All Reviews: Users can fetch all reviews for any car. Reviews should be ordered by the descending order of the rating.

Filter Cars: Users can filter cars based on location, rental price, and review rating.

View Nearby Cars: Users can see all the nearest available cars within a distance if they specify the location and the required distance.

Technical Requirements:
ASP.NET Core Web API: Use ASP.NET Core to build the backend API.
Entity Framework Core: Use EF Core for database interactions.
Database: Use an in-memory database for simplicity.
Authentication and Authorization: Use Duende Identity Server to secure the API.
Unit Tests: Write unit tests for critical parts of the API.