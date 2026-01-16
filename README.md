# C-Sharp-The-Object-of-Your-Affection

## Overview

This program is a simple C# console application that models a basic user profile for a dating scenario.  
It allows creating profiles with personal details, adding hobbies, and viewing the profile in a formatted way.

This project is designed for learning and demonstrating **object-oriented programming** concepts in C#.

---

## What the Program Does

- Creates a user profile with name, age, city, country, and pronouns
- Supports minimal profiles with just name and age
- Tracks hobbies safely and avoids null reference errors
- Displays the profile in a readable format
- Enforces validation rules (e.g., users must be at least 18 years old)

---

## Coding Techniques Demonstrated

This project showcases several core C# and OOP techniques:

- **Classes and Objects** – The `Profile` class represents a user
- **Encapsulation** – Private properties with controlled access
- **Constructor Overloading** – Multiple ways to create a profile
- **Null Safety** – Using `Array.Empty<string>()` and null checks
- **StringBuilder** – Efficiently building multi-line profile output
- **Validation** – Ensuring the age meets minimum requirements
- **Readable Formatting** – Clear console output for hobbies and details

---

## Example Output
```
***Dating Profile***

Name: Michelle Jones
Age: 32
City: New York
Country: USA
Pronouns: she/her
Hobbies:
- Practicing yoga and pilates
- Reading contemporary fiction and memoirs
- Exploring new coffee shops and cafes
- Taking photography walks around the city
```
