# Encapsulation-Excersice

# 1. Class Box Data
Create a class Box, which has the following properties:
 Length - double, should not be zero or negative number
 Width - double, should not be zero or negative number
 Height - double, should not be zero or negative number
If one of the properties is a zero or negative number throw ArgumentException with the message: 
"{propertyName} cannot be zero or negative." Use try-catch block to process the error. All properties are set by 
the constructor and when set, they cannot be modified.
Behavior
double SurfaceArea()
Calculate and return the surface area of the Box.
double LateralSurfaceArea()
Calculate and return the lateral surface area of the Box.
double Volume()
Calculate and return the volume of the Box.
NOTE: You can find all formulas here.
Input
 On the first three lines, you will get the length, width, and height. 
Output
 On the next three lines print the surface area, lateral surface area, and the volume of the box.

# 2. Animal Farm
For this problem, you have to download the provided skeleton.
You should be familiar with encapsulation already. For this problem, you’ll be working with the AnimalFarm project. 
It contains a class Chicken. Chicken contains several fields, a constructor, several properties, and methods. Your 
task is to encapsulate or hide anything unintended for viewing or modification from outside the class.
Step 1. Encapsulate Fields
Fields should be private. Leaving fields open for modification from outside the class is potentially dangerous. Make 
all fields in the Chicken class private. In case the value inside the field is needed elsewhere, use getters to reveal 
it.
Step 2. Ensure Classes Have a Correct State
Having getters and setters is useless if you don’t use them. The Chicken constructor modifies the fields directly, 
which is wrong when there are suitable setters available. Modify the constructor to fix this issue.
Step 3. Validate Data Properly
Validate the chicken’s name (it cannot be null, empty, or whitespace). In case of an invalid name, print the Exception 
message: "Name cannot be empty.".
Validate the age properly, minimum and maximum age are provided, make use of them. In case of an invalid age, 
print Exception message: "Age should be between 0 and 15.". Don’t forget to handle properly the possibly thrown 
Exceptions.
Step 4. Hide Internal Logic
If a method is intended to be used only by descendant classes or internally to perform some action, there is no point 
in keeping them public. The CalculateProductPerDay() method is used by the ProductPerDay public getter. 
This means the method can safely be hidden inside the Chicken class by declaring it private.

# 3. Shopping Spree
Create two classes: 
 Person
 Product
Each person should have a name, money, and a bag of products. Each product should have a name and a cost. 
The name cannot be an empty string. Money cannot be a negative number. 
Create a program where each command corresponds to a person buying a product. If the person can afford a product, 
add it to his bag. If a person doesn’t have enough money, print an appropriate message ("{personName} can't 
afford {productName}").
On the first two lines, you are given all people and all products. After all, purchases print every person in the order 
of appearance and all productsthat he has bought also in order of appearance. If nothing was bought, print the name 
of the person followed by "Nothing bought". 
In case of invalid input (negative money Exception message: "Money cannot be negative") or an empty name 
(empty name Exception message: "Name cannot be empty") break the program with an appropriate message.

# 4. Pizza Calories
A pizza is made of dough and different toppings. You should model a class Pizza, which should have a name, 
dough, and toppings as fields. Every type of ingredient should have its class. Every ingredient has different 
properties: the dough can be white or wholegrain and in addition, it can be crispy, chewy, or homemade. The 
topping can be of type meat, veggies, cheese, or sauce. Every ingredient should weigh grams and a method for 
calculating its calories according to its type. Calories per gram are calculated through modifiers. Every ingredient 
has 2 calories per gram as a base and a modifier that gives the exact calories. For example, a white dough has a 
modifier of 1.5, a chewy dough has a modifier of 1.1, which means that a white chewy dough, weighing 100 grams
will have 2 * 100 * 1.5 * 1.1 = 330.00 total calories.
Your job is to model the classes in such a way that they are properly encapsulated and to provide a public method 
for every pizza that calculates its calories according to the ingredients it has. 
Step 1. Create a Dough Class
The base ingredient of a Pizza is the dough. First, you need to create a class for it. It has a flour type, which can be 
white or wholegrain. In addition, it has a baking technique, which can be crispy, chewy, or homemade. The dough 
should weigh grams. The calories per gram of dough are calculated depending on the flour type and the baking 
technique. Every dough has 2 calories per gram as a base and a modifier that gives the exact calories. For example, 
a white dough has a modifier of 1.5, a chewy dough has a modifier of 1.1, which means that a white chewy dough, 
weighing 100 grams will have (2 * 100) * 1.5 * 1.1 = 330.00 total calories. You are given the modifiers below:
Modifiers:
 White - 1.5
 Wholegrain - 1.0
 Crispy - 0.9
 Chewy - 1.1
 Homemade - 1.0
Everything that the class should expose is a getter for the calories per gram. Your task is to create the class with a 
proper constructor, fields, getters, and setters. Make sure you use the proper access modifiers.
Step 2. Validate Data for the Dough Class
Change the internal logic of the Dough class by adding a data validation in the setters.
Make sure that if an invalid flour type or an invalid baking technique is given a proper Exception is thrown with 
the message "Invalid type of dough.".
The allowed weight of dough is in the range [1..200] grams. If it is outside of this range throw an Exception with 
the message "Dough weight should be in the range [1..200].".
Exception Messages
 "Invalid type of dough."
 "Dough weight should be in the range [1..200]."
Make a test in your main method that reads Doughs and prints their calories until an "END" command is given
