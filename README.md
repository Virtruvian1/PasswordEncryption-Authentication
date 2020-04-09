# PasswordEncryption-Authentication
C# Password System that runs in memory

On startup you have 3 options to choose from [ 1, 2, 3 ]:

```C#
************************************************************

       PASSWORD AUTHENTICATION SYSTEM

       Please select one option:
       1. Establish an account
       2. Authenticate a user
       3. Exit the system

       Enter selection:

************************************************************
```

Option 1 [ 1 ]:
Option 1 prompts you to store a username and password in memory
```C#
************************************************************

       PASSWORD AUTHENTICATION SYSTEM

       Please select one option:
       1. Establish an account
       2. Authenticate a user
       3. Exit the system

       Enter selection: 1

       Please enter a username:

************************************************************
```
After you enter a username you are prompted to enter a password to pair with the username: 
```C#
************************************************************

       PASSWORD AUTHENTICATION SYSTEM

       Please select one option:
       1. Establish an account
       2. Authenticate a user
       3. Exit the system

       Enter selection: 1

       Please enter a username: NewUsername
       Please enter a password: NewPassword

************************************************************
```
You are then shown your username and password converted into a MD5 Hash:
```C#
************************************************************

       PASSWORD AUTHENTICATION SYSTEM

       Please select one option:
       1. Establish an account
       2. Authenticate a user
       3. Exit the system

       Enter selection: 1

       Please enter a username: NewUsername
       Please enter a password: NewPassword

       NewUsername => 232ca836378f8f9f46b3a80289294ede
       NewPassword => 70c04e53f3216a44d9b4f3e517f9b45c

       Credentials Added!

************************************************************                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             
```
