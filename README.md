# Geek Hunters

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
