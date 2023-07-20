# C# Coding Challenge
Here is an old phone keypad with alphabetical letters, a backspace key, and a send button.
Each button has a number to identify it and pressing a button multiple times will cycle through the letters on it allowing each button to represent more than one letter.
For example, pressing 2 once will return 'A' but pressing twice in succession will return 'B'.
You must pause for a second in order to type two characters from the same button after each other: '222 2 22' -> 'CAB'.

## Test Cases
- OldPhonePad(“33#”) => output: E
- OldPhonePad(“227*#”) => output: B
- OldPhonePad(“4433555 555666#”) => output: HELLO
- OldPhonePad(“8 88777444666*664#”) => output: TURING
