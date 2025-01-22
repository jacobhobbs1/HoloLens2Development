# Store to File
## Overview

Storing to a file can be difficult depending on the context of what the data is for and how it needs to be accessed later. For data to be used aolely within an application to contain data to persist between scenes or between application loads is fairly straight forward. See [this documentation](https://learn.microsoft.com/en-us/answers/questions/1179853/hololens-2-development-create-edit-and-write-files) to create, write, and read files. 

However, to save data to a file that can be offloaded from the HoloLens is more difficult. The file system accessible when the HoloLens is plugged into a PC cannot be accessed by an application without the user specifying the location they want to save a file to manually. It is assumed that this is a safeguarding feature implemented by Microsoft to prevent attacks, but it means that in practice, for this task, a work around is required. 

## Storing to a file
### Storing Data to a File to Access Only within the Application

See [this documentation](https://learn.microsoft.com/en-us/answers/questions/1179853/hololens-2-development-create-edit-and-write-files) (untested).

### Storing Data to a File to Access Off the Device

The file system accessible when the HoloLens is plugged into a PC cannot be accessed by an application without the user specifying the location they want to save a file to manually, using a file picker. It is assumed that this is a safeguarding feature implemented by Microsoft to prevent attacks, but it means that in practice, to write to a file accessible by PC later, the user must identify the location to store the file manually. 

The location chosen by the user persists between scenes ***(and maybe between application loads?)***<sup>1</sup>. This means that the location can be set before it's needed and called when the file is required. 

[This forum answer](https://learn.microsoft.com/en-us/answers/questions/949338/how-to-save-files-in-a-specific-path-in-hololens2) for the code to launch the file picker (for the user to choose the location), and to save the file to that location.

[This tutorial](https://grantwinney.com/call-an-async-method-from-a-synchronous-one/) for calling an Async method. See the async section of the [misc](/misc.md) page for an overview of async methods. 

[This file](./FilePicker.cs) as boiler plate code/an example. 


#### Footnotes
1. Does the chosen location persist between application loads? This would be useful as the loaction could be set once at the beginning of use and then would not need to be set every time the application is launched. 