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
If youtry to reenter an already stored username the system will not allow it:
```C#
************************************************************

       PASSWORD AUTHENTICATION SYSTEM

       Please select one option:
       1. Establish an account
       2. Authenticate a user
       3. Exit the system

       Enter selection: 1

       Please enter a username: NewUsername

       NewUsername already exist
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        ************************************************************                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      ```
Option 2 [ 2 ]:
Option 2 prompts you to authenticate stored usernames and passwords, it tells you if they are a correct pair or not
Authenticated:
```C#
************************************************************

       PASSWORD AUTHENTICATION SYSTEM

       Please select one option:
       1. Establish an account
       2. Authenticate a user
       3. Exit the system

       Enter selection: 2

       Please enter a username: NewUsername
       Please enter a password: NewPassword

       Credentials Authenticated!
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                ************************************************************
```
Unauthenticated:
```C#
************************************************************

       PASSWORD AUTHENTICATION SYSTEM

       Please select one option:
       1. Establish an account
       2. Authenticate a user
       3. Exit the system

       Enter selection: 2

       Please enter a username: WrongUsername
       Please enter a password: WrongPassword

       Pair does not exist!
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                ************************************************************
```
Option 3 [ 3 ]:
Option 3 exits the program. On exit it shows the plain text usernames and passwords and the hash sets:
```C#
************************************************************

       PASSWORD AUTHENTICATION SYSTEM

       Please select one option:
       1. Establish an account
       2. Authenticate a user
       3. Exit the system

       Enter selection: 3

       Hashed Pairs:
       d41d8cd98f00b204e9800998ecf8427e <> d41d8cd98f00b204e9800998ecf8427e
       2222b0104b5621b7a68474f2741bcbf1 <> 7c6a180b36896a0a8c02787eeafb0e4c
       fdf65f9ebc8ff131074ad20499655755 <> 6cb75f652a9b52798eb6cf2201057c73
       232ca836378f8f9f46b3a80289294ede <> 70c04e53f3216a44d9b4f3e517f9b45c

       Plain Text Pairs:
        <>
       username1 <> password1
       username2 <> password2
       NewUsername <> NewPassword

       Credentials are discarded on exit!
                                                                                                                        ************************************************************
```
