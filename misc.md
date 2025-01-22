# Miscaleneous
## Overview

Some assorted links to useful sections of the Microsoft documentation or other useful expainers.

## Contents

- [Asynchronous APIs](#asynchronous-apis)
- [HoloLens Desktop App](#the-hololens-desktop-app)
- [HoloLens Emulator](#the-hololens-emulator-whats-the-point)


## Asynchronous APIs

- Async methods were built for processes that may take some time to complete and therefore need to run in parallel in the background while processes for things such as the UI continue to run as well. This stops longer processes from blocking up the thread and inhibiting the UX. 
- Overview explanation of asynchronous APIs in Microsoft documentation [here](https://learn.microsoft.com/en-us/windows/uwp/threading-async/call-asynchronous-apis-in-csharp-or-visual-basic).
- How to call an async method [here](https://grantwinney.com/call-an-async-method-from-a-synchronous-one/)

## The HoloLens Desktop App
- For the setup
    - IPv4 address, one-time code, username and password, etc

## The HoloLens Emulator (What's the Point?)

- [Setup](https://learn.microsoft.com/en-us/windows/mixed-reality/develop/advanced-concepts/using-the-hololens-emulator)

## #if [...] #endif

- *This is also in [HoloLensAndUnity.md](/HoloLensAndUnity.md)*
- This is an example of where Unity and HoloLens development don't fit together. 
- Universal Windows Platform (UWP) C# and Unity C# are not the same language (described in this way [here](https://foxypanda.me/tcp-client-in-a-uwp-unity-app-on-hololens/))
- In order to use commands that don't exist in Unity but to still enable the project to build #if/#else/#endif statements are used to tell Unity to ignore certain section of the code. 
- Example [here](FilePicker.cs)

## Web Requests (Unresolved)

- This [blog post](https://foxypanda.me/tcp-client-in-a-uwp-unity-app-on-hololens/) suggests why web requests can be difficult but may have A potential solution.
- Unity and UWP not directly compatible/Microsoft protecting against potential attacks as with file access?
- This [server](https://webhook.site/) can be used to test network requests.

