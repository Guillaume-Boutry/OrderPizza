CREATE TABLE Order (
    Product int,
    Id int PRIMARY KEY,
    Duration double,
    Price double,
);

CREATE TABLE Category (
    Id int PRIMARY KEY,
    Name varchar,
);

CREATE TABLE Product (
    Name varchar,
    Price double,
    Ingredient int,
    Id int PRIMARY KEY,
    Duration double,
    Category int,
);

CREATE TABLE Ingredient (
    Name varchar,
    Allergen int,
    Id int PRIMARY KEY,
);

CREATE TABLE Allergen (
    Name varchar,
    Id int PRIMARY KEY,
);

CREATE TABLE Stock (
    Ingredient int,
    Quantity int,
);

    
        
    