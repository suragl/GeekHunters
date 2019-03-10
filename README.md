# Geek Hunters

## Problem Statement

You are working at IT-recruiting agency "Geek Hunters". Your employer asked you to implement Geek Registration System
(GRS). 

Using GRS a recruitment agent should be able to:
  - register a new candidate:
     - first name / last name
     - select technologies candidate has experience in from the predefined list 
  - view all candidates
  - filter candidates by technology

## Steps followed for the solution
* Create a web API project (using ASP.NET Core MVC)
* Add a model classes.
* Create the database context 
* Register the database context (Entity Framework Core to interact with sqlite data base file).
* Add a candidate controller with very basic logis.
* Add business logics for filter candidate and put candidates with sill
* Test the web APIs with Postman.
* Design the basic UI with Jquery and HTML
* Add bootstrap for better look and feel

## DB Tables
Use three tables
1. Candidate : contains the candidates information

| Columnn     | Deatils|
| ------------- | ------------- |
| Id         | Primary Key  |
| FirstName  | First name of candidate |
| LastName   | Last name of candidate |


2. Skill :

| Columnn     | Deatils|
| ------------- | ------------- |
| Id         | Primary Key  |
| Name       | Name of skill |


3. CandidateSkillMap : Mapping table between Candidate and Skill

| Columnn     | Deatils|
| ------------- | ------------- |
| CandidateRefId         | Fareign Key of Candidate Table  |
| SkillRefId       | Fareign Key of Skill Table |
