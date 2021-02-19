# BlazorAttributeIssue
Demonstrates an issue hitting breakpoint when using an attribute with an enum parameter in Blazor WASM

Using the standard Blazor WASM template I :
- Added an BreaksDebuggingAttribute class that takes an enum parameter to the Shared project.
- Added @attribute [BreaksDebugging(MyEnum.One)] to the top of Index.razor in the Client project.
- Ran the project and tried placing a breakpoint inside the IncrementCount() method in Counter.razor

When taking these steps you will see that this breakpoint, or any other breakpoint anywhere in the project, will not get hit, and you will get an Unbound Breakpoint message. 
If you remove the attribute at the top of index.razor and rerun, breakpoints will once again work.
