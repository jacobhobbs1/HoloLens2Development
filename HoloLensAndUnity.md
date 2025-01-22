# HoloLens and Unity
## Overview

- TODO
- HoloLens development as been somewhat shoehorned into Unity and symptoms of that can be seen in various places. 

## Contents

- [Unity Editor](#using-the-unity-editor)
- [Euler Angles and Quaternions](#euler-angles-vs-quaternions)
- [#if, #endif](#if-unity_editor--endif)

## Using the Unity Editor

- TODO

## Euler angles vs quaternions?

- TODO

## #if [...] #endif

- This is an example of where Unity and HoloLens development don't fit together. 
- Universal Windows Platform (UWP) C# and Unity C# are not the same language (described in this way [here](https://foxypanda.me/tcp-client-in-a-uwp-unity-app-on-hololens/))
- In order to use commands that don't exist in Unity but to still enable the project to build #if/#else/#endif statements are used to tell Unity to ignore certain section of the code. 
- Example [here](FilePicker.cs)