CREATE DATABASE OrderPizza;

CREATE TABLE Allergen (
    Name varchar,
    AllergenId int PRIMARY KEY,
);

CREATE TABLE Category (
    CategoryId int PRIMARY KEY,
    Name varchar,
);

CREATE TABLE Ingredient (
    Name varchar,
    IngredientId int PRIMARY KEY,
);

CREATE TABLE AllergenIngredient (
    AllergenId int,
    IngredientId int,
    CONSTRAINT PRIMARY KEY (AllergenId, IngredientId),
    CONSTRAINT FOREIGN KEY (AllergenId) REFERENCES (Allergen.AllergenId),
    CONSTRAINT FOREIGN KEY (IngredientId) REFERENCES (Ingredient.IngredientId),
);

CREATE TABLE Stock (
    IngredientId int PRIMARY KEY,
    Quantity int,
    CONSTRAINT FOREIGN KEY (IngredientId) REFERENCES (Ingredient.IngredientId),
);

CREATE TABLE Product (
    Name varchar,
    Price double,
    ProductId int PRIMARY KEY,
    Duration double,
    CategoryId int,
    CONSTRAINT FOREIGN KEY (CategoryId) REFERENCES (Category.CategoryId),
);

CREATE TABLE IngredientProduct (
    IngredientId int,
    ProductId int,
    CONSTRAINT PRIMARY KEY (IngredientId, ProductId),
    CONSTRAINT FOREIGN KEY (IngredientId) REFERENCES (Ingredient.IngredientId),
    CONSTRAINT FOREIGN KEY (ProductId) REFERENCES (Product.ProductId),
);

CREATE TABLE Order (
    OrderId int PRIMARY KEY,
    Duration double,
    Price double,
);

CREATE TABLE ProductOrder (
    OrderId int,
    Product int,
    quantity int,
    CONSTRAINT PRIMARY KEY (OrderId, CategoryId),
    CONSTRAINT FOREIGN KEY (OrderId) REFERENCES (Order.OrderId),
    CONSTRAINT FOREIGN KEY (ProductId) REFERENCES (Product.ProductId),
);  











        
    