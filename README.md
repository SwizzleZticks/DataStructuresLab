# Data Structures: Stack and String Processing

## Objective
Write a program that takes a word from the user and reverses the inputted word using a **Stack**.

## What the Application Will Do
- Take in user input.
- Display the input in reverse.

## Build Specifications

1. **Request and Take User Input** (1 point)

2. **Create a Separate Method for Reversing the String** (3 points)
   - **Return type**: `string`
   - **Parameter**: `string`

3. **Reversing the String Using a Stack** (5 points total)
   - **Instantiate a Stack**: 1 point
   - **Store Characters in the Stack**: 2 points
   - **Retrieve Characters from the Stack in Reverse Order**: 2 points

4. **Display the Reversed String in the Console** (1 point)

## Hints
- This problem **can** be solved without using a stack. If you find it easier without a stack, solve it first without one. Then, re-iterate over your solution and refactor using a stack.

## Extra Challenges
- If the user enters a **sentence** rather than a single word:
  - Do **not** reverse the entire sentence.
  - Instead, reverse **each word** individually, while keeping the word order intact.
  
- **Validate user input** to ensure that the user is only entering words (not symbols or numbers).
