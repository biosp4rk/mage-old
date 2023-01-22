# Metroid Advance Game Editor
**Version 1.4.0**

This is the source code for MAGE 1.4.0, which is a .NET 3.0 application using C# and WinForms. When I started development on MAGE in 2015, I had little experience with programming, and it was my first major project using C# and WinForms. As a result, I made some poor design decisions early on, and a lot of the code is messy, redudant, or prone to throwing exceptions. Here are some notable examples:

- Code could be better organized with appropriate namespaces and directories
- `GetPointers` in `ByteStream` has a small chance to find bytes that aren't actually pointers
- UI code files (particularly the editor forms) contain too much non-UI logic
- Very little code is shared between editors, especially for 2D grid interaction and drawing data
- Lack of error (exception) handling for bad/corrupt/empty data
- No option to set SRAM for the test room feature
- Many actions that modify data don't trigger the "unsaved changes" warning

I won't be adding any more features to this version of MAGE, but I am working on a new version that will be completely rewritten using WPF. In the meantime, feel free to modify the code yourself or submit pull requests.
