CREATE DATABASE OrderPizza CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci; 

CREATE TABLE Allergen (
    Name varchar(80),
    AllergenId int PRIMARY KEY AUTO_INCREMENT
);

CREATE TABLE Category (
    CategoryId int PRIMARY KEY AUTO_INCREMENT,
    Name varchar(80)
);

CREATE TABLE Ingredient (
    Name varchar(80),
    IngredientId int PRIMARY KEY AUTO_INCREMENT
);

CREATE TABLE AllergenIngredient (
    AllergenId int,
    IngredientId int,
    CONSTRAINT PRIMARY KEY (AllergenId, IngredientId),
    CONSTRAINT FOREIGN KEY (AllergenId) REFERENCES Allergen(AllergenId),
    CONSTRAINT FOREIGN KEY (IngredientId) REFERENCES Ingredient(IngredientId)
);

CREATE TABLE Stock (
    IngredientId int PRIMARY KEY AUTO_INCREMENT,
    Quantity int,
    CONSTRAINT FOREIGN KEY (IngredientId) REFERENCES Ingredient(IngredientId)
);

CREATE TABLE Product (
    Name varchar(80),
    Price double,
    ProductId int PRIMARY KEY AUTO_INCREMENT,
    Duration double,
    CategoryId int,
    CONSTRAINT FOREIGN KEY (CategoryId) REFERENCES Category(CategoryId)
);

CREATE TABLE IngredientProduct (
    IngredientId int,
    ProductId int,
    CONSTRAINT PRIMARY KEY (IngredientId, ProductId),
    CONSTRAINT FOREIGN KEY (IngredientId) REFERENCES Ingredient(IngredientId),
    CONSTRAINT FOREIGN KEY (ProductId) REFERENCES Product(ProductId)
);

CREATE TABLE Command (
    CommandId int PRIMARY KEY AUTO_INCREMENT,
    Duration double,
    Price double
);

CREATE TABLE ProductOrder (
    CommandId int,
    ProductId int,
    Quantity int,
    CONSTRAINT PRIMARY KEY (CommandId, ProductId),
    CONSTRAINT FOREIGN KEY (CommandId) REFERENCES Command(CommandId),
    CONSTRAINT FOREIGN KEY (ProductId) REFERENCES Product(ProductId)
);  

