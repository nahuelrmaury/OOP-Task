# OOP Tasks

This repository contains solutions for a set of programming tasks. Each task is described below along with its requirements and expected behavior.

## Table of Contents
- [Task 1: Geometric Shapes](#task-1-geometric-shapes)
- [Task 2: Animal Hierarchy](#task-2-animal-hierarchy)
- [Task 3: Fibonacci Numbers (Loop)](#task-3-fibonacci-numbers-loop)
- [Task 4: Fibonacci Numbers (Recursion)](#task-4-fibonacci-numbers-recursion)
- [Task 5: Polynomial Class](#task-5-polynomial-class)
- [Task 6: Lightstring and Bulb Classes](#task-6-lightstring-and-bulb-classes)

## Task 1: Geometric Shapes

**Description**: Create classes `Square`, `Triangle`, `Circle`, and `Shape`. Define methods for calculating the area and perimeter for each shape. Determine which of these classes can be abstract.

## Task 2: Animal Hierarchy

**Description**: Create and describe a hierarchy for the entities `Animal`, `Herbal`, `Herbivore`, `Carnivore`, `Alive`, `Wolf` (predator), `Rabbit` (herbivore), `Bear` (omnivore), `Rose`, `Grass`.

- All living beings must have a method that returns the name of the species.
- Each animal must have a method that returns the name of a particular individual.
- Animals can be omnivores.
- Herbivores must have an `Eat()` method that takes a plant as a parameter.
- Predators must have an `Eat()` method that takes an animal as a parameter.

## Task 3: Fibonacci Numbers (Loop)

**Description**: Implement an application that accepts a natural number from the console and prints all Fibonacci numbers up to the entered number to the console. Implement the task using a loop.

**Example**: For input `10`, the output should be `0 1 1 2 3 5 8`.

## Task 4: Fibonacci Numbers (Recursion)

**Description**: Implement an application that accepts a natural number from the console and prints all Fibonacci numbers up to the entered number to the console. Implement the task using recursion.

## Task 5: Polynomial Class

**Description**: Implement the `Polynomial` class. The coefficients of the polynomial are set through the constructor. Implement the `ToString()` method in this class, which returns a string representation of the class in the form of `-3 + 4x^2 + 5x^5 – 12x^7`. Implement overloading of binary operators `+`, `-`, `*`.

## Task 6: Lightstring and Bulb Classes

**Description**: Write an abstract class `Lightstring` and expand it with `SimpleLightstring` and `ColoredLightstring` classes. Use `Bulb` and `ColoredBulb` as elements of the `Lightstring`.

- A colored light bulb has a color that can be red, yellow, blue, or green.
- For a colored light bulb, it should be possible to set the color using the `Color` type and get the color as a string.
- For a colored `Lightstring`, when creating, set the color of the light bulb depending on the serial number.
- The state of the bulb (on - off) is calculated from its serial number and the current minute of time.
- Create a method that returns the current state of the lights (on/off) and the color in the case of a colored one.

Print the current state of both lightstrings to the console by calling the implemented class methods.
